using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void WriteScreen()
        {
            string a = ("Vou testar");
            string b = (" as strings do C#");
            Console.WriteLine(a + b);
            Console.WriteLine("Hello World!\naaaa");
        }
        static void Main(string[] args)
        {
            WriteScreen();
            Console.ReadKey();
        }
    }
}
