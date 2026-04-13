using System;
class Program
{
    static void Main()
    {
        //EJERCICIO #1
        Console.WriteLine("EJERCICIO 1: PARAMETROS POR VALOR");
        Console.WriteLine("Ingrese un número entero:");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(suma(num));
        Console.WriteLine();
        
        //EJERCICIO #2
        Console.WriteLine("EJERCICIO 2: PARAMETROS POR REFERENCIA");
        Console.WriteLine("Ingrese el número que sera elevado al cuadrado");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(cuadrado(ref numero));
        Console.WriteLine("El resultado del número al cuadrado es " + numero);
        Console.WriteLine();

        //EJERCICIO #3
        Console.WriteLine("EJERCICIO 3: INTEGRACIÓN");
        Console.WriteLine("Ingrese el precio del producto:");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el descuento a aplicar en el producto: ");
        double descuento = Convert.ToDouble(Console.ReadLine());
        double des = descuentoo(ref precio, descuento);
        Console.WriteLine("El decuento aplicado fue de: Q" + des);
        Console.WriteLine("Su total a pagar es de Q" + precio);
        Console.WriteLine();

        //EJERCICIO #4
        Console.WriteLine("EJERCICIO 4: INTEGRACIÓN 2");
        int energiajugador = 0;
        Console.WriteLine("Ingresa tu cantidad de energía inicial: (Max: 20)");
        do
        {
            energiajugador = Convert.ToInt32(Console.ReadLine());
            if (energiajugador > 20 || energiajugador < 0) { Console.WriteLine("El máximo de energía permitido es 20 y el mínimo es 0"); }
        } while (energiajugador > 20 || energiajugador < 0);
        int opcion = 0;
        do
        {
            Console.WriteLine("OPCIONES");
            Console.WriteLine("1. Consumir energía");
            Console.WriteLine("2. Recargar energía");
            Console.WriteLine("3. Ver estado");
            Console.WriteLine("4. Caclcular rendicmiento");
            Console.WriteLine("5. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine(consumirEnergia(ref energiajugador));
                    break;
                case 2:
                    Console.WriteLine(recargarenergia(ref energiajugador));
                    break;
                case 3:
                    Console.WriteLine("Estado de su energía: " + obtenerestado(energiajugador));
                    break;
                case 4:
                    Console.WriteLine("Su clasificación es: " + calcularRendimiento(energiajugador));
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opción invalida, ingrese otra");
                    break;
            }
        } while (opcion != 5);

    }
    //PROCEDIMIENTO EJERCICIO 1
    static int suma(int nume)
    {
        int sum = 0, residuo, numer;
        do
        {
            numer = nume;
            residuo = nume % 10;
            sum = sum + residuo;
            nume = nume / 10;
        } while (nume < numer);
        sum = sum + nume;
        return sum;
    }
    //PROCEDIMIENTO EJERCICIO 2
    static string cuadrado(ref int num)
    {
        num = num * num;
        return "La operación se realizó con exito.";
    }
    //PROCEDIMIENTO EJERCICIO 3
    static double descuentoo(ref double p, double d)
    {
        d = p * (d/100);
        p = p - d;
        return d;
    }
    //PROCEDIMINETOS EJERCICIO 4
    static string consumirEnergia(ref int e)
    {
        string consumo;
        if (e < 4)
        {
            consumo = "No tiene energía suficiente, recargue energía";
        }
        else
        {
            e = e - 4;
            consumo = "La energía restante es " + e;
        }
        return consumo;
    }
    static string recargarenergia(ref int e)
    {
        string actual;
        if (e >= 20)
        {
            actual = "Llegaste al límite energía, no puedes recargar más por ahora";
        }
        else
        {
            e = e + 6;
            actual = "La energía actual es " + e;
        }
        return actual;
    }
    static string obtenerestado(int e)
    {
        string estado = "";
        if (e <= 20 && e >= 15)
        {
            estado = "ALTA";
        }
        else
        {
            if (e <= 14 && e >= 8)
            {
                estado = "MEDIA";
            }
            else
            {
                estado = "BAJA";
            }
        }
        return estado;
    }
    static string calcularRendimiento(int e)
    {
        string cali = "";
        if (e <= 19 && e >= 15)
        {
            cali = "A";
        }
        else
        {
            if (e <= 14 && e >= 8)
            {
                cali = "B";
            }
            else
            {
                if (e < 17)
                {
                    cali = "C";
                }
                else
                {
                    cali = "S";
                }
            }
        }
        return cali;
    }
}
