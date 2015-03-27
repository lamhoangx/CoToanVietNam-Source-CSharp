using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 

namespace CoToan
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            webMain.Visible = false;
            link.Visible = false;
        }

        private void pbRule_MouseClick(object sender, MouseEventArgs e)
        {
            webMain.Visible = true;
            link.Visible = false;
            String appdir = Path.GetDirectoryName(Application.ExecutablePath);
            String myfile = Path.Combine(appdir, "LuatChoi.htm");
            webMain.Url = new Uri("file:///" + myfile);
            pictureBox2.Visible = false;
        }

        private void pbRule_MouseEnter(object sender, EventArgs e)
        {
            this.pbRule.Image = CoToan.Properties.Resources.Luat_MouseOver;
        }

        private void pbRule_MouseLeave(object sender, EventArgs e)
        {
            this.pbRule.Image = CoToan.Properties.Resources.Luat;
        }

        private void pbGroup_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
            link.Visible = false;
            pictureBox2.Image = CoToan.Properties.Resources.About1;
            webMain.Visible = false;
        }

        private void pbExit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            this.pbExit.Image = CoToan.Properties.Resources.Exit_MouseOver;
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            this.pbExit.Image = CoToan.Properties.Resources.Exit;
        }

        private void pbGroup_MouseEnter(object sender, EventArgs e)
        {
            this.pbGroup.Image = CoToan.Properties.Resources.ThucHien;
        }

        private void pbGroup_MouseLeave(object sender, EventArgs e)
        {
            this.pbGroup.Image = CoToan.Properties.Resources.ThucHien_MouseOver;
        }

        private void pbAuthor_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = CoToan.Properties.Resources.TacGia;
            link.Visible = true;
            webMain.Visible = false;
        }

        private void pbAuthor_MouseEnter(object sender, EventArgs e)
        {
            this.pbAuthor.Image = CoToan.Properties.Resources.TacGia_MouseOver;
        }

        private void pbAuthor_MouseLeave(object sender, EventArgs e)
        {
            this.pbAuthor.Image = CoToan.Properties.Resources.btnTacGia;
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                System.Diagnostics.Process.Start("http://cotoan.vnvista.com"); 
        }

    }
}
