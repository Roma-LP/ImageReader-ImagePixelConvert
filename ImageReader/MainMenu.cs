using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReader
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BT_FirstApp_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void BT_SecondApp_Click(object sender, EventArgs e)
        {
            ImagePixelForm imagePixelForm = new ImagePixelForm();
            imagePixelForm.ShowDialog();
        }
    }
}
