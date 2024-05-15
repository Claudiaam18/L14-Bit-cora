public class OperacionesMatrices
{
    public int[,] matriz = new int[0,0];
    int cantidadCols = 0;
    int cantidadFilas = 0;

    public OperacionesMatrices()
    {
    }

    public void CrearMatriz()
    {

        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
        cantidadFilas = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
        cantidadCols = Int32.Parse(Console.ReadLine());

        matriz = new int[cantidadFilas,cantidadCols];
    }

    public void IngresarDatosMatriz()
    {
        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                Console.WriteLine($"Ingrese valor para la posicion [{fila}][{columna}]");
                matriz[fila,columna] = Int32.Parse(Console.ReadLine());
            }
        }
    }  

    public int[,] MultiplicaciónMatrizEscalar(int escalar)
    {
        int[,] matrizMultiplicada  = new int[matriz.GetLength(0),matriz.GetLength(1)];

        //Ejemplos con dos for (hay más formas)
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                matrizMultiplicada[fila,columna] = matriz[fila,columna] * escalar;
            }
        }

        return matrizMultiplicada;
    }

    public void ImprimirMatriz(int [,]a)
    {
        //Ingrese código para imprimir matriz con tabulaciones y saltos de linea
        for (int i = 0; i < cantidadFilas; i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < cantidadCols; j++)
            {
                Console.Write(a[i,j]+ "\t");
            }
        }    
    }

    public void DevolverNumero(int NumeroBuscado)
    {
        for (int i = 0; i < cantidadFilas; i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < cantidadCols; j++)
            {
                if(matriz[i,j]== NumeroBuscado)
                {
                    Console.Write(i+","+j+"\t");
                }
            }
        } 
    }
    
    public void NumeroEntero()
    {  
       for (int i = 0; i < cantidadFilas; i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < cantidadCols; j++)
            {
                int residuo = matriz[i,j] %2;
                if(residuo == 0)
                {
                    Console.Write(matriz[i,j] + "\t");
                }
            }
        } 
    }
}
