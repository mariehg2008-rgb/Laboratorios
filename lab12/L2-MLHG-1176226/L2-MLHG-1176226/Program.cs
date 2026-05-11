using System;
class Program
{
    static int[,] numeros = new int[4, 4], A = new int[3, 2], B = new int[3, 2], diagonal = new int[5, 5];
    static float[,] numeroMayor = new float[3, 5];
    static void Main()
    {
        //EJERCICIO #1
        Console.WriteLine("EJERCICIO #1: LEER FILAS Y COLUMNAS");
        int filas = 4;
        int columnas = 4;
        llenarMatriz(ref numeros, filas, columnas);
        for (filas = 0; filas < 4; filas++)
        {
            for (columnas = 0; columnas < 4; columnas++)
            {
                Console.Write(numeros[filas, columnas] + "  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Ingrese el número de fila que quiere sumar (1-4)");
        int ff = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La suma de la fila " + ff + " es " + sumarf(numeros, ff));

        Console.WriteLine("Ingrese el número de columna que quiere sumar (1-4)");
        int cc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La suma de la columna " + cc + " es " + sumarc(numeros, cc));
        Console.WriteLine();

        //EJERCICIO #2
        Console.WriteLine("EJERCICIO #2: NÚMERO MAYOR");
        llenar(ref numeroMayor);
        float NM = numeroMayor[0, 0];
        for (filas = 0; filas < 3; filas++)
        {
            for (columnas = 0; columnas < 5; columnas++)
            {
                NM = numM(numeroMayor[filas, columnas], NM);
            }
        }
        Console.WriteLine("Número más grande de la matriz: " + NM);
        Console.WriteLine();

        //EJERCICIO #3
        Console.WriteLine("EJERCICIO #3: MULTIPLICACIÓN DE MATRICES");
        filas = 3;
        columnas = 2;
        llenarMatriz(ref A, filas, columnas);
        llenarMatriz(ref B, filas, columnas);
        int[,] C = multiplicar(A, B);
        for (filas = 0; filas < 3; filas++)
        {
            for (columnas = 0; columnas < 2; columnas++)
            {
                Console.Write(C[filas, columnas] + "   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //EJERCICIO #4
        Console.WriteLine("EJERCICIO #3: MULTIPLICACIÓN DE MATRICES");
        filas = 5;
        columnas = 5;
        llenarMatriz(ref diagonal, filas, columnas);
        Console.WriteLine("La suma de la diagonal principal es " + sumaD(diagonal));
        Console.WriteLine("La suma de la diagonal secundaria es " + sumaD2(diagonal));

    }
    static void llenarMatriz(ref int[,] matriz, int f, int c)//TRATE DE USAR UN MISMO PROCEDIMIENTO PARA LLENAR AMBAS MATRICES, PERO LA DIFERENCIA EN LOS TIPOS DE DATOS ME LO COMPLICA, POR LO QUE OPTE POR HACERLO EN DIFERENTES
    {
        Console.WriteLine("Ingrese los números a la matriz de " + f + "x" + c + ":");
        for (int filas = 0; filas < f; filas++)
        {
            Console.WriteLine("Usted esta llenando la fila No." + (filas + 1));
            for (int columnas = 0; columnas < c; columnas++)
            {
                matriz[filas, columnas] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static void llenar(ref float[,] matriz)
    {
        Console.WriteLine("Ingrese los números a la matriz 3x5: ");
        for (int filas = 0; filas < 3; filas++)
        {
            Console.WriteLine("Usted esta llenando la fila No." + (filas + 1));
            for (int columnas = 0; columnas < 5; columnas++)
            {
                matriz[filas, columnas] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static int sumarf(int[,] matriz, int f)
    {
        int suma = 0;
        f--;
        for (int columna = 0; columna < 4; columna++)
        {
            suma = suma + matriz[f, columna];
        }
        return suma;
    }
    static int sumarc(int[,] matriz, int f)
    {
        int suma = 0;
        f--;
        for (int filas = 0; filas < 4; filas++)
        {
            suma = suma + matriz[filas, f];
        }
        return suma;
    }
    static float numM(float num, float m)
    {
        if (num > m)
        {
            m = num;
        }
        return m;
    }
    static int[,] multiplicar(int[,] matriz1, int[,] matriz2)
    {
        int[,] C = new int[3, 2];
        for (int filas = 0; filas < 3; filas++)
        {
            for (int columnas = 0; columnas < 2; columnas++)
            {
                C[filas, columnas] = matriz1[filas, columnas] * matriz2[filas, columnas];
            }
        }
        return C;
    }
    static int sumaD(int[,] matriz)
    {
        int suma = 0, filas;
        for (filas = 0; filas < 5; filas++)
        {
            suma = suma + matriz[filas, filas];
        }
        return suma;
    }
    static int sumaD2(int[,] matriz)
    {
        int suma = 0, filas;
        for (filas = 0; filas < 5; filas++)
        {
            suma = suma + matriz[filas, (4 - filas)];
        }
        return suma;
    }
}


