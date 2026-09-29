using Dominio.Enums;
using Dominio.Interefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Investigador : IValidacion
    {
        private static int _UltimoId = 0;
        public int Id { get; }

        public string Nombre { get; set; }
        public string Email { get; set; }

        public string Contrasena { get; set; }

        public Rol Rol { get; set; }

        public Investigador(string nombre, string email, string contrasena, Rol rol)
        {
            Id = ++_UltimoId;
            Nombre = nombre;
            Email = email;
            Contrasena = contrasena;
            Rol = rol;
        }

        public void Validar() { }

        public override string ToString()
        {
            return $"{Nombre} ({Email} - {Rol})";
        }

    }
}
