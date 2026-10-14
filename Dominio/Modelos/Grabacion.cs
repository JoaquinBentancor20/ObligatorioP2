using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Grabacion : Evidencia
    {
        private bool CapturaInfraganti { get; set; }

        private int Calidad { get; set; }

        private int Duracion { get; set; }

        public Grabacion(DateTime fechaDeRecoleccion, string descripcion, bool capturaInfraganti, int calidad, int duracion) : base(fechaDeRecoleccion, descripcion)
        {
            CapturaInfraganti = capturaInfraganti;
            Calidad = calidad;
            Duracion = duracion;
            validar();
        }
        private void validar()
        {
            validarCaptura();
            validarCalidadRango();
            validarCalidadVacia();
            validarD();
        }

        private void validarCalidadVacia()
        {
            if (Calidad == null)
            {
                throw new Exception("La calidad de la grabacion no puede estar vacia");
            }
        }

        private void validarD()
        {
            if (Duracion <= 0 || Duracion == null)
            {
                throw new Exception("La duracion de la grabacion no puede ser menor o igual a 0");
            }
        }

        private void validarCalidadRango()
        {
            if (Calidad < 1 || Calidad > 5)
            {
                throw new Exception("La calidad tiene que estar entre 1 y 5");
            }
        }


        private void validarCaptura()
        {
            if (CapturaInfraganti == null)
            {
                throw new Exception("Capturar Infraganti no puede estar vacio");
            }
        }

        public override int CalcularPesoPorEvidencia()
        {
            throw new NotImplementedException();
        }

        public bool DevolverCapturaInfraganti()
        {
            return CapturaInfraganti;
        }
        public int DevolverCalidad()
        {
            return Calidad;
        }
        public int DevolverDuracion()
        {
            return Duracion;
        }
    }
}
