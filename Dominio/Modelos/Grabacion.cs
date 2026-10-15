using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    /// Clase que representa una evidencia de grabación de video o audio
    public class Grabacion : Evidencia
    {
        private bool CapturaInfraganti { get; set; }

        private int Calidad { get; set; }

        private int Duracion { get; set; }

        /// Constructor que inicializa una grabación con sus datos
        public Grabacion(DateTime fechaDeRecoleccion, string descripcion, bool capturaInfraganti, int calidad, int duracion) : base(fechaDeRecoleccion, descripcion)
        {
            CapturaInfraganti = capturaInfraganti;
            Calidad = calidad;
            Duracion = duracion;
            validar();
        }
        /// Realiza todas las validaciones de la grabación
        private void validar()
        {
            validarCaptura();
            validarCalidadRango();
            validarCalidadVacia();
            validarD();
        }

        /// Valida que la calidad no sea nula
        private void validarCalidadVacia()
        {
            if (Calidad == null)
            {
                throw new Exception("La calidad de la grabacion no puede estar vacia");
            }
        }

        /// Valida que la duración sea positiva
        private void validarD()
        {
            if (Duracion <= 0 || Duracion == null)
            {
                throw new Exception("La duracion de la grabacion no puede ser menor o igual a 0");
            }
        }

        /// Valida que la calidad esté entre 1 y 5
        private void validarCalidadRango()
        {
            if (Calidad < 1 || Calidad > 5)
            {
                throw new Exception("La calidad tiene que estar entre 1 y 5");
            }
        }


        /// Valida que la captura en flagrancia no sea nula
        private void validarCaptura()
        {
            if (CapturaInfraganti == null)
            {
                throw new Exception("Capturar Infraganti no puede estar vacio");
            }
        }

        /// Calcula el peso de la grabación
        public override int CalcularPesoPorEvidencia()
        {
            throw new NotImplementedException();
        }

        /// Devuelve si la grabación capturó un acto en flagrancia
        public bool DevolverCapturaInfraganti()
        {
            return CapturaInfraganti;
        }
        /// Devuelve la calidad de la grabación (1-5)
        public int DevolverCalidad()
        {
            return Calidad;
        }
        /// Devuelve la duración de la grabación en segundos
        public int DevolverDuracion()
        {
            return Duracion;
        }
    }
}
