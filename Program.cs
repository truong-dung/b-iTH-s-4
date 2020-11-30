using System;
using System.Collections.Generic;
using System.Text;

namespace btth3 /* bai4-BTTH: Xây dựng một chương trình thực hiện yêu cầu sau:
 - Nhập vào thông tin của các học sinh với số lượng học sinh tùy ý người sử dụng.
Thông tin của học sinh bao gồm: Họ tên, điểm toán, điểm lí, điểm hóa.
 - Hiển thị danh sách các sinh viên phải thi lại. Nếu không có sinh viên nào thi lại thì
đưa ra thông báo “Không có học sinh nào phải thi lại” */
{
    class HocSinh
    {
        private string hoten;
        private double diemtoan;
        private double diemli;
        private double diemhoa;
        public HocSinh()
        {
            hoten = " ";
            diemtoan = diemli = diemhoa = 0;
        }
        //======================================================
        public HocSinh(string hoten, double diemtoan, double diemli, double diemhoa)
        {
            this.hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemli = diemli;
            this.diemhoa = diemhoa;
        }
        // nhập thông tin của học sinh

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Họ tên học sinh : ");
            hoten = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Điểm toán= ");
            diemtoan = double.Parse(Console.ReadLine());
            Console.Write("Điểm lí=");
            diemli = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Điểm hóa= ");
            diemhoa = double.Parse(Console.ReadLine());
        }
        // hiển thị thông tin học sinh
        public void Hien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("HỌ TÊN HỌC SINH{0}", hoten);
            Console.WriteLine("ĐIỂM TOÁN{0} ", diemtoan);
            Console.WriteLine("ĐIỂM LÍ{0} ", diemli);
            Console.WriteLine("ĐIỂM HÓA", diemhoa);
        }
        // tính điểm tb
        public double TB()
        {
            double tb = 0;
            tb = (diemtoan + diemli + diemhoa) / 3;

            return tb;

        }
        public void kt()
        {
            if (TB() <= 5)
                Console.WriteLine(" thi lại!!");
            else
            {
                Console.WriteLine("không phải thi lại!");
            }

        }

    }
    /// <summary>
    /// quản lý học sinh
    /// </summary>
    class QLHS
    {
        private HocSinh[] ds;
        private int sLhs;
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(" SỐ LƯỢNG HỌC SINH: ");
            sLhs = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ds = new HocSinh[sLhs];
            for (int i = 0; i < sLhs; ++i)
            {
                ds[i] = new HocSinh();
                ds[i].Nhap();
            }
        }
        // hiện thị 
        public void Hien()
        {
            if (ds == null)
                Console.WriteLine("CHUA NHAP HOC SINH NAO VAO DANH DACH");
            //Console.WriteLine(" HAY NHAP DANH SACH SINH VIEN DE TIEP TUC");
            else
            {
                Console.WriteLine("DANH SACH CAC HOC SINH!");
                for (int i = 0; i < sLhs; ++i)
                    ds[i].Hien();
            }

        }
        // - Hiển thị danh sách các sinh viên phải thi lại--
        //==========================================================================
        public void KiemTraHS()
        {
            if (ds == null)
                Console.WriteLine("CHUA NHAP HOC SINH NAO DANH SACH");
            else
            {
                Console.WriteLine("DANH SACH HOC SINH PHAI THI LAI");
                for (int i = 0; i < sLhs; ++i)
                    if (ds[i].kt() <= 5)
                        ds[i].Hien();
            }

        }

    }

    class TEst
    {
        static void Main4(string[] args)
        {
            QLHS hs = new QLHS();
            Console.WriteLine(" thông tin cần thiết của học sinh!");
            hs.Nhap();
            hs.Hien();
            Console.ReadKey();
        }
    }

}