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

        public void Validar() 
        {
            ValidarD();
            ValidarE();
            ValidarEstado();
            ValidarFecha();
            ValidarI();
            ValidarInvestigador();
            ValidarS();
            ValidarN();
        }

        public override string ToString()
        {
            return $" Caso {Id} - {Nombre}";
        }

        public bool EstadoCaso()
        {
            if (Estado==false) 
            {
                return false;
            }
            return true;
        }
        public void ValidarInvestigador()
        {
            if (Investigador.Rol != Rol.Detective) 
            {
                throw new Exception("El rol del Investigador tiene que ser de detective");
            }
        }
        public void ValidarN()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("Nombre del caso no puede estar vacio");
            }
        }
        public void ValidarD()
        {
            if (String.IsNullOrEmpty(Descripcion))
            {
                throw new Exception("La descripcion del caso no puede estar vacio");
            }
        }
        public void ValidarEstado()
        {
            if (Estado ==null)
            {
                throw new Exception("El estado del caso no puede ser null");
            }
        }
        public void ValidarS()
        {
            if (Sospechoso== null)
            {
                throw new Exception("Sospechoso no puede estar vacio");
            }
        }
        public void ValidarI()
        {
            if (Investigador == null)
            {
                throw new Exception("Investigador no puede estar vacio");
            }
        }
        public void ValidarE()
        {
            if (Evidencias == null)
            {
                throw new Exception("La lista de evidencias no puede estar vacia");
            }
        }
        public void ValidarFecha()
        {
            if (FechaCreacion!=DateTime.Now)
            {
                throw new Exception("La Fecha de creacion no puede ser distinta a la actual");
            }
        }
    }

}
