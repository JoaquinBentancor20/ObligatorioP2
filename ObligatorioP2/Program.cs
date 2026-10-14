using Dominio;
using Dominio.Modelos;
using Dominio.Enums;

namespace ObligatorioP2
{ 

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sistema sistema = Sistema.Instancia;
                Precarga.CargarDatos(sistema);

                MostrarMenu(sistema);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.ReadKey();
            }
        }

        static void MostrarMenu(Sistema sistema)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("a) Listar todos los casos con sus evidencias");
                Console.WriteLine("b) Buscar casos por email del investigador");
                Console.WriteLine("c) Dar de alta un sospechoso");
                Console.WriteLine("d) Listar sospechosos con antecedentes");
                Console.WriteLine("e) Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "a":
                        ListarCasosConEvidencias(sistema);
                        break;
                    case "b":
                        BuscarCasosPorInvestigador(sistema);
                        break;
                    case "c":
                        AltaSospechoso(sistema);
                        break;
                    case "d":
                        ListarSospechososConAntecedentes(sistema);
                        break;
                    case "e":
                        continuar = false;
                        Console.WriteLine("\nChau.");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ListarCasosConEvidencias(Sistema sistema)
        {
            Console.Clear();
            Console.WriteLine("Casos con Evidencias\n");

            List<Caso> casos = sistema.ObtenerCasos();

            if (casos.Count == 0)
            {
                Console.WriteLine("No hay casos registrados.");
            }
            else
            {
                foreach (Caso caso in casos)
                {
                    Console.WriteLine($"ID: {caso.ToString()}");

                    if (caso.DevolverEvidencias().Count == 0)
                    {
                        Console.WriteLine("  - Sin evidencias");
                    }
                    else
                    {
                        foreach (Evidencia evidencia in caso.DevolverEvidencias())
                        {
                            Console.WriteLine($"  Evidencia ID: {evidencia.ToString()}");
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Presione cualquier tecla para volver al menu");
            Console.ReadKey();
        }


        //Buscar casos por email del investigador
        static void BuscarCasosPorInvestigador(Sistema sistema)
        {
            Console.Clear();
            Console.WriteLine("Listar Casos por Investigador\n");
            Console.Write("Ingrese el email del investigador: ");
            string email = Console.ReadLine();

            Investigador investigador = sistema.BuscarInvestigadorPorEmail(email);

            if (investigador == null)
            {
                Console.WriteLine("\nInvestigador no encontrado.");
            }
            else
            {
                List<Caso> casos = sistema.ObtenerCasosPorInvestigador(investigador);

                if (casos.Count == 0)
                {
                    Console.WriteLine($"\nEl investigador {investigador} no tiene casos asignados.");
                }
                else
                {
                    Console.WriteLine($"\nCasos del investigador {investigador}:\n");
                    foreach (Caso caso in casos)
                    {
                        Investigador inv = caso.DevolverInvestigador();
                        Console.WriteLine($"ID: {caso.ToString()}, Investigador: {inv.DevolverNombre()}");
                    }
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para volver al menu");
            Console.ReadKey();
        }


        //Alta Sospechoso

        static void AltaSospechoso(Sistema sistema)
        {
            Console.Clear();
            Console.WriteLine("Alta Sospechoso\n");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Cédula: ");
            string cedula = Console.ReadLine();

            Console.Write("Fecha de nacimiento (YYYY-MM-DD): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                Console.WriteLine("Fecha no válida.");
                Console.ReadKey();
                return;
            }

            Console.Write("¿Tiene antecedentes? (s/n): ");
            bool antecedentes = Console.ReadLine()?.ToLower() == "s";

            try
            {
                Sospechoso sospechoso = new Sospechoso(nombre, cedula, fechaNacimiento, antecedentes);
                sistema.AltaSospechoso(sospechoso);
                Console.WriteLine("\nSospechoso registrado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al registrar el sospechoso: {ex.Message}");
            }

            Console.WriteLine("Presione cualquier tecla para volver al menu");
            Console.ReadKey();
        }




        //Listar sospechosos con antecedentes
        static void ListarSospechososConAntecedentes(Sistema sistema)
        {
            Console.Clear();
            Console.WriteLine("Sospechosos con antecendentes \n");

            List<Sospechoso> sospechosos = sistema.ObtenerSospechosos();
            List<Sospechoso> conAntecedentes = new List<Sospechoso>();

            foreach (Sospechoso s in sospechosos)
            {
                if (s.DevolverAntecedentes())
                {
                    conAntecedentes.Add(s);
                }
            }

            if (conAntecedentes.Count == 0)
            {
                Console.WriteLine("No hay sospechosos con antecedentes.");
            }
            else
            {
                foreach (Sospechoso sospechoso in conAntecedentes)
                {
                    Console.WriteLine(sospechoso.ToString());
                    Console.WriteLine($"Antecedentes: Sí");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Presione cualquier tecla para volver al menu");
            Console.ReadKey();
        }
    }

}
    

