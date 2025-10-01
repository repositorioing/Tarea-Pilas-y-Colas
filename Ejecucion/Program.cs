using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiBiblioteca;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple salidaPalabraPila= new ListaEnlazadaSimple();
            ListaEnlazadaSimple salidaPalabraCola = new ListaEnlazadaSimple();

            Cola cola = new Cola();
            Pila pila = new Pila();


            Console.WriteLine("Ingresa la palabra para verificar si es palindroma. ");
            string palabra = Console.ReadLine();

            foreach (char c in palabra)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    pila.Apilar(c);
                    cola.Encolar(c);
                }
            }
            while (pila.cima != null)
            {
                char letraPila = pila.Desapilar();
                salidaPalabraPila.InsertarDatos(letraPila);
            }
            while (cola.frente != null)
            {
                char letraCola = cola.Desencolar();
                salidaPalabraCola.InsertarDatos(letraCola);
            }

            Console.WriteLine($"La palabra ingresada es: {palabra} y vamos a verificar con la estructura PILA si es una palabra palindroma. ");
            string resultado1 = salidaPalabraPila.MostrarDatos();

            if (resultado1 == palabra)
            {
                salidaPalabraPila.MostrarDatos();
                Console.WriteLine("Es palíndroma.");
            }
            else
            {
                Console.WriteLine("No es palíndroma.");
            }


            Console.WriteLine($"La palabra ingresada es: {palabra} y vamos a verificar con la estructura COLA si es una palabra palindroma. ");
            string resultado2 = salidaPalabraCola.MostrarDatos();

            if (resultado2 == palabra)
            {
                salidaPalabraCola.MostrarDatos();
                Console.WriteLine("Es palíndroma.");  
            }
            else
            {
                Console.WriteLine("No es palíndroma.");
            }
            
        }
    }
}
