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
        }

        public override int CalcularPesoPorEvidencia()
        {
            throw new NotImplementedException();
        }
    }
}
