using System;

namespace CS007_class
{
    internal class Program
    {
        // class : kiểu dữ liệu tham chiếu

        static void Main(string[] args)
        {
            VuKhi sungluc = new VuKhi();
            sungluc.ThietLapDoSatThuong(5);
            sungluc.TanCong();
           // Console.WriteLine(sungluc); // console sẽ gọi thằng khởi tạo trước
            VuKhi struong = new VuKhi("xin chao ");
           // Console.WriteLine(struong);
            // khai báo 1 phương thức khởi tạo khi khai báo in tên với độ sát thương luôn
            VuKhi sungmay = new VuKhi("sung lung tung", 15);
            sungmay.TanCong();
            //  Console.WriteLine(sungmay);
            // nếu tắt đi thuộc tính set thì sẽ không cho phép gán dữ liệu => câu lệnh bên dưới lỗi
            sungluc.SatThuong = 10;
            // nếu tắ đi thuộc tính get thì sẽ không cho phép đọc dữ liệu => nhưng gán lại được
            Console.WriteLine(sungluc.SatThuong);

            /*
             Một class chỉ được khai báo 1 phương thức huỷ 
            // khi không đủ bộ nhớ nó sẽ gọi đến phương thức huỷ
            // thời điểm nào gọi phương thức huỷ này gọi thì do .net quyết định 

             */
        }
    }
}
