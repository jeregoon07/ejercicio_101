namespace Ejercicio_101
{
    public class Estudiante
    {
        public string Nombre{get; set;}
        public int Documento{get;set;}
        public Estudiante(string nombre, int documento)
        {
            this.Nombre=nombre;
            this.Documento=documento;
        }
    }
    public class Equipo
    {
        public int Codigo{get;set;}
        public string Modelo{get;set;}
        public bool EstaDisponible;
        public Equipo(int codigo, string modelo)
        {
            this.Codigo=codigo;
            this.Modelo=modelo;
        }
    }
    
    
}