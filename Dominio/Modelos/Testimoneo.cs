using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Testimoneo : Evidencia
    {
        public string Nombre { get; set; }

        public Credibilidad Credibilidad { get; set; }

        public Testimoneo (DateTime fechaDeRecoleccion, string descripcion, string nombre, Credibilidad credibilidad): base(fechaDeRecoleccion,descripcion)
        {
            Nombre = nombre;
            Credibilidad = credibilidad;
            validar();
        }

        public override int CalcularPesoPorEvidencia()
        {
            throw new NotImplementedException();
        }
        private void validar()
        {
            validarNombre();
            validarCredibilidad();
        }
        private void validarNombre() 
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre de la persona que da el testimonio no puede estar vacio");
            }
        }
        private void validarCredibilidad() 
        {
            if (Credibilidad==null) 
            {
                throw new Exception("La credibilidad del testimonio no puede estar vacio");

            }
        }

    }
}
