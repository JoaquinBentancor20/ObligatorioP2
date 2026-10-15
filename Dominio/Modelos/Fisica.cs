using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    /// Clase que representa una evidencia física recolectada
    public class Fisica : Evidencia
    {
        private bool TieneHuella { get; set; }

        /// Constructor que inicializa una evidencia física con sus datos
        public Fisica(DateTime fechaDeRecoleccion, string descripcion, bool tieneHuella) : base(fechaDeRecoleccion, descripcion)
        {
            TieneHuella = tieneHuella;
            validarH();
        }

        /// Valida que la huella no sea nula
        private void validarH()
        {
            if (TieneHuella==null) {
                throw new Exception("La evidencia fisica no puede estar null");
            }
        }

        /// Devuelve si la evidencia física tiene huella
        public bool DevolverHuella()
        {
            return TieneHuella;
        }

        /// Calcula el peso de la evidencia física
        public override int CalcularPesoPorEvidencia()
        {
            throw new NotImplementedException();
        }
    }
}
