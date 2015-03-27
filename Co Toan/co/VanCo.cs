using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.IO.Compression;


namespace CoToan
{
    class VanCo
    {
        public static Win win = new Win();

        public  static BanCo Board = new BanCo();
        public struct NuocDi
        {
            public QuanCo Dau;
            public QuanCo Cuoi;
            //----------------
            public int Hang_Dau;
            public int Cot_Dau;
            //----------------
            public int Hang_Cuoi;
            public int Cot_Cuoi;
        }
        public struct QuanBiAn
        {
            public int Hang;
            public int Cot;
            public PictureBox picQuanCo;
        }

        public static QuanCo.TryTestMove bestMoveAI;
       
        //diem
        public static int score_trang = 0, score_den = 0;//diem cua tung nguoi choi
        public static int score = 0;//diem cuoc
        public static int win_t = 0, win_d = 0;//kiem tra bien win 
       // public static int maychoi = 0, nguoichoi = 0;//kiem tra choi o che do 2 nguoi hay choi vs may

        public static int LuotDi = 0;
        public static NguoiChoi[] NguoiChoi = new NguoiChoi[2];
        public static string TenNguoiChoi1;
        public static string TenNguoiChoi2;
        public static bool DangChoi = false;
        //Chọn quân cờ 
        public static bool Marked = false; //Kiểm tra đã có quân cờ nào được chọn chưa
        public static QuanCo DanhDau; //Quân cờ DanhDau tham chiếu đến quân cờ được chọn trong 1 nước đi

        //các quân cờ bị ăn
        public static QuanBiAn[] QuanTrangBiAn;
        public static int count_trang = 0;//dem do quan bi an
        public static QuanBiAn[] QuanDenBiAn;
        public static int count_den = 0;//dem do quan bi an
        
        //Gamelog
        public static NuocDi[] GameLog;//luu lai cac nuoc di cua tran co dung de undo
        public static int turn = 0; // tong so luot di cua van co
        //
        public static String strWin;
        //
        public static PictureBox pic = new PictureBox();
        static VanCo()
        {
            NguoiChoi[0] = new NguoiChoi(0);
            NguoiChoi[1] = new NguoiChoi(1);

            
        }
        /// <summary>
        /// Khoi tao cac quan co cho new game
        /// </summary>
        public static void NewGame()
        {
            switch(DangChoi)
            {
                case true:

                    NguoiChoi[0].q0.picQuanCo.Visible = false;
                    NguoiChoi[0].q1.picQuanCo.Visible = false;
                    NguoiChoi[0].q2.picQuanCo.Visible = false;
                    NguoiChoi[0].q3.picQuanCo.Visible = false;
                    NguoiChoi[0].q4.picQuanCo.Visible = false;
                    NguoiChoi[0].q5.picQuanCo.Visible = false;
                    NguoiChoi[0].q6.picQuanCo.Visible = false;
                    NguoiChoi[0].q7.picQuanCo.Visible = false;
                    NguoiChoi[0].q8.picQuanCo.Visible = false;
                    NguoiChoi[0].q9.picQuanCo.Visible = false;

                    NguoiChoi[1].q0.picQuanCo.Visible = false;
                    NguoiChoi[1].q1.picQuanCo.Visible = false;
                    NguoiChoi[1].q2.picQuanCo.Visible = false;
                    NguoiChoi[1].q3.picQuanCo.Visible = false;
                    NguoiChoi[1].q4.picQuanCo.Visible = false;
                    NguoiChoi[1].q5.picQuanCo.Visible = false;
                    NguoiChoi[1].q6.picQuanCo.Visible = false;
                    NguoiChoi[1].q7.picQuanCo.Visible = false;
                    NguoiChoi[1].q8.picQuanCo.Visible = false;
                    NguoiChoi[1].q9.picQuanCo.Visible = false;

                    //Xoa 2 nguoi choi
                    Array.Resize<CoToan.NguoiChoi>(ref NguoiChoi, 0);
                    //tao moi 2 nguoi choi
                    Array.Resize<CoToan.NguoiChoi>(ref NguoiChoi, 2);
                    NguoiChoi[0] = new NguoiChoi(0);
                    NguoiChoi[1] = new NguoiChoi(1);

                    //tao ban co moi
                    Board.ResetBanCo();

                    //dat qua co len ban co
                    NguoiChoi[0].q0.draw();
                    NguoiChoi[0].q1.draw();
                    NguoiChoi[0].q2.draw();
                    NguoiChoi[0].q3.draw();
                    NguoiChoi[0].q4.draw();
                    NguoiChoi[0].q5.draw();
                    NguoiChoi[0].q6.draw();
                    NguoiChoi[0].q7.draw();
                    NguoiChoi[0].q8.draw();
                    NguoiChoi[0].q9.draw();

                    NguoiChoi[1].q0.draw();
                    NguoiChoi[1].q1.draw();
                    NguoiChoi[1].q2.draw();
                    NguoiChoi[1].q3.draw();
                    NguoiChoi[1].q4.draw();
                    NguoiChoi[1].q5.draw();
                    NguoiChoi[1].q6.draw();
                    NguoiChoi[1].q7.draw();
                    NguoiChoi[1].q8.draw();
                    NguoiChoi[1].q9.draw();
                    
                    break;
                case false:
                    //dat qua co len ban co
                    NguoiChoi[0].q0.draw();
                    NguoiChoi[0].q1.draw();
                    NguoiChoi[0].q2.draw();
                    NguoiChoi[0].q3.draw();
                    NguoiChoi[0].q4.draw();
                    NguoiChoi[0].q5.draw();
                    NguoiChoi[0].q6.draw();
                    NguoiChoi[0].q7.draw();
                    NguoiChoi[0].q8.draw();
                    NguoiChoi[0].q9.draw();

                    NguoiChoi[1].q0.draw();
                    NguoiChoi[1].q1.draw();
                    NguoiChoi[1].q2.draw();
                    NguoiChoi[1].q3.draw();
                    NguoiChoi[1].q4.draw();
                    NguoiChoi[1].q5.draw();
                    NguoiChoi[1].q6.draw();
                    NguoiChoi[1].q7.draw();
                    NguoiChoi[1].q8.draw();
                    NguoiChoi[1].q9.draw();
                    break;

            }
        }

