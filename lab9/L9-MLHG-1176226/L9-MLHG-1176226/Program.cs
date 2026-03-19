using System;
class Program
{
    static void Main()
    {
        //EJERCICIO 1
        Console.WriteLine("EJERCICIO #1");
        Console.WriteLine("Saludo modularizado");
        Console.WriteLine("Ingrese su nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine();
        saludo(nombre);
        curso();
        Console.WriteLine();

        //EJERCICIO 2
        Console.WriteLine("EJERCICIO #2");
        Console.WriteLine("Calculadora con procedimientos");
        Console.WriteLine("Seleccione la figura de la que quiere calcular el área");
        Console.WriteLine("1. Cuadrado");
        Console.WriteLine("2. Rectángulo");
        Console.WriteLine("3. Triángulo");
        int opcion = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        double bas, alt;
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese la base del cuadrado: ");
                bas = Convert.ToDouble(Console.ReadLine());
                cuadrado(bas);
                break;
            case 2:
                Console.WriteLine("Ingrese la base del rectángulo: ");
                bas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del rectángulo: ");
                alt = Convert.ToDouble(Console.ReadLine());
                rectangulo(bas, alt);
                break;
            case 3:
                Console.WriteLine("Ingrese la base del triángulo: ");
                bas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triángulo: ");
                alt = Convert.ToDouble(Console.ReadLine());
                triangulo(bas, alt);
                break;

            default:
                Console.WriteLine("La opción no esta en el menú");
                break;
        }
        Console.WriteLine();
        //EJERCICIO 3
        int op;
        Console.WriteLine("EJERCICIO #3");
        do
        {
            Console.WriteLine("Calculadora con procedimientos");
            Console.WriteLine("Ingrese una opción del menú");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Linea");
            Console.WriteLine("4. Salir");
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int num;
            switch (op)
            {
                case 1:
                    Console.WriteLine("Ingrese un número entero: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    cuadrad(num);
                    break;
                case 2:
                    Console.WriteLine("Ingrese un número entero: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    triangul(num);
                    break;
                case 3:
                    Console.WriteLine("Ingrese un número entero: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    linea(num);
                    break;
                case 4:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("La opción no esta en el menú");
                    break;
            }
        } while (op != 4);

        //EJERCICIO 4
        Console.WriteLine("EJERCICIO #4");
        Console.WriteLine("Registro de notas");
        double notas = 0, promedioo = 0, suma = 0;
        int apro = 0, repro = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Ingrese la nota: ");
            notas = Convert.ToDouble(Console.ReadLine());
            pase(notas, ref apro, ref repro, ref suma);
        }
        resumen(promedioo, suma, apro, repro);
        Console.WriteLine();
        //EJERCICIO 5
        int x = 0;
        Console.WriteLine("EJERCICIO #5");
        Console.WriteLine("Intercambio de valores");
        int num1, num2;
        Console.WriteLine("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1 + ", " + num2);
        cambio(ref num1, ref num2, x);
    }
    //PROCEDIMIENTOS EJERCICIO 1
    static void saludo(string s)
    {
        Console.WriteLine("Bienvenido/a " + s + ", a este curso de Pensamiento Computacional. Se espera que aprendas los conceptos esenciales de la materia y su aplicación.");
    }
    static void curso()
    {
        Console.WriteLine("Nombre del curso: Pensamiento Computacional");
        Console.WriteLine("No. de laboratorio: 20");
    }
    //PROCEDIMIENTOS EJERCICIO 2
    static void cuadrado(double basee)
    {
        double areac = basee * basee;
        Console.WriteLine("Área cuadrado: " + areac);
    }
    static void rectangulo(double basee, double altura)
    {
        double arear = basee * altura;
        Console.WriteLine("Área rectangulo: " + arear);
    }
    static void triangulo(double basee, double altura)
    {
        double areat = (basee * altura) / 2;
        Console.WriteLine("Área rectangulo: " + areat);
    }
    //PROCEDIMIENTOS EJERCICIO 3
    static void cuadrad(int numero)
    {
        for (int i = 1; i <= numero; i++)
        {
            for (int j = 1; j <= numero; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void triangul(int numero)
    {
        for (int i = 1; i <= numero; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void linea(int numero)
    {
        for (int i = 1; i <= numero; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    //PROCEDIMIENTOS EJERCICIO 4
    static void pase(double pasoono, ref int aprovo, ref int reprovo, ref double sum)
    {
        if (pasoono >= 61)
        {
            aprovo++;
            Console.WriteLine("Estudiante aprovado");
        }
        else
        {
            reprovo++;
            Console.WriteLine("Nota insuficiente; estudiante desaprovado");
        }
        sum = sum + pasoono;
    }
    static void resumen(double promedio, double suma, int aprovo, int reprovo)
    {
        promedio = suma / 5;
        Console.WriteLine("Promedio de la clase: " + promedio);
        Console.WriteLine("Aprobados: " + aprovo);
        Console.WriteLine("Reprobados: " + reprovo);
    }
    //PROCEDIMIENTOS EJERCICIO 5
    static void cambio(ref int numero1, ref int numero2, int xx)
    {
        xx = numero1;
        numero1 = numero2;
        numero2 = xx;
        Console.WriteLine(numero1 + ", " + numero2);
    }
}


