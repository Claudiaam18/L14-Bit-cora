class Program
{
    static void Main(string[]args)
    {
        string opcion;
        //objeto para ingresar a metodos
        Personaje personaje = new Personaje (0,0);

        do
        {
        Console.WriteLine("Menú de opciones");
        Console.WriteLine("Ingrese la opcion: ");
        Console.WriteLine("a: sube");
        Console.WriteLine("b: baja");
        Console.WriteLine("c: izqiuerda");
        Console.WriteLine("d: derecha");
        Console.WriteLine("e: salir");
        
        opcion = (Console.ReadLine()+"");

        switch(opcion)
        {
            case "a":
            personaje.MoverHaciaArriba(LeerCantidad("Arriba"));
            break;

            case "b":
            
            personaje.MoverHaciaAbajo(LeerCantidad("Abajo"));
            break;

            case "c":
            personaje.MoverHaciaIzquierda(LeerCantidad("Izquierda"));
            break;

            case "d":
            personaje.MoverHaciaDerecha(LeerCantidad("Derecha"));
            break;

            case "e":
            Console.WriteLine($"Coordenadas finales del personaje; ({personaje.GetX()} , {personaje.GetY()})");
            break;

            default:
            Console.WriteLine("Opcion no válida");
            break;

        }
        }while(opcion != "e");
    }

    static int LeerCantidad(string direccion)
    {
        Console.WriteLine($"Ingrese la cantidad a moverse: {direccion} ");
        int cantidad = int.Parse(Console.ReadLine());
        return cantidad;
    }
}