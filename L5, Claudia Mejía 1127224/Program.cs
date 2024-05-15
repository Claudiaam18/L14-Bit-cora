class Program
{
    static void Main(string[]args)
    {
        string nombre;
        
        Console.WriteLine("Ingrese su nombre");
        nombre=Console.ReadLine();
        Console.WriteLine("Hola "+nombre);

        Console.WriteLine("Parte 2: Ej 1 Operaciones aritmeticas");
        int numero1;
        int numero2;

        Console.WriteLine("Ingrese un numero1");
        numero1=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero2");
        numero2=Int32.Parse(Console.ReadLine());
        int result=numero1+numero2;
        int result2=numero1-numero2;
        int result3=numero1*numero2;
        int result4=numero1/numero2;
        int result5=numero1%numero2; //MOD

        Console.WriteLine("El resultado es: " +numero1+ "+" + numero2+ "=" + result);
        Console.WriteLine("El resultado es: " +numero1+ "-" + numero2+ "=" + result2);
        Console.WriteLine("El resultado es: " +numero1+ "*" + numero2+ "=" + result3);
        Console.WriteLine("El resultado es: " +numero1+ "/" + numero2+ "=" + result4);
        Console.WriteLine("El resultado es: " +numero1+ "%" + numero2+ "=" + result5);


        Console.WriteLine("Parte 2: Ej 2 Operaciones booleanas");
        if(numero1>numero2)
         {
            Console.WriteLine(numero1 +">" +numero2 +"= Verdadero"+" Es mayor "+numero1);
        }
        else
        {
            Console.WriteLine(numero1 +">" +numero2 +"= Falso"+" Es menor "+ numero1);
        }
  
        if(numero1<numero2)
        {
            Console.WriteLine(numero1 +"<" +numero2 +"=Verdadero"+ " Es mayor "+ numero2);
        }
        else
        {
            Console.WriteLine(numero1 +"<" +numero2 +"=Falso"+" Es menor "+ numero2);
        }

        if(numero1==numero2)
        {
            Console.WriteLine(numero1 +"=" +numero2 +"= Son iguales");
        }
        else
        {
            Console.WriteLine(numero1 +"=" +numero2 +"= No son iguales");
        }

        
        Console.WriteLine("Parte 2: Ej 3 Jerarquia de operaciones");
        

        Console.WriteLine("Ingrese un numero a");
        int a =int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero b");
        int b =int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero c");
        int c = int.Parse(Console.ReadLine());

        int expresion1= (a*b)+c;
        int expresion2= a*(b+c);
        double expresion3= a/((double)b*c);
        double expresion4=((3*a)+(2*b))/((double)(c*c));

        Console.WriteLine("El resultado a*b+c es: " +expresion1);
        Console.WriteLine("El resultado a*(b+c) es: " +expresion2);
        Console.WriteLine("El resultado a/b*c es: " +expresion3);
        Console.WriteLine("El resultado (3a+2b)/(c*c) es: " +expresion4);

        Console.WriteLine("Parte 2: Ej 4 Expresion cuadratica");
        double d=((b*b)-4*a*c); 
        double ecm=0;
        double ecr=0;
        double resultado = Math.Sqrt(d);
        if(a!=0 && d>=0)  
        {
            ecm=(-b+resultado)/(2*a);
            ecr=(-b-resultado)/(2*a);
            Console.WriteLine(ecm+" y "+ecr);
        }
        else
        {
            if(a==0) 
            {
                Console.WriteLine("Error a no puede ser 0");
            }
            if(d<0) 
            {
                Console.WriteLine("Error el resultado dentro de la raiz es negativo");
            }
        }


    }
}