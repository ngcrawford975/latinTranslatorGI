using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latinTranslatorGI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autemBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "up";
        }

        private void descenditBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "down";
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "center";
        }
    }
}
