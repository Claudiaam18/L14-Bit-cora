class program
{
    static void Main(string[]args)
    {
        int opcion = 0;
        string entrada;

        do
        {
        Console.WriteLine("Menú");
        Console.WriteLine("1) Sumatoria");
        Console.WriteLine("2) Factorial");
        Console.WriteLine("3) Tablas");
        Console.WriteLine("4) Salida");
        Console.WriteLine("Ingrese un número 1-4");
        entrada = Console.ReadLine();
        try
        {
            opcion = int.Parse(entrada);
        }
        catch(FormatException)
        {
            Console.WriteLine("Error, ingrese un número");
        }
        
        switch(opcion)
        {
            case 1:
                Console.WriteLine("Ingrese un número positivo");
                string entradanumero = Console.ReadLine();
                int n = 0;

                try
                {
                    n = int.Parse(entradanumero);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, ingrese un número");
                }

                int i = 1;
                int sumatoria = 0;
                while(i<= n)
                {
                    sumatoria +=i;
                    i++;
                }
                
                Console.WriteLine($"Sumatoria: '{sumatoria}'");
                break;

            case 2:
                Console.WriteLine("Ingrese un número positivo");
                string entradanumero2 = Console.ReadLine();
                int n2 = 0;

                try
                {
                    n2 = int.Parse(entradanumero2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, ingrese un número");
                }

                int i2 = 1;
                int factorial = 1;
                while(i2<= n2)
                {
                    factorial *=i2;
                    i2++;
                }
                
                Console.WriteLine($"Factorial: '{factorial}'");
                break;

            case 3:
                string titulo = "\t";
                for(int i3 = 1; i3<=10; i3++)
                {
                    titulo += i3 + "\t";
                }
                Console.WriteLine(titulo);
                
                string fila = "";
                for(int ifila = 1; ifila<=10; ifila++)
                {
                    fila = ifila + "\t";
                    for(int multiplo = 1; multiplo<=10; multiplo++)
                    {
                        fila += ifila * multiplo + "\t";
                    }
                    Console.WriteLine(fila);
                }
                break;

            case 4:
                break;
        }
        } while (opcion!=4);
        
    }
}