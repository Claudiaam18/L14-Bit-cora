class Program
{
    Circulo objRadio = new Circulo();

    static double Perimetro(string Radio)
    {
        Console.WriteLine($"Ingrese el perimetro {Radio}");
        double radioP = int.Parse(Console.ReadLine());
        return radioP;
    }

    static double Area(string Radio)
    {
        Console.WriteLine($"Ingrese el perimetro {Radio}");
        double radioA = int.Parse(Console.ReadLine());
        return radioA;
    }

    static double Volumen(string Radio)
    {
        Console.WriteLine($"Ingrese el perimetro {Radio}");
        double radioV = int.Parse(Console.ReadLine());
        return radioV;
    }
}