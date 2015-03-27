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
    public partial class Open : Form
    {
        bool fileExit = false;
        DirectoryInfo fileDire = new DirectoryInfo(Application.StartupPath + "\\save");
        List<string> fileList = new List<string>();
        public Open()
        {
            InitializeComponent();
            if (fileDire.Exists)
            {
                foreach (FileInfo file in fileDire.GetFiles())
                {
                    fileExit = true;
                    fileList.Add(file.Name.Substring(0, file.Name.Length - 5));
                }
                if (fileExit)
                {
                    listBox1.DataSource = fileList;
                }
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            VanCo.Open(Application.StartupPath + "\\save\\" + Convert.ToString(listBox1.SelectedValue) + ".ctvn");
            VanCo.DangChoi = true;
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Image = CoToan.Properties.Resources.BatDau_MouseOver;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = CoToan.Properties.Resources.BatDau;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            FileInfo fileDel = new FileInfo(Application.StartupPath + "\\save\\" + Convert.ToString(listBox1.SelectedValue) + ".ctvn");
            List<string> newfileList = new List<string>();
            fileDel.Delete();
            if (fileDire.Exists)
            {
                foreach (FileInfo file in fileDire.GetFiles())
                {
                    fileExit = true;
                    newfileList.Add(file.Name.Substring(0, file.Name.Length - 4));
                }
                if (fileExit)
                {
                    listBox1.DataSource = newfileList;
                }
            }    
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image = CoToan.Properties.Resources.Del_MouseOver;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = CoToan.Properties.Resources.Del;
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
    }
}
