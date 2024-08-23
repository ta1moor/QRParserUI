using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using ZXing.Common;
using ZXing.Windows.Compatibility;
using ClosedXML.Excel;

namespace QRParserUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                this.SuspendLayout();
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Icon = new System.Drawing.Icon("raastfavicon.ico");
                this.Name = "Form1";
                this.Text = "QR Parser";
                this.ResumeLayout(false);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the QR Dictionary grid on form load
            PopulateQRDictionary();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string qrCodeText = txtQRCode.Text.Trim();
            var parsedData = ParseQRString(qrCodeText);

            dataGridView.DataSource = ConvertDictionaryToDataTable(parsedData);
        }

        private void btnUploadQR_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string qrCodeText = DecodeQRCode(filePath);
                    txtQRCode.Text = qrCodeText;

                    var parsedData = ParseQRString(qrCodeText);
                    dataGridView.DataSource = ConvertDictionaryToDataTable(parsedData);
                }
            }
        }

        private string DecodeQRCode(string filePath)
        {
            Bitmap bitmap = new Bitmap(filePath);
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            return result?.Text ?? string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to prompt the user to select a location to save the file
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";
                saveFileDialog.FileName = "QRData.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a new workbook and worksheet
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("QR Data");

                        // Export column headers
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
                        }

                        // Export rows
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        // Save the workbook
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Export completed successfully.");
                }
            }
        }

        private Dictionary<string, string> ParseQRString(string qrCodeText)
        {
            var qrData = new Dictionary<string, string>();

            int i = 0;
            while (i < qrCodeText.Length)
            {
                var tag = qrCodeText.Substring(i, 2);
                i += 2;
                var length = int.Parse(qrCodeText.Substring(i, 2));
                i += 2;
                var value = qrCodeText.Substring(i, length);
                i += length;

                if (QRTags.tagNames.ContainsKey(tag))
                {
                    qrData.Add(tag, value);

                    // Check if the tag has sub-tags
                    if (tag == "28" || tag == "62")
                    {
                        var subTags = ParseSubTags(value, tag);
                        foreach (var subTag in subTags)
                        {
                            qrData.Add($"{tag}-{subTag.Key}", subTag.Value);
                        }
                    }
                }
                else
                {
                    qrData.Add(tag, value);
                }
            }

            return qrData;
        }

        private Dictionary<string, string> ParseSubTags(string value, string parentTag)
        {
            var subTagData = new Dictionary<string, string>();

            int i = 0;
            while (i < value.Length)
            {
                var subTag = value.Substring(i, 2);
                i += 2;
                var length = int.Parse(value.Substring(i, 2));
                i += 2;
                var subValue = value.Substring(i, length);
                i += length;

                if (parentTag == "28" && QRTags.subTagNames28.ContainsKey(subTag))
                {
                    subTagData.Add(subTag, subValue);
                }
                else if (parentTag == "62" && QRTags.subTagNames62.ContainsKey(subTag))
                {
                    subTagData.Add(subTag, subValue);
                }
            }

            return subTagData;
        }

        private DataTable ConvertDictionaryToDataTable(Dictionary<string, string> data)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TagID", typeof(string));
            dt.Columns.Add("TagName", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            foreach (var item in data)
            {
                string tagName;
                if (item.Key.Contains('-'))
                {
                    var keys = item.Key.Split('-');
                    var parentTag = keys[0];
                    var subTag = keys[1];
                    if (parentTag == "28")
                        tagName = QRTags.subTagNames28.ContainsKey(subTag) ? QRTags.subTagNames28[subTag] : "Unknown";
                    else if (parentTag == "62")
                        tagName = QRTags.subTagNames62.ContainsKey(subTag) ? QRTags.subTagNames62[subTag] : "Unknown";
                    else
                        tagName = "Unknown";
                }
                else
                {
                    tagName = QRTags.tagNames.ContainsKey(item.Key) ? QRTags.tagNames[item.Key] : "Unknown";
                }

                dt.Rows.Add(item.Key, tagName, item.Value);
            }

            return dt;
        }

        private void PopulateQRDictionary()
        {
            var dt = new DataTable();
            dt.Columns.Add("TagNumber", typeof(string));
            dt.Columns.Add("TagName", typeof(string));

            foreach (var tag in QRTags.tagNames)
            {
                dt.Rows.Add(tag.Key, tag.Value);
            }

            // Add sub-tags for Tag 28
            foreach (var subTag in QRTags.subTagNames28)
            {
                dt.Rows.Add($"28-{subTag.Key}", subTag.Value);
            }

            // Add sub-tags for Tag 62
            foreach (var subTag in QRTags.subTagNames62)
            {
                dt.Rows.Add($"62-{subTag.Key}", subTag.Value);
            }

            dataGridViewTags.DataSource = dt;
        }

        private void AdminFeature_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The feature is for Admin");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
