using System;
using System.Collections.Generic;
using System.Text;

namespace CS007_class
{
    // cùng 1 chương trình internal : phạm vi truy cập mặc định
    internal class VuKhi
    {
        // dữ liệu
        string name = "Tên vũ khí"; // mặc định là prive => chỉ truy cập được ở phạm vi lớp
        //=> muốn truy cập phạm vi bên ngoài phải dùng public

        int dosatthuong = 0;

        // thuộc tính
        public int SatThuong
        {
            // thi hành khi thực hiện phép gán
            set {
                // 
                Console.WriteLine("set");
                dosatthuong = value;
            }
            // thi hành khi truy cập
            get {
                // phải trả về kiểu dữ liệu tương ưng với thuộc tính
                return dosatthuong;
            }
        }
        public string NoiSanXuat { get; set; }


        // phương thức khởi tạo
        // khai báo ra phương thức khởi tạo
        // lưu ý : không có dữ liệu trả về
        // mục đích : khi gọi từ khoá new để khởi tạo thì nó sẽ gọi trong phương thức đó đầu tiên
        public VuKhi()
        {
            dosatthuong = 1;
            Console.WriteLine("khoi tao");
        }
        // ta có thể quá tải hàm bằng cách đặt tên giống nhưng truyền params kiểu khác
        public VuKhi(string abc)
        {
            Console.WriteLine("khoi tao" + abc);
        }
        public VuKhi(string name, int _dosatthuong)
        {
            this.name = name;
            dosatthuong = _dosatthuong;
        }
        // phương thức 
        public void ThietLapDoSatThuong(int dosatthuong)
        {
            // this : giá trị trỏ đến giá trị hiện tại của lớp
            this.dosatthuong = dosatthuong;
            
            // this - ref
            // VuKhi abc;
            // abc = this;
        }
        public void TanCong()
        {
            Console.WriteLine(this.name);
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
