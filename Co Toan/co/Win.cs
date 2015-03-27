using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoToan
{
    public partial class Win : Form
    {
        public String strWin;
        public Win()
        {
            InitializeComponent();
            strWin = VanCo.strWin;
            lbWin.Text = strWin;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image = CoToan.Properties.Resources.Exit_MouseOver;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = CoToan.Properties.Resources.Exit;
        }
    }
}
