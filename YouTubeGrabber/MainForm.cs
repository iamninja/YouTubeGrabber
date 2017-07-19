using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeGrabber
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void downloadUrlButton_Click(object sender, EventArgs e)
        {
            String urlText = urlTextBox.ToString();
            Console.WriteLine(urlText);
        }
    }
}
