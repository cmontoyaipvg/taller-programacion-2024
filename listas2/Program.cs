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
         
            string[] array = new string[5];

            List<string> array2 = new List<string>();

            array[0] = "texto1";
            array[1] = "texto2";
            array[2] = "texto3";
            array[3] = "texto4";
            array[4] = "texto5";

            array2.Add("texto1");
            array2.Add("texto2");
            array2.Add("texto3");
            array2.Add("texto4");
            array2.Add("texto5");
            array2.Add("texto6");
            array2.Add("texto7");
            array2.Add("texto8");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals("texto3")) {

                    Console.WriteLine("si esta el texto");
                }
            }
             
            if (array2.Contains("texto3"))
            {
                Console.WriteLine("si esta el texto");
            }

            int index = array2.IndexOf("texto3");   //  no exista el valor -1

            List<int> valores = new List<int>() { 1,23,4,6,7,58,78,98,98,88,877,83,844};
            int suma = valores.Sum();
            int max = valores.Max();
            int min = valores.Min();

            Console.WriteLine("La suma es " + suma);
            Console.WriteLine("Maximo es " + max);
            Console.WriteLine("Minimo es " + min);



            var grupos = valores.GroupBy(n => n % 2 == 0 ? "Pares" : "Impares");

            foreach (var grupo in grupos)
            {
                Console.WriteLine(grupo.Key + ":");
                foreach (var num in grupo)
                {
                    Console.WriteLine(num);
                }
            }
            foreach (var x in valores)
            {
                
            }

            List<int> mayores50 = valores.Where(x => x > 50).ToList();

            int numero50 = valores.Where(x => x > 50).FirstOrDefault();


            Console.WriteLine("");

            //array2.Add(numero.ToString());
           
            string[] array3 = array2.ToArray();
            List<string> nombre = new List<string>() { "juan", "pedro", "diego", "ana", "lucia" };

            /*
             *  List<string> frutas = new List<string>();
            List<int> numeros = new List<int>();
            List<string> nombre = new List<string>() {"juan","pedro","diego","ana","lucia" };
            List<string> rut = new List<string>() { "15213084-8", "14521455-K" };
            Dictionary<string,string> personas = new Dictionary<string,string>();

            personas["15213084-8"] = "Claudio Montoya";

            Console.WriteLine(personas["15213084-8"]);

            
            rut.Add("11587963-8");
            rut.Add("12587568-4");
            
            nombre.Sort((a, b) => a.CompareTo(b));

            imprimirLista(nombre);

            //bool encontrar = rut.Contains("14521455-K");
           // Console.WriteLine(encontrar);
            
            
            //agregar elementos

            frutas.Add("manzana");
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
