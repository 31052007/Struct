using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            MyClass classInstance = new MyClass();
            classInstance.change = "не изменено";

            MyStruct structInstance = new MyStruct();
            structInstance.change = "не изменено";

            ClassTaker(classInstance);
            StructTaker(structInstance);

            Console.WriteLine("Класс после передачи в метод: " + classInstance.change);
            Console.WriteLine("Структура после передачи в метод: " + structInstance.change);

            Console.ReadKey();
        }
    }
}

