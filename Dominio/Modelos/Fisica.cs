using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Fisica : Evidencia
    {
        public bool TieneHuella { get; set; }

        public Fisica(DateTime fechaDeRecoleccion, string descripcion, bool tieneHuella) : base(fechaDeRecoleccion, descripcion)
        {
            TieneHuella = tieneHuella;
            validarH();
        }

        private void validarH()
        {
            if (TieneHuella==null) {
                throw new Exception("La evidencia fisica no puede estar null");
            }
            }

        public override int CalcularPesoPorEvidencia()
        {
            throw new NotImplementedException();
        }
    }
}
