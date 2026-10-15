using Dominio.Enums;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    /// Clase que representa un investigador en el sistema
    public class Investigador : IValidable
    {
        private static int _UltimoId = 0;
        private int Id { get; }

        private string Nombre { get; set; }
        private string Email { get; set; }

        private string Contrasena { get; set; }

        public Rol Rol { get; set; }

        /// Constructor que inicializa un investigador con sus datos
        public Investigador(string nombre, string email, string contrasena, Rol rol)
        {
            Id = ++_UltimoId;
            Nombre = nombre;
            Email = email;
            Contrasena = contrasena;
            Rol = rol;
        }

        /// Valida todos los campos del investigador
        public virtual void Validar() {
            validarN();
            validarE();
            validarC();
            ValidarRol();

        }

        public override string ToString()
        {
            return $"{Nombre} ({Email} - {Rol})";
        }

        /// Valida que el nombre no esté vacío
        private void validarN()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception ("El campo del nombre no puede estar vacio");
            }
        }

        /// Valida que el email no esté vacío
        private void validarE()
        {
            if (String.IsNullOrEmpty(Email))
            {
                throw new Exception("El campo del Email no puede estar vacio");
            }
        }

        /// Valida que la contraseña no esté vacía
        private void validarC()
        {
            if (String.IsNullOrEmpty(Contrasena))
            {
                throw new Exception("El campo de contraseña no puede estar vacio");
            }
        }

        /// </summary>
        private void ValidarRol()
        {
            if (Rol ==null) {
                throw new Exception("Rol no puede estar vacio");
            }
        }

        /// Devuelve el rol del investigador
        public Rol DevolverRol()
        {
            return Rol;
        }

        /// Devuelve el nombre del investigador
        public string DevolverNombre()
        {
            return Nombre;
        }

        /// Devuelve el email del investigador
        public string DevolverEmail()
        {
            return Email;
        }


    }
}
