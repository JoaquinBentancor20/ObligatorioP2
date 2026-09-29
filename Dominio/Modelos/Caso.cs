using Dominio.Enums;
using Dominio.Interefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Caso : IValidacion
    {
        private static int _ultimoId = 0;

        public int Id { get; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public Sospechoso Sospechoso { get; set; }
        public Investigador Investigador { get; set; }
        public List<Evidencia> Evidencias { get; }
        public DateTime FechaCreacion { get; set; }

        public Caso(string nombre, string descripcion, Sospechoso sospechoso, Investigador investigador)
        {
            Id = ++_ultimoId;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = false;
            Sospechoso = sospechoso;
            Investigador = investigador;
            Evidencias = new List<Evidencia>();
            FechaCreacion = DateTime.Now;
        }

        public void AgragarEvidencia(Evidencia evidencia)
        {
            Evidencias.Add(evidencia);
        }

        public void Validar() { }

        public override string ToString()
        {
            return $" Caso {Id} - {Nombre}";
        }

    }

}
