using System;

namespace CS_StructEnum
{
    internal class Program
    {
        // kiểu liệt kê enum
        /*
         0 : kém 
        1 : trung bình 
        2 : khá 
        3 : giỏi
         */

        enum HOCLUC
        {
            KEM = 1,
            TRUNGBINH = 5,
            KHA = 7,
            GIOI = 10
        }

        // struct : // kiểu dữ liệu tham trị
        public struct Product
        {
            // dữ liệu
            public string name;
            public string price;

            // phương thức
            // 
            public string GetInfo()
            {
                return $"ten san pham {name}";
            }
            //constructor
        }
        static void Main(string[] args)
        {
            Product sanpham1;
            HOCLUC hocluc;
            hocluc  = HOCLUC.KEM;
            Console.WriteLine(hocluc);
        }
    }
}
