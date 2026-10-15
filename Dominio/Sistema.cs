using Dominio.Interfaces;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Interfaces;

namespace Dominio
{
    /// Clase singleton que gestiona los datos del sistema y expone operaciones de alta, búsqueda y obtención de datos
    public class Sistema
    {
        private static Sistema _instancia;
        private List<Caso> _listaCasos { get; }

        private List<Investigador> _listaInvestigadores { get; }

        private List<Sospechoso> _listaSospechosos { get; }

        /// Constructor privado para inicializar las listas del sistema (patrón singleton)
        private Sistema()
        {
            _listaCasos = new List<Caso>();
            _listaInvestigadores = new List<Investigador>();
            _listaSospechosos = new List<Sospechoso>();
        }

        /// Propiedad que devuelve la instancia singleton del Sistema
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

        /// Devuelve la lista de todos los casos del sistema
        public List<Caso> ObtenerCasos()
        {
             return _listaCasos; 
        }

        /// Devuelve la lista de todos los investigadores del sistema
        public List<Investigador> ObtenerInvestigadores()
        {
            return _listaInvestigadores;
        }

        /// Devuelve la lista de todos los sospechosos del sistema
        public List<Sospechoso> ObtenerSospechosos()
        {
            return _listaSospechosos;
        }
        /// Valida un objeto que implementa IValidable
        public void ValidarObjeto(IValidable objeto)
        {
            if (objeto == null)
                throw new Exception("El objeto no puede ser null");

            objeto.Validar();
        }

        /// Registra un nuevo investigador en el sistema
        public void AltaInvestigador(Investigador investigador)
        {
            ValidarObjeto(investigador);
            _listaInvestigadores.Add(investigador);
        }

        /// Registra un nuevo sospechoso en el sistema
        public void AltaSospechoso(Sospechoso sospechoso)
        {
            ValidarObjeto(sospechoso);
            _listaSospechosos.Add(sospechoso);
        }

        /// Registra un nuevo caso en el sistema
        public void AltaCaso(Caso caso)
        {
            ValidarObjeto(caso);
            _listaCasos.Add(caso);
        }

      

        /// Obtiene todos los casos asignados a un investigador específico
        public List<Caso> ObtenerCasosPorInvestigador(Investigador investigador)
        {
            List<Caso> resultado = new List<Caso>();

            foreach (Caso c in _listaCasos)
            {
                Investigador casoInvestigador=c.DevolverInvestigador();
                if (casoInvestigador.DevolverEmail() == investigador.DevolverEmail())
                {
                    resultado.Add(c);
                }
            }
            return resultado;
        }

        /// Obtiene la lista de sospechosos que tienen antecedentes penales
        public List<Sospechoso> ObtenerSospechososConAntecedentes(Caso caso)
        {
            List<Sospechoso> resultado = new List<Sospechoso>();

            foreach (Sospechoso s in _listaSospechosos)
            {
                if (s.DevolverAntecedentes())
                {
                    resultado.Add(s);
                }

            }
            return resultado;

        }

        /// Busca un investigador por su correo electrónico
        public Investigador BuscarInvestigadorPorEmail(string email)
        {
            foreach (Investigador i in _listaInvestigadores)
            {
                if (i.DevolverEmail() == email)
                {
                    return i;
                }
            }
            return null;
        }

    }
}
