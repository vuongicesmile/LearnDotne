using System;

namespace CSHelloWorld
{
    internal class Program
    {
        // nhấn ctril f5 : để build 
        static void Main(string[] args)
        {
            // var a : sau này gán nó với kiểu dữ liệu gì thì nó sẽ thành kiểu dữ liệu đó
            // danh sách mảng các sinh viên 
            //string sinhvien1 = "Nguyen van A";
            //string sinhvien2 = "Nguyen van B";
            //string sinhvien3 = "Nguyen van C";
            //Console.WriteLine(sinhvien2);
            //Console.WriteLine(sinhvien3);
            // khai báo dữ liệu kiểu mảng 
            string[] ds;
            ds = new string[3];
            ds[0] = "nguyen van a";
            ds[1] = "nguyen van b";
            ds[2] = "nguyen van b";

            for (int i = 0; i < ds.Length; i++)
            {
            Console.WriteLine(ds[i]);
            }
        }
    }
}
