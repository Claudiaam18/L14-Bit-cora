using System.Reflection.Metadata;
using System.Security.Authentication;

class Program
{
    static void Main(string[]args)
    {
        int NFibonacci;
        bool conversionAint = false;
        bool nPositivo = false;
        int A = 0;
        int B = 1;
        int C = 0;
        int i = 2;
        int result;
        int n; 
        bool nn = false;

        do
        {
            Console.WriteLine("Ingrese un número mayor a 0");
            conversionAint = int.TryParse(Console.ReadLine(), out NFibonacci);
            if(conversionAint)
            {
                if(NFibonacci>0)
                {
                    nPositivo = true;
                }
            }
        }
        while (!conversionAint || !nPositivo);

        Console.WriteLine("");
        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("");
        nn = int.TryParse(Console.ReadLine(), out n);
        Console.WriteLine("Ingrese un número mayor a 0");

        if(n>0)
        {
            result=A;
            Console.WriteLine(result);
            if(n>1)
            {
                result=B;
                Console.WriteLine(result);

                while(i<n)
                {
                    C=A+B;
                    result=C;
                    A=B;
                    B=C;
                    i=i+1;
                    Console.WriteLine(result);
                }
            }

        }
            Console.WriteLine("");
            Console.WriteLine("Tarea 7, CMML 1127224");
            int N;
            double cc = 1;
            double resultado;
            double resultado2 = 0;

            double d = 1;
            double resultado3;
            double resultado4 = 0;

            int x;
            int a;
            int k = 0;
            double resultado5 = 0;
            double resultado6 = 0;
            Console.WriteLine("Ingrese un número mayor a 0:");
            N = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Paso a: ");
            do
            {
                Console.Write($"1/{cc}+");
                resultado = 1/cc;
                resultado2 = resultado2+resultado;

                cc++;
            } while (cc<=N);
            Console.WriteLine("Resultado: " + resultado2);

            Console.WriteLine("Paso b: ");
            do
            {
                Console.Write($"1/2^{d}+");
                resultado3 = 1/Math.Pow(2,d);
                resultado4 = resultado4+resultado3;

                d++;
            } while(d<=n);
            Console.WriteLine("Resultado: "+ resultado4);

            Console.WriteLine("Paso c: ");
            Console.WriteLine("Ingrese un número entero mayor a 0 para x:");
            x=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número entero mayor a 0 para a:");
            a=Int32.Parse(Console.ReadLine());

            do
            {
                resultado5 = (Math.Pow(x,k))*(Math.Pow(A,(N-k)));
                resultado6 = resultado6 + resultado5;

                k++;
            } while(k<=N);
            Console.WriteLine("Resultado: "+resultado6);

    }
}