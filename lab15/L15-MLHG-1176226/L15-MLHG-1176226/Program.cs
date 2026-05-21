using System; //Tipo de error encontrado: sintaxis. Se agrego un ";" porque c# require uno en cada linea de código.
class Program
{
    static void Main()
    {
        //EJERCICIO #1
        Console.WriteLine("-----EJERCICIO #1------");
        Console.WriteLine();
        string nombre; //Tipo de error encontrado: sintaxis. Se agrego un ";" porque c# require uno en cada linea de código.
        int edad;

        Console.WriteLine("Ingrese su nombre:");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine()); //Tipo de error encontrado: sintaxis. Se agrego un ";" porque c# require uno en cada linea de código.
        Console.WriteLine("Hola " + nombre);
        Console.WriteLine("Tienes " + edad + " años");
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }//Tipo de error encontrado: sintaxis. Se agrego un "}" porque hacer falta cerrar el espacio del IF. Ningun corchete puede quedar sin par.
        else
        {
                Console.WriteLine("Eres menor de edad");
        }
        Console.WriteLine();
        //EJERCICIO #2
        Console.WriteLine("-----EJERCICIO #2------");
        Console.WriteLine();
        double nota1, nota2, nota3, promedio;
        Console.WriteLine("Ingrese la primera nota:");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = double.Parse(Console.ReadLine());
        promedio = (nota1 + nota2 + nota3) / 3;//Tipo de error encontrado: lógico. Se metio la suma de los números, dentro de un parentesis. c# opera según la jerarquia de operaciones.
        //Lo que pasa en este caso es que el programa dividia entre 3 el ultimo numero ingresado y le sumaba los otros dos, en vez de dividir entre tres la suma de los tres números.
        Console.WriteLine("El promedio es: " + promedio);
        if (promedio >= 61)//Tipo de error encontrado: lógico. Se agrego un "=" al ">". El mayor que no incluye el número con el que se esta comparando, pero al agregarle un igual se puede solucionar este problema.
        //El programa funcionaba porque los defectos es algo que se puede hacer, pero en este caso no era lo que se estaba buscando hacer y no cumplia con el objetivo del programa.
        {
            Console.WriteLine("El estudiante aprobó");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó");
        }
        Console.WriteLine();
        //EJERCICIO #3
        Console.WriteLine("-----EJERCICIO #3------");
        Console.WriteLine();
        bool valido;
        int[] numeros = new int[5];
        int suma = 0;
        for (int i = 0; i < 5; i++)//Tipo de error encontrado: lógico. Se le quita el "=" al ">". El mayor que o igual incluye el número con el que se esta comparando, pero el arreglo no incluye este ultimo número, pues sus posiciones van de 0 a 4.
        {
            valido = false;
            while (!valido)
            {
                Console.WriteLine("Ingrese un número:");
                if (int.TryParse(Console.ReadLine(), out numeros[i]))//Se agrega una validación de datos donde el programa convierte el texto a números, si puede hacerlo devuleve un valor, sino puede muestra un mensaje de error.
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                }
            }
        }
        for (int i = 0; i < 5; i++)//Tipo de error encontrado: lógico. Se le quita el "=" al ">". El mayor que o igual incluye el número con el que se esta comparando, pero el arreglo no incluye este ultimo número, pues sus posiciones van de 0 a 4.
        {
            suma = suma + numeros[i];
        }
        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine();

        //EJERCICIO #4
        Console.WriteLine("-----EJERCICIO #4------");
        Console.WriteLine();
        double baseRectangulo = 0, alturaRectangulo = 0;
        valido = false;
        while (!valido)
        {
            Console.WriteLine("Ingrese la base del rectángulo:");
            if (double.TryParse(Console.ReadLine(), out baseRectangulo))//Se agrega una validación de datos donde el programa convierte el texto a números, si puede hacerlo devuleve un valor, sino puede muestra un mensaje de error.
            {
                if (baseRectangulo <= 0)
                {
                    Console.WriteLine("La base no puede ser 0 o menor a 0");
                }
                else
                {
                    valido = true;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }
        valido = false;
        while (!valido)
        {
            Console.WriteLine("Ingrese la altura del rectángulo:");
            if (double.TryParse(Console.ReadLine(), out alturaRectangulo))//Se agrega una validación de datos donde el programa convierte el texto a números, si puede hacerlo devuleve un valor, sino puede muestra un mensaje de error.
            {
                if (alturaRectangulo <= 0)
                {
                    Console.WriteLine("La altura no puede ser 0 o menor a 0");
                }
                else
                {
                    valido = true;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }
        double area = CalcularArea(baseRectangulo, alturaRectangulo);
        Console.WriteLine("El área es: " + area);
        if (area >= 100)//Tipo de error encontrado: lógico. Se agrego un "=" al ">". El mayor que no incluye el número con el que se esta comparando, pero al agregarle un igual se puede solucionar este problema.
        {
            Console.WriteLine("El área es grande");
        }
        else
        {
            Console.WriteLine("El área es pequeña");
        }
        int[] edades = new int[5];
        int sum = 0;
        int mayores = 0;
        double prome;

        for (int i = 0; i < 5; i++) //Tipo de error encontrado: lógico. Se le quita el "=" al ">". El mayor que o igual incluye el número con el que se esta comparando, pero el arreglo no incluye este ultimo número, pues sus posiciones van de 0 a 4.
        {
            int ed;
            valido = false;

            // Validación de entrada
            while (!valido)
            {
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out ed)) //Se agrega una validación de datos donde el programa convierte el texto a números, si puede hacerlo devuleve un valor, sino puede muestra un mensaje de error.
                {
                    if (ed >= 0) // Valida que las edades no sean menores a 0
                    {
                        valido = true;
                        edades[i] = ed;
                        sum += ed;

                        if (ed >= 18)
                        {
                            mayores++;

                        }//Tipo de error encontrado: lógico. Se agrego un "=" al ">". El mayor que no incluye el número con el que se esta comparando, pero al agregarle un igual se puede solucionar este problema.
                    }
                    else
                    {
                        Console.WriteLine("La edad no puede ser negativa. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                }
            }
        }

        prome = (double)sum / edades.Length; // permite la división con decimales

        Console.WriteLine("El promedio de edades es: " + prome);
        Console.WriteLine("Cantidad de mayores de edad: " + mayores);
        // Reflexión:
        // Aunque la IA puede generar código rápidamente, pero es muy propensa a errores, lo que dice nunca sera una verdad absoluta por lo que es importante que personas capaces interpretar lo que se quiere hacer revisen los codigos.


    }
    static double CalcularArea(double baseRectangulo, double alturaRectangulo)
    {
        double resultado = baseRectangulo * alturaRectangulo;//Tipo de error: Lógico. Se cambio el signo "+" por "*". La formula del area de un rectangulo en basexaltura.
        return resultado;

    }
}

