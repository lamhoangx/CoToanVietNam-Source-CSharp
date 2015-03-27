namespace CoToan
{
    partial class New
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
            this.lbName1 = new System.Windows.Forms.Label();
            this.lbName2 = new System.Windows.Forms.Label();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.rbNguoi = new System.Windows.Forms.RadioButton();
            this.rbAI = new System.Windows.Forms.RadioButton();
            this.cbScore = new System.Windows.Forms.CheckBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName1
            // 
            this.lbName1.AutoSize = true;
            this.lbName1.BackColor = System.Drawing.Color.Transparent;
            this.lbName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbName1.Location = new System.Drawing.Point(50, 66);
            this.lbName1.Name = "lbName1";
            this.lbName1.Size = new System.Drawing.Size(110, 13);
            this.lbName1.TabIndex = 0;
            this.lbName1.Text = "Tên Người Chơi 1:";
            // 
            // lbName2
            // 
            this.lbName2.AutoSize = true;
            this.lbName2.BackColor = System.Drawing.Color.Transparent;
            this.lbName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName2.ForeColor = System.Drawing.Color.Transparent;
            this.lbName2.Location = new System.Drawing.Point(50, 92);
            this.lbName2.Name = "lbName2";
            this.lbName2.Size = new System.Drawing.Size(110, 13);
            this.lbName2.TabIndex = 1;
            this.lbName2.Text = "Tên Người Chơi 2:";
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(194, 59);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(129, 20);
            this.tbName1.TabIndex = 2;
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(194, 85);
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(129, 20);
            this.tbName2.TabIndex = 3;
            // 
            // rbNguoi
            // 
            this.rbNguoi.AutoSize = true;
            this.rbNguoi.BackColor = System.Drawing.Color.Transparent;
            this.rbNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNguoi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbNguoi.Location = new System.Drawing.Point(53, 36);
            this.rbNguoi.Name = "rbNguoi";
            this.rbNguoi.Size = new System.Drawing.Size(106, 17);
            this.rbNguoi.TabIndex = 4;
            this.rbNguoi.TabStop = true;
            this.rbNguoi.Text = "Chơi với người";
            this.rbNguoi.UseVisualStyleBackColor = false;
            this.rbNguoi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbNguoi_MouseClick);
            // 
            // rbAI
            // 
            this.rbAI.AutoSize = true;
            this.rbAI.BackColor = System.Drawing.Color.Transparent;
            this.rbAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbAI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbAI.Location = new System.Drawing.Point(194, 36);
            this.rbAI.Name = "rbAI";
            this.rbAI.Size = new System.Drawing.Size(97, 17);
            this.rbAI.TabIndex = 5;
            this.rbAI.TabStop = true;
            this.rbAI.Text = "Chơi với máy";
            this.rbAI.UseVisualStyleBackColor = false;
            this.rbAI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbAI_MouseClick);
            // 
            // cbScore
            // 
            this.cbScore.AutoSize = true;
            this.cbScore.BackColor = System.Drawing.Color.Transparent;
            this.cbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbScore.Location = new System.Drawing.Point(53, 114);
            this.cbScore.Name = "cbScore";
            this.cbScore.Size = new System.Drawing.Size(86, 17);
            this.cbScore.TabIndex = 6;
            this.cbScore.Text = "Cược điểm";
            this.cbScore.UseVisualStyleBackColor = false;
            this.cbScore.CheckedChanged += new System.EventHandler(this.cbScore_CheckedChanged);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = global::CoToan.Properties.Resources.Thoat;
            this.pbExit.Location = new System.Drawing.Point(194, 154);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(106, 29);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 10;
            this.pbExit.TabStop = false;
            this.pbExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbExit_MouseClick);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // pbStart
            // 
            this.pbStart.BackColor = System.Drawing.Color.Transparent;
            this.pbStart.Image = global::CoToan.Properties.Resources.BatDau;
            this.pbStart.Location = new System.Drawing.Point(59, 154);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(100, 30);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStart.TabIndex = 9;
            this.pbStart.TabStop = false;
            this.pbStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseClick);
            this.pbStart.MouseEnter += new System.EventHandler(this.pbStart_MouseEnter);
            this.pbStart.MouseLeave += new System.EventHandler(this.pbStart_MouseLeave);
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(194, 111);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(129, 20);
            this.tbScore.TabIndex = 11;
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoToan.Properties.Resources.SubForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 221);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.cbScore);
            this.Controls.Add(this.rbAI);
            this.Controls.Add(this.rbNguoi);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.tbName1);
            this.Controls.Add(this.lbName2);
            this.Controls.Add(this.lbName1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName1;
        private System.Windows.Forms.Label lbName2;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.RadioButton rbNguoi;
        private System.Windows.Forms.RadioButton rbAI;
        private System.Windows.Forms.CheckBox cbScore;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.TextBox tbScore;
    }
}