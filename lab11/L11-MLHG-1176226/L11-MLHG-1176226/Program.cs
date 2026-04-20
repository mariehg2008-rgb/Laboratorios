using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        int i;
        //EJERCICIO #1
        Console.WriteLine("EJERCICIO #1: MANEJO DE CADENAS; VALIDAR CONTRASEÑA");
        Console.WriteLine("Cree su contraseña: ");
        string contra = Console.ReadLine();
        int m = 0, c = 0;
        if (contra.Length < 8)
        {
            Console.WriteLine("La contraseña debe tener por lo menos 8 caracteres");
        }
        for (i = 0; i <= (contra.Length - 1); i++)
        {
            if (contra[i] == contra.ToUpper()[i])
            {
                m++;
                break;
            }
            else
            {
                if (i == (contra.Length - 1))
                {
                    Console.WriteLine("La contraseña debe tener por lo menos una mayuscula");
                }
            }
        }
        for (i = 0; i <= (contra.Length - 1); i++)
        {
            if (contra[i] == '@' || contra[i] == '!' || contra[i] == '¡' || contra[i] == '?' || contra[i] == '¿' || contra[i] == '#' || contra[i] == '&' || contra[i] == '$')
            {
                c++;
                break;
            }
            else
            {
                if (i == (contra.Length - 1))
                {
                    Console.WriteLine("La contraseña debe tener por lo menos un caracter especial");
                }
            }
        }
        if (contra.Length > 8 && m > 0 && c > 0)
        {
            Console.WriteLine("Contraseña valida");
        }
        else
        {
            Console.WriteLine("Contraseña invalida");
        }
        Console.WriteLine();

        //EJERCICIO #2
        Console.WriteLine("EJERCICIO #2: MANEJO DE CADENAS; INVERTIR TEXTO");
        Console.Write("Ingrese el texto: ");
        string texto = Console.ReadLine();
        int l = (texto.Length - 1); ; //Como el lenght devuelve el número sin tomar en cuenta el 0, es importante restarle uno para poder utilizar la función subtring después
        string j = "";
        for (i = 1; i <= (texto.Length); i++)
        {
            string letra = Convert.ToString(texto[l]);
            l = l - 1;
            j = j + letra;
        }
        Console.WriteLine(j);
        Console.WriteLine();

        //EJERCICIO #3
        Console.WriteLine("EJERCICIO #3: ARREGLOS UNIDIMENSIONALES; SUMA Y PROMEDIO");
        Console.WriteLine("Ingrese la cantidad de número que desea trabajar: ");
        int num =Convert.ToInt32(Console.ReadLine());
        int[] numeros = new int[num];
        double promedio;
        int suma = 0, mayor = 0, menor = 0;
        for (int a = 0; a <= num-1; a++)
        {
            Console.WriteLine("Ingrese un número:");
            numeros[a] = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                mayor = numeros[0];
                menor = numeros[0];
            }
            suma = suma + numeros[a];
            if (numeros[a]> mayor)
            {
                mayor = numeros[a];
            }
            else
            {
                if (numeros[a]< menor)
                {
                    menor = numeros[a];
                }
            }
        }
        promedio = (double)suma / num;
        Console.WriteLine("El total de la suma es: " + suma);
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Número mayor: " + mayor);
        Console.WriteLine("Número menor: " + menor);
        Console.WriteLine();

        //EJERCICIO #4
        Console.WriteLine("EJERCICIO #4: ARREGLOS UNIDIMENSIONALES; BUSCAR UN NÚMERO");
        int conta = 0;
        int[] n = new int[8];
        for (i = 0; i < 8; i++)
        {
            Console.WriteLine("Ingrese un número:");
            n[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Ingrese el número que desea encontrar en el arreglo:");
        int opcion = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < 8; i++)
        {
            if (n[i] == opcion)
            {
                conta = i;
                Console.WriteLine(conta);
                break;
            }
        }
        if (conta == 0)
        {
            Console.WriteLine("Ese número no existe en el arreglo");
        }
        else
        {
            Console.WriteLine("El número sí existe y esta en la posición " + (conta + 1));
        }
        Console.WriteLine();

        //EJERCICIO #5
        Console.WriteLine("EJERCICIO #5: INTEGRACIÓN; NOMBRES EN ARREGLO");
        Console.WriteLine("Ingrese 5 nombres");
        string[] nombres = new string[5];
        string lar = "", nombre;
        int no = 0;
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese el nombre No." + (i + 1));
            nombres[i] = Console.ReadLine();
            if (nombres[i].Length > 5)
            {
                no++;
                nombre = nombres[i];
                largo(ref lar, nombre);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Nombres ingresados");
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine(nombres[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de nombres con más de 5 letras: " + no);
        Console.WriteLine("Nombre más largo: " + lar);
    }
    static void largo(ref string largo, string nom)
    {
        if (nom.Length > largo.Length)
        {
            largo = nom;
        }

    }
}
