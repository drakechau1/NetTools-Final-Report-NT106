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
        private int hex = 16;
        private int bin = 2;
        private int dec = 10;

        private bool digitChecked = false;

        string currentComboxFromItem, currentComboxToItem;

        public UCBinaryConverter()
        {
            InitializeComponent();
        }

        #region Methods
        private void ActivateControls()
        {
            currentComboxToItem = comboxTo.Text.ToLower();
            currentComboxFromItem = comboxFrom.Text.ToLower();

            if (currentComboxFromItem == currentComboxToItem)
                return;

            textOutput1.Text = null;
            textOutput2.Text = null;
            textOutput3.Text = null;

            switch (currentComboxToItem)
            {
                case "binary":
                    labelOutput1.Text = "Binary number";
                    if (currentComboxFromItem == "hexadecimal")
                    {
                        labelOutput2.Text = "Decimal number";
                        panelInvisibal.Visible = false;
                    }
                    else if (currentComboxFromItem == "decimal")
                    {
                        labelOutput2.Text = "Binary signed 2's complement";
                        panelInvisibal.Visible = true;
                        labelOutput3.Text = "Hex number";
                    }
                    break;
                case "decimal":
                    panelInvisibal.Visible = true;
                    labelOutput1.Text = "Decimal number";
                    labelOutput2.Text = "Decimal from signed 2's complement";

                    if (currentComboxFromItem == "hexadecimal")
                    {
                        labelOutput3.Text = "Binary number";
                    }
                    else if (currentComboxFromItem == "binary")
                    {
                        labelOutput3.Text = "Hex number";
                    }
                    break;
                case "hexadecimal":
                    labelOutput1.Text = "Hex number";
                    if (currentComboxFromItem == "binary")
                    {
                        labelOutput2.Text = "Decimal number";
                        panelInvisibal.Visible = false;
                    }
                    else if (currentComboxFromItem == "decimal")
                    {
                        labelOutput2.Text = "Hex signed 2's complement";
                        panelInvisibal.Visible = true;
                        labelOutput3.Text = "Binary number";
                    }
                    break;
                default:
                    break;
            }
        }

        private List<string> SplitString(string str, int chunkSize)
        {
            List<string> listString = new List<string>();
            string tempString = str;
            if (str.Length % chunkSize != 0)
            {
                int mod = str.Length % chunkSize;
                listString.Add(str.Substring(0, mod));
                tempString = str.Remove(0, mod);
            }
            for (int i = 0; i < str.Length / chunkSize; i++)
            {
                listString.Add(tempString.Substring(i * chunkSize, chunkSize));
            }
            return listString;
        }

        private string Signed2sComplement(string strValue, int fromBase, int toBase)
        {
            try
            {
                Int64 maxInt = 0;
                if (fromBase == hex)
                    maxInt = (Int64)Math.Pow(16.0, (double)strValue.Length);
                else if (fromBase == bin)
                    maxInt = (Int64)Math.Pow(2.0, (double)strValue.Length);
                else
                {
                    string result = string.Empty;
                    try
                    {
                        foreach (var item in SplitString(strValue, 16))
                        {
                            result += Convert.ToString(Convert.ToInt64(item, fromBase), toBase);
                        }
                        return FormatOutput(result, toBase);
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
                Int64 value = Convert.ToInt64(strValue, fromBase);
                Int64 res = value - maxInt;
                return FormatOutput(res.ToString(), toBase);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private string BinaryConvert(string value, int fromBase, int toBase)
        {
            List<string> listSplitValues = new List<string>();
            try
            {
                Int64 n;
                n = Convert.ToInt64(value, fromBase);   /* Convert string to the fromBase of Value */
                if (fromBase == dec && toBase == bin && n < 0)
                    return "N/A";
                try
                {
                    return FormatOutput(Convert.ToString(n, toBase), toBase);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            catch
            {
                listSplitValues = SplitString(value, 16);
                string result = string.Empty;
                try
                {
                    foreach (var item in listSplitValues)
                    {
                        result += Convert.ToString(Convert.ToInt64(item, fromBase), toBase);
                    }
                    return FormatOutput(result, toBase);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        private string FormatOutput(string str, int baseFormat)
        {
            /* Check the condition */
            if (digitChecked == false || baseFormat == dec)
                return str;

            string strFormated = null; /* Return the formated string */
            List<string> listString = new List<string>();    /* Store the string was splitted */
            if (baseFormat == hex)
                listString = SplitString(str, 2);
            else
                listString = SplitString(str, 8);
            foreach (var item in listString)
            {
                strFormated += $"{item} ";
            }
            return strFormated;
        }
        #endregion

        #region User Interaction
        private void UCBinaryConverter_Load(object sender, EventArgs e)
        {
            /* Initialize ComboBox Selected Item */
            comboxFrom.SelectedItem = comboxFrom.Items[1];  //Decimal
            comboxTo.SelectedItem = comboxFrom.Items[0];    //Binary
        }

        private void comboxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxFrom.SelectedItem.ToString().ToLower() == currentComboxFromItem)
                return;
            labelEnterNumber.Text = $"Enter {comboxFrom.SelectedItem.ToString().ToLower()} number";
            ActivateControls();
        }

        private void comboxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboxTo.SelectedItem.ToString().ToLower() == currentComboxToItem)
                return;
            ActivateControls();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (comboxFrom.SelectedItem == comboxTo.SelectedItem)
                return;
            /* Swap selected item */
            object temp1 = comboxFrom.SelectedItem;
            comboxFrom.SelectedItem = comboxTo.SelectedItem;
            comboxTo.SelectedItem = temp1;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textInput.Text))
                return;

            currentComboxToItem = comboxTo.Text.ToLower();
            currentComboxFromItem = comboxFrom.Text.ToLower();
            if (currentComboxFromItem == currentComboxToItem)
                return;

            string value = textInput.Text;
            switch (currentComboxToItem)
            {
                case "binary":
                    if (currentComboxFromItem == "hexadecimal")
                    {
                        textOutput1.Text = BinaryConvert(value, hex, bin);
                        textOutput2.Text = BinaryConvert(value, hex, dec);
                    }
                    else if (currentComboxFromItem == "decimal")
                    {
                        textOutput1.Text = BinaryConvert(value, dec, bin);
                        textOutput2.Text = Signed2sComplement(value, dec, bin);
                        textOutput3.Text = BinaryConvert(value, dec, hex).ToUpper();
                    }
                    break;
                case "decimal":
                    if (currentComboxFromItem == "hexadecimal")
                    {
                        textOutput1.Text = BinaryConvert(value, hex, dec);
                        textOutput2.Text = Signed2sComplement(value, hex, dec);
                        textOutput3.Text = BinaryConvert(value, hex, bin);
                    }
                    else if (currentComboxFromItem == "binary")
                    {
                        textOutput1.Text = BinaryConvert(value, bin, dec);
                        textOutput2.Text = Signed2sComplement(value, bin, dec);
                        textOutput3.Text = BinaryConvert(value, bin, hex).ToUpper();
                    }
                    break;
                case "hexadecimal":
                    if (currentComboxFromItem == "binary")
                    {
                        textOutput1.Text = BinaryConvert(value, bin, hex).ToUpper();
                        textOutput2.Text = BinaryConvert(value, bin, dec).ToUpper();
                    }
                    else if (currentComboxFromItem == "decimal")
                    {
                        textOutput1.Text = BinaryConvert(value, dec, hex).ToUpper();
                        textOutput2.Text = BinaryConvert(value, dec, hex).ToUpper();
                        textOutput3.Text = BinaryConvert(value, dec, bin);
                    }
                    break;
                default:
                    break;
            }
        }

        private void checkboxDigitGrouping_CheckedChanged(object sender, EventArgs e)
        {
            digitChecked = checkboxDigitGrouping.Checked;
            this.buttonConvert_Click(sender, e);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textInput.Text = null;
            textOutput1.Text = null;
            textOutput2.Text = null;
            textOutput3.Text = null;
        }
        #endregion
    }
}
