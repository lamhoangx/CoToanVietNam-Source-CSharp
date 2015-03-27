namespace CoToan
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.webMain = new System.Windows.Forms.WebBrowser();
            this.pbRule = new System.Windows.Forms.PictureBox();
            this.pbGroup = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbAuthor = new System.Windows.Forms.PictureBox();
            this.link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbRule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // webMain
            // 
            this.webMain.Location = new System.Drawing.Point(145, 69);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(611, 387);
            this.webMain.TabIndex = 1;
            // 
            // pbRule
            // 
            this.pbRule.BackColor = System.Drawing.Color.Transparent;
            this.pbRule.Image = global::CoToan.Properties.Resources.Luat;
            this.pbRule.Location = new System.Drawing.Point(16, 235);
            this.pbRule.Name = "pbRule";
            this.pbRule.Size = new System.Drawing.Size(116, 41);
            this.pbRule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRule.TabIndex = 2;
            this.pbRule.TabStop = false;
            this.pbRule.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRule_MouseClick);
            this.pbRule.MouseEnter += new System.EventHandler(this.pbRule_MouseEnter);
            this.pbRule.MouseLeave += new System.EventHandler(this.pbRule_MouseLeave);
            // 
            // pbGroup
            // 
            this.pbGroup.BackColor = System.Drawing.Color.Transparent;
            this.pbGroup.Image = global::CoToan.Properties.Resources.ThucHien_MouseOver;
            this.pbGroup.Location = new System.Drawing.Point(16, 188);
            this.pbGroup.Name = "pbGroup";
            this.pbGroup.Size = new System.Drawing.Size(116, 41);
            this.pbGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGroup.TabIndex = 3;
            this.pbGroup.TabStop = false;
            this.pbGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGroup_MouseClick);
            this.pbGroup.MouseEnter += new System.EventHandler(this.pbGroup_MouseEnter);
            this.pbGroup.MouseLeave += new System.EventHandler(this.pbGroup_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CoToan.Properties.Resources.About1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(145, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(624, 387);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = global::CoToan.Properties.Resources.Exit;
            this.pbExit.InitialImage = global::CoToan.Properties.Resources.Exit;
            this.pbExit.Location = new System.Drawing.Point(724, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(32, 29);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 8;
            this.pbExit.TabStop = false;
            this.pbExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbExit_MouseClick);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // pbAuthor
            // 
            this.pbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.pbAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pbAuthor.Image")));
            this.pbAuthor.Location = new System.Drawing.Point(16, 282);
            this.pbAuthor.Name = "pbAuthor";
            this.pbAuthor.Size = new System.Drawing.Size(116, 41);
            this.pbAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuthor.TabIndex = 9;
            this.pbAuthor.TabStop = false;
            this.pbAuthor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAuthor_MouseClick);
            this.pbAuthor.MouseEnter += new System.EventHandler(this.pbAuthor_MouseEnter);
            this.pbAuthor.MouseLeave += new System.EventHandler(this.pbAuthor_MouseLeave);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.BackColor = System.Drawing.Color.Transparent;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.link.Location = new System.Drawing.Point(571, 428);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(185, 16);
            this.link.TabIndex = 10;
            this.link.TabStop = true;
            this.link.Text = "http://cotoan.vnvista.com/";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoToan.Properties.Resources.Thongtin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 528);
            this.Controls.Add(this.link);
            this.Controls.Add(this.pbAuthor);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbGroup);
            this.Controls.Add(this.pbRule);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.webMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.pbRule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.PictureBox pbRule;
        private System.Windows.Forms.PictureBox pbGroup;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbAuthor;
        private System.Windows.Forms.LinkLabel link;
    }
}