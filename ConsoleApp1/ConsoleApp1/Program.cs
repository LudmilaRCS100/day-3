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
            Funkcija3();
            int mainigais2=Funkcija4(12,14);

            Console.WriteLine(mainigais2);
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
        static void Funkcija3()

        {
            int skaitlis1, skaitlis2, d;
            skaitlis1 = 2;
            skaitlis2 = 3;
            d= skaitlis1 + skaitlis2;
            Console.WriteLine(d);

            return;


        }
        static int Funkcija4(int skaitlis1, int skaitlis2)
        {
            int result;
            result = skaitlis1 + skaitlis2;
            return result;
        }





        
           
    }
}
