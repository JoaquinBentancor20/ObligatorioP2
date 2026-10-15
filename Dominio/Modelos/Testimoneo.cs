using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    /// Clase que representa una evidencia testimonial
    public class Testimoneo : Evidencia
    {
        private string Nombre { get; set; }

        private Credibilidad Credibilidad { get; set; }

        /// Constructor que inicializa una evidencia testimonial
        public Testimoneo (DateTime fechaDeRecoleccion, string descripcion, string nombre, Credibilidad credibilidad): base(fechaDeRecoleccion,descripcion)
        {
            Nombre = nombre;
            Credibilidad = credibilidad;
            validar();
        }

        /// Calcula el peso del testimonio
        public override int CalcularPesoPorEvidencia()
        {
            throw new NotImplementedException();
        }

        /// Realiza todas las validaciones del testimonio
        private void validar()
        {
            validarNombre();
            validarCredibilidad();
        }

        /// Valida que el nombre del testigo no esté vacío
        private void validarNombre() 
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre de la persona que da el testimonio no puede estar vacio");
            }
        }

        /// Valida que la credibilidad no sea nula
        /// Valida que la credibilidad no sea nula
        private void validarCredibilidad() 
        {
            if (Credibilidad==null) 
            {
                throw new Exception("La credibilidad del testimonio no puede estar vacio");
            }
        }

        /// Devuelve el nombre del testigo
        public string ObtenerNombre()
        {
            return Nombre;
        }

        /// Devuelve el nivel de credibilidad del testimonio
        public Credibilidad ObtenerCredibilidad()
        {
            return Credibilidad;
        }
    }
}
