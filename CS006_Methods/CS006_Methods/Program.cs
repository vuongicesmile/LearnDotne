using System;

namespace CS006_Methods
{
    internal class Program
    {
        protected static void Main(string[] args)   
        {
            //CS006_Methods.TinhToan.tong(5, 6);
           var result = TinhToan.tong(5, 6);
            xinchao();
            Console.WriteLine(result);
        }
        // để truy cập đến xin chào thì phải truy cập đúng namespace đấy
        // <Access modifier> <return type> <name_method> (<parameters>) cú pháp khai báo 
        /*
         - // các câu lệnh trong phương thức
        - các phương thức phải nằm trong class , vì vậy có thể tạo các file mã nguồn nằm trong các lớp

         */
        static void xinchao()
        {
            Console.WriteLine("Hello World!");
            //.. phương thức không có giá trị trả về
        }

    }
}
