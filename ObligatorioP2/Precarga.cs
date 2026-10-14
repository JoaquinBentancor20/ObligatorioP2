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
        // INVESTIGADORES DETECTIVES
        Investigador i1 = new Investigador ("Juan Perez","juan.perez@gmail.com","Obliga123!", Rol.Detective);
        sistema.AltaInvestigador(i1);
        Investigador i2 = new Investigador("Martin Palermo", "PalermoM@gmail.com", "Obliga123!", Rol.Detective);
        sistema.AltaInvestigador(i2);

        Investigador i3 = new Investigador(
            "Carlos Fernandez", "carlos.fernandez@gmail.com", "Obliga123!", Rol.Detective);

        Investigador i4 = new Investigador(
            "Lucia Gonzalez", "lucia.gonzalez@gmail.com", "Obliga123!", Rol.Detective);

        Investigador i5 = new Investigador(
            "Diego Martinez", "diego.martinez@gmail.com", "Obliga123!", Rol.Detective);


        // INVESTIGADORES FISCALES

        Investigador i6 = new Investigador(
            "Ana Silva", "ana.silva@gmail.com", "Obliga123!", Rol.Fiscal);

        Investigador i7 = new Investigador(
            "Pablo Torres", "pablo.torres@gmail.com", "Obliga123!", Rol.Fiscal);

        Investigador i8 = new Investigador(
            "Sofia Castro", "sofia.castro@gmail.com", "Obliga123!", Rol.Fiscal);

        Investigador i9 = new Investigador(
            "Martin Lopez", "martin.lopez@gmail.com", "Obliga123!", Rol.Fiscal);

        Investigador i10 = new Investigador(
            "Valentina Diaz", "valentina.diaz@gmail.com", "Obliga123!", Rol.Fiscal);


        // ALTA DE INVESTIGADORES

        sistema.AltaInvestigador(i3);
        sistema.AltaInvestigador(i4);
        sistema.AltaInvestigador(i5);

        sistema.AltaInvestigador(i6);
        sistema.AltaInvestigador(i7);
        sistema.AltaInvestigador(i8);
        sistema.AltaInvestigador(i9);
        sistema.AltaInvestigador(i10);
    }
    private static void CargarSospechosos(Sistema sistema)
    {
        Sospechoso s1 = new Sospechoso("Roberto Suarez", "12345678", new DateTime(1985, 3, 12), true);
        Sospechoso s2 = new Sospechoso("Federico Ramos", "23456789", new DateTime(1990, 7, 22), false);
        Sospechoso s3 = new Sospechoso("Gabriela Mendez", "34567890", new DateTime(1978, 11, 5), true);
        Sospechoso s4 = new Sospechoso("Andres Pereira", "45678901", new DateTime(1995, 1, 18), false);
        Sospechoso s5 = new Sospechoso("Natalia Cabrera", "56789012", new DateTime(1988, 9, 30), false);

        Sospechoso s6 = new Sospechoso("Matias Romero", "67890123", new DateTime(1982, 4, 14), true);
        Sospechoso s7 = new Sospechoso("Camila Varela", "78901234", new DateTime(1998, 6, 9), false);
        Sospechoso s8 = new Sospechoso("Sebastian Acosta", "89012345", new DateTime(1975, 12, 2), true);
        Sospechoso s9 = new Sospechoso("Florencia Sosa", "90123456", new DateTime(1992, 2, 25), false);
        Sospechoso s10 = new Sospechoso("Nicolas Medina", "11234567", new DateTime(1986, 8, 17), true);

        Sospechoso s11 = new Sospechoso("Paula Olivera", "22345678", new DateTime(1994, 5, 11), false);
        Sospechoso s12 = new Sospechoso("Bruno Iglesias", "33456789", new DateTime(1980, 10, 7), true);
        Sospechoso s13 = new Sospechoso("Agustina Nuñez", "44567890", new DateTime(1997, 3, 21), false);
        Sospechoso s14 = new Sospechoso("Facundo Lima", "55678901", new DateTime(1983, 1, 29), true);
        Sospechoso s15 = new Sospechoso("Victoria Franco", "66789012", new DateTime(1991, 7, 16), false);

        sistema.AltaSospechoso(s1);
        sistema.AltaSospechoso(s2);
        sistema.AltaSospechoso(s3);
        sistema.AltaSospechoso(s4);
        sistema.AltaSospechoso(s5);
        sistema.AltaSospechoso(s6);
        sistema.AltaSospechoso(s7);
        sistema.AltaSospechoso(s8);
        sistema.AltaSospechoso(s9);
        sistema.AltaSospechoso(s10);
        sistema.AltaSospechoso(s11);
        sistema.AltaSospechoso(s12);
        sistema.AltaSospechoso(s13);
        sistema.AltaSospechoso(s14);
        sistema.AltaSospechoso(s15);


    }

    private static void CargarCasos(Sistema sistema)
    {
        List<Investigador> investigadores = sistema.ObtenerInvestigadores();
        List<Sospechoso> sospechosos = sistema.ObtenerSospechosos();

        Caso c1 = new Caso(
      "Robo en joyeria",
      "Robo de varias joyas durante la noche.",
      sospechosos[0],
      investigadores[0]
  );

        c1.AgregarEvidencia(new Fisica(
            new DateTime(2026, 1, 10),
            "Guante encontrado en la entrada.",
            true
        ));

        c1.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 1, 10),
            "Camara de seguridad.",
            true,
            8,
            120
        ));

        c1.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 1, 11),
            "Un vecino vio salir a una persona.",
            "Pedro Gomez",
            Credibilidad.Alto
        ));

        c1.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 1, 11),
            "Un comerciante escucho ruidos.",
            "Raul Perez",
            Credibilidad.Medio
        ));

        sistema.AltaCaso(c1);
    }


}