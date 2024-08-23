using System.Collections.Generic;

namespace QRParserUI
{
    public static class QRTags
    {
        public static Dictionary<string, string> tagNames = new Dictionary<string, string>
        {
            { "00", "PFI" },
            { "01", "POI" },
            { "02", "MAI1 Visa" },
            { "04", "MAI2 Mastercard" },
            { "06", "MAI3 UPI" },
            { "26", "MAI4 Domestic scheme1" },
            { "28", "MAI5 Domestic Scheme2" },
            { "52", "MCC" },
            { "53", "Currency" },
            { "54", "Amount" },
            { "55", "Convenience fee" },
            { "56", "Convenience fee" },
            { "57", "Convenience fee" },
            { "58", "Country Code" },
            { "59", "Merchant Name" },
            { "60", "Merchant City" },
            { "62", "Additional Data Field" },
            { "64", "Alternate Language" },
            { "80", "Context of Trxn" },
            { "81", "Discounts & Loyalty Programs" },
            { "82", "O2O+" },
            { "83", "e-Commerce" },
            { "84", "Scheme Specific" },
            { "85", "Scheme Specific" },
            { "86", "Scheme Specific" },
            { "87", "Acquirer Specific" },
            { "88", "Acquirer Specific" },
            { "89", "RFUSBP" },
            { "90", "RFUSBP" },
            { "91", "RFUSBP" },
            { "92", "RFUSBP" },
            { "93", "RFUSBP" },
            { "94", "RFUSBP" },
            { "95", "RFUSBP" },
            { "96", "RFUSBP" },
            { "97", "RFUSBP" },
            { "98", "RFUSBP" },
            { "99", "RFUSBP" },
            { "63", "CRC" }
        };

        public static Dictionary<string, string> subTagNames28 = new Dictionary<string, string>
        {
            { "00", "GUID" },
            { "01", "BIC" },
            { "02", "IBAN" }
        };

        public static Dictionary<string, string> subTagNames62 = new Dictionary<string, string>
        {
            { "01", "Bill Number" },
            { "02", "Mobile Number" },
            { "03", "Store Label" },
            { "04", "Loyalty Number" },
            { "05", "Reference Label" },
            { "06", "Customer Label" },
            { "07", "Terminal Label" },
            { "08", "Purpose of Transaction" },
            { "09", "Additional Consumer Data Request" },
            { "10", "Merchant Tax ID" },
            { "11", "Merchant Channel" },
            { "12", "RFU for EMVCo" },
            { "49", "RFU for EMVCo" },
            { "50", "Due Date" },
            { "51", "Amount after Due Date" },
            { "52", "Scheme Specific" },
            { "53", "Scheme Specific" },
            { "54", "Scheme Specific" },
            { "55", "Acquirer Specific" },
            { "56", "Acquirer Specific" },
            { "57", "RFU-SBP" },
            { "99", "RFU-SBP" }
        };
    }
}
