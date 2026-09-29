using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Grabacion : Evidencia
    {
        public bool CapturaInfraganti { get; set; }

        public int Calidad { get; set; }

        public int Duracion { get; set; }

        public Grabacion(DateTime fechaDeRecoleccion, string descripcion, bool capturaInfraganti, int calidad, int duracion) : base(fechaDeRecoleccion, descripcion)
        {
            CapturaInfraganti = capturaInfraganti;
            Calidad = calidad;
            Duracion = duracion;
        }
        public override int CalcularPesoPorEvidencia()
        {
            throw new NotImplementedException();
        }
    }
}
