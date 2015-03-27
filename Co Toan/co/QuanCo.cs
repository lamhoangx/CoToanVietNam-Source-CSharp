using System;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace CoToan
{
    class QuanCo
    {
        public int Hang;
        public int Cot;
        public string Ten;
        public int Phe;
        public int gtri;
        public int TrangThai; //1: dang song, 0: bi an
        public PictureBox picQuanCo = new PictureBox();
        public bool Khoa = false;
        public int index1 = 0, index2 = 0, result_Add = 0, result_Add_Div = 0, result_Add_Mul = 0, result_Sub = 0,result_Du = 0;
        public bool turn = false;
        public static QuanCo[] arrCoToanQ =  new QuanCo[20];

        //do tot cua quan co
        public int posQ = 0;
        
        public struct _MoveAI
        {
            public int movei;
            public int movej;
        }
        
        public struct TryTestMove
        {
            public QuanCo q;
            public int movei ;
            public int movej ;
        }
        public _MoveAI[] moveAI;
        //public _OldMoveAI oldMoveAI;
        public int cout_MoveAI = 0;
        //dem so nuoc di duoc
        public static int countMoveAll = 0;

        public QuanCo()
        {
            Hang = 11;
            Cot = 9;
            Ten = "";
            Phe = 2;
            gtri = 0;
            TrangThai = 0;
            Khoa = true;
        }

        public void KhoiTao(int phe, int giatri, string name, int stt, bool khoa, int x, int y)
        {
            ////
            Hang = x;
            Cot = y;
            Ten = name;
            TrangThai = stt;
            Phe = phe;
            gtri = giatri;

            Khoa = khoa;
            VanCo.Board.ViTri[x, y].Hang = x;
            VanCo.Board.ViTri[x, y].Cot = y;
            VanCo.Board.ViTri[x, y].Ten = name;
            VanCo.Board.ViTri[x, y].Phe = phe;
            VanCo.Board.ViTri[x, y].Trong = false;
            picQuanCo.MouseClick += new MouseEventHandler(picQuanCo_MouseClick);


        }

        public void draw()
        {

            if (Phe == 0)
            {
                if (Ten == "0") picQuanCo.Image = CoToan.Properties.Resources.Trang0;
                if (Ten == "1") picQuanCo.Image = CoToan.Properties.Resources.Trang1;
                if (Ten == "2") picQuanCo.Image = CoToan.Properties.Resources.Trang2;
                if (Ten == "3") picQuanCo.Image = CoToan.Properties.Resources.Trang3;
                if (Ten == "4") picQuanCo.Image = CoToan.Properties.Resources.Trang4;
                if (Ten == "5") picQuanCo.Image = CoToan.Properties.Resources.Trang5;
                if (Ten == "6") picQuanCo.Image = CoToan.Properties.Resources.Trang6;
                if (Ten == "7") picQuanCo.Image = CoToan.Properties.Resources.Trang7;
                if (Ten == "8") picQuanCo.Image = CoToan.Properties.Resources.Trang8;
                if (Ten == "9") picQuanCo.Image = CoToan.Properties.Resources.Trang9;
            }
            if (Phe == 1)
            {
                if (Ten == "0") picQuanCo.Image = CoToan.Properties.Resources.Den0;
                if (Ten == "1") picQuanCo.Image = CoToan.Properties.Resources.Den1;
                if (Ten == "2") picQuanCo.Image = CoToan.Properties.Resources.Den2;
                if (Ten == "3") picQuanCo.Image = CoToan.Properties.Resources.Den3;
                if (Ten == "4") picQuanCo.Image = CoToan.Properties.Resources.Den4;
                if (Ten == "5") picQuanCo.Image = CoToan.Properties.Resources.Den5;
                if (Ten == "6") picQuanCo.Image = CoToan.Properties.Resources.Den6;
                if (Ten == "7") picQuanCo.Image = CoToan.Properties.Resources.Den7;
                if (Ten == "8") picQuanCo.Image = CoToan.Properties.Resources.Den8;
                if (Ten == "9") picQuanCo.Image = CoToan.Properties.Resources.Den9;
            }

            ;
            picQuanCo.Width = 50;
            picQuanCo.Height = 50;
            picQuanCo.Cursor = Cursors.Hand;

            picQuanCo.Top = Hang * 54 + 58;
            picQuanCo.Left = Cot * 54 + 28;
            picQuanCo.BackColor = Color.Transparent;
            picQuanCo.Visible = true;

            //thiet lap quan tren ban co
            VanCo.Board.ViTri[Hang, Cot].Hang = Hang;
            VanCo.Board.ViTri[Hang, Cot].Cot = Cot;
            VanCo.Board.ViTri[Hang, Cot].Trong = false;
            VanCo.Board.ViTri[Hang, Cot].Ten = Ten;
            VanCo.Board.ViTri[Hang, Cot].Phe = Phe;

        }
        public virtual int KiemTra(int i, int j)
        {
            return 0;
        }
        public  bool AnToan(int i, int j)
        {
            if (Phe == 0)
            {
                if(KiemTra(1,5) == 1)
                {
                    return false; 
                }
            }
            else if (Phe == 1)
            {
                if (KiemTra(10,5) == 1)
                {
                    return false;
                }
            }
             return true;
        }

        public static void getListQuanCo(QuanCo[] arrCoToan)
        {
            arrCoToan[0] = VanCo.NguoiChoi[0].q0;
            arrCoToan[1] = VanCo.NguoiChoi[0].q1;
            arrCoToan[2] = VanCo.NguoiChoi[0].q2;
            arrCoToan[3] = VanCo.NguoiChoi[0].q3;
            arrCoToan[4] = VanCo.NguoiChoi[0].q4;
            arrCoToan[5] = VanCo.NguoiChoi[0].q5;
            arrCoToan[6] = VanCo.NguoiChoi[0].q6;
            arrCoToan[7] = VanCo.NguoiChoi[0].q7;
            arrCoToan[8] = VanCo.NguoiChoi[0].q8;
            arrCoToan[9] = VanCo.NguoiChoi[0].q9;

            //
            arrCoToan[10] = VanCo.NguoiChoi[1].q0;
            arrCoToan[11] = VanCo.NguoiChoi[1].q1;
            arrCoToan[12] = VanCo.NguoiChoi[1].q2;
            arrCoToan[13] = VanCo.NguoiChoi[1].q3;
            arrCoToan[14] = VanCo.NguoiChoi[1].q4;
            arrCoToan[15] = VanCo.NguoiChoi[1].q5;
            arrCoToan[16] = VanCo.NguoiChoi[1].q6;
            arrCoToan[17] = VanCo.NguoiChoi[1].q7;
            arrCoToan[18] = VanCo.NguoiChoi[1].q8;
            arrCoToan[19] = VanCo.NguoiChoi[1].q9;

            
        }
       
        /// <summary>
        /// Sinh cac nuoc co the di cua toan bo quan trong 1 the co
        /// </summary>
        public  static void MoveAI()
        {                 
            foreach (QuanCo q in arrCoToanQ)
            {
                if(q.TrangThai == 1)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        for (int j = 0; j <= 8; j++)
                        {
                            if (i != q.Hang || j != q.Cot)
                                if (q.KiemTra(i, j) == 1)
                                {

                                    //Random random = new Random();
                                    //int rand = random.Next(0,50);

                                    Array.Resize<_MoveAI>(ref q.moveAI, q.cout_MoveAI + 1);
                                    q.moveAI[q.cout_MoveAI].movei = i;
                                    q.moveAI[q.cout_MoveAI].movej = j;

                                    //q.moveAI[q.cout_MoveAI].eval =rand; //random do tot nuoc di

                                    q.cout_MoveAI++;
                                }
                        }
                    }
                }
            }
            foreach (QuanCo q in arrCoToanQ)
            {
                countMoveAll += q.cout_MoveAI;
            }
        }

        /// <summary>
        /// Sinh cac nuoc di cua 1 quan co trong 1 the co
        /// </summary>
        public void MoveAIQ()
        {
            if (this.TrangThai == 1)
            {
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 8; j++)
                    {
                        if (i != Hang || j != Cot)
                            if (KiemTra(i, j) == 1)
                            {

                                //Random random = new Random();
                                //int rand = random.Next(0,50);

                                Array.Resize<_MoveAI>(ref moveAI, cout_MoveAI + 1);
                                moveAI[cout_MoveAI].movei = i;
                                moveAI[cout_MoveAI].movej = j;

                                //q.moveAI[q.cout_MoveAI].eval =rand; //random do tot nuoc di

                                cout_MoveAI++;
                            }
                    }
                }
            }
        }
        /// <summary>
        /// Su kien click quan co de di
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picQuanCo_MouseClick(Object sender, MouseEventArgs e)
        {
            switch (VanCo.Marked)
            {
                case true:
                    if (this.TrangThai == 1)
                    {
                        VanCo.Marked = false;
                        if (VanCo.DanhDau.Phe == 0)
                        {
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
                        VanCo.Board.ResetCanMove();
                    }
                    break;
                case false:
                    if (this.TrangThai == 1)
                    {
                        if (this.Khoa == false)
                        {
                            VanCo.Marked = true;
                            VanCo.DanhDau = new QuanCo();
                            VanCo.DanhDau = this;

                            if (Phe == 0)
                            {
                                if (Ten == "1") picQuanCo.Image = CoToan.Properties.Resources.Trang1_Select;
                                if (Ten == "2") picQuanCo.Image = CoToan.Properties.Resources.Trang2_Select;
                                if (Ten == "3") picQuanCo.Image = CoToan.Properties.Resources.Trang3_Select;
                                if (Ten == "4") picQuanCo.Image = CoToan.Properties.Resources.Trang4_Select;
                                if (Ten == "5") picQuanCo.Image = CoToan.Properties.Resources.Trang5_Select;
                                if (Ten == "6") picQuanCo.Image = CoToan.Properties.Resources.Trang6_Select;
                                if (Ten == "7") picQuanCo.Image = CoToan.Properties.Resources.Trang7_Select;
                                if (Ten == "8") picQuanCo.Image = CoToan.Properties.Resources.Trang8_Select;
                                if (Ten == "9") picQuanCo.Image = CoToan.Properties.Resources.Trang9_Select;

                            }
                            if (Phe == 1)
                            {
                                if (Ten == "1") picQuanCo.Image = CoToan.Properties.Resources.Den1_Select;
                                if (Ten == "2") picQuanCo.Image = CoToan.Properties.Resources.Den2_Select;
                                if (Ten == "3") picQuanCo.Image = CoToan.Properties.Resources.Den3_Select;
                                if (Ten == "4") picQuanCo.Image = CoToan.Properties.Resources.Den4_Select;
                                if (Ten == "5") picQuanCo.Image = CoToan.Properties.Resources.Den5_Select;
                                if (Ten == "6") picQuanCo.Image = CoToan.Properties.Resources.Den6_Select;
                                if (Ten == "7") picQuanCo.Image = CoToan.Properties.Resources.Den7_Select;
                                if (Ten == "8") picQuanCo.Image = CoToan.Properties.Resources.Den8_Select;
                                if (Ten == "9") picQuanCo.Image = CoToan.Properties.Resources.Den9_Select;
                            }

                            for (int i = 0; i <= 10; i++)
                            {
                                for (int j = 0; j <= 8; j++)
                                {
                                    if (i != Hang || j != Cot)
                                        if (this.KiemTra(i, j) == 1)
                                            VanCo.Board.ViTri[i, j].CanMove.Visible = true;
                                }
                            }
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Ham sinh nuoc di hop le cua 1 quan co
        /// </summary>
        /// <param name="i"> hang </param>
        /// <param name="j"> cot </param>
        /// <param name="n"> so buoc di cua quan co</param>
        public void Move(int i, int j, int n)
        {
            if (i >= 0 && i <= 10 && j >= 0 && j <= 8) turn = false;
            for (int x = 1; x <= n; x++)
            {
                if ((i == Hang - x && j == Cot - x) || (i == Hang - x && j == Cot + x))
                {
                    if (VanCo.Board.ViTri[i, j].Trong == true) turn = true;
                    if (i < Hang && j < Cot)
                    {
                        int k, l;
                        for (k = Hang - 1, l = Cot - 1; k >= i && l >= j; k--, l--)
                        {
                            if (VanCo.Board.ViTri[k, l].Trong == false)
                            {
                                turn = false;
                                break;
                            }
                        }
                    }
                    if (i < Hang && j > Cot)
                    {
                        int k, l;
                        for (k = Hang - 1, l = Cot + 1; k >= i && l <= j; k--, l++)
                        {
                            if (VanCo.Board.ViTri[k, l].Trong == false)
                            {
                                turn = false;
                                break;
                            }
                        }
                    }
                }
                if ((i == Hang + x && j == Cot - x) || (i == Hang + x && j == Cot + x))
                {
                    if (VanCo.Board.ViTri[i, j].Trong == true) turn = true;

                    if (i > Hang && j > Cot)
                    {
                        int k, l;
                        for (k = Hang + 1, l = Cot + 1; k <= i && l <= j; k++, l++)
                        {
                            if (VanCo.Board.ViTri[k, l].Trong == false)
                            {
                                turn = false;
                                break;
                            }
                        }
                    }

                    if (i > Hang && j < Cot)
                    {
                        int k, l;
                        for (k = Hang + 1, l = Cot - 1; k <= i && l >= j; k++, l--)
                        {
                            if (VanCo.Board.ViTri[k, l].Trong == false)
                            {
                                turn = false;
                                break;
                            }
                        }
                    }
                }

                if ((i == Hang - x && j == Cot) || (i == Hang + x && j == Cot))
                {
                    if (VanCo.Board.ViTri[i, j].Trong == true) turn = true;
                    if (i > Hang)
                        for (int k = Hang + 1; k <= i; k++)
                        {

                            if (VanCo.Board.ViTri[k, j].Trong == false)
                            {
                                turn = false;
                                break;
                            }
                        }
                    if (i < Hang)
                        for (int k = i + 1; k <= Hang - 1; k++)
                        {
                            if (VanCo.Board.ViTri[k, j].Trong == false)
                            {
                                turn = false;
                                break;
                            }
                        }

                }
                //
                if ((i == Hang && j == Cot - x) || (i == Hang && j == Cot + x))
                {
                    //
                    if (VanCo.Board.ViTri[i, j].Trong == true) turn = true;
                    //
                    if (j > Cot)
                        for (int k = Cot + 1; k <= j; k++)
                        {
                            if (VanCo.Board.ViTri[i, k].Trong == false)
                            {
                                turn = false;
                                break;
                            }
                        }
                    if (j < Cot)
                        for (int k = j + 1; k <= Cot - 1; k++)
                        {
                            if (VanCo.Board.ViTri[i, k].Trong == false)
                            {
                                turn = false;
                                break;
                            }
                        }
                }

            }
        }
        
        /// <summary>
        /// Lay gia tri cua quan co tai vi tri i,j
        /// </summary>
        /// <param name="i"> hang </param>
        /// <param name="j"> cot </param>
        /// <returns></returns>
        public int GiaTri(int i, int j)
        {
            if (VanCo.Board.ViTri[i, j].Ten == "0") return 0;
            if (VanCo.Board.ViTri[i, j].Ten == "1") return 1;
            if (VanCo.Board.ViTri[i, j].Ten == "2") return 2;
            if (VanCo.Board.ViTri[i, j].Ten == "3") return 3;
            if (VanCo.Board.ViTri[i, j].Ten == "4") return 4;
            if (VanCo.Board.ViTri[i, j].Ten == "5") return 5;
            if (VanCo.Board.ViTri[i, j].Ten == "6") return 6;
            if (VanCo.Board.ViTri[i, j].Ten == "7") return 7;
            if (VanCo.Board.ViTri[i, j].Ten == "8") return 8;
            if (VanCo.Board.ViTri[i, j].Ten == "9") return 9;
            else return 0;
        }

        public void XDAnQuan1(int i, int j)
        {
            if (i == Hang - 2 && j == Cot - 2)
            {
                turn = true;
            }
            else
            {
                //kiem tra khong co quan chan trong nuoc an quan
                for (int k = Hang - 2, l = Cot - 2; k > i && l > j; k--, l--)
                {
                    if (VanCo.Board.ViTri[k, l].Trong == false)
                    {
                        turn = false;
                        break;
                    }
                    else turn = true;
                }
            }
        }

        public void XDAnQuan2(int i, int j)
        {
            if (i == Hang - 2 && j == Cot + 2)
            {
                turn = true;
            }
            else
            {
                for (int k = Hang - 2, l = Cot + 2; k > i && l < j; k--, l++)
                {
                    if (VanCo.Board.ViTri[k, l].Trong == false)
                    {
                        turn = false;
                        break;
                    }
                    else turn = true;
                }
            }
        }

        public void XDAnQuan3(int i, int j)
        {
            if (i == Hang + 2 && j == Cot + 2)
            {
                turn = true;
            }
            else
            {
                for (int k = Hang + 2, l = Cot + 2; k < i && l < j; k++, l++)
                {
                    if (VanCo.Board.ViTri[k, l].Trong == false)
                    {
                        turn = false;
                        break;
                    }
                    else turn = true;
                }
            }
        }

        public void XDAnQuan4(int i, int j)
        {
            if (i == Hang + 2 && j == Cot - 2)
            {
                turn = true;
            }
            else
            {
                for (int k = Hang + 2, l = Cot - 2; k < i && l > j; k++, l--)
                {
                    if (VanCo.Board.ViTri[k, l].Trong == false)
                    {
                        turn = false;
                        break;
                    }
                    else turn = true;
                }
            }
        }

        public void XDAnQuan5(int i, int j)
        {
            if (i == Hang + 2 && j == Cot)
            {
                turn = true;
            }
            else
            {
                for (int k = Hang + 2; k < i; k++)
                {
                    if (VanCo.Board.ViTri[k, j].Trong == false)
                    {
                        turn = false;
                        break;
                    }
                    else turn = true;
                }
            }
        }

        public void XDAnQuan6(int i, int j)
        {
            if (i == Hang - 2 && j == Cot)
            {
                turn = true;
            }
            else
            {
                for (int k = i + 1; k <= Hang - 2; k++)
                {
                    if (VanCo.Board.ViTri[k, j].Trong == false)
                    {
                        turn = false;
                        break;
                    }
                    else turn = true;
                }
            }
        }

        public void XDAnQuan7(int i, int j)
        {
            if (i == Hang && j == Cot + 2)
            {
                turn = true;
            }
            else
            {
                for (int k = Cot + 2; k < j; k++)
                {
                    if (VanCo.Board.ViTri[i, k].Trong == false)
                    {
                        turn = false;
                        break;
                    }
                    else turn = true;
                }
            }
        }

        public void XDAnQuan8(int i, int j)
        {
            if (i == Hang && j == Cot - 2)
            {
                turn = true;
            }
            else
            {
                for (int k = j + 1; k <= Cot - 2; k++)
                {
                    if (VanCo.Board.ViTri[i, k].Trong == false)
                    {
                        turn = false;
                        break;
                    }
                    else turn = true;
                }
            }
        }

        /// <summary>
        /// Ham sinh cac nuoc di de an quan cua doi phuong
        /// </summary>
        /// <param name="i"> hang </param>
        /// <param name="j"> cot </param>
        /// <param name="result_Add"> ket qua phep cong </param>
        /// <param name="result_Add_Div"> ket qua phep chia </param>
        /// <param name="result_Add_Mul"> ket qua phep nhan </param>
        /// <param name="result_Sub"> ket qua phep tru </param>
        /// <param name="result_Du"> ket qua phep du </param>
        public void AnQuan(int i, int j, int result_Add, int result_Add_Div, int result_Add_Mul, int result_Sub , int result_Du)
        {
            int pc = 0, pt = 0, pn = 0, pch = 0, pd = 0;
            //xac dinh vi tri duoc an cua quan co
            if ((i == Hang - result_Add && j == Cot) || (i == Hang + result_Add && j == Cot) || (i == Hang && j == Cot - result_Add) || (i == Hang && j == Cot + result_Add) || (i == Hang - result_Add && j == Cot - result_Add) || (i == Hang - result_Add && j == Cot + result_Add) || (i == Hang + result_Add && j == Cot - result_Add) || (i == Hang + result_Add && j == Cot + result_Add) ||
                (i == Hang - result_Add_Div && j == Cot) || (i == Hang + result_Add_Div && j == Cot) || (i == Hang && j == Cot - result_Add_Div) || (i == Hang && j == Cot + result_Add_Div) || (i == Hang - result_Add_Div && j == Cot - result_Add_Div) || (i == Hang - result_Add_Div && j == Cot + result_Add_Div) || (i == Hang + result_Add_Div && j == Cot - result_Add_Div) || (i == Hang + result_Add_Div && j == Cot + result_Add_Div) ||
                (i == Hang - result_Add_Mul && j == Cot) || (i == Hang + result_Add_Mul && j == Cot) || (i == Hang && j == Cot - result_Add_Mul) || (i == Hang && j == Cot + result_Add_Mul) || (i == Hang - result_Add_Mul && j == Cot - result_Add_Mul) || (i == Hang - result_Add_Mul && j == Cot + result_Add_Mul) || (i == Hang + result_Add_Mul & j == Cot - result_Add_Mul) || (i == Hang + result_Add_Mul && j == Cot + result_Add_Mul) ||
                (i == Hang - result_Sub && j == Cot) || (i == Hang + result_Sub && j == Cot) || (i == Hang && j == Cot - result_Sub) || (i == Hang && j == Cot + result_Sub) || (i == Hang - result_Sub && j == Cot - result_Sub) || (i == Hang - result_Sub && j == Cot + result_Sub) || (i == Hang + result_Sub && j == Cot - result_Sub) || (i == Hang + result_Sub && j == Cot + result_Sub) ||
                (i == Hang - result_Du && j == Cot) || (i == Hang + result_Du && j == Cot) || (i == Hang && j == Cot - result_Du) || (i == Hang && j == Cot + result_Du) || (i == Hang - result_Du && j == Cot - result_Du) || (i == Hang - result_Du && j == Cot + result_Du) || (i == Hang + result_Du && j == Cot - result_Du) || (i == Hang + result_Du && j == Cot + result_Du))
            {
                //kiem tra dieu kien duoc an
                if (VanCo.Board.ViTri[i, j].Trong == false)
                {
                    if (VanCo.Board.ViTri[i, j].Phe != this.Phe)
                    {
                        if ((i == Hang - result_Add && j == Cot) || (i == Hang + result_Add && j == Cot) || (i == Hang && j == Cot - result_Add) || (i == Hang && j == Cot + result_Add) || (i == Hang - result_Add && j == Cot - result_Add) || (i == Hang - result_Add && j == Cot + result_Add) || (i == Hang + result_Add && j == Cot - result_Add) || (i == Hang + result_Add && j == Cot + result_Add))
                            pc = 1;
                        if ((i == Hang - result_Add_Div && j == Cot) || (i == Hang + result_Add_Div && j == Cot) || (i == Hang && j == Cot - result_Add_Div) || (i == Hang && j == Cot + result_Add_Div) || (i == Hang - result_Add_Div && j == Cot - result_Add_Div) || (i == Hang - result_Add_Div && j == Cot + result_Add_Div) || (i == Hang + result_Add_Div && j == Cot - result_Add_Div) || (i == Hang + result_Add_Div && j == Cot + result_Add_Div))
                            pch = 1;
                        if ((i == Hang - result_Add_Mul && j == Cot) || (i == Hang + result_Add_Mul && j == Cot) || (i == Hang && j == Cot - result_Add_Mul) || (i == Hang && j == Cot + result_Add_Mul) || (i == Hang - result_Add_Mul && j == Cot - result_Add_Mul) || (i == Hang - result_Add_Mul && j == Cot + result_Add_Mul) || (i == Hang + result_Add_Mul & j == Cot - result_Add_Mul) || (i == Hang + result_Add_Mul && j == Cot + result_Add_Mul))
                            pn = 1;
                        if ((i == Hang - result_Sub && j == Cot) || (i == Hang + result_Sub && j == Cot) || (i == Hang && j == Cot - result_Sub) || (i == Hang && j == Cot + result_Sub) || (i == Hang - result_Sub && j == Cot - result_Sub) || (i == Hang - result_Sub && j == Cot + result_Sub) || (i == Hang + result_Sub && j == Cot - result_Sub) || (i == Hang + result_Sub && j == Cot + result_Sub))
                            pt = 1;
                        if ((i == Hang - result_Du && j == Cot) || (i == Hang + result_Du && j == Cot) || (i == Hang && j == Cot - result_Du) || (i == Hang && j == Cot + result_Du) || (i == Hang - result_Du && j == Cot - result_Du) || (i == Hang - result_Du && j == Cot + result_Du) || (i == Hang + result_Du && j == Cot - result_Du) || (i == Hang + result_Du && j == Cot + result_Du))
                            pd = 1;

                        //huong xet 
                        //cheo len trai
                        if (i < Hang && j < Cot)
                        {
                            if (VanCo.Board.ViTri[Hang - 1, Cot - 1].Trong == false)
                            {
                                if (VanCo.Board.ViTri[Hang - 1, Cot - 1].Phe == this.Phe)
                                {
                                    int ch = 0, c = 0, t = 0, n = 0, d = 0;
                                    ResultEat(this.gtri, GiaTri(Hang - 1, Cot - 1), ref c, ref t, ref n, ref ch, ref d);
                                   //kiem tra nguoc lai quan theo cac huong co dung dieu kien de an quan hay khong
                                    //if (c == result_Add && c > 1 || t == result_Sub && t > 1 || n == result_Add_Mul && n > 1 || ch == result_Add_Div && ch > 1 || d == result_Du && d > 1)
                                    
                                    //{
                                    //    XDAnQuan1(i,j);
                                    //}
                                    if(pc == 1 && c == result_Add && c > 1)
                                        XDAnQuan1(i, j);
                                    if(pt == 1 && t == result_Sub && t > 1)
                                        XDAnQuan1(i, j);
                                    if(pn == 1 && n == result_Add_Mul && n > 1)
                                        XDAnQuan1(i, j);
                                    if(pch == 1 && n == result_Add_Div && n > 1)
                                        XDAnQuan1(i, j);
                                    if(pd == 1 && d == result_Du && d > 1)
                                        XDAnQuan1(i, j);
                                }
                            }
                        }
                        //cheo len phai
                        if (i < Hang && j > Cot)
                        {
                            if (VanCo.Board.ViTri[Hang - 1, Cot + 1].Trong == false)
                            {
                                if (VanCo.Board.ViTri[Hang - 1, Cot + 1].Phe == this.Phe)
                                {
                                    int ch = 0, c = 0, t = 0, n = 0, d = 0;
                                    ResultEat(this.gtri, GiaTri(Hang - 1, Cot + 1), ref c, ref t, ref n, ref ch, ref d);
                                    //if (c == result_Add && c > 1 || t == result_Sub && t > 1 || n == result_Add_Mul && n > 1 || ch == result_Add_Div && ch > 1 || d == result_Du && d > 1)
                                    //{
                                    //    XDAnQuan2(i, j);
                                    //}
                                    if (pc == 1 && c == result_Add && c > 1)
                                        XDAnQuan2(i, j);
                                    if (pt == 1 && t == result_Sub && t > 1)
                                        XDAnQuan2(i, j);
                                    if (pn == 1 && n == result_Add_Mul && n > 1)
                                        XDAnQuan2(i, j);
                                    if (pch == 1 && n == result_Add_Div && n > 1)
                                        XDAnQuan2(i, j);
                                    if (pd == 1 && d == result_Du && d > 1)
                                        XDAnQuan2(i, j);
                                }
                            }
                        }
                        //cheo xuong phai
                        if (i > Hang && j > Cot)
                        {
                            if (VanCo.Board.ViTri[Hang + 1, Cot + 1].Trong == false)
                            {
                                if (VanCo.Board.ViTri[Hang + 1, Cot + 1].Phe == this.Phe)
                                {
                                    int ch = 0, c = 0, t = 0, n = 0, d = 0;
                                    ResultEat(this.gtri, GiaTri(Hang + 1, Cot + 1), ref c, ref t, ref n, ref ch, ref d);
                                    //if (c == result_Add && c > 1|| t == result_Sub && t > 1|| n == result_Add_Mul && n > 1 || ch == result_Add_Div && ch > 1 || d == result_Du && d > 1)
                                    //{
                                    //    XDAnQuan3(i,j);
                                    //}
                                    if (pc == 1 && c == result_Add && c > 1)
                                        XDAnQuan3(i, j);
                                    if (pt == 1 && t == result_Sub && t > 1)
                                        XDAnQuan3(i, j);
                                    if (pn == 1 && n == result_Add_Mul && n > 1)
                                        XDAnQuan3(i, j);
                                    if (pch == 1 && n == result_Add_Div && n > 1)
                                        XDAnQuan3(i, j);
                                    if (pd == 1 && d == result_Du && d > 1)
                                        XDAnQuan3(i, j);
                                }
                            }
                        }
                        //cheo xuong trai
                        if (i > Hang && j < Cot)
                        {
                            if (VanCo.Board.ViTri[Hang + 1, Cot - 1].Trong == false)
                            {
                                if (VanCo.Board.ViTri[Hang + 1, Cot - 1].Phe == this.Phe)
                                {
                                    int ch = 0, c = 0, t = 0, n = 0, d = 0;
                                    ResultEat(this.gtri, GiaTri(Hang + 1, Cot - 1), ref c, ref t, ref n, ref ch, ref d);
                                    //if (c == result_Add && c > 1 || t == result_Sub && t > 1 || n == result_Add_Mul && n > 1 || ch == result_Add_Div && ch > 1 || d == result_Du && d > 1)
                                    //{
                                    //    XDAnQuan4(i, j);
                                    //}
                                    if (pc == 1 && c == result_Add && c > 1)
                                        XDAnQuan4(i, j);
                                    if (pt == 1 && t == result_Sub && t > 1)
                                        XDAnQuan4(i, j);
                                    if (pn == 1 && n == result_Add_Mul && n > 1)
                                        XDAnQuan4(i, j);
                                    if (pch == 1 && n == result_Add_Div && n > 1)
                                        XDAnQuan4(i, j);
                                    if (pd == 1 & d == result_Du && d > 1)
                                        XDAnQuan4(i, j);
                                }
                            }
                        }
                        //len tren
                        if (i > Hang && j == Cot)
                        {
                            if (VanCo.Board.ViTri[Hang + 1, Cot].Trong == false)
                            {
                                if (VanCo.Board.ViTri[Hang, Cot].Phe == this.Phe)
                                {
                                    int ch = 0, c = 0, t = 0, n = 0, d = 0;
                                    ResultEat(this.gtri, GiaTri(Hang + 1, Cot), ref c, ref t, ref n, ref ch, ref d);
                                    //if (c == result_Add && c > 1 || t == result_Sub && t > 1 || n == result_Add_Mul && n > 1 || ch == result_Add_Div && ch > 1 || d == result_Du && d > 1)
                                    //{
                                    //    XDAnQuan5(i, j);
                                    //}

                                    if (pc == 1 && c == result_Add && c > 1)
                                        XDAnQuan5(i, j);
                                    if (pt == 1 && t == result_Sub && t > 1)
                                        XDAnQuan5(i, j);
                                    if (pn == 1 && n == result_Add_Mul && n > 1)
                                        XDAnQuan5(i, j);
                                    if (pch == 1 && n == result_Add_Div && n > 1)
                                        XDAnQuan5(i, j);
                                    if (pd == 1 && d == result_Du && d > 1)
                                        XDAnQuan5(i, j);
                                }
                            }
                        }
                        //xuong duoi
                        if (i < Hang && j == Cot)
                        {
                            if (VanCo.Board.ViTri[Hang - 1, Cot].Trong == false)
                            {
                                if (VanCo.Board.ViTri[Hang - 1, Cot].Phe == this.Phe)
                                {
                                    int ch = 0, c = 0, t = 0, n = 0, d = 0;
                                    ResultEat(this.gtri, GiaTri(Hang - 1, Cot), ref c, ref t, ref n, ref ch, ref d);
                                    //if (c == result_Add && c > 1 || t == result_Sub && t > 1 || n == result_Add_Mul && n > 1 || ch == result_Add_Div && ch > 1 || d == result_Du && d > 1)
                                    //{
                                    //    XDAnQuan6(i, j);
                                    //}
                                    if (pc == 1 && c == result_Add && c > 1)
                                        XDAnQuan6(i, j);
                                    if (pt == 1 && t == result_Sub && t > 1)
                                        XDAnQuan6(i, j);
                                    if (pn == 1 && n == result_Add_Mul && n > 1)
                                        XDAnQuan6(i, j);
                                    if (pch == 1 && n == result_Add_Div && n > 1)
                                        XDAnQuan6(i, j);
                                    if (pd == 1 && d == result_Du && d > 1)
                                        XDAnQuan6(i, j);
                                }
                            }
                        }
                        //sang phai
                        if (i == Hang && j > Cot)
                        {
                            if (VanCo.Board.ViTri[Hang, Cot + 1].Trong == false)
                            {
                                if (VanCo.Board.ViTri[Hang, Cot + 1].Phe == this.Phe)
                                {
                                    int ch = 0, c = 0, t = 0, n = 0, d = 0;
                                    ResultEat(this.gtri, GiaTri(Hang, Cot + 1), ref c, ref t, ref n, ref ch, ref d);
                                    //if (c == result_Add && c > 1 || t == result_Sub && t > 1 || n == result_Add_Mul && n > 1 || ch == result_Add_Div && ch > 1 || d == result_Du && d > 1)
                                    //{
                                    //    XDAnQuan7(i, j);
                                    //}
                                    if (pc == 1 && c == result_Add && c > 1)
                                        XDAnQuan7(i, j);
                                    if (pt == 1 && t == result_Sub && t > 1)
                                        XDAnQuan7(i, j);
                                    if (pn == 1 && n == result_Add_Mul && n > 1)
                                        XDAnQuan7(i, j);
                                    if (pch == 1 && n == result_Add_Div && n > 1)
                                        XDAnQuan7(i, j);
                                    if (pd == 1 && d == result_Du && d > 1)
                                        XDAnQuan7(i, j);
                                }
                            }
                        }
                        //sang trai
                        if (i == Hang && j < Cot)
                        {
                            if (VanCo.Board.ViTri[Hang, Cot - 1].Trong == false)
                            {
                                if (VanCo.Board.ViTri[Hang, Cot - 1].Phe == this.Phe)
                                {
                                    int ch = 0, c = 0, t = 0, n = 0,d = 0 ;
                                    ResultEat(this.gtri, GiaTri(Hang, Cot - 1), ref c, ref t, ref n, ref ch, ref d);
                                    //if (c == result_Add && c > 1 || t == result_Sub && t > 1 || n == result_Add_Mul && n > 1 || ch == result_Add_Div && ch > 1 || d == result_Du && d > 1)
                                    //{
                                    //    XDAnQuan8(i, j);
                                    //}
                                    if (pc == 1 && c == result_Add && c > 1)
                                        XDAnQuan8(i, j);
                                    if (pt == 1 && t == result_Sub && t > 1)
                                        XDAnQuan8(i, j);
                                    if (pn == 1 && n == result_Add_Mul && n > 1)
                                        XDAnQuan8(i, j);
                                    if (pch == 1 && n == result_Add_Div && n > 1)
                                        XDAnQuan8(i, j);
                                    if (pd == 1 && d == result_Du && d > 1)
                                        XDAnQuan8(i, j);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// tra ve cac gia tri cong, tru, nhan, chia, phan du cua 2 quan co lien tiep cung phe
        /// </summary>
        /// <param name="x"> gia tri cua quan dang xet</param>
        /// <param name="y"> gia tri cua quan lam dem de an</param>
        /// <param name="c"> cong </param>
        /// <param name="t"> tru </param>
        /// <param name="n"> nhan </param>
        /// <param name="ch"> chia </param>
        /// <param name="d"> phan du</param>
        private void ResultEat(int x, int y, ref int c, ref int t, ref int n, ref int ch, ref int d)
        {
            if (x > y)
            {
                t = (x - y) + 1;

                c = (x + y);
                {
                    if (c >= 10)
                    {
                        c = (c - 10) + 1;
                    }
                    else c = c + 1;
                }
                if (y != 0)
                {
                    ch = ((int)((x / y) % 10));
                    if (ch * y < x)
                    {
                        d = (x - ch) + 1;
                    }
                    else ch = ch + 1;
                }
                n = ((x * y));
                if (n > 10)
                {
                    n = (n % 10) + 1;
                }
                else n = n + 1;
                //AnQuan(i, j, result_Add, result_Add_Div, result_Add_Mul, result_Sub, result_Du);
            }
            if (x < y)
            {
                int temp = y + x;
                if (temp > 10)
                {
                    c = (temp - 10) + 1;
                }
                else c = temp + 1;
                if (y != 0)
                {
                    ch = ((int)((x / y) % 10));
                    if (ch * y < x)
                    {
                        d = (x - ch) + 1;
                    }
                    else ch = ch + 1;
                }
                n = ((x * y));
                if (n > 10)
                {
                    n = (n % 10) + 1;
                }
                else n = n + 1;
                //AnQuan(i, j, result_Add, result_Add_Div, result_Add_Mul, result_Sub, result_Du);
            }
        }
       
        /// <summary>
        /// Ham tong hop tat ca cac nuoc co the di cua 1 quan co (di chuyen va an quan doi phuong)
        /// </summary>
        /// <param name="i"> hang </param>
        /// <param name="j"> cot </param>
        /// <param name="gtri"> gia tri cua quan co dang xet</param>
        public void IsValue(int i, int j, int gtri)
        {
            Move(i, j, gtri);
            for (int m = 0; m <= 10; m++)
            {
                for (int n = 0; n <= 8; n++)
                {
                    //xac dinh co quan ke vs this.quanco
                    if ((m == Hang - 1 && n == Cot) || (m == Hang + 1 && n == Cot) || (m == Hang && n == Cot - 1) || (m == Hang && n == Cot + 1) || (m == Hang - 1 && n == Cot - 1) || (m == Hang - 1 && n == Cot + 1) || (m == Hang + 1 && n == Cot - 1) || (m == Hang + 1 && n == Cot + 1))
                    {
                        if (VanCo.Board.ViTri[m, n].Trong == false)
                        {
                            if (VanCo.Board.ViTri[m, n].Phe == this.Phe)
                            {

                                index2 = gtri;
                                if (VanCo.Board.ViTri[m, n].Ten == "0") index1 = 0;
                                if (VanCo.Board.ViTri[m, n].Ten == "1") index1 = 1;
                                if (VanCo.Board.ViTri[m, n].Ten == "2") index1 = 2;
                                if (VanCo.Board.ViTri[m, n].Ten == "3") index1 = 3;
                                if (VanCo.Board.ViTri[m, n].Ten == "4") index1 = 4;
                                if (VanCo.Board.ViTri[m, n].Ten == "5") index1 = 5;
                                if (VanCo.Board.ViTri[m, n].Ten == "6") index1 = 6;
                                if (VanCo.Board.ViTri[m, n].Ten == "7") index1 = 7;
                                if (VanCo.Board.ViTri[m, n].Ten == "8") index1 = 8;
                                if (VanCo.Board.ViTri[m, n].Ten == "9") index1 = 9;


                                
                                if (index2 > index1)
                                {
                                    result_Sub = (index2 - index1) + 1;

                                    result_Add = (index2 + index1);
                                    {
                                        if (result_Add >= 10)
                                        {
                                            result_Add = (result_Add - 10) + 1;
                                        }
                                        else result_Add = result_Add + 1;
                                    }
                                    if (index1 != 0)
                                    {
                                        result_Add_Div = ((int)((index2 / index1) % 10));
                                        if (result_Add_Div * index1 < index2)
                                        {
                                            result_Du = (index2 - result_Add_Div) + 1;
                                        }
                                        else result_Add_Div = result_Add_Div + 1;
                                    }
                                    result_Add_Mul = ((index2 * index1));
                                    if (result_Add_Mul > 10)
                                    {
                                        result_Add_Mul = (result_Add_Mul % 10) + 1;
                                    }
                                    else result_Add_Mul = result_Add_Mul + 1;
                                    AnQuan(i, j, result_Add, result_Add_Div, result_Add_Mul, result_Sub, result_Du);
                                }
                                if (index2 < index1)
                                {
                                    int temp = index1 + index2;
                                    if (temp > 10)
                                    {
                                        result_Add = (temp - 10) + 1;
                                    }
                                    else result_Add = temp + 1;
                                    if (index1 != 0)
                                    {
                                        result_Add_Div = ((int)((index2 / index1) % 10));
                                        if (result_Add_Div * index1 < index2)
                                        {
                                            result_Du = (index2 - result_Add_Div) + 1;
                                        }
                                        else result_Add_Div = result_Add_Div + 1;
                                    }
                                    result_Add_Mul = ((index2 * index1));
                                    if (result_Add_Mul > 10)
                                    {
                                        result_Add_Mul = (result_Add_Mul % 10) + 1;
                                    }
                                    else result_Add_Mul = result_Add_Mul + 1;
                                    AnQuan(i, j, result_Add, result_Add_Div, result_Add_Mul, result_Sub, result_Du);
                                }

                            }
                        }
                    }
                }
            }
        }


    }
}