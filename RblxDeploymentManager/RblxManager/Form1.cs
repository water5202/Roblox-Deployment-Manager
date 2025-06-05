using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace RblxManager
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
            ApplyDarkTitleBar();
        }

        private void UI_Load(object sender, EventArgs e)
        {
        }

        private void ApplyDarkTitleBar()
        {
            int attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
            int useDark = 1;
            DwmSetWindowAttribute(this.Handle, attribute, ref useDark, Marshal.SizeOf(typeof(int)));
        }

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private void ClientSettings_Click(object sender, EventArgs e)
        {
            string url = "https://clientsettings.roblox.com/v2/client-version/WindowsPlayer/channel/LIVE";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void RblxDownloader_Click(object sender, EventArgs e)
        {
            // https://rdd.latte.to/?channel=<CHANNEL_NAME>&binaryType=<BINARY_TYPE>&version=<VERSION_HASH>
        }

        private void GithubPage_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/water5202";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void LABELPROGRAM_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
