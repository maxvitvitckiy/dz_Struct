using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class MyClass
    {
        public string change;
        public MyClass()
        {
            change = "Не изменено";
        }

    }
    struct MyStruct
    {
        public string change;
        
        public MyStruct(string value)
        {
            change = value;
        }
    }

    
    class Program
    {
        public static void ChangeChange(MyClass myClass)
        {
            myClass.change = "Изменено";
        }
        public static void ChangeStructChange(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
        static void Main(string[] args)
        {
            MyStruct ms = new MyStruct("Не изменено");
            MyClass mc = new MyClass();
            Console.WriteLine("Class: " + mc.change);
            Console.WriteLine("Struct: " + ms.change);
            ChangeChange(mc);
            ChangeStructChange(ms);
            Console.WriteLine("\n");
            Console.WriteLine("Class: " + mc.change);
            Console.WriteLine("Struct: " + ms.change);
            Console.ReadLine();
        }
    }
}
