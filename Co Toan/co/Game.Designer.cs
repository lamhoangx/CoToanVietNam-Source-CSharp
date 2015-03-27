namespace CoToan
{
    partial class Game
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
            this.lbScore_den = new System.Windows.Forms.Label();
            this.lbScore_trang = new System.Windows.Forms.Label();
            this.pbMin = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.lbTen1 = new System.Windows.Forms.Label();
            this.lbTen2 = new System.Windows.Forms.Label();
            this.pbOption = new System.Windows.Forms.PictureBox();
            this.pbUndo = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUndo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore_den
            // 
            this.lbScore_den.AutoSize = true;
            this.lbScore_den.BackColor = System.Drawing.Color.Transparent;
            this.lbScore_den.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore_den.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbScore_den.Location = new System.Drawing.Point(598, 89);
            this.lbScore_den.Name = "lbScore_den";
            this.lbScore_den.Size = new System.Drawing.Size(21, 24);
            this.lbScore_den.TabIndex = 0;
            this.lbScore_den.Text = "0";
            // 
            // lbScore_trang
            // 
            this.lbScore_trang.AutoSize = true;
            this.lbScore_trang.BackColor = System.Drawing.Color.Transparent;
            this.lbScore_trang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore_trang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbScore_trang.Location = new System.Drawing.Point(598, 459);
            this.lbScore_trang.Name = "lbScore_trang";
            this.lbScore_trang.Size = new System.Drawing.Size(21, 24);
            this.lbScore_trang.TabIndex = 1;
            this.lbScore_trang.Text = "0";
            // 
            // pbMin
            // 
            this.pbMin.BackColor = System.Drawing.Color.Transparent;
            this.pbMin.BackgroundImage = global::CoToan.Properties.Resources.Mini;
            this.pbMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMin.Location = new System.Drawing.Point(670, 0);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(33, 26);
            this.pbMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMin.TabIndex = 2;
            this.pbMin.TabStop = false;
            this.pbMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMin_MouseClick);
            this.pbMin.MouseEnter += new System.EventHandler(this.pbMin_MouseEnter);
            this.pbMin.MouseLeave += new System.EventHandler(this.pbMin_MouseLeave);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImage = global::CoToan.Properties.Resources.Exit;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExit.Location = new System.Drawing.Point(709, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(33, 26);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 3;
            this.pbExit.TabStop = false;
            this.pbExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbExit_MouseClick);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // lbTen1
            // 
            this.lbTen1.AutoSize = true;
            this.lbTen1.BackColor = System.Drawing.Color.Transparent;
            this.lbTen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTen1.Location = new System.Drawing.Point(623, 61);
            this.lbTen1.Name = "lbTen1";
            this.lbTen1.Size = new System.Drawing.Size(76, 24);
            this.lbTen1.TabIndex = 4;
            this.lbTen1.Text = "Name1";
            // 
            // lbTen2
            // 
            this.lbTen2.AutoSize = true;
            this.lbTen2.BackColor = System.Drawing.Color.Transparent;
            this.lbTen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTen2.Location = new System.Drawing.Point(623, 433);
            this.lbTen2.Name = "lbTen2";
            this.lbTen2.Size = new System.Drawing.Size(76, 24);
            this.lbTen2.TabIndex = 5;
            this.lbTen2.Text = "Name2";
            // 
            // pbOption
            // 
            this.pbOption.BackColor = System.Drawing.Color.Transparent;
            this.pbOption.BackgroundImage = global::CoToan.Properties.Resources.Options;
            this.pbOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOption.Location = new System.Drawing.Point(627, 369);
            this.pbOption.Name = "pbOption";
            this.pbOption.Size = new System.Drawing.Size(33, 32);
            this.pbOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOption.TabIndex = 6;
            this.pbOption.TabStop = false;
            this.pbOption.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbOption_MouseClick);
            this.pbOption.MouseEnter += new System.EventHandler(this.pbOption_MouseEnter);
            this.pbOption.MouseLeave += new System.EventHandler(this.pbOption_MouseLeave);
            // 
            // pbUndo
            // 
            this.pbUndo.BackColor = System.Drawing.Color.Transparent;
            this.pbUndo.BackgroundImage = global::CoToan.Properties.Resources.Undo;
            this.pbUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUndo.Location = new System.Drawing.Point(586, 369);
            this.pbUndo.Name = "pbUndo";
            this.pbUndo.Size = new System.Drawing.Size(33, 32);
            this.pbUndo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUndo.TabIndex = 7;
            this.pbUndo.TabStop = false;
            this.pbUndo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbUndo_MouseClick);
            this.pbUndo.MouseEnter += new System.EventHandler(this.pbUndo_MouseEnter);
            this.pbUndo.MouseLeave += new System.EventHandler(this.pbUndo_MouseLeave);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbScore.Location = new System.Drawing.Point(667, 351);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(49, 16);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "Score";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoToan.Properties.Resources.Banco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(753, 675);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pbUndo);
            this.Controls.Add(this.pbOption);
            this.Controls.Add(this.lbTen2);
            this.Controls.Add(this.lbTen1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbMin);
            this.Controls.Add(this.lbScore_trang);
            this.Controls.Add(this.lbScore_den);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "co";
            this.Load += new System.EventHandler(this.Game_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChessBoard_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Chessco_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chessco_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Chessco_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUndo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScore_den;
        private System.Windows.Forms.Label lbScore_trang;
        private System.Windows.Forms.PictureBox pbMin;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label lbTen1;
        private System.Windows.Forms.Label lbTen2;
        private System.Windows.Forms.PictureBox pbOption;
        private System.Windows.Forms.PictureBox pbUndo;
        private System.Windows.Forms.Label lbScore;

    }
}

