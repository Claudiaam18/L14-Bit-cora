class Program
{
    static void Main(string[]args)
    {
        Automovil objAutomovil = new Automovil();

        //modelo
        Console.WriteLine("Ingrese el modelo del automóvil: ");
        int modelo = int.Parse(Console.ReadLine());
        objAutomovil.DefinirModelo(modelo);

        //precio
        Console.WriteLine("Ingrese el precio del automóvil: ");
        double precio = double.Parse(Console.ReadLine());
        objAutomovil.DefinirPrecio(precio);

        //marca
        Console.WriteLine("Ingrese la marca del automóvil: ");
        string marca = Console.ReadLine();
        objAutomovil.DefinirMarca(marca);

        //tipo de cambio
        Console.WriteLine("Ingrese el tipo de cambio de dólares del automóvil: ");
        double tipoCambio = double.Parse(Console.ReadLine());
        objAutomovil.DefinirTipoCambio(tipoCambio);

        //mostrar datos
        Console.WriteLine("Datos del automóvil: ");
        Console.WriteLine(objAutomovil.MostrarInformacion());

        //disponibilidad
        Console.WriteLine("Desea cambiar la disponibilidad (Disponibilidad actual: " + objAutomovil.MostrarDisponibilidad()+ "? : ");
        string respuestasDisponibilidad = Console.ReadLine();
        if (respuestasDisponibilidad == "si")
        {
            objAutomovil.CambiarDisponibilidad();
            Console.WriteLine("Disponibilidad actualizada: " + objAutomovil.MostrarDisponibilidad());
        }

        //descuento
        Console.Write("Ingrese el monto de descuento a aplicar: ");
        double descuento = double.Parse(Console.ReadLine());
        objAutomovil.AplicarDescuento(descuento);
        Console.WriteLine("Descuento aplicado. Precio con descuento: Q" + objAutomovil.precio());

        // Mostrar la información actualizada del automóvil
        Console.WriteLine("Información actualizada del automóvil:");
        Console.WriteLine(objAutomovil.MostrarInformacion());
    }
}