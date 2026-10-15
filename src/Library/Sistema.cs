using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using Microsoft.VisualBasic;

namespace Ejercicio_101
{
    public class SistemaProceso
    {
        public List<Equipo> equipos= new List<Equipo>();
        public List<Prestamo> prestamos= new List<Prestamo>();
        public void RegistrarEquipo(Equipo equipo)
        {
            equipos.Add(equipo);
        }
        public void Prestar(string estudianteSolicitante, string modeloSolicitado)
        {
            Prestamo nuevoPrestamo= new Prestamo(estudianteSolicitante,modeloSolicitado);
            prestamos.Add(nuevoPrestamo);
        }
        public void Devolver(string modeloSolicitado)
        {
            foreach(Prestamo p in prestamos)
            {
                if(p.ModeloSolicitado==modeloSolicitado)
                {
                    if (p.Activo)
                    {
                        p.Finalizar();
                        break;
                    }
                }
            }
        }
    }
}