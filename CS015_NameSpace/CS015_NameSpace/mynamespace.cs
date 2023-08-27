using System;
using System.Collections.Generic;
using System.Text;

namespace CS015_NameSpace
{
    // class struct, enum ,interface .. cho phép khai báo các namespace con trongd dó
    internal class mynamespace
    {
        public class Class1
        {
            public static void XinChao()
            {
                Console.WriteLine("xin chao từ class1");
            }
        }
      
    }
    namespace Abc
    {
        public class Class1
        {
            public static void XinChao()
            {
                Console.WriteLine("xin chao từ class2");
            }
        }
    }
}
