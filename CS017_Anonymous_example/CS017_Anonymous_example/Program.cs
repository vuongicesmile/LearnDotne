using System;
using System.Collections.Generic;
using System.Linq;

namespace CS017_Anonymous_example
{
    internal class Program
    {

        class SinhVien
        {
            public string HoTen { set; get; }
            public int Namsinh { set; get; }
            public string Noisinh { set; get; }

        } 
        // anouymous - kiểu dữ liệu vô danh 
        // object - thuộc tính - chỉ đọc 
        // new { thuộc tính = giá trị , thuộc tính 2 = giatri2 }
        static void Main(string[] args)
        {
            // khai báo kiểu dữ liệu vô danh
            var sanpham = new
            {
                Ten = "I phone 8",
                Gia = 1000,
                namSx = 2018
            };
            // để truy cập kiểu dữ liệu vô danh 
            //Console.WriteLine(sanpham.Ten);
            //Console.WriteLine(sanpham.Gia);

            List <SinhVien> cacsinhvien = new List<SinhVien> ()
            {
                new SinhVien() { HoTen = "nam", Namsinh = 2000 , Noisinh = "abc"},
                new SinhVien() { HoTen = "vuong", Namsinh = 2001 , Noisinh = "abc"},
                new SinhVien() { HoTen = "avb", Namsinh = 2002 , Noisinh = "abc"},
                new SinhVien() { HoTen = "test", Namsinh = 2003 , Noisinh = "abc"},
            };

            var ketqua = from sv in cacsinhvien
                         where sv.Namsinh <= 2001
                         select new
                         {
                             Ten = sv.HoTen,
                             NS = sv.Noisinh
                         };

            foreach (var sinhvien in ketqua)
            {
                Console.WriteLine(sinhvien.Ten + sinhvien.NS);
            }
        }
    }
}
