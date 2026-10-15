using System;
using System.Data;
using System.Dynamic;
using Microsoft.VisualBasic;

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
            public bool EstaDisponible {get; set;}
            
            public Equipo(int codigo, string modelo)
            {
                this.Codigo=codigo;
                this.Modelo=modelo;
                EstaDisponible= true;
            }

            public void Prestar()
        {
            EstaDisponible=false;
        }
        public void Disponible()
        {
            EstaDisponible= true;
        }
    }
    public class Prestamo
    {
        public string EstudianteSolicitante{get;}
        public string ModeloSolicitado{get;}
        public DateTime FechaDeEntrega{get;}
        public DateTime FechaDeDevolucion{get;}
        public bool Activo{get;set;}

        public Prestamo(string estudianteSolicitante, string modeloSolicitado, int DiasParadevolver=7 )
        {
            EstudianteSolicitante=estudianteSolicitante;
            ModeloSolicitado=modeloSolicitado;
            Activo=true;
            FechaDeEntrega= DateAndTime.Now;
            FechaDeDevolucion=FechaDeEntrega.AddDays(DiasParadevolver);
        }
        public void Finalizar()
        {
            Activo=false;
        }

    }

    
}