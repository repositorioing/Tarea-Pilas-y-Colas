using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Pila
    {
        public Nodo cima = null;

        public void Apilar(char p)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = p;

            nuevoDato.siguiente = cima;
            cima = nuevoDato;
        }
        public char Desapilar()
        {
            if (cima != null)
            {
                char dato = cima.dato;
                cima = cima.siguiente;
                return dato;
            }
            return ' ';
        }


    }
}
