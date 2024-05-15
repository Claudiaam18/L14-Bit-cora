using System;
// Clase principal Program que contiene el método Main
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la máquina dispensadora de licuados de Kevin y Claudia.");
            Console.Write("Por favor, ingrese su nombre: ");
            string nombreCliente = Console.ReadLine();
            Console.Write("¿Desea ingresar su NIT? (S/N): ");
            string opcionNIT = Console.ReadLine().ToUpper();
            string nitCliente = "";
            if (opcionNIT == "S")
            {
                Console.Write("Ingrese su NIT: ");
                nitCliente = Console.ReadLine();
            }

            Cliente cliente = new Cliente(nombreCliente, nitCliente); // Instancia un objeto de la clase Cliente
            Licuado licuado = new Licuado("Leche deslactosada", 20.00); // Instancia un objeto de la clase Licuado

            bool terminado = false; // Variable para controlar si el pedido ha sido confirmado
            DateTime inicio = DateTime.Now; // Almacena la fecha y hora de inicio del pedido
            while (!terminado)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Ver información del licuado");
                Console.WriteLine("2. Agregar azúcar");
                Console.WriteLine("3. Modificar leche");
                Console.WriteLine("4. Agrandar");
                Console.WriteLine("5. Confirmar pedido");
                Console.Write("Por favor, seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        licuado.MostrarInformacion();
                        break;
                    case 2:
                        licuado.AgregarAzucar();
                        break;
                    case 3:
                        licuado.ModificarLeche();
                        break;
                    case 4:
                        licuado.Agrandar();
                        break;
                    case 5:
                        Console.WriteLine("\nConfirmación del pedido:");
                        Console.WriteLine("Cliente: " + cliente.Nombre);
                        if (opcionNIT == "S")
                            Console.WriteLine("NIT: " + cliente.NIT);
                        Console.WriteLine("Fecha y hora de inicio: " + inicio);
                        Console.WriteLine("Fecha y hora de finalización: " + DateTime.Now);
                        licuado.MostrarInformacion();
                        Console.WriteLine("Total a cobrar por el licuado: Q" + (licuado.Precio + licuado.PrecioAzucar + licuado.DescuentoLeche));
                        Console.WriteLine("¡Su pedido ha sido confirmado! Gracias por su compra.");
                        terminado = true; // Marca el pedido como confirmado y finaliza el ciclo
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
