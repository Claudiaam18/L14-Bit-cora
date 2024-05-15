using System.ComponentModel;

class Program
{
    static void Main(string[]args)
    {
        int numeroMes;
        string entradaMes;
        string mesCadena;

        Console.WriteLine("Ejercicio 1: estructuras selectivas");
        Console.WriteLine("Ingrese un numero del 1 al 12 para mostrar el nombre del mes");
        entradaMes = Console.ReadLine();

        if(int.TryParse(entradaMes, out numeroMes))
        {
            Console.WriteLine($"Se convirtió '{entradaMes}' a '{numeroMes}'");
        }
        else
        {
            Console.WriteLine("Error: Ingrese un numero del 1 al 12");
        }
        Console.WriteLine(numeroMes);

        switch(numeroMes)
        {
            case 1:
                mesCadena = "Enero";
                //instrucciones
                 break; 
            case 2:
                mesCadena = "Febrero";
                break;
            case 3:
                mesCadena = "Marzo";
                break;
            case 4:
                mesCadena = "Abril";
                break;
            case 5:
                mesCadena = "Mayo";
                break;
            case 6:
                mesCadena = "Junio";
                break;
            case 7:
                mesCadena = "Julio";
                break;
            case 8:
                mesCadena = "Agosto";
                break;
            case 9:
                mesCadena = "Septiembre";
                break;
            case 10:
                mesCadena = "Octubre";
                break;
            case 11:
                mesCadena = "Noviembre";
                break;
            case 12:
                mesCadena = "Diciembre";
                break;
            default:
                mesCadena = "";
                Console.WriteLine("Error: Debe ingresar numeros del 1 al 12");
                break;
        }
        Console.WriteLine($"Mes: '{mesCadena}'");

        Console.WriteLine("Ejercicio 2: estructuras selectivas");
        int a,b,c;

        Console.WriteLine("Ingrese 3 números mayores a 0");
        int.TryParse(Console.ReadLine(), out a);
        int.TryParse(Console.ReadLine(), out b);
        int.TryParse(Console.ReadLine(), out c);

        if(a>b)
        {
            if (a>c)
            {
            Console.WriteLine($"RESULTADO: el número mayor es: '{a}'");
            }
            else if (a==c)
            {
                Console.WriteLine($"RESULTADO: '{a}' y '{c}' son iguales");
            }
            else
            {
                if (c>a)
                {
                    Console.WriteLine($"RESULTADO: el número mayor es: '{c}'");
                }
            }
        }
        else if (a==b)
        {
            if (a>c)
            {
                Console.WriteLine($"RESULTADO: '{a}' y '{b}' son iguales");
            }
            else if (a==c)
            {
                Console.WriteLine($"RESULTADO: los números '{a}' y '{c}' son iguales");
            }
            else
            {
                if (c>a)
                {
                    Console.WriteLine($"RESULTADO: el número mayor es: '{c}'");
                }
            }
        }
        else
        {
            if (b>c)
            {
                Console.WriteLine($"RESULTADO: el número mayor es '{b}'");
            }
            else if (b==c)
            {
                Console.WriteLine($"RESULTADO: '{b}' y '{c}' son iguales");
            }
            else
            {
                if (c>b)
                {
                    Console.WriteLine($"RESULTADO: el número mayor es '{c}'");
                }
            }
        }
        Console.WriteLine("T7 CM 1127224");
        //nacimiento
        int año;
        string mes;
        int diacumple;

        Console.WriteLine("Ingrese su año de nacimiento");
        año = int.Parse( Console.ReadLine());
        Console.WriteLine("Ingrese su mes de nacimiento en minusculas");
        mes = Console.ReadLine();
        Console.WriteLine("Ingrese el día de su nacimiento");
        diacumple = int.Parse( Console.ReadLine());

         switch(mes)
        {
            case "enero":
                if(diacumple>=1 && diacumple<=19)
                {
                    Console.WriteLine("Capricornio");
                }
                if(diacumple>=20 && diacumple<=31)
                {
                    Console.WriteLine("Acuario");
                }
                //instrucciones
                 break; 
            case "febrero":
                if(diacumple>=1 && diacumple<=18)
                {
                    Console.WriteLine("Acuario");
                }
                if(diacumple>=19 && diacumple<=29)
                {
                    Console.WriteLine("Piscis");
                }
                break;
            case "marzo":
                if(diacumple>=1 && diacumple<=20)
                {
                    Console.WriteLine("Piscis");
                }
                if(diacumple>=21 && diacumple<31)
                {
                    Console.WriteLine("Aries");
                }
                break;
            case "abril":
                if(diacumple>=1 && diacumple<=19)
                {
                    Console.WriteLine("Aries");
                }
                if(diacumple>=19 && diacumple<=31)
                {
                    Console.WriteLine("Tauro");
                }
                //instrucciones
                 break; 
            case "mayo":
                if(diacumple>=1 && diacumple<=20)
                {
                    Console.WriteLine("Acuario");
                }
                if(diacumple>=21 && diacumple<=31)
                {
                    Console.WriteLine("Geminis");
                }
                break;
            case "junio":
                if(diacumple>=1 && diacumple<=20)
                {
                    Console.WriteLine("Geminis");
                }
                if(diacumple>=21 && diacumple<=31)
                {
                    Console.WriteLine("Cancer");
                }
                break;
            case "julio":
                if(diacumple>=1 && diacumple<=22)
                {
                    Console.WriteLine("Cancer");
                }
                if(diacumple>=23 && diacumple<=31)
                {
                    Console.WriteLine("Leo");
                }
                //instrucciones
                 break; 
            case "agosto":
                if(diacumple>=1 && diacumple<=22)
                {
                    Console.WriteLine("Leo");
                }
                if(diacumple>=23 && diacumple<=31)
                {
                    Console.WriteLine("Virgo");
                }
                break;
            case "septiembre":
                if(diacumple>=1 && diacumple<=22)
                {
                    Console.WriteLine("Virgo");
                }
                if(diacumple>=23 && diacumple<=31)
                {
                    Console.WriteLine("Libra");
                }
                break;
            case "octubre":
                if(diacumple>=1 && diacumple<=22)
                {
                    Console.WriteLine("Libra");
                }
                if(diacumple>=23 && diacumple<=31)
                {
                    Console.WriteLine("Escropio");
                }
                //instrucciones
                 break; 
            case "noviembre":
                if(diacumple>=1 && diacumple<=21)
                {
                    Console.WriteLine("Escorpio");
                }
                if(diacumple>=22 && diacumple<=31)
                {
                    Console.WriteLine("Sagitario");
                }
                //instrucciones
                 break; 
            case "diciembre":
                if(diacumple>=1 && diacumple<=21)
                {
                    Console.WriteLine("Sagitario");
                }
                if(diacumple>=22 && diacumple<=31)
                {
                    Console.WriteLine("Capricornio");
                }
                break;
            default:
                Console.WriteLine("Error: Debe ingresar un mes o en minuscula ");
                break;
        }
    }
    }