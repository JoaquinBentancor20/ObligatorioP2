using Dominio.Interefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public abstract class Evidencia : IValidacion
    {
        private static int _UltimoId = 0;
        public int Id { get; }

        public DateTime FechaDeRecoleccion { get; set; }

        public string Descrripcion { get; set; }

        protected Evidencia(DateTime fechaDeRecoleccion, string descripcion)
        {
            Id = ++_UltimoId;
            FechaDeRecoleccion = fechaDeRecoleccion;
            Descrripcion = descripcion;
        }

        public abstract int CalcularPesoPorEvidencia();

        public void Validas() { }

        public override string ToString()
        {
            return $"Evidencia {Id} - {Descrripcion} ({FechaDeRecoleccion:D})";
        }
    

    }
}
