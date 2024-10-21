using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliProgramacion
{
    public class Sistema
    {

        //Listas 
        private List<Articulo> _listaDeArticulos = new List<Articulo>();
        private List<Cliente> _listaDeCliente = new List<Cliente>();
        private List<Administrador> _listaDeAdministradores = new List<Administrador>();
        private List<Publicacion> _listaDePublicaciones = new List<Publicacion>();
        private List<Oferta> _ListaDeOfertas = new List<Oferta>();
        private List<Venta> _ListaDeVentas = new List<Venta>();

        //Precargar clientes 
        public void PreCargarClientes()
        {
            Console.Clear();
            Cliente cliente1 = new Cliente("Mateo", "González", "mateo.gonzalez@gmail.com", "Usuario123", 1000);
            Cliente cliente2 = new Cliente("Carla", "Ramírez", "carla.ramirez@gmail.com", "Usuario123", 1000);
            Cliente cliente3 = new Cliente("Lucas", "Fernández", "lucas.fernandez@gmail.com", "Usuario123", 1000);
            Cliente cliente4 = new Cliente("Sofía", "Martínez", "sofia.martinez@gmail.com", "Usuario123", 1000);
            Cliente cliente5 = new Cliente("Daniel", "López", "daniel.lopez@gmail.com", "Usuario123", 1000);
            Cliente cliente6 = new Cliente("Laura", "Torres", "laura.torres@gmail.com", "Usuario123", 1000);
            Cliente cliente7 = new Cliente("María", "Hernández", "maria.hernandez@gmail.com", "Usuario123", 1000);
            Cliente cliente8 = new Cliente("Juan", "Pérez", "juan.perez@gmail.com", "Usuario123", 1000);
            Cliente cliente9 = new Cliente("Andrés", "Gómez", "andres.gomez@gmail.com", "Usuario123", 1000);
            Cliente cliente10 = new Cliente("Lucía", "Díaz", "lucia.diaz@gmail.com", "Usuario123", 1000);

            _listaDeCliente = new List<Cliente> { cliente1,cliente2,cliente3,cliente4,cliente5,
                cliente6,cliente7, cliente8,cliente9,cliente10 };


        }
        //Metodo que valida y agrega el cliente a una lista de clientes 
        public void AltaCliente(Cliente nuevoCliente)
        {
            nuevoCliente.Validar();
            _listaDeCliente.Add(nuevoCliente);
        }


        //Precarga de usuarios administardores 
        public void PreCargarAdministradores()
        {
            Administrador administrador1 = new Administrador("Rocio", "Rodriguez", "rorodriguez@gmail.com", "Admi123");
            Administrador administrador2 = new Administrador("Carolina", "Mendez", "carolinamendez@gmail.com", "Admi123");
            _listaDeAdministradores = new List<Administrador> { administrador1, administrador2 };
        }

        //Precargar articulos 
        public void PreCargarArticulos()
        {

            // Categoría: Maletas y Mochilas
            Articulo articulo01 = new Articulo("Maleta de Cabina Rígida", "Maletas y Mochilas", 80);
            Articulo articulo02 = new Articulo("Mochila de Viaje 30L", "Maletas y Mochilas", 45);
            Articulo articulo03 = new Articulo("Bolso de Mano con Ruedas", "Maletas y Mochilas", 65);

            // Categoría: Organización de Equipaje
            Articulo articulo04 = new Articulo("Set de Cubos Organizadores (6 piezas)", "Organización de Equipaje", 25);
            Articulo articulo05 = new Articulo("Neceser de Viaje Impermeable", "Organización de Equipaje", 15);
            Articulo articulo06 = new Articulo("Bolsa de Zapatos para Viaje (2 piezas)", "Organización de Equipaje", 12);

            // Categoría: Comodidad en el Viaje
            Articulo articulo07 = new Articulo("Cojín de Cuello de Espuma", "Comodidad en el Viaje", 20);
            Articulo articulo08 = new Articulo("Antifaz para Dormir con Tapones para Oídos", "Comodidad en el Viaje", 8);
            Articulo articulo09 = new Articulo("Manta de Viaje Compacta", "Comodidad en el Viaje", 18);

            // Categoría: Artículos de Seguridad
            Articulo articulo10 = new Articulo("Candado TSA con Combinación", "Artículos de Seguridad", 12);
            Articulo articulo11 = new Articulo("Cinturón Oculto para Dinero", "Artículos de Seguridad", 18);
            Articulo articulo12 = new Articulo("Cinturón con Bolsillo Secreto", "Artículos de Seguridad", 25);

            // Categoría: Tecnología para Viajeros
            Articulo articulo13 = new Articulo("Adaptador de Corriente Universal", "Tecnología para Viajeros", 25);
            Articulo articulo14 = new Articulo("Cargador Portátil (10,000mAh)", "Tecnología para Viajeros", 30);
            Articulo articulo15 = new Articulo("Auriculares con Cancelación de Ruido", "Tecnología para Viajeros", 50);

            // Categoría: Higiene Personal
            Articulo articulo16 = new Articulo("Kit de Higiene de Viaje (Mini)", "Higiene Personal", 10);
            Articulo articulo17 = new Articulo("Toalla de Microfibra de Secado Rápido", "Higiene Personal", 15);
            Articulo articulo18 = new Articulo("Botella Reutilizable para Jabón y Shampoo (Set de 4)", "Higiene Personal", 8);

            // Categoría: Artículos para Clima Cálido
            Articulo articulo19 = new Articulo("Sombrero de Ala Ancha Plegable", "Artículos para Clima Cálido", 20);
            Articulo articulo20 = new Articulo("Gafas de Sol Polarizadas", "Artículos para Clima Cálido", 35);
            Articulo articulo21 = new Articulo("Protector Solar en Barra (50ml)", "Artículos para Clima Cálido", 10);

            // Categoría: Artículos para Clima Frío
            Articulo articulo22 = new Articulo("Guantes Térmicos Touchscreen", "Artículos para Clima Frío", 25);
            Articulo articulo23 = new Articulo("Bufanda de Lana Merina", "Artículos para Clima Frío", 30);
            Articulo articulo24 = new Articulo("Gorro de Lana Plegable", "Artículos para Clima Frío", 15);

            // Categoría: Entretenimiento en el Viaje
            Articulo articulo25 = new Articulo("Kindle (E-reader) con Luz Integrada", "Entretenimiento en el Viaje", 100);
            Articulo articulo26 = new Articulo("Altavoz Bluetooth Portátil", "Entretenimiento en el Viaje", 40);
            Articulo articulo27 = new Articulo("Libro de Pasatiempos para Viaje", "Entretenimiento en el Viaje", 12);

            // Categoría: Accesorios para Aviones
            Articulo articulo28 = new Articulo("Máscara Hidratante para Avión", "Accesorios para Aviones", 10);
            Articulo articulo29 = new Articulo("Tapa Ocular con Gel Relajante", "Accesorios para Aviones", 15);
            Articulo articulo30 = new Articulo("Calcetines de Compresión para Viaje", "Accesorios para Aviones", 20);

            // Categoría: Hidratación y Alimentos
            Articulo articulo31 = new Articulo("Botella Reutilizable de Agua con Filtro", "Hidratación y Alimentos", 25);
            Articulo articulo32 = new Articulo("Termo de Acero Inoxidable (500ml)", "Hidratación y Alimentos", 30);
            Articulo articulo33 = new Articulo("Caja de Snacks Saludables para Viaje", "Hidratación y Alimentos", 15);

            // Categoría: Accesorios de Fotografía
            Articulo articulo34 = new Articulo("Trípode Compacto para Cámara o Teléfono", "Accesorios de Fotografía", 35);
            Articulo articulo35 = new Articulo("Funda Impermeable para Cámaras", "Accesorios de Fotografía", 20);
            Articulo articulo36 = new Articulo("Kit de Lentes para Teléfono (3 en 1)", "Accesorios de Fotografía", 25);

            // Categoría: Artículos Impermeables
            Articulo articulo37 = new Articulo("Poncho Impermeable Compacto", "Artículos Impermeables", 12);
            Articulo articulo38 = new Articulo("Funda Impermeable para Teléfono", "Artículos Impermeables", 15);
            Articulo articulo39 = new Articulo("Bolsa Impermeable para Ropa", "Artículos Impermeables", 20);

            // Categoría: Mochilas Técnicas
            Articulo articulo40 = new Articulo("Mochila para Escalada 50L", "Mochilas Técnicas", 80);
            Articulo articulo41 = new Articulo("Mochila de Hidratación 15L", "Mochilas Técnicas", 50);
            Articulo articulo42 = new Articulo("Mochila de Senderismo con Bastón", "Mochilas Técnicas", 65);

            // Categoría: Equipamiento para Camping
            Articulo articulo43 = new Articulo("Tienda de Campaña Ultraligera", "Equipamiento para Camping", 120);
            Articulo articulo44 = new Articulo("Saco de Dormir 4 Estaciones", "Equipamiento para Camping", 60);
            Articulo articulo45 = new Articulo("Colchoneta Inflable para Camping", "Equipamiento para Camping", 45);

            // Categoría: Accesorios de Viaje para Niños
            Articulo articulo46 = new Articulo("Maleta Infantil con Ruedas", "Accesorios de Viaje para Niños", 50);
            Articulo articulo47 = new Articulo("Cojín de Cuello Infantil", "Accesorios de Viaje para Niños", 15);
            Articulo articulo48 = new Articulo("Juego de Entretenimiento para Viaje", "Accesorios de Viaje para Niños", 25);

            // Categoría: Protección Solar
            Articulo articulo49 = new Articulo("Sombrero de Paja Plegable", "Protección Solar", 30);
            Articulo articulo50 = new Articulo("Camisa UV de Secado Rápido", "Protección Solar", 40);
            Articulo articulo51 = new Articulo("Lentes de Sol con Protección UV", "Protección Solar", 25);

            // metodo valida y agrega el nuevo articulo

            AltaArticulo(articulo01);
            AltaArticulo(articulo02);
            AltaArticulo(articulo03);
            AltaArticulo(articulo04);
            AltaArticulo(articulo05);
            AltaArticulo(articulo06);
            AltaArticulo(articulo07);
            AltaArticulo(articulo08);
            AltaArticulo(articulo09);
            AltaArticulo(articulo10);

            AltaArticulo(articulo11);
            AltaArticulo(articulo12);
            AltaArticulo(articulo13);
            AltaArticulo(articulo14);
            AltaArticulo(articulo15);
            AltaArticulo(articulo16);
            AltaArticulo(articulo17);
            AltaArticulo(articulo18);
            AltaArticulo(articulo19);
            AltaArticulo(articulo20);

            AltaArticulo(articulo21);
            AltaArticulo(articulo22);
            AltaArticulo(articulo23);
            AltaArticulo(articulo24);
            AltaArticulo(articulo25);
            AltaArticulo(articulo26);
            AltaArticulo(articulo27);
            AltaArticulo(articulo28);
            AltaArticulo(articulo29);
            AltaArticulo(articulo30);

            AltaArticulo(articulo31);
            AltaArticulo(articulo32);
            AltaArticulo(articulo33);
            AltaArticulo(articulo34);
            AltaArticulo(articulo35);
            AltaArticulo(articulo36);
            AltaArticulo(articulo37);
            AltaArticulo(articulo38);
            AltaArticulo(articulo39);
            AltaArticulo(articulo40);

            AltaArticulo(articulo41);
            AltaArticulo(articulo42);
            AltaArticulo(articulo43);
            AltaArticulo(articulo44);
            AltaArticulo(articulo45);
            AltaArticulo(articulo46);
            AltaArticulo(articulo47);
            AltaArticulo(articulo48);
            AltaArticulo(articulo49);
            AltaArticulo(articulo50);



        }

        public List<Cliente> ListarClientes()
        {
            if (_listaDeCliente.Count == 0)
            {
                Console.WriteLine("No hay clientes disponibles.");
                return new List<Cliente>(); // Retorna una lista vacía
            }
         
            return _listaDeCliente;

        }
        // Método que busca artículos por categoría y devuelve una lista de artículos que coinciden con la categoría especificada
        public List<Articulo> BuscarPorCategoria(string categoria)
        {
            // Crear una lista vacía para almacenar los artículos que coincidan con la categoría
            List<Articulo> lista = new List<Articulo>();

            // Recorrer la lista de artículos existente
            for (int i = 0; i < _listaDeArticulos.Count; i++)
            {
                // Comprobar si la categoría del artículo actual coincide con la categoría buscada
                if (_listaDeArticulos[i].Categoria == categoria)
                {
                    // Si hay una coincidencia, añadir el artículo a la lista
                    lista.Add(_listaDeArticulos[i]);
                }
            }

            // Retornar la lista de artículos que coinciden con la categoría
            return lista;
        }

        //ALTA DE ARTICULO ////metodo que valida y agrega articulo a una lista de articulos 
        public void AltaArticulo(Articulo nuevoArticulo)
        {
            nuevoArticulo.Validar();
            _listaDeArticulos.Add(nuevoArticulo);
        }


        //PUBLICACIONES//

        public void PreCargarListaDeArticulos()

        {


            List<Oferta> listaDeOfertas = new List<Oferta>
           {
                 new Oferta(new Usuario("Juan", "Pérez", "juan.perez@example.com", "passwordJuan"), 1000, DateTime.Now),
                 new Oferta(new Usuario("Ana", "García", "ana.garcia@example.com", "passwordAna"), 1500, DateTime.Now.AddDays(-1)),
                 new Oferta(new Usuario("Carlos", "López", "carlos.lopez@example.com", "passwordCarlos"), 2000, DateTime.Now.AddDays(-2)),
                 new Oferta(new Usuario("María", "Fernández", "maria.fernandez@example.com", "passwordMaria"), 2500, DateTime.Now.AddDays(-3)),
                 new Oferta(new Usuario("José", "Rodríguez", "jose.rodriguez@example.com", "passwordJose"), 3000, DateTime.Now.AddDays(-4))
           };





            //Lista de artículos para una publicación
            List<Articulo> listaDeArticulos1 = new List<Articulo>
            {

            _listaDeArticulos[2],
            _listaDeArticulos[3]
            };


            List<Articulo> listaDeArticulos2 = new List<Articulo>

           {
             _listaDeArticulos[4],
             _listaDeArticulos[5],
             _listaDeArticulos[6],

           };

            List<Articulo> listaDeArticulos3 = new List<Articulo>
            {
             _listaDeArticulos[7],
             _listaDeArticulos[8],
             _listaDeArticulos[9],
            };


            List<Articulo> listaDeArticulos4 = new List<Articulo>
            {
             _listaDeArticulos[10],
             _listaDeArticulos[11],
             _listaDeArticulos[12],
            };
            List<Articulo> listaDeArticulos5 = new List<Articulo>
            {
             _listaDeArticulos[13],
             _listaDeArticulos[14],
             _listaDeArticulos[15],
            };
            List<Articulo> listaDeArticulos6 = new List<Articulo>
            {
             _listaDeArticulos[16],
             _listaDeArticulos[17],
             _listaDeArticulos[18],
            };
            List<Articulo> listaDeArticulos7 = new List<Articulo>
            {
             _listaDeArticulos[19],
             _listaDeArticulos[20],
             _listaDeArticulos[21],
            };
            List<Articulo> listaDeArticulos8 = new List<Articulo>
            {
             _listaDeArticulos[22],
             _listaDeArticulos[23],
             _listaDeArticulos[24],
            };
            List<Articulo> listaDeArticulos9 = new List<Articulo>
            {
             _listaDeArticulos[25],
             _listaDeArticulos[26],
             _listaDeArticulos[27],
            };
            List<Articulo> listaDeArticulos10 = new List<Articulo>
            {
             _listaDeArticulos[28],
             _listaDeArticulos[29],
             _listaDeArticulos[30],
            };
            List<Articulo> listaDeArticulos11 = new List<Articulo>
            {
             _listaDeArticulos[31],
             _listaDeArticulos[32],
             _listaDeArticulos[33],
            };
            List<Articulo> listaDeArticulos12 = new List<Articulo>
            {
             _listaDeArticulos[34],
             _listaDeArticulos[35],

            };

            List<Articulo> listaDeArticulos13 = new List<Articulo>
            {
             _listaDeArticulos[36],
             _listaDeArticulos[37],
            };
            List<Articulo> listaDeArticulos14 = new List<Articulo>
            {

             _listaDeArticulos[38],
             _listaDeArticulos[39],
            };
            List<Articulo> listaDeArticulos15 = new List<Articulo>
            {
             _listaDeArticulos[40],
             _listaDeArticulos[41],

            };

            List<Articulo> listaDeArticulos16 = new List<Articulo>
            {

             _listaDeArticulos[42],
             _listaDeArticulos[43],
            };
            List<Articulo> listaDeArticulos17 = new List<Articulo>
            {

             _listaDeArticulos[44],
             _listaDeArticulos[45],

            };
            List<Articulo> listaDeArticulos18 = new List<Articulo>
            {
             _listaDeArticulos[46],
             _listaDeArticulos[47],

            };
            List<Articulo> listaDeArticulos19 = new List<Articulo>
            {
             _listaDeArticulos[48],
             _listaDeArticulos[49],
            };
            List<Articulo> listaDeArticulos20 = new List<Articulo>
           {
             _listaDeArticulos[0],
            _listaDeArticulos[1],
            };

          



            // Crear instancias de Venta con un nuevo Cliente y un nuevo Administrador
            Venta venta1 = new Venta("Venta 1", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                     new Cliente("NombreCliente1", "ApellidoCliente1", "cliente1@example.com", "password1", 2),
                                     new Administrador("Admin1", "ApellidoAdmin1", "admin1@example.com", "passwordAdmin1"),
                                     DateTime.Today, false, listaDeArticulos1);

            Venta venta2 = new Venta("Venta 2", Estado.ABIERTA, new DateTime(2024, 10, 06),
                                     new Cliente("NombreCliente2", "ApellidoCliente2", "cliente2@example.com", "password2", 2),
                                     new Administrador("Admin2", "ApellidoAdmin2", "admin2@example.com", "passwordAdmin2"),
                                     DateTime.Today, false, listaDeArticulos2);

            Venta venta3 = new Venta("Venta 3", Estado.ABIERTA, new DateTime(2024, 10, 05),
                                     new Cliente("NombreCliente3", "ApellidoCliente3", "cliente3@example.com", "password3", 2),
                                     new Administrador("Admin3", "ApellidoAdmin3", "admin3@example.com", "passwordAdmin3"),
                                     DateTime.Today, false, listaDeArticulos3);

            Venta venta4 = new Venta("Venta 4", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                     new Cliente("NombreCliente4", "ApellidoCliente4", "cliente4@example.com", "password4", 2),
                                     new Administrador("Admin4", "ApellidoAdmin4", "admin4@example.com", "passwordAdmin4"),
                                     DateTime.Today, false, listaDeArticulos4);

            Venta venta5 = new Venta("Venta 5", Estado.ABIERTA, new DateTime(2024, 10, 06),
                                     new Cliente("NombreCliente5", "ApellidoCliente5", "cliente5@example.com", "password5", 2),
                                     new Administrador("Admin5", "ApellidoAdmin5", "admin5@example.com", "passwordAdmin5"),
                                     DateTime.Today, false, listaDeArticulos5);

            Venta venta6 = new Venta("Venta 6", Estado.ABIERTA, new DateTime(2024, 10, 05),
                                     new Cliente("NombreCliente6", "ApellidoCliente6", "cliente6@example.com", "password6", 2),
                                     new Administrador("Admin6", "ApellidoAdmin6", "admin6@example.com", "passwordAdmin6"),
                                     DateTime.Today, false, listaDeArticulos6);

            Venta venta7 = new Venta("Venta 7", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                     new Cliente("NombreCliente7", "ApellidoCliente7", "cliente7@example.com", "password7", 2),
                                     new Administrador("Admin7", "ApellidoAdmin7", "admin7@example.com", "passwordAdmin7"),
                                     DateTime.Today, false, listaDeArticulos7);

            Venta venta8 = new Venta("Venta 8", Estado.ABIERTA, new DateTime(2024, 10, 06),
                                     new Cliente("NombreCliente8", "ApellidoCliente8", "cliente8@example.com", "password8", 2),
                                     new Administrador("Admin8", "ApellidoAdmin8", "admin8@example.com", "passwordAdmin8"),
                                     DateTime.Today, false, listaDeArticulos8);

            Venta venta9 = new Venta("Venta 9", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                     new Cliente("NombreCliente9", "ApellidoCliente9", "cliente9@example.com", "password9", 2),
                                     new Administrador("Admin9", "ApellidoAdmin9", "admin9@example.com", "passwordAdmin9"),
                                     DateTime.Today, false, listaDeArticulos9);

            Venta venta10 = new Venta("Venta 10", Estado.ABIERTA, new DateTime(2024, 10, 05),
                                     new Cliente("NombreCliente10", "ApellidoCliente10", "cliente10@example.com", "password10", 2),
                                     new Administrador("Admin10", "ApellidoAdmin10", "admin10@example.com", "passwordAdmin10"),
                                     DateTime.Today, false, listaDeArticulos10);

            // Crear instancias de Subasta con un nuevo Cliente y un nuevo Administrador
            Subasta subasta1 = new Subasta("Subasta 1", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente11", "ApellidoCliente11", "cliente11@example.com", "password11", 2),
                                           new Administrador("Admin11", "ApellidoAdmin11", "admin11@example.com", "passwordAdmin11"),
                                           DateTime.Today, listaDeArticulos11, listaDeOfertas);

            Subasta subasta2 = new Subasta("Subasta 2", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente12", "ApellidoCliente12", "cliente12@example.com", "password12", 2),
                                           new Administrador("Admin12", "ApellidoAdmin12", "admin12@example.com", "passwordAdmin12"),
                                           DateTime.Today, listaDeArticulos12, listaDeOfertas);

            Subasta subasta3 = new Subasta("Subasta 3", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente13", "ApellidoCliente13", "cliente13@example.com", "password13", 2),
                                           new Administrador("Admin13", "ApellidoAdmin13", "admin13@example.com", "passwordAdmin13"),
                                           DateTime.Today, listaDeArticulos13, new List<Oferta>());

            Subasta subasta4 = new Subasta("Subasta 4", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente14", "ApellidoCliente14", "cliente14@example.com", "password14", 2),
                                           new Administrador("Admin14", "ApellidoAdmin14", "admin14@example.com", "passwordAdmin14"),
                                           DateTime.Today, listaDeArticulos14, new List<Oferta>());

            Subasta subasta5 = new Subasta("Subasta 5", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente15", "ApellidoCliente15", "cliente15@example.com", "password15", 2),
                                           new Administrador("Admin15", "ApellidoAdmin15", "admin15@example.com", "passwordAdmin15"),
                                           DateTime.Today, listaDeArticulos15, new List<Oferta>());

            Subasta subasta6 = new Subasta("Subasta 6", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente16", "ApellidoCliente16", "cliente16@example.com", "password16", 2),
                                           new Administrador("Admin16", "ApellidoAdmin16", "admin16@example.com", "passwordAdmin16"),
                                           DateTime.Today, listaDeArticulos16, new List<Oferta>());

            Subasta subasta7 = new Subasta("Subasta 7", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente17", "ApellidoCliente17", "cliente17@example.com", "password17", 2),
                                           new Administrador("Admin17", "ApellidoAdmin17", "admin17@example.com", "passwordAdmin17"),
                                           DateTime.Today, listaDeArticulos17, new List<Oferta>());

            Subasta subasta8 = new Subasta("Subasta 8", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente18", "ApellidoCliente18", "cliente18@example.com", "password18", 2),
                                           new Administrador("Admin18", "ApellidoAdmin18", "admin18@example.com", "passwordAdmin18"),
                                           DateTime.Today, listaDeArticulos18, new List<Oferta>());

            Subasta subasta9 = new Subasta("Subasta 9", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente19", "ApellidoCliente19", "cliente19@example.com", "password19", 2),
                                           new Administrador("Admin19", "ApellidoAdmin19", "admin19@example.com", "passwordAdmin19"),
                                           DateTime.Today, listaDeArticulos19, new List<Oferta>());

            Subasta subasta10 = new Subasta("Subasta 10", Estado.ABIERTA, new DateTime(2024, 10, 07),
                                           new Cliente("NombreCliente20", "ApellidoCliente20", "cliente20@example.com", "password20", 2),
                                           new Administrador("Admin20", "ApellidoAdmin20", "admin20@example.com", "passwordAdmin20"),
                                           DateTime.Today, listaDeArticulos20, new List<Oferta>());


            AltaVenta(venta1);
            AltaVenta(venta2);
            AltaVenta(venta3);
            AltaVenta(venta4);
            AltaVenta(venta5);
            AltaVenta(venta6);
            AltaVenta(venta7);
            AltaVenta(venta8);
            AltaVenta(venta9);
            AltaVenta(venta10);

            AltaSubasta(subasta1);
            AltaSubasta(subasta2);
            AltaSubasta(subasta3);
            AltaSubasta(subasta4);
            AltaSubasta(subasta5);
            AltaSubasta(subasta6);
            AltaSubasta(subasta7);
            AltaSubasta(subasta8);
            AltaSubasta(subasta9);
            AltaSubasta(subasta10);
        }

        //Metdo que valida y agrega ventas a la lista de publicaciones
        public void AltaVenta(Venta nuevaVenta)
        {
            nuevaVenta.Validar();
            _listaDePublicaciones.Add(nuevaVenta);

        }
        //metodo que valida y agrega subastas a la lista de publicaciones 
        public void AltaSubasta(Subasta nuevaSubasta)
        {
            nuevaSubasta.Validar();
            _listaDePublicaciones.Add(nuevaSubasta);

        }


        //metodo que busca publicacion segun la fecha y retorna una lista con publicaicones 
        public List<Publicacion> BuscarPublicacionesPorFecha(DateTime Desde, DateTime Hasta)
        {

            List<Publicacion> listaPublicaciones = new List<Publicacion>();

            foreach (Publicacion item in _listaDePublicaciones)
            {
                if (item.FechaPublicacion >= Desde && item.FechaPublicacion <= Hasta)
                {
                    listaPublicaciones.Add(item);
                }
            }

            return listaPublicaciones;
        }


    }


}

