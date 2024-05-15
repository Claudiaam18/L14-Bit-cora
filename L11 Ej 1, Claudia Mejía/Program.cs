class Program
{
    static void Main(string[]args)
    {
        string opcion;
        Console.WriteLine("Menú de opciones");
        Console.WriteLine("a. Calcular Area de un triangulo");
        Console.WriteLine("b. Calcular Area de un cuadrado");
        Console.WriteLine("c. Calcular Area de un rectangulo");
        Console.WriteLine("d. Calcular Area de un circulo");
    
        opcion = (Console.ReadLine()+"");
        Operaciones objoperaciones = new Operaciones();

        switch (opcion)
        {
        case "a":
        Console.WriteLine("Ingrese base");
        double Base=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Altura");
        double Altura=double.Parse(Console.ReadLine());
        double Area= objoperaciones.obtenerAreaTriangulo(Base,Altura);
        Console.WriteLine(Area);
        break;
        case "b":
        Console.WriteLine("Ingrese lado");
        double lado=double.Parse(Console.ReadLine());
        double  Areac= objoperaciones.obtenerAreaCuadrado(lado);
        Console.WriteLine(Areac);
        break;
        case "c":
        Console.WriteLine("Ingrese base");
        double Baser=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Altura");
        double Alturar=double.Parse(Console.ReadLine());
        double Arear= objoperaciones.obtenerAreaTriangulo(Baser,Alturar);
        Console.WriteLine(Arear);
        break;
        case "d":
        Console.WriteLine("Radio");
        double radio=double.Parse(Console.ReadLine());
        double  Arearadio= objoperaciones.obtenerAreaCuadrado(radio);
        Console.WriteLine(Arearadio);
        break;
        }
    }
}