namespace CoToan
{
    partial class Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.pbNewGame = new System.Windows.Forms.PictureBox();
            this.pbOpen = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAbout
            // 
            this.pbAbout.BackColor = System.Drawing.Color.Transparent;
            this.pbAbout.Image = global::CoToan.Properties.Resources.About;
            this.pbAbout.Location = new System.Drawing.Point(44, 129);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(143, 43);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbout.TabIndex = 4;
            this.pbAbout.TabStop = false;
            this.pbAbout.Tag = "Rule";
            this.pbAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAbout_MouseClick);
            this.pbAbout.MouseEnter += new System.EventHandler(this.pbAbout_MouseEnter);
            this.pbAbout.MouseLeave += new System.EventHandler(this.pbAbout_MouseLeave);
            // 
            // pbNewGame
            // 
            this.pbNewGame.BackColor = System.Drawing.Color.Transparent;
            this.pbNewGame.Image = global::CoToan.Properties.Resources.Newgame;
            this.pbNewGame.Location = new System.Drawing.Point(44, 61);
            this.pbNewGame.Name = "pbNewGame";
            this.pbNewGame.Size = new System.Drawing.Size(143, 43);
            this.pbNewGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewGame.TabIndex = 0;
            this.pbNewGame.TabStop = false;
            this.pbNewGame.Tag = "New Game";
            this.pbNewGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbNewGame_MouseClick);
            this.pbNewGame.MouseEnter += new System.EventHandler(this.pbNewGame_MouseEnter);
            this.pbNewGame.MouseLeave += new System.EventHandler(this.pbNewGame_MouseLeave);
            // 
            // pbOpen
            // 
            this.pbOpen.BackColor = System.Drawing.Color.Transparent;
            this.pbOpen.Image = global::CoToan.Properties.Resources.Open;
            this.pbOpen.Location = new System.Drawing.Point(241, 61);
            this.pbOpen.Name = "pbOpen";
            this.pbOpen.Size = new System.Drawing.Size(143, 43);
            this.pbOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpen.TabIndex = 2;
            this.pbOpen.TabStop = false;
            this.pbOpen.Tag = "Open Game";
            this.pbOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbOpen_MouseClick);
            this.pbOpen.MouseEnter += new System.EventHandler(this.pbOpen_MouseEnter);
            this.pbOpen.MouseLeave += new System.EventHandler(this.pbOpen_MouseLeave);
            // 
            // pbSave
            // 
            this.pbSave.BackColor = System.Drawing.Color.Transparent;
            this.pbSave.Image = global::CoToan.Properties.Resources.Save;
            this.pbSave.Location = new System.Drawing.Point(241, 129);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(143, 43);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 1;
            this.pbSave.TabStop = false;
            this.pbSave.Tag = "Save Game";
            this.pbSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbSave_MouseClick);
            this.pbSave.MouseEnter += new System.EventHandler(this.pbSave_MouseEnter);
            this.pbSave.MouseLeave += new System.EventHandler(this.pbSave_MouseLeave);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = global::CoToan.Properties.Resources.Exit;
            this.pbExit.InitialImage = global::CoToan.Properties.Resources.Exit;
            this.pbExit.Location = new System.Drawing.Point(377, -2);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 29);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            this.pbExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbExit_MouseClick);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoToan.Properties.Resources.SubForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 218);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbAbout);
            this.Controls.Add(this.pbOpen);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbNewGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.PictureBox pbNewGame;
        private System.Windows.Forms.PictureBox pbOpen;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.PictureBox pbExit;
    }
}