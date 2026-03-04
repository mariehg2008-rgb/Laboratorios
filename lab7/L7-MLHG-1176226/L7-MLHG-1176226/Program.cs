using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
class Program
{
    static void Main()
    {
        //EJERCICIO #1
        Console.WriteLine("EJERCICIO #1");
        Console.WriteLine("Ingrese la cantidad de números que desea sumar: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int conta = 0;
        int suma = 0;
        while (num < 0)
        {
            Console.WriteLine("El número tiene que ser mayor a 0, vuelve a ingresar el número");
            num = Convert.ToInt32(Console.ReadLine());
        }
        while (conta <= num)
        {
            suma = suma + conta;
            conta++;//El contador va abajo de la operación porque sino comienza con el valor 1 en vez de 0 y da una suma incorrecta.
        }
        Console.WriteLine("La suma de sus números es " + suma);
        
    }
}