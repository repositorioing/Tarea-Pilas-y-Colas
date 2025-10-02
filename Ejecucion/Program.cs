using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using MiBiblioteca;
using BibliotecaColaBanco;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola colaBanco1 = new Cola();
            Cola colaBanco2 = new Cola();
            //Cliente cliente = new Cliente();

            //Console.WriteLine("Ingrese la cantidad de clientes. ");
            //int cantidad = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= cantidad; i++)
            //{
            //    Console.WriteLine($"Ingrese el nombre del cliente: {i} ");
            //    string nombre = Console.ReadLine();
            //    Console.WriteLine($"Ingrese el tiempo de atencion del cliente: {i}");
            //    float tiempoAtencion = float.Parse(Console.ReadLine());
            //    Console.Clear();

            //    colaBanco.Encolar(new Cliente(nombre, tiempoAtencion));
            //}
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cola 1");
            colaBanco1.Encolar(new Cliente("juan", 20));
            colaBanco1.Encolar(new Cliente("alex", 10));
            colaBanco1.Encolar(new Cliente("mario", 35));
            colaBanco1.Encolar(new Cliente("juana", 100));
            colaBanco1.Encolar(new Cliente("pedro", 25));

            colaBanco1.MostrarClientesTiempos();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cola 2");
            colaBanco2.Encolar(new Cliente("Maria", 18));
            colaBanco2.Encolar(new Cliente("Isabel", 8));
            colaBanco2.Encolar(new Cliente("Grabiel", 45));
            colaBanco2.Encolar(new Cliente("Andy", 60));
            colaBanco2.Encolar(new Cliente("Patricia", 35));

            colaBanco2.MostrarClientesTiempos();


            Console.ForegroundColor = ConsoleColor.Green;
            if (colaBanco1.TiempoTotal() > colaBanco2.TiempoTotal())
            {
                Console.WriteLine("Cola 1 tiene mas tiempo de atencion. ");
            }
            else
            {
                Console.WriteLine("Cola 2 tiene mas tiempo de atencion. ");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
