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
    public partial class Game : Form
    {
        public static Game gameN;
        Control control = new Control();
        New newgame = new New();
        public PictureBox pic = new PictureBox();
        String strScore_den, strScore_trang;//hien dienm cua nguoi choi
        public static String score;
        public static String strWin;
        //Khai báo Timer đếm thời gian cho 2 người chơi
        public static Timer Timer_NguoiChoi1 = new Timer();
        public static Timer Timer_NguoiChoi2 = new Timer();
        //
        public static int nguoi = 0, may = 0;//bien kiem tra la che do choi giua nguoi vs nguoi hay nguoi vs may
        public static int iNewGame = 0;//kiem tra new game
        public static int iNewGameS = 0;//khoi tao new game lan 2 (ko chay)
        public Game()
        {
            this.Hide();
            control.ShowDialog();
            //newgame.ShowDialog();
            this.Show();
            InitializeComponent();
            if(iNewGame == 1)
                AddQuanCo(this);
            if (iNewGame == 0)
            {
                NewGameN();
                iNewGame = 1;
            }
            
            lbTen1.Text = VanCo.TenNguoiChoi1;
            lbTen2.Text = VanCo.TenNguoiChoi2;

            strScore_den = VanCo.score_den.ToString();
            strScore_trang = VanCo.score_trang.ToString();

            lbScore_den.Text = strScore_den;
            lbScore_trang.Text = strScore_trang;

            if (VanCo.score == 100000)
            {
                lbScore.Text = "Không";
            }
            else
            {
                score = Convert.ToString(VanCo.score);
                lbScore.Text = score;
            }
            New.start = 1;
            gameN = this;
            VanCo.DoiLuotDi();


        }
        public void NewGameN()
        {
            VanCo.NewGame();
            
            VanCo.Board.ResetCanMove();
            //if (VanCo.DangChoi == true)
            {
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 8; j++)
                    {
                        this.Controls.Add(VanCo.Board.ViTri[i, j].CanMove);
                        VanCo.Board.ViTri[i, j].CanMove.MouseClick += new MouseEventHandler(CanMove_MouseClick);
                    }
                }
                AddQuanCo(this);
                QuanCo.getListQuanCo(QuanCo.arrCoToanQ);
            }
        }
        private void Game_Load(object sender, EventArgs e)
        {
            


        }
        #region Dùng chuột di chuyển form
        private bool dangkeo;
        private Point diemkeo;
        private void Chessco_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangkeo = true;
                diemkeo = new Point(e.X, e.Y);
            }
            else dangkeo = false;
        }

        private void Chessco_MouseUp(object sender, MouseEventArgs e)
        {
            dangkeo = false;
        }

        private void Chessco_MouseMove(object sender, MouseEventArgs e)
        {
            if (dangkeo)
            {
                Point diemden;
                diemden = this.PointToScreen(new Point(e.X, e.Y));
                diemden.Offset(-diemkeo.X, -diemkeo.Y);
                this.Location = diemden;
            }
        }
        #endregion
        #region Xử lí nút
        #region Mini
        private void pbMin_MouseEnter(object sender, EventArgs e)
        {
            this.pbMin.Image = CoToan.Properties.Resources.Mini_MouseOver;

        }
        private void pbMin_MouseLeave(object sender, EventArgs e)
        {
            this.pbMin.Image = CoToan.Properties.Resources.Mini;
            pbMin.BackColor = Color.Transparent;
        }
        private void pbMin_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Exit
        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            this.pbExit.Image = CoToan.Properties.Resources.Exit;
        }

        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            this.pbExit.Image = CoToan.Properties.Resources.Exit_MouseOver;
        }

        private void pbExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Undo, Option
        private void pbUndo_MouseClick(object sender, MouseEventArgs e)
        {
            VanCo.Undo();

            strScore_den = VanCo.score_den.ToString();
            strScore_trang = VanCo.score_trang.ToString();

            lbScore_den.Text = strScore_den;
            lbScore_trang.Text = strScore_trang;
            if (Game.may == 1)
                VanCo.LuotDi = 0;

        }

        private void pbUndo_MouseLeave(object sender, EventArgs e)
        {
            this.pbUndo.Image = CoToan.Properties.Resources.Undo;
        }

        private void pbUndo_MouseEnter(object sender, EventArgs e)
        {
            this.pbUndo.Image = CoToan.Properties.Resources.Undo_MouseOver;

        }

        private void pbOption_MouseClick(object sender, MouseEventArgs e)
        {
            Control control = new Control();
            control.Show();
        }

        private void pbOption_MouseLeave(object sender, EventArgs e)
        {
            this.pbOption.Image = CoToan.Properties.Resources.Options;
        }

        private void pbOption_MouseEnter(object sender, EventArgs e)
        {
            this.pbOption.Image = CoToan.Properties.Resources.Options_MouseOver;
        }
      
        #endregion
        #endregion


        #region Di chuyen quan co
        private void ChessBoard_MouseClick(Object sender, MouseEventArgs e)
        {
            QuanCo temp = new QuanCo();
            switch (VanCo.Marked)
            {
                case true:
                    VanCo.Marked = false;
                    if (VanCo.DanhDau.Ten == "0") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q0;
                    if (VanCo.DanhDau.Ten == "1") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q1;
                    if (VanCo.DanhDau.Ten == "2") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q2;
                    if (VanCo.DanhDau.Ten == "3") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q3;
                    if (VanCo.DanhDau.Ten == "4") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q4;
                    if (VanCo.DanhDau.Ten == "5") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q5;
                    if (VanCo.DanhDau.Ten == "6") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q6;
                    if (VanCo.DanhDau.Ten == "7") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q7;
                    if (VanCo.DanhDau.Ten == "8") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q8;
                    if (VanCo.DanhDau.Ten == "9") temp = VanCo.NguoiChoi[VanCo.DanhDau.Phe].q9;
                    if (temp.Phe == 0)
                    {
                        if (temp.Ten == "0") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang0;
                        if (temp.Ten == "1") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang1;
                        if (temp.Ten == "2") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang2;
                        if (temp.Ten == "3") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang3;
                        if (temp.Ten == "4") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang4;
                        if (temp.Ten == "5") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang5;
                        if (temp.Ten == "6") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang6;
                        if (temp.Ten == "7") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang7;
                        if (temp.Ten == "8") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang8;
                        if (temp.Ten == "9") temp.picQuanCo.Image = CoToan.Properties.Resources.Trang9;
                    }
                    if (temp.Phe == 1)
                    {
                        if (temp.Ten == "0") temp.picQuanCo.Image = CoToan.Properties.Resources.Den0;
                        if (temp.Ten == "1") temp.picQuanCo.Image = CoToan.Properties.Resources.Den1;
                        if (temp.Ten == "2") temp.picQuanCo.Image = CoToan.Properties.Resources.Den2;
                        if (temp.Ten == "3") temp.picQuanCo.Image = CoToan.Properties.Resources.Den3;
                        if (temp.Ten == "4") temp.picQuanCo.Image = CoToan.Properties.Resources.Den4;
                        if (temp.Ten == "5") temp.picQuanCo.Image = CoToan.Properties.Resources.Den5;
                        if (temp.Ten == "6") temp.picQuanCo.Image = CoToan.Properties.Resources.Den6;
                        if (temp.Ten == "7") temp.picQuanCo.Image = CoToan.Properties.Resources.Den7;
                        if (temp.Ten == "8") temp.picQuanCo.Image = CoToan.Properties.Resources.Den8;
                        if (temp.Ten == "9") temp.picQuanCo.Image = CoToan.Properties.Resources.Den9;
                    }
                    VanCo.Board.ResetCanMove();
                    break;
                case false:
                    break;
            }
        }

        private void CanMove_MouseClick(Object sender, MouseEventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (sender.Equals(VanCo.Board.ViTri[i, j].CanMove))
                    {
                        if (VanCo.Marked)
                        {
                            switch (VanCo.Board.ViTri[i, j].Trong)
                            {
                                case true:
                                    if (VanCo.DanhDau.Phe == 0)
                                    {
                                        if (VanCo.DanhDau.Ten == "0") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang0;
                                        if (VanCo.DanhDau.Ten == "1") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang1;
                                        if (VanCo.DanhDau.Ten == "2") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang2;
                                        if (VanCo.DanhDau.Ten == "3") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang3;
                                        if (VanCo.DanhDau.Ten == "4") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang4;
                                        if (VanCo.DanhDau.Ten == "5") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang5;
                                        if (VanCo.DanhDau.Ten == "6") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang6;
                                        if (VanCo.DanhDau.Ten == "7") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang7;
                                        if (VanCo.DanhDau.Ten == "8") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang8;
                                        if (VanCo.DanhDau.Ten == "9") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang9;
                                    }
                                    if (VanCo.DanhDau.Phe == 1)
                                    {
                                        if (VanCo.DanhDau.Ten == "0") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den0;
                                        if (VanCo.DanhDau.Ten == "1") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den1;
                                        if (VanCo.DanhDau.Ten == "2") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den2;
                                        if (VanCo.DanhDau.Ten == "3") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den3;
                                        if (VanCo.DanhDau.Ten == "4") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den4;
                                        if (VanCo.DanhDau.Ten == "5") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den5;
                                        if (VanCo.DanhDau.Ten == "6") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den6;
                                        if (VanCo.DanhDau.Ten == "7") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den7;
                                        if (VanCo.DanhDau.Ten == "8") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den8;
                                        if (VanCo.DanhDau.Ten == "9") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den9;
                                    }
                                    VanCo.Marked = false;

                                    VanCo.SaveGameLog(this, VanCo.DanhDau);

                                    VanCo.OCoTrong(VanCo.DanhDau.Hang, VanCo.DanhDau.Cot);

                                    VanCo.DatQuanCo(sender, VanCo.DanhDau, i, j);


                                    VanCo.DoiLuotDi();
                                    VanCo.Board.ResetCanMove();
                                    VanCo.Board.ResetBanCo();
                                    if (may == 1)
                                    {
                                        VanCo.RanDomMoveAI();
                                        VanCo.DoiLuotDi();
                                    }
                                    VanCo.Board.ResetCanMove();
                                    
                                    //VanCo.DoiLuotDi();
                                    
                                    break;
                                case false:
                                    if (VanCo.DanhDau.Phe == 0)
                                    {
                                        if (VanCo.DanhDau.Ten == "0") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang0;
                                        if (VanCo.DanhDau.Ten == "1") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang1;
                                        if (VanCo.DanhDau.Ten == "2") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang2;
                                        if (VanCo.DanhDau.Ten == "3") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang3;
                                        if (VanCo.DanhDau.Ten == "4") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang4;
                                        if (VanCo.DanhDau.Ten == "5") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang5;
                                        if (VanCo.DanhDau.Ten == "6") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang6;
                                        if (VanCo.DanhDau.Ten == "7") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang7;
                                        if (VanCo.DanhDau.Ten == "8") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang8;
                                        if (VanCo.DanhDau.Ten == "9") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Trang9;
                                    }
                                    if (VanCo.DanhDau.Phe == 1)
                                    {
                                        if (VanCo.DanhDau.Ten == "0") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den0;
                                        if (VanCo.DanhDau.Ten == "1") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den1;
                                        if (VanCo.DanhDau.Ten == "2") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den2;
                                        if (VanCo.DanhDau.Ten == "3") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den3;
                                        if (VanCo.DanhDau.Ten == "4") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den4;
                                        if (VanCo.DanhDau.Ten == "5") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den5;
                                        if (VanCo.DanhDau.Ten == "6") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den6;
                                        if (VanCo.DanhDau.Ten == "7") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den7;
                                        if (VanCo.DanhDau.Ten == "8") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den8;
                                        if (VanCo.DanhDau.Ten == "9") VanCo.DanhDau.picQuanCo.Image = CoToan.Properties.Resources.Den9;
                                    }

                                    int index = 2;
                                    if (VanCo.DanhDau.Phe == 0)
                                        index = 1;
                                    else index = 0;
                                    QuanCo temp;
                                    temp = new QuanCo();

                                    if (VanCo.Board.ViTri[i, j].Ten == "0") temp = VanCo.NguoiChoi[index].q0;
                                    if (VanCo.Board.ViTri[i, j].Ten == "1") temp = VanCo.NguoiChoi[index].q1;
                                    if (VanCo.Board.ViTri[i, j].Ten == "2") temp = VanCo.NguoiChoi[index].q2;
                                    if (VanCo.Board.ViTri[i, j].Ten == "3") temp = VanCo.NguoiChoi[index].q3;
                                    if (VanCo.Board.ViTri[i, j].Ten == "4") temp = VanCo.NguoiChoi[index].q4;
                                    if (VanCo.Board.ViTri[i, j].Ten == "5") temp = VanCo.NguoiChoi[index].q5;
                                    if (VanCo.Board.ViTri[i, j].Ten == "6") temp = VanCo.NguoiChoi[index].q6;
                                    if (VanCo.Board.ViTri[i, j].Ten == "7") temp = VanCo.NguoiChoi[index].q7;
                                    if (VanCo.Board.ViTri[i, j].Ten == "8") temp = VanCo.NguoiChoi[index].q8;
                                    if (VanCo.Board.ViTri[i, j].Ten == "9") temp = VanCo.NguoiChoi[index].q9;

                                    //bo chon quan co
                                    VanCo.Marked = false;

                                    VanCo.SaveGameLog(sender, temp);

                                    //an quan co
                                    VanCo.AnQuanCo(temp);
                                    //cap nhat diem
                                    if (temp.Phe == 1)
                                    {
                                        VanCo.score_den += temp.gtri;
                                    }
                                    if (temp.Phe == 0)
                                    {
                                        VanCo.score_trang += temp.gtri;
                                    }

                                    
                                    
                                    //tra lai o trong
                                    VanCo.OCoTrong(VanCo.DanhDau.Hang, VanCo.DanhDau.Cot);
                                    //dat quan co vao vi tri duoc an
                                    VanCo.DatQuanCo(sender, VanCo.DanhDau, i, j);

                                    IsWin();
                                    //thay doi luot di
                                    VanCo.DoiLuotDi();
                                    VanCo.Board.ResetCanMove();
                                    VanCo.Board.ResetBanCo();
                                    if (may == 1)
                                    {
                                        VanCo.RanDomMoveAI();
                                        VanCo.DoiLuotDi();
                                    }
                                    VanCo.Board.ResetCanMove();
                                    
                                    break;
                            }
                        }
                    }

                }
            }
            strScore_den = VanCo.score_den.ToString();
            strScore_trang = VanCo.score_trang.ToString();

            lbScore_den.Text = strScore_den;
            lbScore_trang.Text = strScore_trang;
        }

        #endregion

        public static bool IsWin()
        {
            int kt = 0;
            if (VanCo.score_den >= VanCo.score || VanCo.NguoiChoi[0].q0.TrangThai == 0)
            {
                VanCo.win_d = 1;
                 VanCo.strWin= VanCo.TenNguoiChoi1;
                Game.KhoaVanCo();
                //VanCo.KetQua.Visible = true;
                Win win = new Win();
                win.Show();
                kt = 1;

            }
            if (VanCo.score_trang >= VanCo.score || VanCo.NguoiChoi[1].q0.TrangThai == 0)
            {
                VanCo.win_t = 1;
                VanCo.strWin = VanCo.TenNguoiChoi1;
                Game.KhoaVanCo();

                Win win = new Win();
                win.Show();
                kt = 1;
            }
            if (kt == 1) return true;
            else return false;
        }
        public static void KhoaVanCo()
        {
            VanCo.NguoiChoi[0].q0.Khoa = true;
            VanCo.NguoiChoi[0].q1.Khoa = true;
            VanCo.NguoiChoi[0].q2.Khoa = true;
            VanCo.NguoiChoi[0].q3.Khoa = true;
            VanCo.NguoiChoi[0].q4.Khoa = true;
            VanCo.NguoiChoi[0].q5.Khoa = true;
            VanCo.NguoiChoi[0].q6.Khoa = true;
            VanCo.NguoiChoi[0].q7.Khoa = true;
            VanCo.NguoiChoi[0].q8.Khoa = true;
            VanCo.NguoiChoi[0].q9.Khoa = true;

            VanCo.NguoiChoi[1].q0.Khoa = true;
            VanCo.NguoiChoi[1].q1.Khoa = true;
            VanCo.NguoiChoi[1].q2.Khoa = true;
            VanCo.NguoiChoi[1].q3.Khoa = true;
            VanCo.NguoiChoi[1].q4.Khoa = true;
            VanCo.NguoiChoi[1].q5.Khoa = true;
            VanCo.NguoiChoi[1].q6.Khoa = true;
            VanCo.NguoiChoi[1].q7.Khoa = true;
            VanCo.NguoiChoi[1].q8.Khoa = true;
            VanCo.NguoiChoi[1].q9.Khoa = true;

            VanCo.LuotDi = 2;
            
        }
        public static void AddQuanCo(Game game)
        {
            game.Controls.Add(VanCo.NguoiChoi[0].q0.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q1.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q2.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q3.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q4.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q5.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q6.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q7.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q8.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[0].q9.picQuanCo);

            game.Controls.Add(VanCo.NguoiChoi[1].q0.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q1.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q2.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q3.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q4.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q5.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q6.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q7.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q8.picQuanCo);
            game.Controls.Add(VanCo.NguoiChoi[1].q9.picQuanCo);

            

            
        }

       
    }
}
