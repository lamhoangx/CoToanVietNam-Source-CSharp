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
    public partial class New : Form
    {
        int kt = 0;   
        public static int start = 0;
        public New()
        {
            InitializeComponent();

            rbNguoi.Checked = true;
            if (cbScore.Checked == false)
                tbScore.Visible = false;

        }

        private void rbNguoi_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbAI.Checked == true)
                rbAI.Checked = false;
            rbNguoi.Checked = true;
            Game.may = 0;
            Game.nguoi = 1;
            lbName2.Visible = true;
            tbName2.Visible = true;
            lbName1.Text = "Tên người chơi 1: ";
        }

        private void rbAI_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbNguoi.Checked == true)
                rbNguoi.Checked = false;
            rbAI.Checked = true;
            Game.may = 1;
            Game.nguoi = 0;
            lbName2.Visible = false;
            tbName2.Visible = false;
            lbName1.Text = "Tên người chơi : ";
        }
        private void pbStart_MouseClick(object sender, MouseEventArgs e)
        {
            
            
            if (rbNguoi.Checked == true)
            {
                VanCo.TenNguoiChoi1 = tbName1.Text.ToString();
                VanCo.TenNguoiChoi2 = tbName2.Text.ToString();
                Game.nguoi = 1;
                Game.may = 0;
            }
            if (rbAI.Checked == true)
            {
                VanCo.TenNguoiChoi2 = tbName1.Text.ToString();
                VanCo.TenNguoiChoi1 = "Máy";
                lbName2.Visible = false;
                tbName2.Visible = false;
                Game.nguoi = 0;
                Game.may = 1;
            }

            if (Game.iNewGame == 1)
            {
                Game.iNewGameS = 1;
            }
            if (cbScore.Checked == true)
            {


                if (tbScore.Text != "")
                {
                    VanCo.score = Convert.ToInt32(tbScore.Text.ToString());
                }
                else
                {
                    MessageBox.Show("Nhập vào điểm cược!!! ");
                    kt = 1;
                }
            }
            if (cbScore.Checked == false)
            {
                VanCo.score = 100000 ;
                Game.score = "Không Cược";
            }
            if(kt == 0)
                this.Close();

        }

        private void pbStart_MouseLeave(object sender, EventArgs e)
        {
            this.pbStart.Image = CoToan.Properties.Resources.BatDau;
        }

        private void pbStart_MouseEnter(object sender, EventArgs e)
        {
            this.pbStart.Image = CoToan.Properties.Resources.BatDau_MouseOver;

            
        }

        private void pbExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            this.pbExit.Image = CoToan.Properties.Resources.Thoat;
        }

        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            this.pbExit.Image = CoToan.Properties.Resources.Thoat_MouseOver;
        }

        private void cbScore_CheckedChanged(object sender, EventArgs e)
        {
            tbScore.Visible = true;
            
        }

        private void New_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        
    }
}
