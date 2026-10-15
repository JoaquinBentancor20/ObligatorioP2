using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    /// Clase abstracta que representa una evidencia recolectada en una investigación
    public abstract class Evidencia : IValidable
    {
        private static int _UltimoId = 0;
        private int Id { get; }

        private DateTime FechaDeRecoleccion { get; set; }

        private string Descripcion { get; set; }

        /// Constructor protegido para inicializar una evidencia
        protected Evidencia(DateTime fechaDeRecoleccion, string descripcion)
        {
            Id = ++_UltimoId;
            FechaDeRecoleccion = fechaDeRecoleccion;
            Descripcion = descripcion;
        }

        /// Método abstracto para calcular el peso de la evidencia
        public abstract int CalcularPesoPorEvidencia();

        /// Valida los campos de la evidencia
        public virtual void Validar() 
        {
            ValidarD();
            ValidarFechaR();
        }

        public override string ToString()
        {
            return $"Evidencia {Id} - {Descripcion} ({FechaDeRecoleccion:D})";
        }

        /// Devuelve el ID de la evidencia
        public int DevolverID()
        {
            return Id;
        }

        /// Devuelve la descripción de la evidencia
        public string DevolverDescripcion()
        {
            return Descripcion;
        }

        /// Valida que la fecha de recolección sea la actual
        private void ValidarFechaR() 
        {
            if (FechaDeRecoleccion != DateTime.Now.Date)
            {
                throw new Exception("La fecha de recoleccion no puede ser distinta a la actual");
            }
        }

        /// Valida que la descripción no esté vacía
        private void ValidarD() 
        {
            if (String.IsNullOrEmpty(Descripcion)) 
            {
                throw new Exception("La descripcion no puede estar vacia");
            }
        }
    }
}
