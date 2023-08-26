using System;
using System.Text;

namespace CS012_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string loichao;
            // chèn ký tự vào chuỗi
            string ten = "vuong\"";
            Console.WriteLine(ten);
            /// chèo giá trị vào chuỗi 
            Console.WriteLine($"xin chao {1}");

            StringBuilder thongbao = new StringBuilder();
            thongbao.Append("xin chao");
            thongbao.Replace("xin", "hong");
            Console.WriteLine(thongbao);
        }
    }
}
