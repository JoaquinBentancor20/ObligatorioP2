using System;
using Dominio;
using Dominio.Modelos;
using Dominio.Enums;
public static class Precarga

{
    public static void CargarDatos(Sistema sistema)
    {
        CargarInvestigadores(sistema);
        CargarSospechosos(sistema);
        CargarCasos(sistema);
    }

    private static void CargarInvestigadores(Sistema sistema)
    {
        Investigador i1 = new Investigador ('Juan Perez', 'juan.perez@example.com','Clave123!', Rol.Detective);
        sistema.AltaInvestigador(i1);
    }
    private static void CargarSospechosos(Sistema sistema)
    {
    
    }

    private static void CargarCasos(Sistema sistema)
    {
        //crear lista de investigadores tipo detective
    }


}