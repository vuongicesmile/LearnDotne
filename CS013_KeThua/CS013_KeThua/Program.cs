using System;

namespace CS013_KeThua
{
    // tính kế thừa 
    /*
     A,B
    B kế thừa A
    A - cơ sở , cha 
    B - kế thừa , con 

    class B : A 
    {
    
    }
    Animal 
        - Legs
        - weight 
        - showlog
    Cat : Animal 

     */

    //sealed class Animal -- khai báo từ khoá sealed để không cho nó kế thừa 
     class Animal
    {
        public int Legs {  get; set; }
        public int Weight { get; set; }
        
        public void ShowLegs()
        {
            Console.WriteLine($"meo co {Legs} chan");
        }
    }

    class Cat : Animal
    {
        public string Food;

        public Cat()
        {
            this.Legs = 4;
            this.Food = "xuong";
        }
        // khai báo lại phương thức trong lớp cơ sở 
        public new void ShowLegs()
        {
            Console.WriteLine($"loai meo có {Legs} chan");
        }

        public void ShowInfo()
        {
            // gọi lại phương thức trong kế thừa 
            ShowLegs();
            // gọi phương thức ở lớp cơ sở
            base.ShowLegs();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat meo = new Cat();
            meo.ShowInfo();
        }
    }
}
