using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageINI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var MyIni = new IniFile("Settings.ini");
            MyIni.Write("DefaultVolume", "100", "Audio");
            MyIni.Write("DefaultVolume", "100", "Audio1");
            MyIni.DeleteKey("DefaultVolume", "Audio");
            MyIni.DeleteSection("Audio");
            var DefaultVolume = MyIni.Read("DefaultVolume", "Audio1");
            var a = 0;
        }
    }
}
