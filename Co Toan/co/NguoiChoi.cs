using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CoToan
{
    class NguoiChoi
    {
        public int Phe;
        public Quan0 q0 = new Quan0();
        public Quan1 q1 = new Quan1();
        public Quan2 q2 = new Quan2();
        public Quan3 q3 = new Quan3();
        public Quan4 q4 = new Quan4();
        public Quan5 q5 = new Quan5();
        public Quan6 q6 = new Quan6();
        public Quan7 q7 = new Quan7();
        public Quan8 q8 = new Quan8();
        public Quan9 q9 = new Quan9();
        public NguoiChoi(int x)        
        {
            if (x == 0) //nguoi 1
            {
                Phe = 0;
                q0.KhoiTao(0,0, "0", 1, false, 1, 4);
                q1.KhoiTao(0,1, "1", 1, false, 0, 8);
                q2.KhoiTao(0,2, "2", 1, false, 0, 7);
                q3.KhoiTao(0,3, "3", 1, false, 0, 6);
                q4.KhoiTao(0,4, "4", 1, false, 0, 5);
                q5.KhoiTao(0,5, "5", 1, false, 0, 4);
                q6.KhoiTao(0,6, "6", 1, false, 0, 3);
                q7.KhoiTao(0,7, "7", 1, false, 0, 2);
                q8.KhoiTao(0,8, "8", 1, false, 0, 1);
                q9.KhoiTao(0,9, "9", 1, false, 0, 0);
            }

            if (x == 1)//nguoi 2
            {
                Phe = 1;
                q0.KhoiTao(1,0, "0", 1, false, 9, 4);
                q1.KhoiTao(1,1, "1", 1, false, 10, 0);
                q2.KhoiTao(1,2, "2", 1, false, 10, 1);
                q3.KhoiTao(1,3, "3", 1, false, 10, 2);
                q4.KhoiTao(1,4, "4", 1, false, 10, 3);
                q5.KhoiTao(1,5, "5", 1, false, 10, 4);
                q6.KhoiTao(1,6, "6", 1, false, 10, 5);
                q7.KhoiTao(1,7, "7", 1, false, 10, 6);
                q8.KhoiTao(1,8, "8", 1, false, 10, 7);
                q9.KhoiTao(1,9, "9", 1, false, 10, 8);
            }
            //-----------------------------------

            
        }
    }
}
