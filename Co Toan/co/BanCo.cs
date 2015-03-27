using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CoToan
{
    class BanCo
    {
        public struct OCo 
        {
            public int Hang;
            public int Cot;
            public bool Trong; 
            public string Ten; 
            public int Phe;
            public PictureBox CanMove;
        }

        public  OCo[,] ViTri = new OCo[12, 10]; //Mang cac OCo 
        

        public BanCo() //Constructor khoi tao mang ViTri trong
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    //BanCo.ViTri[i, j] = new OCo();
                    ViTri[i, j].Hang = i;
                    ViTri[i, j].Cot = j;
                    ViTri[i, j].Trong = true;
                    ViTri[i, j].Ten = "";
                    ViTri[i, j].Phe = 0;
                    ViTri[i, j].CanMove = new PictureBox();
                    ViTri[i, j].CanMove.Image = CoToan.Properties.Resources.CanMove;
                    ViTri[i, j].CanMove.Width = 28;
                    ViTri[i, j].CanMove.Height = 28;
                    ViTri[i, j].CanMove.BackColor = Color.Transparent;
                    ViTri[i, j].CanMove.Top = i * 54 + 70;
                    ViTri[i, j].CanMove.Left = j * 54 + 40;
                    ViTri[i, j].CanMove.Cursor = Cursors.Hand;
                    ViTri[i, j].CanMove.Visible = false;
                    //picQuanCo.Top = Hang * 54 + 58;
                    //picQuanCo.Left = Cot * 54 + 28;
                }
            }
        }
        public  void ResetCanMove()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    ViTri[i, j].CanMove.Visible = false;
                }
            }
        }
        public  void ResetBanCo()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (VanCo.Board.ViTri[i, j].Trong == true)
                    {
                        //BanCo.ViTri[i, j] = new OCo();
                        ViTri[i, j].Hang = i;
                        ViTri[i, j].Cot = j;
                        ViTri[i, j].Trong = true;
                        ViTri[i, j].Ten = "";
                        ViTri[i, j].Phe = 0;
                        ViTri[i, j].CanMove.Visible = false;
                    }
                }
            }
        } 
    }
}
