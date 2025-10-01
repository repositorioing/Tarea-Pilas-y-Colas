using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Cola
    {
        public Nodo frente = null;
        public Nodo fin = null;

        public void Encolar(char p)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = p;

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
        public char Desencolar()
        {
            if (frente != null)
            {
                char dato = frente.dato;

                frente = frente.siguiente;
                return dato;
            }
            return ' ';
        }
    }
}
