class Program
{
    static void Main(string[]args)
    {
        //objeto 1
        HelloWorld objetoHellow = new HelloWorld("Hola desde el menú");

        Console.WriteLine(objetoHellow.ObtenerSaludo());
        objetoHellow.Saludar();

        objetoHellow.definirnombre("Claudia");

        Console.WriteLine(objetoHellow.ObtenerSaludo()+objetoHellow.obtenernombre());

        //objeto 2
        HelloWorld helloWorld2 = new HelloWorld("Hola 2");
        Console.WriteLine(helloWorld2.obtenerSaludo());

        //objeto 3
        Calculadora objCalculadora = new Calculadora(1,2);
        Console.WriteLine(objCalculadora.suma());
    }
}