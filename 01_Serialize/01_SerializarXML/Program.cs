using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "José Costa Silva", CPF="222.222.222-22", Email="jose@gmail.com" };

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"C:\Users\Elias\Documents\Arquivo C# Avançado\01_SerializarXML.xml");

            serializador.Serialize(stream, usuario);
        }
    }
}
