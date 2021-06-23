using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTools
{
    public partial class FormDashboard : Form
    {
        #region Declare User Controls
        UserControls.Network.UCIPGeoLocation ucIPGeoLocation = new UserControls.Network.UCIPGeoLocation();
        UserControls.Network.UCIPHeader ucIPHeader = new UserControls.Network.UCIPHeader();
        UserControls.Network.UCPing ucPing = new UserControls.Network.UCPing();
        UserControls.Network.UCTraceRoute ucTraceRoute = new UserControls.Network.UCTraceRoute();
        UserControls.Misc.UCBase64 ucBase64 = new UserControls.Misc.UCBase64();
        UserControls.Misc.UCBinaryConverter ucBinaryConverter = new UserControls.Misc.UCBinaryConverter();
        UserControls.Misc.UCSIDConverter ucSIDConverter = new UserControls.Misc.UCSIDConverter();
        UserControls.UCHome ucHome = new UserControls.UCHome();
        UserControls.UCSetting ucSetting = new UserControls.UCSetting();
        UserControls.Network.UCWhoIs ucWhoIs = new UserControls.Network.UCWhoIs();
        #endregion

        // Constructor
        public FormDashboard()
        {
            InitializeComponent();

            // Hide list button in menu bar
            labelTitle.Text = "Home";
            panelNetwork.Visible = false;
            panelMisc.Visible = false;

            // Hide window-control bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region Drag and risize form
        // Drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #region Control window
        private void buttonExitWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximizeWindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #endregion Drag and risize form

        #region Methods
        private void ActivateDesktopPanel(Control userControl)
        {
            if (userControl != null)
            {
                panelDesktop.Controls.Clear();
                userControl.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add((Control)userControl);
            }
        }
        private void HidePanel(Panel panel)
        {
            if (panel != null)
            {
                if (panel.Visible == true)
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }
        }
        #endregion Methods

        #region User interaction
        /* Load start form */
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucHome);
            labelTitle.Text = "Home";
        }
        /* Click logo */
        private void pictureLogo_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucHome);
            labelTitle.Text = "Home";
        }
        /* Setting */
        private void buttonSetting_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucSetting);
            labelTitle.Text = "Setting";
        }

        #region Network functions
        private void buttonNetwork_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucHome);
            HidePanel(panelNetwork);
            labelTitle.Text = "Network";
        }

        private void buttonIPHeader_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucIPHeader);
            labelTitle.Text = "IP Header";
        }

        private void buttonIPGeoLocation_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucIPGeoLocation);
            labelTitle.Text = "IP Geo Location";
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucPing);
            labelTitle.Text = "Ping";
        }

        private void buttonTraceRoute_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucTraceRoute);
            labelTitle.Text = "Trace Route";
        }

        private void buttonWhoIs_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucWhoIs);
            labelTitle.Text = "WhoIs";
        }
        #endregion End network

        #region Misc functions
        private void buttonMisc_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucHome);
            HidePanel(panelMisc);
            labelTitle.Text = "Misc";
        }

        private void buttonBase64_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucBase64);
            labelTitle.Text = "Base64";
        }

        private void buttonBinaryConverter_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucBinaryConverter);
            labelTitle.Text = "Binary Converter";
        }

        private void buttonSIDConverter_Click(object sender, EventArgs e)
        {
            ActivateDesktopPanel(ucSIDConverter);
            labelTitle.Text = "SID Converter";
        }
        #endregion End misc

        #endregion End user interaction
    }
}
