using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainigais = Funkcija2();
            Console.WriteLine(mainigais);


            Funkcija();
            Console.ReadLine();
        }
        static void Funkcija()
        {
            int a, b, c;
            a = 7;
            b = 9;

            c = a + b;
            Console.WriteLine(c);


        }

        static int Funkcija2()
        {
            int a, b, c;
            a = 7;
            b = 9;

            c = a + b;
            return c;
        }





        
            int a, b, c;

    }
}
