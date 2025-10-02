namespace BibliotecaColaBanco
{
    public class Cliente
    {
        public string nombre;
        public float tiempoAtencion;

        public Cliente()
        {

        }
        public Cliente(string nombre, float tiempoAtencion)
        {
            this.nombre = nombre;
            this.tiempoAtencion = tiempoAtencion;
        }
    }
}