using Dominio.Enums;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Investigador : IValidable
    {
        private static int _UltimoId = 0;
        private int Id { get; }

        private string Nombre { get; set; }
        private string Email { get; set; }

        private string Contrasena { get; set; }

        private Rol Rol { get; set; }

        public Investigador(string nombre, string email, string contrasena, Rol rol)
        {
            Id = ++_UltimoId;
            Nombre = nombre;
            Email = email;
            Contrasena = contrasena;
            Rol = rol;
        }

        public void Validar() {
            validarN();
            validarE();
            validarC();
            ValidarRol();
        
        }

        public override string ToString()
        {
            return $"{Nombre} ({Email} - {Rol})";
        }

        private void validarN()
        {
            if (String.IsNullOrEmpty(Nombre))
            {
                throw new Exception ("El campo del nombre no puede estar vacio");
            }
        }
        private void validarE()
        {
            if (String.IsNullOrEmpty(Email))
            {
                throw new Exception("El campo del Email no puede estar vacio");
            }
        }
        private void validarC()
        {
            if (String.IsNullOrEmpty(Contrasena))
            {
                throw new Exception("El campo de contraseña no puede estar vacio");
            }
        }
        private void ValidarRol()
        {
            if (Rol ==null) {
                throw new Exception("Rol no puede estar vacio");
            }
        }
        public Rol DevolverRol()
        {
            return Rol;
        }   
        public string DevolverNombre()
        {
            return Nombre;
        }
        public string DevolverEmail()
        {
            return Email;
        }
       

    }
}
