using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Reflection.Modelo;
namespace _04_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José",
                Email = "jose.costa@gmail.com",
                Senha = "123456ab"
            };
            Log.Gravar(usuario.Clone());

            usuario.Nome = "José Costa";
            Log.Gravar(usuario.Clone());

            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };
            Log.Gravar(carro);

            Log.ApresentarLog();

            Console.WriteLine("Log gravado!");
            Console.ReadKey();
        }
    }
}
