using Dominio.Enums;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Caso : IValidable
    {
        private static int _ultimoId = 0;

        private int Id { get; }
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private bool Estado { get; set; }
        private Sospechoso Sospechoso { get; set; }
        private Investigador Investigador { get; set; }
        private List<Evidencia> Evidencias { get; }
        private DateTime FechaCreacion { get; set; }

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

        public void AgregarEvidencia(Evidencia evidencia)

        {
            if (evidencia == null)
            {
                throw new Exception("El objeto no puede estar vacio");
            }
            Evidencias.Add(evidencia);
        }

        public virtual void Validar()
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
           return Estado;
        }
        private void ValidarInvestigador()
        {
            Investigador i=DevolverInvestigador();
            if (i.DevolverRol() != Rol.Detective)
            {
                throw new Exception("El rol del Investigador tiene que ser de detective");
            }
        }
        private void ValidarN()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("Nombre del caso no puede estar vacio");
            }
        }
        private void ValidarD()
        {
            if (String.IsNullOrEmpty(Descripcion))
            {
                throw new Exception("La descripcion del caso no puede estar vacio");
            }
        }
        private void ValidarEstado()
        {
            if (Estado == null)
            {
                throw new Exception("El estado del caso no puede ser null");
            }
        }
        private void ValidarS()
        {
            if (Sospechoso == null)
            {
                throw new Exception("Sospechoso no puede estar vacio");
            }
        }
        private void ValidarI()
        {
            if (Investigador == null)
            {
                throw new Exception("Investigador no puede estar vacio");
            }
        }
        private void ValidarE()
        {
            if (Evidencias == null)
            {
                throw new Exception("La lista de evidencias no puede estar vacia");
            }
        }
        private void ValidarFecha()
        {

            if (FechaCreacion > DateTime.Now) 

            {
                throw new Exception("La Fecha de creacion no puede ser distinta a la actual");
            }
        }
        public void AltaEvidencia(Evidencia evidencia)
        {

            AgregarEvidencia(evidencia);
        }

        public int DevolverID()
        {
            return Id;
        }

        public string DevolverNombre()
        {
            return Nombre;
        }

        public string DevolverDescripcion()
        {
            return Descripcion;
        }

        public List<Evidencia> DevolverEvidencias()
        {
            return Evidencias;
        }

        public Sospechoso DevolverSospechoso()
        {
            return Sospechoso;
        }

     

        public Investigador DevolverInvestigador()
        {
            return Investigador;
        }

    }
}