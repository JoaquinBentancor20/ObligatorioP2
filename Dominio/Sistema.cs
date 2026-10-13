using Dominio.Interfaces;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Interfaces;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema _instancia;
        private List<Caso> _listaCasos { get; }

        private List<Investigador> _listaInvestigadores { get; }

        private List<Sospechoso> _listaSospechosos { get; }

        private Sistema()
        {
            _listaCasos = new List<Caso>();
            _listaInvestigadores = new List<Investigador>();
            _listaSospechosos = new List<Sospechoso>();
        }

        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }
        }

        public List<Caso> ObtenerCasos()
        {
             return _listaCasos; 
        }

        public List<Investigador> ObtenerInvestigadores()
        {
            return _listaInvestigadores;
        }

        public List<Sospechoso> ObtenerSospechosos()
        {
            return _listaSospechosos;
        }
        public void ValidarObjeto(IValidable objeto)
        {
            if (objeto == null)
                throw new Exception("El objeto no puede ser null");

            objeto.Validar();
        }

        public void AltaInvestigador(Investigador investigador)
        {
            ValidarObjeto(investigador);
            _listaInvestigadores.Add(investigador);
        }

        public void AltaSospechoso(Sospechoso sospechoso)
        {
            ValidarObjeto(sospechoso);
            _listaSospechosos.Add(sospechoso);
        }

        public void AltaCaso(Caso caso)
        {
            ValidarObjeto(caso);
            _listaCasos.Add(caso);
        }

      

        public List<Caso> ObtenerCasosPorInvestigador(Investigador investigador)
        {
            List<Caso> resultado = new List<Caso>();

            foreach (Caso c in _listaCasos)
            {
                if (c.Investigador == investigador)
                {
                    resultado.Add(c);
                }
            }
            return resultado;
        }

        public List<Sospechoso> ObtenerSospechososConAntecedentes(Caso caso)
        {
            List<Sospechoso> resultado = new List<Sospechoso>();

            foreach (Sospechoso s in _listaSospechosos)
            {
                if (s.Antecedentes)
                {
                    resultado.Add(s);
                }

            }
            return resultado;

        }

    }
}
