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
            //Создаем экземпляр Класса и Структуры
            MyClass myClass = new MyClass();
            //Инициализируем поля 
            class.change = "не изменено";

            MyStruct mystruct = new MyStruct();
            struct.change = "не изменено";

            Console.WriteLine("Класс после передачи в метод: " + class.change);
            Console.WriteLine("Структура после передачи в метод: " + struct.change);

            Console.ReadKey();
        }
    }
}

