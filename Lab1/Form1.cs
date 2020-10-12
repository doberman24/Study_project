using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool vis = true;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            l1.Text = b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (rB1.Checked)
                l1.Text = tB1.Text;
            else
                l1.Text = lB1.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                l1.Visible = false;
                vis = false;
            }
            else
            {
                l1.Visible = true;
                vis = true;
            }
        }
    }
}
