
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ObliProgramacion
{
    internal class Program
    {
        private static Sistema _sistema = new Sistema();


        static void Main(string[] args)
        {
            _sistema.PreCargarArticulos();
            _sistema.PreCargarAdministradores();
            _sistema.PreCargarClientes();
            _sistema.PreCargarListaDeArticulos();


            int ejercicio;
            do
            {

                Console.WriteLine("Menu:" +
                    "\n 1-Listado de todos los clientes." +
                    "\n 2-Dado un nombre de categoria listar todos los articulos de esa categoria." +
                    "\n 3-Alta de articulo." +
                    "\n 4-Dadas dos fechas, listar publicaciones." +
                    "\n 0-Para salir.");


                

                while (!int.TryParse(Console.ReadLine(), out ejercicio))
                {
                    Console.WriteLine("Debe ingresar un numero entre 0 y 4 ");
                }
                Console.Clear();
                switch (ejercicio)
                {
                    // Estructura de control que ejecuta una acción basada en el número ingresado
                    case 1:
                        
                        ListarClientes();
                        break;
                    case 2:
                        BuscarPorCategoria();
                        break;
                    case 3:
                        AltaArticulo();
                        break;
                    case 4:
                        BuscarPublicacionesPorFecha();
                        break;
                }
                // Continuar el bucle hasta que el usuario ingrese 0 para salir
            } while (ejercicio != 0);
        }

     
        public static void ListarClientes()
        {

            Console.WriteLine("La lista de clientes es:");
            List<Cliente> clientes = _sistema.ListarClientes();
            foreach (Cliente cliente in clientes)
            {

                Console.WriteLine(cliente.ToString());
            }


        }

        public static void BuscarPorCategoria()
        {
            Console.WriteLine("Escriba la categoria que desea listar los articulos:" +
                "\n 1- Maletas y Mochilas" +
                "\n 2- Organización de Equipaje" +
                "\n 3- Comodidad en el Viaje" +
                "\n 4- Artículos de Seguridad" +
                "\n 5- Tecnología para Viajeros" +
                "\n 6- Higiene Personal" +
                "\n 7- Artículos para Clima Cálido" +
                "\n 8- Artículos para Clima Frío" +
                "\n 9- Entretenimiento en el Viaje" +
                "\n 10- Accesorios para Aviones" +
                "\n 11- Hidratación y Alimentos" +
                "\n 12- Accesorios de Fotografía" +
                "\n 13- Artículos Impermeables" +
                "\n 14- Mochilas Técnicas" +
                "\n 15- Equipamiento para Camping" +
                "\n 16- Accesorios de Viaje para Niños" +
                "\n 17- Protección Solar");


            // Método que busca artículos por categoría y devuelve una lista de artículos que coinciden con la categoría especificada
            string categoria = Console.ReadLine();
            List<Articulo> articulos = _sistema.BuscarPorCategoria(categoria);


            if (articulos.Count == 0)
            {
                Console.WriteLine($"No se encontró la categoría: {categoria}");
                Console.ReadKey();
               
                Console.Clear();
            }
            else
            {
                foreach (Articulo articulo in articulos)
                {
                    Console.WriteLine(articulo.ToString());
                }
            }


            Console.ReadKey();
            Console.Clear();
            
        }
        public static void AltaArticulo()
        {
            Console.WriteLine("Nombre del articulo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Categoria del articulo");
            string categroia = Console.ReadLine();
            Console.WriteLine("Precio del articulo");

            decimal.TryParse(Console.ReadLine(), out decimal precio);

            try
            {
                Articulo articulo = new Articulo(nombre, categroia, precio);

                _sistema.AltaArticulo(articulo);
                ;
                Console.WriteLine("Articulo agregado correctamente");

                Console.WriteLine(articulo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo el error {ex.Message}");
            }
            Console.ReadKey();
            Console.Clear();
        }


        public static void BuscarPublicacionesPorFecha()


        {       
            
            Console.WriteLine("Por favor, ingrese una fecha (formato: dd/MM/yyyy):");

            string inputDesde = Console.ReadLine();
            DateTime Desde;
            if (DateTime.TryParseExact(inputDesde, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out Desde))
            {
                Console.WriteLine($"Fecha ingresada correctamente: {Desde.ToString("dd/MM/yyyy")}");
               
            }
            else
            {
                Console.WriteLine("Formato de fecha inválido. Inténtalo de nuevo.");
            }
            

            Console.WriteLine("Por favor, ingrese una fecha (formato: dd/MM/yyyy):");
            string inputHasta = Console.ReadLine();
            DateTime Hasta;
            
            if (DateTime.TryParseExact(inputHasta, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out Hasta))
            {
                Console.WriteLine($"Fecha ingresada correctamente: {Hasta.ToString("dd/MM/yyyy")}");
                
            }
            else
            {
                Console.WriteLine("Formato de fecha inválido. Inténtalo de nuevo.");
            }


            List<Publicacion> publicaciones = _sistema.BuscarPublicacionesPorFecha(Desde, Hasta);
            foreach (Publicacion item in publicaciones)
            {
                Console.WriteLine(item.ToString());
            }
        }



    }
      






}




