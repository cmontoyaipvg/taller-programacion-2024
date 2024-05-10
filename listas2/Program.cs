using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace listas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // uso de listas 
            //declaracion
            List<string> frutas = new List<string>();
            List<int> numeros = new List<int>();
            List<string> nombre = new List<string>() {"juan","pedro","diego","ana","lucia" };
            List<string> rut = new List<string>() { "15213084-8", "14521455-K" };
            Dictionary<string,string> personas = new Dictionary<string,string>();

            personas["15213084-8"] = "Claudio Montoya";

            Console.WriteLine(personas["15213084-8"]);

            /*
            rut.Add("11587963-8");
            rut.Add("12587568-4");
            */
            nombre.Sort((a, b) => a.CompareTo(b));

            imprimirLista(nombre);

            //bool encontrar = rut.Contains("14521455-K");
           // Console.WriteLine(encontrar);
            
            
            //agregar elementos

           /* frutas.Add("manzana");
            frutas.Add("pera");
            frutas.Add("uva");
            frutas.Add("frutilla");
            frutas.Add("platano");
            frutas.Add("kiwi");



            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);

            Console.WriteLine("elementos:"+frutas.Count());
            Console.WriteLine(frutas.IndexOf("platano"));
            Console.WriteLine("El platano esta en la posicion 4 :"+ frutas[4]);
            
            frutas.RemoveAt(2);
            
            imprimirLista(frutas);
            imprimirLista(numeros);

            frutas.Clear();
            Console.WriteLine("elementos:" + frutas.Count());
           */
            Console.WriteLine("fin del programa");
            Console.ReadKey();
        }

        static void imprimirLista(List<string> lista) {

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        static void imprimirLista(List<int> lista)
        {

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

    }
}
