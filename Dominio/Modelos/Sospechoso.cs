using Dominio.Enums;
using Dominio.Interefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Sospechoso : IValidacion
    {
        private static int _ultimoId = 0;

        public int Id { get;}
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public bool Antecedentes { get; set; }

        public Sospechoso(string nombre, string cedula, DateTime fechaDeNacimiento, bool antecedentes)
        {
            Id = ++_ultimoId;
            Nombre = nombre;
            Cedula = cedula;
            FechaDeNacimiento = fechaDeNacimiento;
            Antecedentes = antecedentes;
        }

        public void Validar() { }

        public override string ToString()
        {
            return $"{Nombre} - CI: {Cedula})";
        }

        public void validarN()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El campo del nombre no puede estar vacio");
            }
        }
     
        public void validarC()
        {
            if (String.IsNullOrEmpty(Cedula))
            {
                throw new Exception("El campo de cedula no puede estar vacio");
            }
        }
        public void ValidarAntecedente()
        {
            if (Antecedentes == null)
            {
                throw new Exception("Antecedentes no puede estar vacio");
            }
        }
        public void ValidarFecha()
        {
            if (FechaDeNacimiento > DateTime.Now)
            {
                throw new Exception("La fecha de nacimiento no puede ser mayor a la actual");
            }
        }
    }
}
