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

        public string Descripcion { get; set; }

        protected Evidencia(DateTime fechaDeRecoleccion, string descripcion)
        {
            Id = ++_UltimoId;
            FechaDeRecoleccion = fechaDeRecoleccion;
            Descripcion = descripcion;
        }

        public abstract int CalcularPesoPorEvidencia();

        public void Validar() 
        {
            ValidarD();
            ValidarFechaR();
        }

        public override string ToString()
        {
            return $"Evidencia {Id} - {Descripcion} ({FechaDeRecoleccion:D})";
        }
    public void ValidarFechaR() 
        {
            if (FechaDeRecoleccion != DateTime.Now)
            {
                throw new Exception("La fecha de recoleccion no puede ser distinta a la actual");
            }
        }
        public void ValidarD() 
        {
            if (String.IsNullOrEmpty(Descripcion)) 
            {
                throw new Exception("La descripcion no puede estar vacia");
            }
        }

    }
}
