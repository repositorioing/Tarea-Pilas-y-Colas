using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaColaBanco
{
    public class Cola
    {
        public Nodo frente = null;
        public Nodo fin = null;

        public void Encolar(Cliente c)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = c;

            if (frente == null)
            {
                frente = nuevoDato;
                fin = nuevoDato;
            }
            else
            {
                fin.siguiente = nuevoDato;
                fin = nuevoDato;
            }
        }
        public Cliente Desencolar()
        {
            if (frente != null)
            {
                Cliente dato = frente.dato;
                frente = frente.siguiente;
                return dato;
            }
            return null;
        }
        public float TiempoTotal()
        {
            Nodo temp = frente;
            float suma = 0;

            while (temp != null)
            {
                suma += temp.dato.tiempoAtencion;
                temp = temp.siguiente;
            }
            return suma;
        }
        public float ClienteMenosTiempo()
        {

            Nodo temp = frente;
            float min = temp.dato.tiempoAtencion;

            while (temp != null)
            {
                if (temp.dato.tiempoAtencion < min)
                {
                    min = temp.dato.tiempoAtencion;
                }
                temp = temp.siguiente;
            }
            return min;
        }
        public float ClienteMasTiempo()
        {

            Nodo temp = frente;
            float max = temp.dato.tiempoAtencion;

            while (temp != null)
            {
                if (temp.dato.tiempoAtencion > max)
                {
                    max = temp.dato.tiempoAtencion;
                }
                temp = temp.siguiente;
            }
            return max;
        }
    
        public void MostrarClientesTiempos()
        {

            float total = TiempoTotal();
            float min = ClienteMenosTiempo();
            float max = ClienteMasTiempo();

            Nodo temp = frente;
            Console.WriteLine("=============== CLIENTES ATENDIDOS ================");
            while (frente != null)
            {
                Cliente actual = Desencolar();
                Console.WriteLine($"Atendido a: {actual.nombre} tiempo de atencion es: {actual.tiempoAtencion}");
                Console.WriteLine("===================================================");
                temp = temp.siguiente;
            }

            Console.WriteLine("===================================================");
            Console.WriteLine($"El tiempo total de atencion de la cola es: {total}");
            Console.WriteLine($"El tiempo minimo de atencion es: {min} minutos.");
            Console.WriteLine($"El tiempo maximo de atencion es: {max} minutos.");
            Console.WriteLine("===================================================");
            
        }
    }
}
