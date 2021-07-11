using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace NetTools.UserControls.Misc
{
    public partial class UCTextConversion : UserControl
    {
        #region Global Variables
        private object currentCharacterEncoding;
        private object currentChecksumType;
        private object currentBase64Option;
        #endregion
        /* Constructor */
        public UCTextConversion()
        {
            InitializeComponent();
            /* Begin setup*/
            InitCombox();
        }
        private bool IsDigitGroupingChecked()
        {
            return checkboxDigitGrouping.Checked;
        }

        #region Combo box
        private void InitCombox()
        {
            currentCharacterEncoding = comboxCharacterEncoding.SelectedItem = comboxCharacterEncoding.Items[0];
            currentChecksumType = comboxChecksumType.SelectedItem = comboxChecksumType.Items[0];
            currentBase64Option = comboxBase64Option.SelectedItem = comboxBase64Option.Items[0];

            checkboxDigitGrouping.Checked = true;
        }
        #endregion
        #region Text Converter
        private int GetTextLength(string text)
        {
            return ToByteArray(text).Length;
        }
        private byte[] ToByteArray(string text)
        {
            if ((string)currentCharacterEncoding == "ASCII")
                return Encoding.ASCII.GetBytes(text);
            if ((string)currentCharacterEncoding == "UTF8")
                return Encoding.UTF8.GetBytes(text);
            if ((string)currentCharacterEncoding == "Unicode")
                return Encoding.Unicode.GetBytes(text);
            return null;
        }
        private string ConvertText2Hex(string text)
        {
            string hex = string.Empty;
            string space = (IsDigitGroupingChecked() ? " " : null);
            foreach (var item in ToByteArray(text))
            {
                int n = Convert.ToInt32(item);
                hex += $"{n:X}{space}";
            }
            return hex;
        }
        private string ConvertText2Bin(string text)
        {
            string bin = string.Empty;
            string space = (IsDigitGroupingChecked() ? " " : null);
            foreach (var item in ToByteArray(text))
            {
                int value = Convert.ToInt32(item);
                bin += $"{Convert.ToString(value, 2).PadLeft(8, '0')}{space}";
            }
            return bin;
        }
        private string ConvertText2Base64(string text)
        {
            if ((string)currentBase64Option == "None")
                return Convert.ToBase64String(ToByteArray(text));
            /* Line break option */
            return Convert.ToBase64String(ToByteArray(text), Base64FormattingOptions.InsertLineBreaks);
        }
        #endregion
        #region Checksum
        private string GetHash(HashAlgorithm hashAlgorithm, string text)
        {
            // Reference source: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.hashalgorithm.computehash?view=net-5.0#System_Security_Cryptography_HashAlgorithm_ComputeHash_System_Byte___
            byte[] checksum = hashAlgorithm.ComputeHash(ToByteArray(text));
            var sBuilder = new StringBuilder();

            for (int i = 0; i < checksum.Length; i++)
            {
                sBuilder.Append(checksum[i].ToString("X2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        private string CalcMD5Checksum(string text)
        {
            return GetHash(MD5.Create(), text);
        }
        private string CalcSHA1(string text)
        {
            return GetHash(SHA1.Create(), text);
        }
        private string CalcSHA256(string text)
        {
            return GetHash(SHA256.Create(), text);
        }
        private string CalcSHA512(string text)
        {
            return GetHash(SHA512.Create(), text);
        }
        private string CalcXorChecksum(string text)
        {
            byte[] bytes = ToByteArray(text);
            byte chkSumByte = 0x00;
            foreach (var item in bytes)
            {
                chkSumByte ^= item;
            }
            return chkSumByte.ToString("X2");
        }
        private string Calc2sComplementChecksum(string text)
        {
            int chksum = 0;
            foreach (var item in ToByteArray(text))
            {
                int value = Convert.ToInt32(item);
                string hex = $"{value:X}";
                int n = int.Parse(hex, System.Globalization.NumberStyles.AllowHexSpecifier);
                chksum += n & 0xFF;
            }
            return (256 - chksum & 0xFF).ToString("X2");
        }
        private string CalcChecksum(string text)
        {
            if ((string)currentChecksumType == "MD5")
                return CalcMD5Checksum(text);
            if ((string)currentChecksumType == "Xor")
                return CalcXorChecksum(text);
            if ((string)currentChecksumType == "2's complement")
                return Calc2sComplementChecksum(text);
            if ((string)currentChecksumType == "SHA-1")
                return CalcSHA1(text);
            if ((string)currentChecksumType == "SHA-256")
                return CalcSHA256(text);
            if ((string)currentChecksumType == "SHA-512")
                return CalcSHA512(text);
            return null;
        }
        #endregion
        #region Read file-content
        private bool CheckFileExtension(string path, string extension)
        {
            try
            {
                string ext = Path.GetExtension(path);
                if (ext == extension)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
            MessageBox.Show($"The file-extention is not {extension}", "Error");
            return false;
        }
        private string ReadTextFile(string path)
        {
            /* Check input extention */
            if (!CheckFileExtension(path, ".txt"))
                return null;
            /* The correct input-extention */
            try
            {
                return File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
        }
        #endregion

        #region User Interaction
        #region Button
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            /* OpenFileDialog Result OK */

            richtextInput.Text = ReadTextFile(openFileDialog.FileName);
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string text = richtextInput.Text;
            if (String.IsNullOrEmpty(text))
                return;
            /* Otherwise */
            labelTextLength.Text = $"Length (bytes): {GetTextLength(text).ToString()}";
            richtextHex.Text = ConvertText2Hex(text);
            richtextBinary.Text = ConvertText2Bin(text);
            richtextBase64.Text = ConvertText2Base64(text);
            richtextChecksum.Text = CalcChecksum(text);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            /* Clear all rich text boxs */
            labelTextLength.Text = $"Length (bytes):";
            richtextInput.Clear();
            richtextHex.Clear();
            richtextBinary.Clear();
            richtextBase64.Clear();
            richtextChecksum.Clear();
        }
        #endregion
        #region Combo box
        private void comboxCharacterEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCharacterEncoding = comboxCharacterEncoding.SelectedItem;
        }
        private void comboxChecksumType_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentChecksumType = comboxChecksumType.SelectedItem;
            if (String.IsNullOrEmpty(richtextInput.Text))
                return;
            richtextChecksum.Text = CalcChecksum(richtextInput.Text);
        }
        private void comboxBase64Option_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentBase64Option = comboxBase64Option.SelectedItem;
            if (String.IsNullOrEmpty(richtextInput.Text))
                return;
            richtextBase64.Text = ConvertText2Base64(richtextInput.Text);
        }
        #endregion
        private void checkboxDigitGrouping_CheckedChanged(object sender, EventArgs e)
        {
            /* Call convert-button click event */
            this.buttonConvert_Click(sender, e);
        }
        #endregion
    }
}
