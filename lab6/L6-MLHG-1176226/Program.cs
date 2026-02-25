using System;
class Program
{
    static void Main()
    {
        //EJERCICIO 1
        Console.WriteLine("Ingrese el tipo de vehiculo");
        Console.WriteLine("1 para Bicicleeta");
        Console.WriteLine("2 para Motocicleta");
        Console.WriteLine("3 para Auto");
        Console.WriteLine("4 para camión");
        Console.WriteLine("5 para autobus");//Se establecieron las opciones del menú con una misma variable para luego ser evaluada
        string tipo = Console.ReadLine();//Se pide el dato al usuario y se transforma de un string a un int
        int TIPO = int.Parse(tipo);
        switch (TIPO)
        {
           case 1:
           
            Console.WriteLine("Eligio la opción de bicicleta y su clasificación es no motorizado");
            break;
           case 2: 
                Console.WriteLine("Elgio la opción de motocicleta y su clasificación es ligero");
                break;
           case 3: 
                Console.WriteLine("Eligio la opción de auto y su clasificación es mediano");
                break;
           case 4:
                Console.WriteLine("Elgio la opción de camión y su clasificación es pesado");
                break;
           case 5:
                Console.WriteLine("Elilio la opción autobus y su clasificación es trasporte público");
                break;
           default:
                Console.WriteLine("Invalido; ingrese un número dentro de las opciones");
                break;
          
        }
        //EJERCIO 2
        Console.WriteLine("Ingrese el número de su tipo de tarjeta para determinar el límite de su crédito");
        Console.WriteLine("Tarjeta tipo 1");
        Console.WriteLine("Tarjeta tipo 2");
        Console.WriteLine("Tarjeta tipo 3");
        Console.WriteLine("Para cualquier otro tipo ingrese 4");
        string tarjeta = Console.ReadLine();
        int TAR = int.Parse(tarjeta);
        switch (TAR)
        {
            case 1:

                Console.WriteLine("El límite de su crédito aumentara un 25%");
                break;
            case 2:
                Console.WriteLine("El límite de su crédito aumentara un 35%");
                break;
            case 3:
                Console.WriteLine("El límite de su crédito aumentara un 40%");
                break;
            case 4:
                Console.WriteLine("El límite de su crédito aumentara un 50 %");
                break;
            default:
                Console.WriteLine("Ingrese una opción que este en el menú");
                break;

        }

    }
}
