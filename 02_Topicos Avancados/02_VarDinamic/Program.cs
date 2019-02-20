using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 123456;
            t2 = "";
            

            var v1 = "";
            var v2 = 1234567;
            //var v3;
            //ERRO: var v3;
            //ERRO: v2 = "";

            dynamic d1 = new Usuario { Nome="Maria" };

            Console.WriteLine(d1.Nome);
            //ERRO: Console.WriteLine(d1.Senha);

            d1 = "";

            Console.ReadKey();




        }

        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
