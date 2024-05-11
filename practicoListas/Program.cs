using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listado = new List<string>();
            agregaElemento(listado);
            imprimirLista(listado);
            Console.ReadKey();
        }

        static void agregaElemento(List<string> listado)
        {
            Console.WriteLine("Ingrese el texto?");
            string texto = Console.ReadLine();
            listado.Add(texto);
        }
        static void imprimirLista(List<string> listado) {
            Console.WriteLine("Listado");
            Console.WriteLine("****************************");
            foreach (string item in listado)
            {
                Console.WriteLine(item);
            }
        }
    }
}
