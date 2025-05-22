using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook myNotebook = new Notebook("VivoBook", "Asus", 8000);
            myNotebook.DisplayInfo();

            Console.ReadKey(); 
        }
    }
}
