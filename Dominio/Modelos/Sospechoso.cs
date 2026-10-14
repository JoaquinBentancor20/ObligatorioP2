using Dominio.Enums;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Sospechoso : IValidable
    {
        private static int _ultimoId = 0;

        private int Id { get;}
        private string Nombre { get; set; }
        private string Cedula { get; set; }
        private DateTime FechaDeNacimiento { get; set; }
        private bool Antecedentes { get; set; }

        public Sospechoso(string nombre, string cedula, DateTime fechaDeNacimiento, bool antecedentes)
        {
            Id = ++_ultimoId;
            Nombre = nombre;
            Cedula = cedula;
            FechaDeNacimiento = fechaDeNacimiento;
            Antecedentes = antecedentes;
        }

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

        private void validarN()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El campo del nombre no puede estar vacio");
            }
        }
     
        private void validarC()
        {
            if (String.IsNullOrEmpty(Cedula))
            {
                throw new Exception("El campo de cedula no puede estar vacio");
            }
        }
        private void ValidarAntecedente()
        {
            if (Antecedentes == null)
            {
                throw new Exception("Antecedentes no puede estar vacio");
            }
        }
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

        public string DevolverCedula()
        {
            return Cedula;
        }
        public string DevolverNombre()
        {
            return Nombre;
        }
        public bool DevolverAntecedentes()
        {
            return Antecedentes;
        }
        public DateTime DevolverFecha()
        {
            return FechaDeNacimiento;
        }
        public DateTime DevolverFechaNacimiento()
        {
            return FechaDeNacimiento;
        }
    }
}
