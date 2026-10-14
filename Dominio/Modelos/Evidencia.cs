using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public abstract class Evidencia : IValidable
    {
        private static int _UltimoId = 0;
        private int Id { get; }

        private DateTime FechaDeRecoleccion { get; set; }

        private string Descripcion { get; set; }

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

        public int DevolverID()
        {
            return Id;
        }

        public string DevolverDescripcion()
        {
            return Descripcion;
        }

        private void ValidarFechaR() 
        {
            if (FechaDeRecoleccion != DateTime.Now.Date)
            {
                throw new Exception("La fecha de recoleccion no puede ser distinta a la actual");
            }
        }
        private void ValidarD() 
        {
            if (String.IsNullOrEmpty(Descripcion)) 
            {
                throw new Exception("La descripcion no puede estar vacia");
            }
        }



    }
}