        /// <summary>
        /// Luu cac nuoc di cua tran co 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="q"></param>
        public static void SaveGameLog(Object sender, QuanCo q)
        {
            if (sender.GetType() == typeof(CoToan.Game))
            {
                VanCo.turn++;
                Array.Resize<VanCo.NuocDi>(ref VanCo.GameLog, VanCo.turn);
                VanCo.GameLog[VanCo.turn - 1].Dau = VanCo.DanhDau;
                VanCo.GameLog[VanCo.turn - 1].Hang_Dau = q.Hang;
                VanCo.GameLog[VanCo.turn - 1].Cot_Dau = q.Cot;
            }
            if (sender.GetType() == typeof(System.Windows.Forms.PictureBox))
            {
                VanCo.turn++;
                Array.Resize<VanCo.NuocDi>(ref VanCo.GameLog, VanCo.turn);
                VanCo.GameLog[VanCo.turn - 1].Dau = VanCo.DanhDau;
                VanCo.GameLog[VanCo.turn - 1].Hang_Dau = VanCo.DanhDau.Hang;
                VanCo.GameLog[VanCo.turn - 1].Cot_Dau = VanCo.DanhDau.Cot;
                VanCo.GameLog[VanCo.turn - 1].Cuoi = q;
                VanCo.GameLog[VanCo.turn - 1].Hang_Cuoi = q.Hang;
                VanCo.GameLog[VanCo.turn - 1].Cot_Cuoi = q.Cot;
            }
        }

