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

        public UCBinaryConverter()
        {
            InitializeComponent();
        }

        #region Methods
        private void ActivateControls()
        {
            string currentComboxToSelected = comboxTo.Text.ToLower();
            string currentComboxFromSelected = comboxFrom.Text.ToLower();

            if (currentComboxFromSelected == currentComboxToSelected)
                return;

            textOutput1.Text = null;
            textOutput2.Text = null;
            textOutput3.Text = null;

            switch (currentComboxToSelected)
            {
                case "binary":
                    labelOutput1.Text = "Binary number";
                    if (currentComboxFromSelected == "hexadecimal")
                    {
                        labelOutput2.Text = "Decimal number";
                        panelInvisibal.Visible = false;
                    }
                    else if (currentComboxFromSelected == "decimal")
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

                    if (currentComboxFromSelected == "hexadecimal")
                    {
                        labelOutput3.Text = "Binary number";
                    }
                    else if (currentComboxFromSelected == "binary")
                    {
                        labelOutput3.Text = "Hex number";
                    }
                    break;
                case "hexadecimal":
                    labelOutput1.Text = "Hex number";
                    if (currentComboxFromSelected == "binary")
                    {
                        labelOutput2.Text = "Decimal number";
                        panelInvisibal.Visible = false;
                    }
                    else if (currentComboxFromSelected == "decimal")
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

        private IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        private string BinaryConvert(string value, int fromBase, int toBase)
        {
            IEnumerable<string> listValue = null;
            try
            {
                Int64 n;
                n = Convert.ToInt64(value, fromBase);
                try
                {
                    return Convert.ToString(n, toBase);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            catch
            {
                listValue = Split(value, 16);
                string result = string.Empty;
                try
                {
                    foreach (var item in listValue)
                    {
                        result += Convert.ToString(Convert.ToInt64(item, fromBase), toBase);
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        #endregion

        private void UCBinaryConverter_Load(object sender, EventArgs e)
        {
            /* Initialize ComboBox Selected Item */
            comboxFrom.SelectedItem = comboxFrom.Items[1];  //Decimal
            comboxTo.SelectedItem = comboxFrom.Items[0];    //Binary
        }

        private void comboxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelEnterNumber.Text = $"Enter {comboxFrom.SelectedItem.ToString().ToLower()} number";
            ActivateControls();
        }

        private void comboxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            string currentComboxToSelected = comboxTo.Text.ToLower();
            string currentComboxFromSelected = comboxFrom.Text.ToLower();

            if (currentComboxFromSelected == currentComboxToSelected)
                return;

            string value = textInput.Text;
            switch (currentComboxToSelected)
            {
                case "binary":
                    if (currentComboxFromSelected == "hexadecimal")
                    {
                        textOutput1.Text = BinaryConvert(value, hex, bin);
                        textOutput2.Text = BinaryConvert(value, hex, bin);
                    }
                    else if (currentComboxFromSelected == "decimal")
                    {
                        textOutput1.Text = BinaryConvert(value, dec, bin);
                        textOutput2.Text = BinaryConvert(value, dec, bin);
                        textOutput3.Text = BinaryConvert(value, dec, hex).ToUpper();
                    }
                    break;
                case "decimal":
                    if (currentComboxFromSelected == "hexadecimal")
                    {
                        textOutput1.Text = BinaryConvert(value, hex, dec);
                        textOutput2.Text = BinaryConvert(value, hex, dec);
                        textOutput3.Text = BinaryConvert(value, hex, bin);
                    }
                    else if (currentComboxFromSelected == "binary")
                    {
                        textOutput1.Text = BinaryConvert(value, bin, dec);
                        textOutput2.Text = BinaryConvert(value, bin, dec);
                        textOutput3.Text = BinaryConvert(value, bin, hex).ToUpper();
                    }
                    break;
                case "hexadecimal":
                    if (currentComboxFromSelected == "binary")
                    {
                        textOutput1.Text = BinaryConvert(value, bin, hex).ToUpper();
                        textOutput2.Text = BinaryConvert(value, bin, dec).ToUpper();
                    }
                    else if (currentComboxFromSelected == "decimal")
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textInput.Text = null;
            textOutput1.Text = null;
            textOutput2.Text = null;
            textOutput3.Text = null;
        }
    }
}
