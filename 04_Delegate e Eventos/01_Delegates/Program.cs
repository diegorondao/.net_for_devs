using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates
{
    class Program
    {
        delegate int Calcula(int a, int b);

        static void Main(string[] args)
        {
            Calcula calc = new Calcula(Soma);
            int so = calc(10, 20);

            Calcula calc1 = new Calcula(Subtrair);
            int su = calc1(30, 15);
            /*
             * var so = Soma(10, 20);
             * var su = Subtrair(20, 10);
            */

            Console.WriteLine("Soma: " + so);
            Console.WriteLine("Sub: " + su);

            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }
        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