        public static void SaveGameLogAI(QuanCo q, QuanCo p,int i, int x, int y)
        {
            if (i == 0)
            {
                VanCo.turn++;
                Array.Resize<VanCo.NuocDi>(ref VanCo.GameLog, VanCo.turn);
                VanCo.GameLog[VanCo.turn - 1].Dau = q;
                VanCo.GameLog[VanCo.turn - 1].Hang_Dau = p.Hang;
                VanCo.GameLog[VanCo.turn - 1].Cot_Dau = p.Cot;
            }
            if (i == 1)
            {
                VanCo.turn++;
                Array.Resize<VanCo.NuocDi>(ref VanCo.GameLog, VanCo.turn);
                VanCo.GameLog[VanCo.turn - 1].Dau = p;
                VanCo.GameLog[VanCo.turn - 1].Hang_Dau = p.Hang;
                VanCo.GameLog[VanCo.turn - 1].Cot_Dau = p.Cot;
                VanCo.GameLog[VanCo.turn - 1].Cuoi = q;
                VanCo.GameLog[VanCo.turn - 1].Hang_Cuoi = x;
                VanCo.GameLog[VanCo.turn - 1].Cot_Cuoi = y;
            }
        }
        /// <summary>
        /// Luu ban co 
        /// </summary>
        public static void Save()
        {
            Directory.CreateDirectory("Save");
            FileStream saveFile = File.Create(Application.StartupPath + "\\Save\\" + TenNguoiChoi1 + "_vs_" + TenNguoiChoi2 + "__" + Convert.ToString(DateTime.Now.Day) + "-" + Convert.ToString(DateTime.Now.Month) + "-" /*+ Convert.ToString(DateTime.Now.Year) + "__" + Convert.ToString(DateTime.Now.Hour) + "." + Convert.ToString(DateTime.Now.Minute) + "." + Convert.ToString(DateTime.Now.Second)*/ + ".ctvn");
            
            StreamWriter fileWriter = new StreamWriter(saveFile);

            //Ghi lượt đi vào dòng đầu tiên
            fileWriter.WriteLine(Convert.ToString(Game.nguoi));
            fileWriter.WriteLine(Convert.ToString(Game.may));
            fileWriter.WriteLine(Convert.ToString(VanCo.LuotDi));
            fileWriter.WriteLine(Convert.ToString(VanCo.score));
            fileWriter.WriteLine(Convert.ToString(VanCo.score_den));
            fileWriter.WriteLine(Convert.ToString(VanCo.score_trang));
            //Ghi tên 2 người chơi vào 2 dòng tiếp theo
            fileWriter.WriteLine(VanCo.TenNguoiChoi1);
            fileWriter.WriteLine(VanCo.TenNguoiChoi2);


            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (VanCo.Board.ViTri[i, j].Trong == false)
                    {
                        fileWriter.WriteLine(Convert.ToString(VanCo.Board.ViTri[i, j].Phe) + Convert.ToString(VanCo.Board.ViTri[i, j].Ten) + Convert.ToString(VanCo.Board.ViTri[i, j].Cot) + VanCo.Board.ViTri[i, j].Hang);
                    }
                }
            }
            fileWriter.Close();
            saveFile.Close();
            MessageBox.Show("Ván cờ đã được lưu");
        }

        /// <summary>
        /// Mo ban co da luu
        /// </summary>
        /// <param name="path"></param>
        public static void Open(string path)
        {
            VanCo.NguoiChoi[0].q0.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q1.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q2.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q3.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q4.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q5.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q6.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q7.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q8.picQuanCo.Visible = false;
            VanCo.NguoiChoi[0].q9.picQuanCo.Visible = false;

            VanCo.NguoiChoi[1].q0.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q1.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q2.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q3.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q4.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q5.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q6.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q7.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q8.picQuanCo.Visible = false;
            VanCo.NguoiChoi[1].q9.picQuanCo.Visible = false;
            VanCo.Board.ResetBanCo();

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    VanCo.Board.ViTri[i, j].Trong = true;
                }
            }

            QuanCo temp;
            temp = new QuanCo();
            int may, nguoi,hang, cot, phe, luotdi, diem,diem1,diem2;
            string ld = "", ten = "", ten1, ten2, strhang ="";
            StreamReader fileReader = File.OpenText(path);
            //doc may-nguoi
            nguoi = Convert.ToInt32(ld = fileReader.ReadLine());
            may = Convert.ToInt32(ld = fileReader.ReadLine());
            //Đọc vào giá trị luotdi
            luotdi = Convert.ToInt32(ld = fileReader.ReadLine());

            diem = Convert.ToInt32(ld = fileReader.ReadLine());
            diem2 = Convert.ToInt32(ld = fileReader.ReadLine());
            diem1 = Convert.ToInt32(ld = fileReader.ReadLine());
            ten1 = fileReader.ReadLine();
            ten2 = fileReader.ReadLine();

            while (!fileReader.EndOfStream)
            {
                string Line = fileReader.ReadLine();
                phe = Convert.ToInt32(Convert.ToString(Line[0]));
                ten = (Convert.ToString(Line[1]));
                cot = Convert.ToInt32(Convert.ToString(Line[2]));
                for (int i = 3; i < Line.Length; i++)
                {
                    strhang += Line[i];
                }
                hang = Convert.ToInt32(strhang);
                //Kiểm tra quân cờ để tham chiếu
                if (ten == "0") temp = VanCo.NguoiChoi[phe].q0;
                if (ten == "1") temp = VanCo.NguoiChoi[phe].q1;
                if (ten == "2") temp = VanCo.NguoiChoi[phe].q2;
                if (ten == "3") temp = VanCo.NguoiChoi[phe].q3;
                if (ten == "4") temp = VanCo.NguoiChoi[phe].q4;
                if (ten == "5") temp = VanCo.NguoiChoi[phe].q5;
                if (ten == "6") temp = VanCo.NguoiChoi[phe].q6;
                if (ten == "7") temp = VanCo.NguoiChoi[phe].q7;
                if (ten == "8") temp = VanCo.NguoiChoi[phe].q8;
                if (ten == "9") temp = VanCo.NguoiChoi[phe].q9;

                //Thiết lập quân cờ trên bàn cờ
                VanCo.Board.ViTri[hang, cot].Trong = false;
                VanCo.Board.ViTri[hang, cot].Phe = phe;
                VanCo.Board.ViTri[hang, cot].Ten = ten;

                //Đặt quân cờ vào vị trí
                if (luotdi != phe) temp.Khoa = true;
                else temp.Khoa = false;
                temp.picQuanCo.Visible = true;
                temp.Hang = hang;
                temp.Cot = cot;
                temp.TrangThai = 1;
                temp.draw();

                //Trả lại giá trị null để tiếp tục lấy thông tin quân cờ khác
                ten = "";
                strhang = "";
            }
            //Thiết lập lượt đi, tên người chơi, thời gian
            Game.nguoi = nguoi;
            Game.may = may;
            VanCo.TenNguoiChoi1 = ten1;
            VanCo.TenNguoiChoi2 = ten2;
            VanCo.LuotDi = luotdi;
            VanCo.score = diem;
            VanCo.score_den = diem2;
            VanCo.score_trang = diem1;
            turn = 0;
            DangChoi = true;
            count_den = 0;
            count_trang = 0;

           
            fileReader.Close();
        }
        public static void OCoTrong(int i, int j)
        {
            Board.ViTri[i, j].Trong = true;
            Board.ViTri[i, j].Ten = "";
            Board.ViTri[i, j].Phe = 2;
        }

        /// <summary>
        /// Kiem tra thang tran cua tran co
        /// </summary>
        

        public static void DatQuanCo(Object sender, QuanCo q, int i, int j)
        {
            if (sender.GetType() == typeof(CoToan.Game))
            {
                q.Hang = i;
                q.Cot = j;
                q.draw();
            }
            if (sender.GetType() == typeof(System.Windows.Forms.PictureBox))
            {
                Board.ViTri[i, j].Trong = false;
                Board.ViTri[i, j].Phe = VanCo.DanhDau.Phe;
                Board.ViTri[i, j].Ten = VanCo.DanhDau.Ten;
                VanCo.DanhDau.Hang = i;
                VanCo.DanhDau.Cot = j;
                VanCo.DanhDau.picQuanCo.Top = i * 54 + 58;
                VanCo.DanhDau.picQuanCo.Left = j * 54 + 28;
            }
        }
        public static void DoiLuotDi()
        {
            if (LuotDi == 0) LuotDi = 1;
            else LuotDi = 0;
            if (VanCo.LuotDi == 0)
            {
                VanCo.NguoiChoi[0].q1.Khoa = false;
                VanCo.NguoiChoi[0].q2.Khoa = false;
                VanCo.NguoiChoi[0].q3.Khoa = false;
                VanCo.NguoiChoi[0].q4.Khoa = false;
                VanCo.NguoiChoi[0].q5.Khoa = false;
                VanCo.NguoiChoi[0].q6.Khoa = false;
                VanCo.NguoiChoi[0].q7.Khoa = false;
                VanCo.NguoiChoi[0].q8.Khoa = false;
                VanCo.NguoiChoi[0].q9.Khoa = false;

                VanCo.NguoiChoi[1].q1.Khoa = true;
                VanCo.NguoiChoi[1].q2.Khoa = true;
                VanCo.NguoiChoi[1].q3.Khoa = true;
                VanCo.NguoiChoi[1].q4.Khoa = true;
                VanCo.NguoiChoi[1].q5.Khoa = true;
                VanCo.NguoiChoi[1].q6.Khoa = true;
                VanCo.NguoiChoi[1].q7.Khoa = true;
                VanCo.NguoiChoi[1].q8.Khoa = true;
                VanCo.NguoiChoi[1].q9.Khoa = true;
            }
            if (VanCo.LuotDi == 1)
            {
                VanCo.NguoiChoi[0].q1.Khoa = true;
                VanCo.NguoiChoi[0].q2.Khoa = true;
                VanCo.NguoiChoi[0].q3.Khoa = true;
                VanCo.NguoiChoi[0].q4.Khoa = true;
                VanCo.NguoiChoi[0].q5.Khoa = true;
                VanCo.NguoiChoi[0].q6.Khoa = true;
                VanCo.NguoiChoi[0].q7.Khoa = true;
                VanCo.NguoiChoi[0].q8.Khoa = true;
                VanCo.NguoiChoi[0].q9.Khoa = true;

                VanCo.NguoiChoi[1].q1.Khoa = false;
                VanCo.NguoiChoi[1].q2.Khoa = false;
                VanCo.NguoiChoi[1].q3.Khoa = false;
                VanCo.NguoiChoi[1].q4.Khoa = false;
                VanCo.NguoiChoi[1].q5.Khoa = false;
                VanCo.NguoiChoi[1].q6.Khoa = false;
                VanCo.NguoiChoi[1].q7.Khoa = false;
                VanCo.NguoiChoi[1].q8.Khoa = false;
                VanCo.NguoiChoi[1].q9.Khoa = false;
            }
        }

        /// <summary>
        /// Undo nuoc co da di
        /// </summary>
        public static void Undo()
        {
            int t;
            QuanCo temp_d, temp_c;
            temp_d = new QuanCo();
            temp_c = new QuanCo();

            if (!VanCo.Marked)
                if (VanCo.turn > 0)
                {
                    //Kiểm tra -> tham chiếu temp_d đến quân cờ trên bàn cờ
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "0") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q0;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "1") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q1;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "2") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q2;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "3") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q3;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "4") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q4;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "5") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q5;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "6") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q6;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "7") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q7;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "8") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q8;
                    if (VanCo.GameLog[VanCo.turn - 1].Dau.Ten == "9") temp_d = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Dau.Phe].q9;
                    //Kiểm tra nước đi có phải là nước đi ăn hay không
                    if (VanCo.GameLog[VanCo.turn - 1].Cuoi == null) t = 0;
                    else t = 1;

                    switch (t)
                    {
                        //Nếu là nước đi không ăn quân cờ của đối phương
                        case 0:
                            //Trả lại ô cờ trống cho vị trí vừa đi đến
                            
                            OCoTrong(VanCo.GameLog[VanCo.turn - 1].Dau.Hang, VanCo.GameLog[VanCo.turn - 1].Dau.Cot);
                            //Đặt quân cờ vừa đi trở lại vị trí cũ
                            temp_d.Hang = VanCo.GameLog[VanCo.turn - 1].Hang_Dau;
                            temp_d.Cot = VanCo.GameLog[VanCo.turn - 1].Cot_Dau;
                            temp_d.picQuanCo.Top = temp_d.Hang * 54 + 58;
                            temp_d.picQuanCo.Left = temp_d.Cot * 54 + 28;

                            //Thiết lập quân cờ tại vị trí cũ vừa đặt ở trên
                            VanCo.Board.ViTri[temp_d.Hang, temp_d.Cot].Trong = false;
                            VanCo.Board.ViTri[temp_d.Hang, temp_d.Cot].Phe = temp_d.Phe;
                            VanCo.Board.ViTri[temp_d.Hang, temp_d.Cot].Ten = temp_d.Ten;

                            //Xóa nước đi cuối cùng khỏi GameLog
                            if (VanCo.turn >= 1) VanCo.turn--;
                            Array.Resize<VanCo.NuocDi>(ref VanCo.GameLog, VanCo.turn);

                            //Trả lại lượt đi                        
                            VanCo.DoiLuotDi();
                            if (Game.may == 1)
                                VanCo.LuotDi = 1;
                            break;

                        //Nếu là nước đi ăn quân cờ của đối phương
                        case 1:
                            //Kiểm tra -> tham chiếu temp_c đến quân cờ trên bàn cờ
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "0") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q0;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "1") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q1;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "2") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q2;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "3") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q3;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "4") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q4;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "5") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q5;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "6") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q6;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "7") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q7;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "8") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q8;
                            if (VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten == "9") temp_c = VanCo.NguoiChoi[VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe].q9;

                            //Thiết lập lại quân cờ ở vị trí vừa bị ăn trên Bàn Cờ
                            VanCo.Board.ViTri[VanCo.GameLog[VanCo.turn - 1].Dau.Hang, VanCo.GameLog[VanCo.turn - 1].Dau.Cot].Trong = false;
                            VanCo.Board.ViTri[VanCo.GameLog[VanCo.turn - 1].Dau.Hang, VanCo.GameLog[VanCo.turn - 1].Dau.Cot].Phe = VanCo.GameLog[VanCo.turn - 1].Cuoi.Phe;
                            VanCo.Board.ViTri[VanCo.GameLog[VanCo.turn - 1].Dau.Hang, VanCo.GameLog[VanCo.turn - 1].Dau.Cot].Ten = VanCo.GameLog[VanCo.turn - 1].Cuoi.Ten;

                            //Đặt quân cờ bị ăn vào vị trí ở trên
                            temp_c.TrangThai = 1;
                            temp_c.picQuanCo.Top = temp_c.Hang * 54 + 58;
                            temp_c.picQuanCo.Left = temp_c.Cot * 54 + 28;
                            temp_c.picQuanCo.Width = 50;
                            temp_c.picQuanCo.Height = 50;
                            temp_c.picQuanCo.Cursor = Cursors.Hand;
                            if (temp_c.Phe == 0)
                            {
                                count_den--;
                                if (temp_c.Ten == "0") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang0;
                                if (temp_c.Ten == "1") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang1;
                                if (temp_c.Ten == "2") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang2;
                                if (temp_c.Ten == "3") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang3;
                                if (temp_c.Ten == "4") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang4;
                                if (temp_c.Ten == "5") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang5;
                                if (temp_c.Ten == "6") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang6;
                                if (temp_c.Ten == "7") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang7;
                                if (temp_c.Ten == "8") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang8;
                                if (temp_c.Ten == "9") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Trang9;
                                
                            }
                            if (temp_c.Phe == 1)
                            {
                                count_trang--;
                                if (temp_c.Ten == "0") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den0;
                                if (temp_c.Ten == "1") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den1;
                                if (temp_c.Ten == "2") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den2;
                                if (temp_c.Ten == "3") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den3;
                                if (temp_c.Ten == "4") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den4;
                                if (temp_c.Ten == "5") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den5;
                                if (temp_c.Ten == "6") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den6;
                                if (temp_c.Ten == "7") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den7;
                                if (temp_c.Ten == "8") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den8;
                                if (temp_c.Ten == "9") temp_c.picQuanCo.Image = CoToan.Properties.Resources.Den9;

                                
                            }

                            //Đặt quân cờ vừa đi trở lại vị trí cũ
                            temp_d.Hang = VanCo.GameLog[VanCo.turn - 1].Hang_Dau;
                            temp_d.Cot = VanCo.GameLog[VanCo.turn - 1].Cot_Dau;
                            temp_d.picQuanCo.Top = temp_d.Hang * 54 + 58;
                            temp_d.picQuanCo.Left = temp_d.Cot * 54 + 28;
                            if (temp_d.Phe == 0)
                            {
                                score_den -= temp_c.gtri;
                                count_den--;
                            }
                            if (temp_d.Phe == 1)
                            {
                                score_trang -= temp_c.gtri;
                                count_trang--;
                            }
                            //Thiết lập quân cờ tại vị trí vừa đặt ở trên
                            VanCo.Board.ViTri[temp_d.Hang, temp_d.Cot].Trong = false;
                            VanCo.Board.ViTri[temp_d.Hang, temp_d.Cot].Phe = temp_d.Phe;
                            VanCo.Board.ViTri[temp_d.Hang, temp_d.Cot].Ten = temp_d.Ten;

                            //Xóa nước đi cuối cùng khỏi GameLog
                            if (VanCo.turn >= 1) VanCo.turn--;
                            Array.Resize<VanCo.NuocDi>(ref VanCo.GameLog, VanCo.turn);

                            //Trả lại lượt đi    
                            
                            VanCo.DoiLuotDi();
                            if (Game.may == 1)
                                VanCo.LuotDi = 1;

                            break;
                    }
                }
            
        }

        public static void AnQuanCo(QuanCo q)
        {
            int hang = 0, cot = 0;
            q.TrangThai = 0;
            if (q.Phe == 1)//quan den
            {
                if (count_den >= 0 && count_den <= 2)
                {
                    hang = 0;
                    cot = count_den;
                }
                if (count_den >= 3 && count_den <= 5)
                {
                    hang = 1;
                    cot = count_den - 3;
                }
                if (count_den >= 6 && count_den <= 9)
                {
                    hang = 2;
                    cot = count_den - 6;
                }
                count_den++;
                Array.Resize<QuanBiAn>(ref QuanDenBiAn, count_den);
                VanCo.QuanDenBiAn[count_den - 1].Hang = hang;
                VanCo.QuanDenBiAn[count_den - 1].Cot = cot;
                VanCo.QuanDenBiAn[count_den - 1].picQuanCo = q.picQuanCo;
                if (q.Ten == "1") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den1;
                if (q.Ten == "2") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den2;
                if (q.Ten == "3") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den3;
                if (q.Ten == "4") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den4;
                if (q.Ten == "5") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den5;
                if (q.Ten == "6") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den6;
                if (q.Ten == "7") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den7;
                if (q.Ten == "8") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den8;
                if (q.Ten == "9") VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Image = CoToan.Properties.Resources.Den9;

                VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Width = 48;
                VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Height = 48;
                VanCo.QuanDenBiAn[count_den - 1].picQuanCo.BackColor = Color.Transparent;
                VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Cursor = Cursors.Arrow;
                VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Top = VanCo.QuanDenBiAn[count_den - 1].Hang * 55 + 115;
                VanCo.QuanDenBiAn[count_den - 1].picQuanCo.Left = VanCo.QuanDenBiAn[count_den - 1].Cot * 55 + 540;


                
            }

            if (q.Phe == 0)//quan trang
            {
                if (count_trang >= 0 && count_trang <= 2)
                {
                    hang = 0;
                    cot = count_trang;
                }
                if (count_trang >= 3 && count_trang <= 5)
                {
                    hang = 1;
                    cot = count_trang - 3;
                }
                if (count_trang >= 6 && count_trang <= 9)
                {
                    hang = 2;
                    cot = count_trang - 6;
                }

                count_trang++;
                Array.Resize<QuanBiAn>(ref QuanTrangBiAn, count_trang);
                VanCo.QuanTrangBiAn[count_trang - 1].Hang = hang;
                VanCo.QuanTrangBiAn[count_trang - 1].Cot = cot;
                VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo = q.picQuanCo;

                if (q.Ten == "1") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang1;
                if (q.Ten == "2") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang2;
                if (q.Ten == "3") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang3;
                if (q.Ten == "4") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang4;
                if (q.Ten == "5") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang5;
                if (q.Ten == "6") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang6;
                if (q.Ten == "7") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang7;
                if (q.Ten == "8") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang8;
                if (q.Ten == "9") VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Image = CoToan.Properties.Resources.Trang9;

                VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Width = 48;
                VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Height = 48;
                VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.BackColor = Color.Transparent;
                VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Cursor = Cursors.Arrow;
                VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Top = VanCo.QuanTrangBiAn[count_trang - 1].Hang * 55 + 490;
                VanCo.QuanTrangBiAn[count_trang - 1].picQuanCo.Left = VanCo.QuanTrangBiAn[count_trang - 1].Cot * 55 + 540;

            }
        }

        /// <summary>
        /// An quan co cua nuoc di AI
        /// </summary>
        /// <param name="q"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void MoveEatQuanCo(QuanCo q, int i, int j)
        {
            int index = 1;
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

            SaveGameLogAI(temp, temp, 0, i, j);
            SaveGameLogAI(q, q, 1, i, j);
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
            VanCo.OCoTrong(q.Hang,q.Cot);

            q.Hang = i;
            q.Cot = j;

            Board.ViTri[i, j].Trong = false;
            Board.ViTri[i, j].Phe = q.Phe;
            Board.ViTri[i, j].Ten = q.Ten;
            q.picQuanCo.Top = i * 54 + 58;
            q.picQuanCo.Left = j * 54 + 28;
            
        }

        /// <summary>
        /// Di chuyen quan co trong AI
        /// </summary>
        /// <param name="q"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void MoveRanDomQuanCo(QuanCo q, int i, int j)
        {
            if (VanCo.Board.ViTri[i, j].Trong == true)
            {
                VanCo.OCoTrong(q.Hang, q.Cot);

                SaveGameLogAI(q, q, 0,i,j);

                q.Hang = i;
                q.Cot = j;

                Board.ViTri[i, j].Trong = false;
                Board.ViTri[i, j].Phe = q.Phe;
                Board.ViTri[i, j].Ten = q.Ten;
                q.picQuanCo.Top = i * 54 + 58;
                q.picQuanCo.Left = j * 54 + 28;

                
            }
            else 
            {
                MoveEatQuanCo(q, i, j);
            }

            

            foreach (QuanCo p in QuanCo.arrCoToanQ)
            {
                //xoa mang cac nuoc di hop le cua quan duoc di
                Array.Resize<QuanCo._MoveAI>(ref p.moveAI, 0);
                p.cout_MoveAI = 0;
            }
            //VanCo.DoiLuotDi();
            
            //VanCo.Board.ResetCanMove();
            VanCo.Board.ResetBanCo();

            
        }

        public static void MoveHeuristic()
        {
 
        }

        /// <summary>
        /// Ham danh gia do tot cua the co
        /// </summary>
        /// <returns></returns>
        public static int Evaluate()
        {
            //QuanCo.MoveAI();
            int value = 0;

            QuanCo[] arrQuanCoE = new QuanCo[20];
            QuanCo.getListQuanCo(arrQuanCoE);
            //dem so quan
            int m=0, nc=0;//dem so quan tren ban co cua may va nguoi choi
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (Board.ViTri[i, j].Phe == 0)
                        m++;//may
                    if (Board.ViTri[i, j].Phe == 1)
                        nc++;//nguoi choi
                }
            }
            if (m > nc)
                value += 30;

            //kiem tra neu co ton tai nuoc di co the de bat duoc quan cua doi phuong
            for (int k = 1; k < 10; k++)
            {
                arrQuanCoE[k].MoveAIQ();
                int x = arrQuanCoE[k].cout_MoveAI;
                for (int i = 0; i < x ; i++)
                {
                    if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Trong == false && Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Phe == 1)
                    {
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "0")
                        {
                            value += 1000;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "9")
                        {
                            value += 100;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "8")
                        {
                            value += 90;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "7")
                        {
                            value += 80;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "6")
                        {
                            value += 70;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "5")
                        {
                            value += 60;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "4")
                        {
                            value += 50;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "3")
                        {
                            value += 40;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "2")
                        {
                            value += 30;
                        }
                        if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Ten == "1")
                        {
                            value += 20;
                        }
                     
                    }
                }
            }
            
            return value;
        }

        /// <summary>
        /// Di chuyen quan co AI
        /// </summary>
        public static void RanDomMoveAI()
        {
            QuanCo[] arrQuanCoE = new QuanCo[20];
            QuanCo.getListQuanCo(arrQuanCoE);

            for (int k = 1; k < 10; k++)
            {
                arrQuanCoE[k].MoveAIQ();
                int x = arrQuanCoE[k].cout_MoveAI;
                for (int i = 0; i < x; i++)
                {
                    if (Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Trong == false && Board.ViTri[arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej].Phe == 1)
                    {
                        MoveRanDomQuanCo(arrQuanCoE[k], arrQuanCoE[k].moveAI[i].movei, arrQuanCoE[k].moveAI[i].movej);
                       // SaveGameLogAI(arrQuanCoE[k],arrQuanCoE[k],1);
                        goto end;
                    }
                }
            }

            QuanCo.TryTestMove test;
            test.q = QuanCo.arrCoToanQ[4];
            test.movei = 1;
            test.movej = 5;


            AlphaBetaQ(test, 0, 1, -100, 100);
            
            MoveRanDomQuanCo(bestMoveAI.q, bestMoveAI.movei, bestMoveAI.movej);
            //SaveGameLogAI(bestMoveAI.q, bestMoveAI.q, 1);

        end:
            { }
        Game.IsWin();
        }

        /// <summary>
        /// Sinh nuoc di thu trong Alpha - Beta
        /// </summary>
        /// <param name="q"></param>
        /// <param name="phe"></param>
        /// <param name="tryMove"></param>
        /// <param name="temp"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void TryMove(QuanCo q,int phe, QuanCo._MoveAI tryMove,QuanCo temp, ref int i, ref int j)
        {
            OCoTrong(q.Hang, q.Cot);

            i = q.Hang;
            j = q.Cot;

            //di thu
            if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Trong == true)
            {
                q.Hang = tryMove.movei;
                q.Cot = tryMove.movej;
                Board.ViTri[q.Hang, q.Cot].Trong = false;
                Board.ViTri[q.Hang, q.Cot].Phe = q.Phe;
                Board.ViTri[q.Hang, q.Cot].Ten = q.Ten;
            }
            else 
            {
                int index = 2;
                if (VanCo.DanhDau.Phe == 0)
                    index = 1;
                else index = 0;
                //QuanCo temp;
                //temp = new QuanCo();

                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "1") temp = VanCo.NguoiChoi[index].q1;
                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "2") temp = VanCo.NguoiChoi[index].q2;
                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "3") temp = VanCo.NguoiChoi[index].q3;
                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "4") temp = VanCo.NguoiChoi[index].q4;
                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "5") temp = VanCo.NguoiChoi[index].q5;
                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "6") temp = VanCo.NguoiChoi[index].q6;
                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "7") temp = VanCo.NguoiChoi[index].q7;
                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "8") temp = VanCo.NguoiChoi[index].q8;
                if (VanCo.Board.ViTri[tryMove.movei, tryMove.movej].Ten == "9") temp = VanCo.NguoiChoi[index].q9;

                temp.TrangThai = 0;
            }
            VanCo.Board.ResetCanMove();
            //foreach (QuanCo p in QuanCo.arrCoToan)
            //{
            //    //xoa mang cac nuoc di hop le cua quan duoc di
            //    Array.Resize<QuanCo._MoveAI>(ref p.moveAI, 0);
            //    p.cout_MoveAI = 0;
            //}
            
        }
        
        /// <summary>
        /// Huy nuoc di thu trong Alpha - Beta
        /// </summary>
        /// <param name="q"></param>
        /// <param name="temp"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void RemoveTryMove(QuanCo q, QuanCo temp, int i, int j)
        {
            OCoTrong(q.Hang, q.Cot);
            
            q.Hang = i;
            q.Cot =  j;
            temp.TrangThai = 1;
            Board.ViTri[q.Hang, q.Cot].Trong = false;
            Board.ViTri[q.Hang, q.Cot].Phe = q.Phe;
            Board.ViTri[q.Hang, q.Cot].Ten = q.Ten;

            VanCo.Board.ResetCanMove();
            //foreach (QuanCo p in QuanCo.arrCoToan)
            //{
            //    //xoa mang cac nuoc di hop le cua quan duoc di
            //    Array.Resize<QuanCo._MoveAI>(ref p.moveAI, 0);
            //    p.cout_MoveAI = 0;
            //}

        }
       
        /// <summary>
        /// Ham Minimax voi cat tia Alpha - Beta
        /// </summary>
        /// <param name="tryTestMove"></param>
        /// <param name="phe"></param>
        /// <param name="depth"></param>
        /// <param name="alpha"></param>
        /// <param name="beta"></param>
        /// <returns></returns>
        public static int AlphaBetaQ(QuanCo.TryTestMove tryTestMove, int phe, int depth, int alpha, int beta)
        {
            //int value = 0;
            //int bestValue = -100000;
            if (depth == 0)
            {
                return Evaluate();//tinh do tot
            }
            int bestValue = alpha;
            if (phe == 1)//neu la nguoi choi
                bestValue = beta;
            //if (bestValue > alpha)
            //    alpha = bestValue;
           //QuanCo.MoveAI();//sinh moi nuoc co co the di cua cac quan
            
           while (alpha < beta)//dieu kien cat tia
            {
                //if (QuanCo.arrQuanCo.Length >= 0)//kiem tra con nuoc di
                {
                    //foreach (QuanCo p in arrQuanCo)//duyet tat ca cac quan co
                    {
                        if (phe == 0)//luot may di
                        {
                            
                            for (int i = 1; i < 10; i++)
                            {

                                QuanCo[] arrQuanCo = new QuanCo[20];
                                QuanCo.getListQuanCo(arrQuanCo);


                                QuanCo p = new QuanCo();
                                p = arrQuanCo[i];
                                if (p.Phe == 0)//duyet quan cua may
                                //
                                {
                                    if (p.TrangThai == 1)
                                    {
                                        //foreach (QuanCo p in QuanCo.arrCoToan)
                                        //{
                                        //    //xoa mang cac nuoc di hop le cua quan duoc di
                                        //    Array.Resize<QuanCo._MoveAI>(ref p.moveAI, 0);
                                        //    p.cout_MoveAI = 0;
                                        //}
                                        p.cout_MoveAI = 0;
                                        p.MoveAIQ();//sinh cac nuoc co the di cua quan p
                                        int k = p.cout_MoveAI;
                                        for (int j = 0; j < k; j++)//duyet toan bo nuoc co the di cua quan p dang xet
                                        //int j = 0;
                                        //while(j<p.cout_MoveAI)
                                        {
                                            QuanCo temp = new QuanCo();
                                            int x = 0, y = 0;//luu diem hien tai de quay ve
                                            QuanCo.TryTestMove nextMove;//tao ra nuoc di thu
                                            nextMove.q = p;
                                            nextMove.movei = p.moveAI[j].movei;
                                            nextMove.movej = p.moveAI[j].movej;

                                            TryMove(p,phe, p.moveAI[j], temp,ref x, ref y);//di thu quan co p dang xet
                                            int value = AlphaBetaQ(nextMove, 1 - phe, depth - 1, alpha, beta);//duyet alpha-beta
                                            RemoveTryMove(p,temp, x, y);//huy nuoc di thu
                                            
                                            if (value > bestValue)
                                            {
                                                alpha = bestValue = value;

                                                //luu nuoc di tot nhat cua quan co trong 1 lần duyet
                                                tryTestMove.q = nextMove.q;
                                                tryTestMove.movei = nextMove.movei;
                                                tryTestMove.movej = nextMove.movej;

                                            }

                                        }
                                    }
                                }
                            }
                        }
                        if (phe == 1)//luot may di
                        {
                           

                            for (int i = 11; i < 20; i++)
                            {
                                QuanCo[] arrQuanCo1 = new QuanCo[20];
                                QuanCo.getListQuanCo(arrQuanCo1);

                                QuanCo w = new QuanCo();
                                w = arrQuanCo1[i];
                                if (w.Phe == 1)//duyet quan cua may
                                //
                                {
                                    if (w.TrangThai == 1)
                                    {
                                        w.cout_MoveAI = 0;
                                        w.MoveAIQ();//sinh cac nuoc co the di cua quan p
                                        int k = w.cout_MoveAI;
                                        for (int j = 0; j < k; j++)//duyet toan bo nuoc co the di cua quan p dang xet
                                        {
                                            QuanCo temp = new QuanCo();
                                            int x = 0, y = 0;//luu diem hien tai de quay ve
                                            QuanCo.TryTestMove nextMove;//tao ra nuoc di thu
                                            nextMove.q = w;
                                            nextMove.movei = w.moveAI[j].movei;
                                            nextMove.movej = w.moveAI[j].movej;

                                            TryMove(w,phe, w.moveAI[j],temp, ref x, ref y);//di thu quan co p dang xet
                                            int value = AlphaBetaQ(nextMove, 1 - phe, depth - 1, alpha, beta);//duyet alpha-beta
                                            RemoveTryMove(w,temp, x, y);//huy nuoc di thu
                                            //j++;
                                            if (value < bestValue)
                                            {
                                                beta = bestValue = value;

                                                //luu nuoc di tot nhat cua quan co trong 1 lần duyet
                                                //tryTestMove.q = nextMove.q;
                                                //tryTestMove.movei = nextMove.movei;
                                                //tryTestMove.movej = nextMove.movej;

                                            }

                                        }
                                    }
                                }
                            }
                        }

                    }

                }
            }

            bestMoveAI = tryTestMove;

            return bestValue;
        }
     
        //public static int AlphaBeta(int alpha, int beta, int depth)
        //{
        //    int value = 0;
        //    if (depth == 0)
        //        return Evaluate();
        //    else
        //    {
        //        int best = -10000;
        //        QuanCo.MoveAI();
        //        while (best < beta)
        //        {
        //            if (best > alpha)
        //                alpha = best;
        //                //thuc hien nuoc di m
        //            //quet toan bo quan co 
        //            for (int l = 1; l < 10; l++)
        //            {
        //                //di thu toan bo cac nuoc co the di cua 1 quan co
        //                for (int m = 0; l < QuanCo.arrCoToan[l].cout_MoveAI; m++)
        //                {
        //                    //QuanCo._MoveAI oldMoveAIQ;
        //                    TryMove(Board, QuanCo.arrCoToan[l], QuanCo.arrCoToan[l].moveAI[m]);

        //                    {
        //                        //xet nuoc di cua nguoi
        //                        for (int k = 10; k < 10; k++)
        //                        {
        //                            for (int n = 0; n < QuanCo.arrCoToan[k].cout_MoveAI; n++)
        //                            {

        //                                value = -AlphaBeta(-beta, -alpha, depth - 1);

        //                            }
        //                        }
        //                       // RemoveTryMove(Board, QuanCo.arrCoToan[l], QuanCo.arrCoToan[l].moveAI[m], oldMoveAIQ);
        //                    }
        //                    if (value > best)
        //                    {
        //                        best = value;
        //                    }
        //                }

        //            }

                    
        //            //bo thuc hien nuoc di m

                    
        //        }
        //        return best;
        //    }
        //}
    }
}
