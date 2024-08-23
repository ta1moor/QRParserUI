namespace QRParserUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            btnUploadQR = new Button();
            btnExport = new Button();
            dataGridView = new DataGridView();
            btnClose = new Button();
            btnParse = new Button();
            txtQRCode = new TextBox();
            lblQRCode = new Label();
            tabPage2 = new TabPage();
            dataGridViewTags = new DataGridView();
            tabPage3 = new TabPage();
            btnGenerateRTP = new Button();
            btnGenerateMerchantDynamicQR = new Button();
            btnGenerateMerchantStaticQR = new Button();
            btnGeneratePersonDynamicQR = new Button();
            btnGeneratePersonStaticQR = new Button();
            tabPage4 = new TabPage();
            lblContact = new Label();
            lblContributor = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTags).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            //
            //ICON
            //
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Location = new Point(14, 16);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(887, 568);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnUploadQR);
            tabPage1.Controls.Add(btnExport);
            tabPage1.Controls.Add(dataGridView);
            tabPage1.Controls.Add(btnClose);
            tabPage1.Controls.Add(btnParse);
            tabPage1.Controls.Add(txtQRCode);
            tabPage1.Controls.Add(lblQRCode);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(879, 535);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "QR Parser";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUploadQR
            // 
            btnUploadQR.Location = new Point(551, 479);
            btnUploadQR.Margin = new Padding(3, 4, 3, 4);
            btnUploadQR.Name = "btnUploadQR";
            btnUploadQR.Size = new Size(126, 31);
            btnUploadQR.TabIndex = 6;
            btnUploadQR.Text = "Upload QR Image";
            btnUploadQR.UseVisualStyleBackColor = true;
            btnUploadQR.Click += btnUploadQR_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(384, 479);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(86, 31);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            //
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Adjust column width to fill the DataGridView
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.Location = new Point(17, 64);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(851, 407);
            dataGridView.TabIndex = 4;
            dataGridView.CellContentClick += dataGridView_CellContentClick;

            // 
            // btnClose
            // 
            btnClose.Location = new Point(754, 479);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnParse
            // 
            btnParse.Location = new Point(210, 479);
            btnParse.Margin = new Padding(3, 4, 3, 4);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(86, 31);
            btnParse.TabIndex = 2;
            btnParse.Text = "Parse";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.Click += btnParse_Click;
            // 
            // txtQRCode
            // 
            txtQRCode.Location = new Point(91, 23);
            txtQRCode.Margin = new Padding(3, 4, 3, 4);
            txtQRCode.Name = "txtQRCode";
            txtQRCode.Size = new Size(777, 27);
            txtQRCode.TabIndex = 1;
            // 
            // lblQRCode
            // 
            lblQRCode.AutoSize = true;
            lblQRCode.Location = new Point(17, 27);
            lblQRCode.Name = "lblQRCode";
            lblQRCode.Size = new Size(71, 20);
            lblQRCode.TabIndex = 0;
            lblQRCode.Text = "QR Code:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewTags);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(879, 535);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "QR Dictionary";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTags
            // 
            dataGridViewTags.AllowUserToAddRows = false;
            dataGridViewTags.AllowUserToDeleteRows = false;
            dataGridViewTags.AllowUserToOrderColumns = true;
            dataGridViewTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTags.Location = new Point(17, 20);
            dataGridViewTags.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTags.Name = "dataGridViewTags";
            dataGridViewTags.ReadOnly = true;
            dataGridViewTags.RowHeadersWidth = 51;
            dataGridViewTags.RowTemplate.Height = 25;
            dataGridViewTags.Size = new Size(851, 487);
            dataGridViewTags.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnGenerateRTP);
            tabPage3.Controls.Add(btnGenerateMerchantDynamicQR);
            tabPage3.Controls.Add(btnGenerateMerchantStaticQR);
            tabPage3.Controls.Add(btnGeneratePersonDynamicQR);
            tabPage3.Controls.Add(btnGeneratePersonStaticQR);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(879, 535);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "RAAST Services";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGenerateRTP
            // 
            btnGenerateRTP.Location = new Point(353, 219);
            btnGenerateRTP.Margin = new Padding(3, 4, 3, 4);
            btnGenerateRTP.Name = "btnGenerateRTP";
            btnGenerateRTP.Size = new Size(171, 31);
            btnGenerateRTP.TabIndex = 4;
            btnGenerateRTP.Text = "Generate RTP";
            btnGenerateRTP.UseVisualStyleBackColor = true;
            btnGenerateRTP.Click += AdminFeature_Click;
            // 
            // btnGenerateMerchantDynamicQR
            // 
            btnGenerateMerchantDynamicQR.Location = new Point(353, 167);
            btnGenerateMerchantDynamicQR.Margin = new Padding(3, 4, 3, 4);
            btnGenerateMerchantDynamicQR.Name = "btnGenerateMerchantDynamicQR";
            btnGenerateMerchantDynamicQR.Size = new Size(171, 31);
            btnGenerateMerchantDynamicQR.TabIndex = 3;
            btnGenerateMerchantDynamicQR.Text = "Generate Merchant DynamicQR";
            btnGenerateMerchantDynamicQR.UseVisualStyleBackColor = true;
            btnGenerateMerchantDynamicQR.Click += AdminFeature_Click;
            // 
            // btnGenerateMerchantStaticQR
            // 
            btnGenerateMerchantStaticQR.Location = new Point(353, 115);
            btnGenerateMerchantStaticQR.Margin = new Padding(3, 4, 3, 4);
            btnGenerateMerchantStaticQR.Name = "btnGenerateMerchantStaticQR";
            btnGenerateMerchantStaticQR.Size = new Size(171, 31);
            btnGenerateMerchantStaticQR.TabIndex = 2;
            btnGenerateMerchantStaticQR.Text = "Generate Merchant StaticQR";
            btnGenerateMerchantStaticQR.UseVisualStyleBackColor = true;
            btnGenerateMerchantStaticQR.Click += AdminFeature_Click;
            // 
            // btnGeneratePersonDynamicQR
            // 
            btnGeneratePersonDynamicQR.Location = new Point(353, 63);
            btnGeneratePersonDynamicQR.Margin = new Padding(3, 4, 3, 4);
            btnGeneratePersonDynamicQR.Name = "btnGeneratePersonDynamicQR";
            btnGeneratePersonDynamicQR.Size = new Size(171, 31);
            btnGeneratePersonDynamicQR.TabIndex = 1;
            btnGeneratePersonDynamicQR.Text = "Generate Person DynamicQR";
            btnGeneratePersonDynamicQR.UseVisualStyleBackColor = true;
            btnGeneratePersonDynamicQR.Click += AdminFeature_Click;
            // 
            // btnGeneratePersonStaticQR
            // 
            btnGeneratePersonStaticQR.Location = new Point(353, 11);
            btnGeneratePersonStaticQR.Margin = new Padding(3, 4, 3, 4);
            btnGeneratePersonStaticQR.Name = "btnGeneratePersonStaticQR";
            btnGeneratePersonStaticQR.Size = new Size(171, 31);
            btnGeneratePersonStaticQR.TabIndex = 0;
            btnGeneratePersonStaticQR.Text = "Generate Person StaticQR";
            btnGeneratePersonStaticQR.UseVisualStyleBackColor = true;
            btnGeneratePersonStaticQR.Click += AdminFeature_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblContact);
            tabPage4.Controls.Add(lblContributor);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(879, 535);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Details";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(17, 60);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(237, 20);
            lblContact.TabIndex = 1;
            lblContact.Text = "Build Version: 1.0.0 (31-Jul-2023)";
            // 
            // lblContributor
            // 
            lblContributor.AutoSize = true;
            lblContributor.Location = new Point(17, 20);
            lblContributor.Name = "lblContributor";
            lblContributor.Size = new Size(168, 20);
            lblContributor.TabIndex = 0;
            lblContributor.Text = "Contributor: Zindigi (Powered by JS Bank)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 702);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "QR Parser";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTags).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridViewTags;
        private System.Windows.Forms.Button btnUploadQR;
        private System.Windows.Forms.Button btnGeneratePersonStaticQR;
        private System.Windows.Forms.Button btnGenerateMerchantDynamicQR;
        private System.Windows.Forms.Button btnGenerateMerchantStaticQR;
        private System.Windows.Forms.Button btnGeneratePersonDynamicQR;
        private System.Windows.Forms.Button btnGenerateRTP;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblContributor;
    }
}
