using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class ListaEnlazadaSimple
    {
        public Nodo primero = null;

        public void InsertarDatos(char p1)
        {
            Nodo nuevoDato = new Nodo();
            nuevoDato.dato = p1;

            if (primero == null)
            {
                primero = nuevoDato;
            }
            else
            {
                Nodo temp = primero;

                while (temp.siguiente != null)
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoDato;
            }

        }
        public string MostrarDatos()
        {

            Nodo temp = primero;
            string resultado = "";

            while (temp != null)
            {
                resultado += temp.dato;   
                temp = temp.siguiente;   
            }

            return resultado;
        }
    }
}
