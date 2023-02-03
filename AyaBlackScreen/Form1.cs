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

namespace AyaBlackScreen
{
    public partial class Form1 : Form
    {
        int clickTimes;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        public static extern void ShowCursor(int status);

        private void Form1_Load(object sender, EventArgs e)
        {
            clickTimes = 0;
            ShowCursor(0);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            clickTimes++;
            if(clickTimes >= 3)
            {
                Application.Exit();
            }
        }
    }
}
