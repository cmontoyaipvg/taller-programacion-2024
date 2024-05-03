using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            int edad = LeerNumero("Ingresa tu edad?","Debes ingresar una edad valida!!");
            imprimir($"su edad es:{ edad}");

            string nombre = LeerTexto("Ingrese su nombre");
            imprimir($"su nombre es: {nombre}");
            Console.ReadKey();*/
            /* int numero = 10;
             numero = Valor2(numero);
             int num1 = 1;
             int num2 = 2;

             num1 = num2;
             num2 = 70;


             Referencia(ref numero);
             imprimir($"Principal: { numero}");*/

            imprimirNumero(1); 
            Console.ReadKey();
        }


        static public void imprimirNumero(int x) {
            Console.WriteLine(x);
            if(x < 100)
            {
                imprimirNumero(x + 1);
            }
        }
        static public void Valor(int numero)
        {
            numero = 5;
            imprimir($"Metodo: {numero}");

        }

        static public int Valor2(int numero)
        {
            numero = 5;
            imprimir($"Metodo: {numero}");
            return numero;
        }
        static public void Referencia(ref int numero)
        {
            numero = 5;
            imprimir($"Metodo: {numero}");

        }
        static public void imprimir(string texto) {
            Console.WriteLine(texto);
        }    
        static public int LeerNumero(string mensaje,string error)
        {
            imprimir(mensaje);
            while (true)
            {
                string input = Console.ReadLine();
                int numero = 0;
                if (int.TryParse(input, out numero ))
                {
                    return numero;
                }
                else
                {
                    imprimir(error);
                }
            }
        }
        static public string LeerTexto(string mensaje)
        {
            imprimir(mensaje);
            string texto = Console.ReadLine();
            return texto;
        }
        static public int suma(int j,int x, int y = 5) {
            int numero = 0;
            numero = numero + 1;
            return numero ;
        }
        static public int suma(string f,int g,int p)
        {
            int numero = 0;
            numero = numero + 1;
            return numero;
        }
        static public void auditoria() { 
        
        }
    }
}
