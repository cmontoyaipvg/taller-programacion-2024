using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //es este ejemplo se usaran las listas dictiory y arraylist
            // este es un nuevo comentario
           /* int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"La suma es {sumar(num1,num2)}");
            int resultado = sumar(num1);
            saludar("Claudio");
           */
            int valor = 10;
            Console.WriteLine("1.- "+valor);
            Sumar10(ref valor);
            //Console.WriteLine("R:"+Sumar10(valor));
            Console.WriteLine("2.- "+valor);

            Console.ReadKey();

        }

        static int sumar(int x,int y = 20)
        {
            return x + y;
        }
        static void saludar(string nombre){
            Console.WriteLine($"Bienvenido a este programa {nombre}");
        }

        static bool comparacion(int n1, int n2, int n3)
        {
          return (n1 == n2 && n2 == n3 && n1 ==n3);
        }
        static bool comparacion(int n1, int n2)
        {
            return (n1 == n2);
        }
        static bool comparacion(string n1, string n2)
        {
            return (n1 == n2);
        }
        static int Sumar10(ref int valor)
        {
            valor = valor + 10;
            return valor;
        }
    }
}
