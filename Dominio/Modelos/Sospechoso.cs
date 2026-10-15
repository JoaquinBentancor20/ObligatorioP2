using Dominio.Enums;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    /// Clase que representa una persona sospechosa en una investigación
    public class Sospechoso : IValidable
    {
        private static int _ultimoId = 0;

        private int Id { get;}
        private string Nombre { get; set; }
        private string Cedula { get; set; }
        private DateTime FechaDeNacimiento { get; set; }
        private bool Antecedentes { get; set; }

        /// Constructor que inicializa un sospechoso con sus datos
        public Sospechoso(string nombre, string cedula, DateTime fechaDeNacimiento, bool antecedentes)
        {
            Id = ++_ultimoId;
            Nombre = nombre;
            Cedula = cedula;
            FechaDeNacimiento = fechaDeNacimiento;
            Antecedentes = antecedentes;
        }

        /// Valida todos los campos del sospechoso
        public virtual void Validar() 
        {
        validarC();
            validarN();
            ValidarAntecedente();
            ValidarFecha();
        }

        public override string ToString()
        {
            return $"{Nombre} - CI: {Cedula} - Fecha de Nacimiento: {FechaDeNacimiento}";
        }

        /// Valida que el nombre no esté vacío
        private void validarN()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El campo del nombre no puede estar vacio");
            }
        }

        /// Valida que la cédula no esté vacía
        private void validarC()
        {
            if (String.IsNullOrEmpty(Cedula))
            {
                throw new Exception("El campo de cedula no puede estar vacio");
            }
        }

        /// Valida que los antecedentes no sean nulos
        private void ValidarAntecedente()
        {
            if (Antecedentes == null)
            {
                throw new Exception("Antecedentes no puede estar vacio");
            }
        }

        /// Valida que la fecha de nacimiento no sea futura
        private void ValidarFecha()
        {
            if (FechaDeNacimiento > DateTime.Now)
            {
                throw new Exception("La fecha de nacimiento no puede ser mayor a la actual");
            }
        }

        public override bool Equals(object? obj)
        {
            Sospechoso s= (Sospechoso)obj;
            return Cedula == s.Cedula;
        }

        /// Devuelve la cédula del sospechoso
        public string DevolverCedula()
        {
            return Cedula;
        }

        /// Devuelve el nombre del sospechoso
        public string DevolverNombre()
        {
            return Nombre;
        }

        /// Devuelve si el sospechoso tiene antecedentes
        public bool DevolverAntecedentes()
        {
            return Antecedentes;
        }

        /// Devuelve la fecha de nacimiento del sospechoso
        public DateTime DevolverFecha()
        {
            return FechaDeNacimiento;
        }

        /// Devuelve la fecha de nacimiento del sospechoso (alias)
        public DateTime DevolverFechaNacimiento()
        {
            return FechaDeNacimiento;
        }
    }
}
