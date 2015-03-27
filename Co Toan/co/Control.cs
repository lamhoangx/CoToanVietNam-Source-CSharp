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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void pbNewGame_MouseLeave(object sender, EventArgs e)
        {
            this.pbNewGame.Image = CoToan.Properties.Resources.Newgame;
        }

        private void pbNewGame_MouseEnter(object sender, EventArgs e)
        {
            this.pbNewGame.Image = CoToan.Properties.Resources.Newgame_MouseOver;
        }

        private void pbNewGame_MouseClick(object sender, MouseEventArgs e)
        {

            New newgame = new New();
            newgame.ShowDialog();
            this.Close();
        }

        private void pbSave_MouseClick(object sender, MouseEventArgs e)
        {
            VanCo.Save();//luu van co hien tai
        }

        private void pbSave_MouseLeave(object sender, EventArgs e)
        {
            this.pbSave.Image = CoToan.Properties.Resources.Save;
        }

        private void pbSave_MouseEnter(object sender, EventArgs e)
        {
            this.pbSave.Image = CoToan.Properties.Resources.Save_MouseOver;
        }

        private void pbOpen_MouseClick(object sender, MouseEventArgs e)
        {
            Open openGame = new Open();
            openGame.ShowDialog();
            this.Close();
        }

        private void pbOpen_MouseLeave(object sender, EventArgs e)
        {
            this.pbOpen.Image = CoToan.Properties.Resources.Open;
        }

        private void pbOpen_MouseEnter(object sender, EventArgs e)
        {
            this.pbOpen.Image = CoToan.Properties.Resources.Open_MouseOver;
        }

        private void pbAbout_MouseClick(object sender, MouseEventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void pbAbout_MouseEnter(object sender, EventArgs e)
        {
            this.pbAbout.Image = CoToan.Properties.Resources.About_MouseOver;
        }

        private void pbAbout_MouseLeave(object sender, EventArgs e)
        {
            this.pbAbout.Image = CoToan.Properties.Resources.About;
        }

        private void pbExit_MouseClick(object sender, MouseEventArgs e)
        {
           // Application.Exit();
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
