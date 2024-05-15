using System; // Importamos el espacio de nombres para usar la clase Console

namespace Proyecto_Pensamiento_Lab
{
}
    // Definimos la clase Cliente
    public class Cliente
    {
        public string Nombre { get; set; } // Propiedad para almacenar el nombre del cliente
        public string NIT { get; set; } // Propiedad para almacenar el NIT del cliente

        // Constructor de la clase Cliente
        public Cliente(string nombre, string nit)
        {
            Nombre = nombre; // Inicializa el nombre del cliente
            NIT = nit; // Inicializa el NIT del cliente
        }
    }

    // Definimos la clase Licuado
    public class Licuado
    {
        // Propiedades para el tipo de leche, precio, cantidad de azúcar, precio del azúcar, descuento de la leche y aumento del tamaño
        // get se utiliza para obtener el valor de una propiedad y set se utiliza para para asignar un valor a una propiedad.
        public string TipoLeche { get; set; }
        public double Precio { get; set; }
        public int CantidadAzucar { get; set; }
        public double PrecioAzucar { get; set; }
        public double DescuentoLeche { get; set; }
        public double AumentoTamaño { get; set; }
        public double PrecioFinal { get; set; }

        // Constructor de la clase Licuado
        public Licuado(string tipoLeche, double precio)
        {
            TipoLeche = tipoLeche; // Inicializa el tipo de leche
            Precio = precio; // Inicializa el precio del licuado
        }

        // Método para mostrar la información del licuado
        public void MostrarInformacion()
        {
            Console.WriteLine("\nInformación del licuado:");
            Console.WriteLine("Tipo de leche: " + TipoLeche);
            Console.WriteLine("Cantidad de azúcar: " + CantidadAzucar + " cucharaditas");
            Console.WriteLine("Precio del licuado: Q" + Precio);
        }

        // Método para agregar azúcar al licuado
        public void AgregarAzucar()
        {
            if (CantidadAzucar < 3)
            {
                Console.WriteLine("\nTipos de azúcar disponibles:");
                Console.WriteLine("1. Azúcar blanca (Q0.60 por cucharadita)");
                Console.WriteLine("2. Azúcar morena (Q0.40 por cucharadita)");
                Console.WriteLine("3. Suplemento de azúcar (Q0.90 por cucharadita)");
                Console.Write("Seleccione el tipo de azúcar a agregar (1-3): ");
                int tipoAzucar = int.Parse(Console.ReadLine());
                double[] preciosAzucar = { 0.60, 0.40, 0.90 };
                PrecioAzucar += preciosAzucar[tipoAzucar - 1];
                CantidadAzucar++;
                Console.WriteLine("Se agregó 1 cucharadita de azúcar al licuado.");
                Console.WriteLine("Total de azúcar agregada: " + CantidadAzucar + " cucharaditas de tipo " + (tipoAzucar == 1 ? "azúcar blanca" : (tipoAzucar == 2 ? "azúcar morena" : "suplemento")));
                Console.WriteLine("Total a cobrar por el azúcar: Q" + PrecioAzucar);
            }
            else
            {
                Console.WriteLine("No se puede agregar más azúcar, ya se alcanzó el límite de 3 cucharaditas.");
            }
        }

        // Método para modificar el tipo de leche del licuado
        public void ModificarLeche()
        {
            Console.WriteLine("\nTipos de leche disponibles:");
            Console.WriteLine("1. Sin leche (únicamente con agua)");
            Console.WriteLine("2. Leche deslactosada");
            Console.WriteLine("3. Leche entera");
            Console.WriteLine("4. Leche de soya");
            Console.Write("Seleccione el tipo de leche (1-4): ");
            int opcionLeche = int.Parse(Console.ReadLine());
            switch (opcionLeche)
            {
                case 1:
                    TipoLeche = "Sin leche";
                    DescuentoLeche = -3.00;
                    break;
                case 2:
                    TipoLeche = "Leche deslactosada";
                    DescuentoLeche = 0;
                    break;
                case 3:
                    TipoLeche = "Leche entera";
                    DescuentoLeche = 0;
                    break;
                case 4:
                    TipoLeche = "Leche de soya";
                    DescuentoLeche = -2.00;
                    break;
            }
            Console.WriteLine("Se ha modificado el tipo de leche del licuado a: " + TipoLeche);
        }

        // Método para aumentar el tamaño del licuado
        public void Agrandar()
        {
            if (AumentoTamaño == 0)
            {
                Precio *= 1.07;
                AumentoTamaño = 1;
                Console.WriteLine("El tamaño del licuado ha sido aumentado en un 7%.");
            }
            else
            {
                Console.WriteLine("No se puede agrandar el licuado más de una vez.");
            }
        }
    }