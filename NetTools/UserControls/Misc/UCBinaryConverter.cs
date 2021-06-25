using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTools.UserControls.Misc
{
    public partial class UCBinaryConverter : UserControl
    {
        #region Global Variables
        private int hex = 16;
        private int bin = 2;
        private int dec = 10;
        private bool digitChecked = false;
        private string inputValue = null;
        private string currentComboxFrom, currentComboxTo;
        #endregion

        private void InitForm()
        {
            /* Initialize ComboBox Selected Item */
            comboxFrom.SelectedItem = comboxFrom.Items[1];  //Decimal
            comboxTo.SelectedItem = comboxFrom.Items[0];    //Binary
        }
        /* Constructor */
        public UCBinaryConverter()
        {
            InitializeComponent();
            /* Begin */
            InitForm();
        }

        #region Methods
        private void ActivateControls()
        {
            currentComboxTo = comboxTo.Text.ToLower();
            currentComboxFrom = comboxFrom.Text.ToLower();

            if (currentComboxFrom == currentComboxTo)
                return;

            /* Reset richtex boxs */
            richtextOutput1.Text = null;
            richtextOutput2.Text = null;
            richtextOutput3.Text = null;

            switch (currentComboxTo)
            {
                case "binary":
                    BinaryDesktop();
                    break;
                case "decimal":
                    DecimalDesktop();
                    break;
                case "hexadecimal":
                    HexadecimalDesktop();
                    break;
                default:
                    break;
            }
        }
        private string FormatOutput(string iString /*input string*/, int iBase)
        {
            /* Check input string */
            if (String.IsNullOrEmpty(iString))
                return null;

            /* Check the digit-checked box */
            if (!digitChecked)
                return iString;

            if (iBase != bin && iBase != hex)
                return iString;

            /* Number of the size of the substring */
            int chunkSize = (iBase == bin ? 8 : 2);     /* 8: binary format, 2: hex format */
            /* Length of the input-string */
            int length = iString.Length;
            /* The remainder of the input-string */
            int mod = length % chunkSize;
            /* Set the space */
            char space = ' ';

            /* output string */
            string oString = string.Empty;
            string tempString = iString;
            if (mod != 0)
            {
                oString += iString.Substring(0, mod).PadLeft(chunkSize, '0');
                tempString = iString.Remove(0, mod);
            }
            while (tempString.Length != 0)
            {
                oString += $"{space}{tempString.Substring(0, chunkSize)}";
                tempString = tempString.Remove(0, chunkSize);
            }
            return oString;
        }
        #endregion

        #region Base Conversion
        private string Dec2Bin(bool signed = false)
        {
            try
            {
                string result = null;
                Int64 value = Convert.ToInt64(inputValue, dec);     /* dec: 10 */
                if (value < 0)
                {
                    if (signed)
                        result = Convert.ToString(value, bin);
                    else
                        result = $"-{Convert.ToString(-value, bin)}";
                    return FormatOutput(result, bin);
                }
                result = Convert.ToString(value, bin);                /* bin: 2 */
                return FormatOutput(result, bin);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string Dec2Hex(bool signed = false)
        {
            try
            {
                string result = null;
                Int64 value = Convert.ToInt64(inputValue, dec); /* dec: 10 */
                if (value < 0)
                {
                    if (signed)
                        result = Convert.ToString(value, hex).ToUpper();
                    else
                        result = $"-{Convert.ToString(-value, hex).ToUpper()}";
                    return FormatOutput(result, hex);
                }
                result = Convert.ToString(value, hex).ToUpper();            /* hex: 16 */
                return FormatOutput(result, hex);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string Bin2Dec(bool signed = false)
        {
            try
            {
                Int64 value = Convert.ToInt64(inputValue, bin);     /* bin: 2 */
                if (signed)
                {
                    int len = inputValue.Length;
                    //if (len % 8 != 0)
                    //    return "N/A";
                    return Convert.ToString(value - Math.Pow(2, len));
                }
                return Convert.ToString(value, dec);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string Bin2Hex()
        {
            try
            {
                Int64 value = Convert.ToInt64(inputValue, bin);                         /* bin: 2 */
                return FormatOutput(Convert.ToString(value, hex).ToUpper(), hex);      /* dec: 10 */
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string Hex2Bin()
        {
            try
            {
                Int64 value = Convert.ToInt64(inputValue, hex);     /* bin: 2 */
                return FormatOutput(Convert.ToString(value, bin), bin);                /* dec: 10 */
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string Hex2Dec(bool signed = false)
        {
            try
            {
                Int64 value = Convert.ToInt64(inputValue, hex);     /* hex: 16 */
                if (signed)
                {
                    int len = inputValue.Length;
                    //if (len % 2 != 0)
                    //    return "N/A";
                    return Convert.ToString(value - Math.Pow(16, len));
                }
                return Convert.ToString(value, dec);                /* dec: 10 */
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region Number Conversion
        private void BinConversion()
        {
            if (currentComboxTo == "hexadecimal")
            {
                /* Hex number */
                richtextOutput1.Text = Bin2Hex();
                /* Decimal number */
                richtextOutput2.Text = Bin2Dec();
                return;
            }
            if (currentComboxTo == "decimal")
            {
                /* Decimal number */
                richtextOutput1.Text = Bin2Dec();
                /* Decimal from signed 2's complement */
                richtextOutput2.Text = Bin2Dec(true);
                /* Hex number */
                richtextOutput3.Text = Bin2Hex();
                return;
            }
        }
        private void DecConversion()
        {
            if (currentComboxTo == "binary")
            {
                /* Binary number */
                richtextOutput1.Text = Dec2Bin();
                /* Binary signed 2's complement */
                richtextOutput2.Text = Dec2Bin(true);
                /* Hex number */
                richtextOutput3.Text = Dec2Hex();
                return;
            }
            if (currentComboxTo == "hexadecimal")
            {
                /* Hex number */
                richtextOutput1.Text = Dec2Hex();
                /* Hex signed 2's complement */
                richtextOutput2.Text = Dec2Hex(true);
                /* Binary number */
                richtextOutput3.Text = Dec2Bin();
                return;
            }
        }
        private void HexConversion()
        {
            if (currentComboxTo == "decimal")
            {
                /* Decimal number */
                richtextOutput1.Text = Hex2Dec();
                /* Decimal from signed 2's complement */
                richtextOutput2.Text = Hex2Dec(true);
                /* Binary number */
                richtextOutput3.Text = Hex2Bin();
                return;
            }
            if (currentComboxTo == "binary")
            {
                /* Binary number */
                richtextOutput1.Text = Hex2Bin();
                /* Decimal number */
                richtextOutput2.Text = Hex2Dec();
                return;
            }
        }
        #endregion

        #region Active Format Controls
        private void BinaryDesktop()
        {
            labelOutput1.Text = "Binary number";
            if (currentComboxFrom == "hexadecimal")
            {
                labelOutput2.Text = "Decimal number";
                panelInvisibal.Visible = false;
            }
            else if (currentComboxFrom == "decimal")
            {
                labelOutput2.Text = "Binary signed 2's complement";
                panelInvisibal.Visible = true;
                labelOutput3.Text = "Hex number";
            }
        }
        private void HexadecimalDesktop()
        {
            labelOutput1.Text = "Hex number";
            if (currentComboxFrom == "binary")
            {
                labelOutput2.Text = "Decimal number";
                panelInvisibal.Visible = false;
            }
            else if (currentComboxFrom == "decimal")
            {
                labelOutput2.Text = "Hex signed 2's complement";
                panelInvisibal.Visible = true;
                labelOutput3.Text = "Binary number";
            }
        }
        private void DecimalDesktop()
        {
            panelInvisibal.Visible = true;
            labelOutput1.Text = "Decimal number";
            labelOutput2.Text = "Decimal from signed 2's complement";

            if (currentComboxFrom == "hexadecimal")
            {
                labelOutput3.Text = "Binary number";
            }
            else if (currentComboxFrom == "binary")
            {
                labelOutput3.Text = "Hex number";
            }
        }
        #endregion

        #region User Interaction
        #region Combox
        private void comboxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxFrom.SelectedItem.ToString().ToLower() == currentComboxFrom)
                return;
            labelEnterNumber.Text = $"Enter {comboxFrom.SelectedItem.ToString().ToLower()} number";
            ActivateControls();
        }
        private void comboxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxTo.SelectedItem.ToString().ToLower() == currentComboxTo)
                return;
            ActivateControls();
        }
        #endregion
        #region Button
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richtextInput.Text))
                return;

            currentComboxTo = comboxTo.Text.ToLower();
            currentComboxFrom = comboxFrom.Text.ToLower();

            if (currentComboxFrom == currentComboxTo)
                return;

            /* Get global inputValue */
            inputValue = richtextInput.Text;

            /* Select the type of conversion */
            switch (currentComboxFrom)
            {
                case "binary":
                    BinConversion();
                    break;
                case "decimal":
                    DecConversion();
                    break;
                case "hexadecimal":
                    HexConversion();
                    break;
                default:
                    break;
            }
        }
        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (comboxFrom.SelectedItem == comboxTo.SelectedItem)
                return;
            /* Swap selected item */
            object t = comboxFrom.SelectedItem;
            comboxFrom.SelectedItem = comboxTo.SelectedItem;
            comboxTo.SelectedItem = t;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            richtextInput.Text = null;
            richtextOutput1.Text = null;
            richtextOutput2.Text = null;
            richtextOutput3.Text = null;
        }
        #endregion
        #region Checkbox
        private void checkboxDigitGrouping_CheckedChanged(object sender, EventArgs e)
        {
            digitChecked = checkboxDigitGrouping.Checked;
            this.buttonConvert_Click(sender, e);
        }
        #endregion
        #endregion
    }
}
