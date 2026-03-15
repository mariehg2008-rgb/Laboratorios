using System;
class Program
{
    static void Main()
    {
        //EJERCICIO 1
        Console.WriteLine("EJERCICIO # 1");
        Console.WriteLine("Notas clase #");
        double promedio;
        int re = 0, nota;
        int apro = 0;
        int total = 0;
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Ingrese la nota: ");
            nota = int.Parse(Console.ReadLine());
            if (nota >= 61)
            {
                Console.WriteLine("El estudiante aprobo");
                apro++;
            }
            else
            {
                Console.WriteLine("El estudiante reprobo");
                re++;
            }
            total = total + nota;
        }
        promedio = total / 10;
        Console.WriteLine("El promedio de la clase es de: " + promedio);
        Console.WriteLine("Aprobados: " + apro);
        Console.WriteLine("Reprobados: " + re);
        Console.WriteLine();
        
        //EJERCICIO #2
        Console.WriteLine("EJERCICIO #2");
        Console.WriteLine("Ingrese un número entero");
        int j, totall = 0, par = 0, impar = 0;
        int num = Convert.ToInt32(Console.ReadLine());
        for (j = 1; j <= num; j++)
        {
            if (j % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
            totall = totall + j;

        }
        Console.WriteLine("La suma es: " + totall);
        Console.WriteLine("En este rango hay " + par + " números pares");
        Console.WriteLine("En este rango hay " + impar + " números impares");
        Console.WriteLine();

        //EJERCICIO #3
        Console.WriteLine("EJERCICIO #3");
        double totalc = 0;
        int clientes = 0, opcion;
        do
        {
            Console.WriteLine("Ingrese la opción que desea realixar");
            Console.WriteLine("1. Registrar compra");
            Console.WriteLine("2. Mostrar total de ventas");
            Console.WriteLine("3. Mostrar cantidad de clientes atendidos");
            Console.WriteLine("4. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el monto de la compra");
                    double compra = Convert.ToDouble(Console.ReadLine());
                    totalc = totalc + compra;
                    clientes++;
                    break;
                case 2:
                    Console.WriteLine("El total de ventas es de " + totalc);
                    break;
                case 3:
                    Console.WriteLine("Se han atendido " + clientes + " cliente/s");
                    break;
                case 4:
                    Console.WriteLine("Cerrando programa...");
                    break;
                default:
                    Console.WriteLine("Ingrese una opción que se encuentre en el menú");
                    Console.WriteLine();
                    break;
            }

        } while (opcion != 4);
        Console.WriteLine();

        //EJERCICIO #4
        Console.WriteLine("EJERCICIO #3");
        Console.WriteLine("Programa que se repite hasta que el número ingresado sea 0");
        Console.WriteLine("Ingrese un número");
        int numero = Convert.ToInt32(Console.ReadLine());
        int conta = 0, positi = 0, negati = 0, totalt = 0;
        while (numero != 0)
        {
            conta++;
            if (numero < 0)
            {
                negati++;
            }
            else
            {
                positi++;
            }
            totalt = totalt + numero;
            Console.WriteLine("Ingrese un número");
            numero = Convert.ToInt32(Console.ReadLine());
        }
        if (conta == 0)
        {
            Console.WriteLine("Solo se ingreso un número y fue 0, por lo que no hay más datos que mostrar");
        }
        else
        {
            Console.WriteLine("La suma de todos los número ingresado es: " + totalt);
            Console.WriteLine("Se ingresaron " + conta + " números");
            Console.WriteLine(positi + " números fueron positivos");
            Console.WriteLine(negati + " números fueron negativos");
        }
        Console.WriteLine();

        //EJERCICIO #5
        Console.WriteLine("EJERCICIO #5");
        Console.WriteLine("Ingrese un número");
        int nume = Convert.ToInt16(Console.ReadLine());
        int u, e;
        for (u = 1; u <= nume; u++)
        {
            for (e = 1; e <= u; e++)
            {
                Console.Write(e);
            }
            Console.WriteLine();
        }
    }
}
