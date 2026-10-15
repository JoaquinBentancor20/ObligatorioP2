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
            4,
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


        // CASO 2
        Caso c2 = new Caso(
            "Hurto en comercio",
            "Hurto de mercaderia durante el horario comercial.",
            sospechosos[1],
            investigadores[1]
        );

        c2.AgregarEvidencia(new Fisica(
            new DateTime(2026, 2, 3),
            "Huella encontrada en el mostrador.",
            true
        ));

        c2.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 2, 3),
            "Grabacion de la camara del local.",
            true,
            5,
            90
        ));

        c2.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 2, 4),
            "Un empleado vio a una persona guardar mercaderia.",
            "Laura Martinez",
            Credibilidad.Alto
        ));

        c2.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 2, 4),
            "Un cliente escucho una discusion.",
            "Diego Perez",
            Credibilidad.Medio
        ));

        sistema.AltaCaso(c2);


        // CASO 3
        Caso c3 = new Caso(
            "Fraude empresarial",
            "Investigacion por movimientos financieros sospechosos.",
            sospechosos[2],
            investigadores[2]
        );

        c3.AgregarEvidencia(new Fisica(
            new DateTime(2026, 3, 5),
            "Documentos contables encontrados en una oficina.",
            false
        ));

        c3.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 3, 5),
            "Grabacion de una reunion empresarial.",
            false,
            5,
            240
        ));

        c3.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 3, 6),
            "Un empleado declaro sobre operaciones irregulares.",
            "Santiago Lopez",
            Credibilidad.Alto
        ));

        c3.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 3, 6),
            "Una secretaria aporto informacion sobre reuniones.",
            "Carolina Silva",
            Credibilidad.Medio
        ));

        sistema.AltaCaso(c3);


        // CASO 4
        Caso c4 = new Caso(
            "Robo de vehiculo",
            "Desaparicion de un vehiculo estacionado en la via publica.",
            sospechosos[3],
            investigadores[3]
        );

        c4.AgregarEvidencia(new Fisica(
            new DateTime(2026, 4, 7),
            "Fragmento de plastico encontrado junto al estacionamiento.",
            false
        ));

        c4.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 4, 7),
            "Camara de seguridad registra un vehiculo saliendo de la zona.",
            true,
            5,
            180
        ));

        c4.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 4, 8),
            "Un vecino vio a una persona cerca del vehiculo.",
            "Marcelo Diaz",
            Credibilidad.Alto
        ));

        c4.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 4, 8),
            "Un guardia escucho arrancar un motor durante la noche.",
            "Andres Silva",
            Credibilidad.Medio
        ));

        sistema.AltaCaso(c4);


        // CASO 5
        Caso c5 = new Caso(
            "Desaparicion de documentos",
            "Desaparicion de documentos importantes de una oficina.",
            sospechosos[4],
            investigadores[4]
        );

        c5.AgregarEvidencia(new Fisica(
            new DateTime(2026, 5, 9),
            "Carpeta vacia encontrada junto a un escritorio.",
            false
        ));

        c5.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 5, 9),
            "Grabacion del pasillo de la oficina.",
            false,
            4,
            150
        ));

        c5.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 5, 10),
            "Un trabajador vio a una persona salir con una carpeta.",
            "Natalia Torres",
            Credibilidad.Alto
        ));

        c5.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 5, 10),
            "Un companero noto movimientos inusuales.",
            "Federico Ramos",
            Credibilidad.Bajo
        ));

        sistema.AltaCaso(c5);


        // CASO 6
        Caso c6 = new Caso(
            "Robo en vivienda",
            "Robo de objetos de valor en una vivienda particular.",
            sospechosos[5],
            investigadores[0]
        );

        c6.AgregarEvidencia(new Fisica(
            new DateTime(2026, 6, 11),
            "Herramienta encontrada cerca de una ventana.",
            true
        ));

        c6.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 6, 11),
            "Camara exterior registra movimientos sospechosos.",
            true,
            5,
            200
        ));

        c6.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 6, 12),
            "Un vecino vio a una persona ingresar al patio.",
            "Gabriel Mendez",
            Credibilidad.Alto
        ));

        c6.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 6, 12),
            "Un repartidor observo un movimiento extraño.",
            "Pablo Castro",
            Credibilidad.Medio
        ));

        sistema.AltaCaso(c6);


        // CASO 7
        Caso c7 = new Caso(
            "Estafa informatica",
            "Denuncia por una transferencia bancaria no autorizada.",
            sospechosos[6],
            investigadores[1]
        );

        c7.AgregarEvidencia(new Fisica(
            new DateTime(2026, 7, 13),
            "Impresion de los movimientos bancarios denunciados.",
            false
        ));

        c7.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 7, 13),
            "Grabacion de seguridad de un cajero automatico.",
            false,
            5,
            100
        ));

        c7.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 7, 14),
            "La persona denunciante explico los movimientos de su cuenta.",
            "Veronica Suarez",
            Credibilidad.Alto
        ));

        c7.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 7, 14),
            "Un empleado informo sobre una consulta sospechosa.",
            "Ignacio Pereira",
            Credibilidad.Medio
        ));

        sistema.AltaCaso(c7);


        // CASO 8
        Caso c8 = new Caso(
            "Danos a propiedad",
            "Danos ocasionados en la fachada de un local comercial.",
            sospechosos[7],
            investigadores[2]
        );

        c8.AgregarEvidencia(new Fisica(
            new DateTime(2026, 8, 15),
            "Fragmentos de vidrio encontrados frente al local.",
            true
        ));

        c8.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 8, 15),
            "Camara del comercio registra la calle.",
            true,
            6,
            160
        ));

        c8.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 8, 16),
            "Un vecino escucho ruidos frente al comercio.",
            "Silvia Fernandez",
            Credibilidad.Alto
        ));

        c8.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 8, 16),
            "Un transeunte vio a una persona alejarse.",
            "Esteban Morales",
            Credibilidad.Bajo
        ));

        sistema.AltaCaso(c8);


        // CASO 9
        Caso c9 = new Caso(
            "Robo de obras de arte",
            "Desaparicion de varias obras de una galeria.",
            sospechosos[8],
            investigadores[3]
        );

        c9.AgregarEvidencia(new Fisica(
            new DateTime(2026, 9, 17),
            "Guante encontrado en una sala de exposicion.",
            true
        ));

        c9.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 9, 17),
            "Grabacion de la entrada de la galeria.",
            true,
            8,
            220
        ));

        c9.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 9, 18),
            "Un trabajador noto la ausencia de una obra.",
            "Daniela Romero",
            Credibilidad.Alto
        ));

        c9.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 9, 18),
            "Un visitante vio a una persona cerca de la salida.",
            "Mauricio Cabrera",
            Credibilidad.Medio
        ));

        sistema.AltaCaso(c9);


        // CASO 10
        Caso c10 = new Caso(
            "Allanamiento ilegal",
            "Ingreso no autorizado a una propiedad privada.",
            sospechosos[9],
            investigadores[4]
        );

        c10.AgregarEvidencia(new Fisica(
            new DateTime(2026, 10, 19),
            "Marca encontrada en la cerradura de la puerta.",
            true
        ));

        c10.AgregarEvidencia(new Grabacion(
            new DateTime(2026, 10, 19),
            "Grabacion de seguridad del acceso a la propiedad.",
            false,
            7,
            140
        ));

        c10.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 10, 20),
            "Un residente vio a una persona ingresar sin permiso.",
            "Claudia Medina",
            Credibilidad.Alto
        ));

        c10.AgregarEvidencia(new Testimoneo(
            new DateTime(2026, 10, 20),
            "Un vecino escucho ruidos dentro de la propiedad.",
            "Ricardo Varela",
            Credibilidad.Medio
        ));

        sistema.AltaCaso(c10);

    }


}