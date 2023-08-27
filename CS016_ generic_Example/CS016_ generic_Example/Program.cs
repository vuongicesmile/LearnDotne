using System;

namespace CS016__generic_Example
{
    internal class Program
    {
        // giải thuật giống nhau nhưng kiểu dữ liệu khác nhau 
        // => xử lý generic 

        // khai báo kiểu đại diện T
        static void Swap<T>(ref T x ,ref T y)
        {
            T t;
            t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            int a = 5; // khai báo là int thì t biến thành string
            int b = 45;
            Console.WriteLine($"a = {a} ., b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a} ., b = {b}");

        }
    }
}
