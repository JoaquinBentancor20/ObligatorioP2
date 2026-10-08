using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Modelos;

namespace Dominio
{
    public class Sistema
    {
      public List<Caso> _listaCasos { get; } = new List<Caso>();

        public void ValidarObjeto(IValidacion objeto)
 {
     if (objeto == null) 
         throw new Exception("El objeto no puede ser null");

     objeto.Validar();
 
 }
    }
}
