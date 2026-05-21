using System;
class Program
{
    static void Main()
    {
        //EJERCICIO # 1
        Console.WriteLine("FICHA TÉCNICA"); //Solo para saber de que se esta hablando
        string modelo = "M67584";
        int capacidad = 3000;
        float combustible = 87.5f;
        bool salto = true;
        Console.WriteLine("Modelo: " + modelo + ", Capacidad de carga: " + capacidad + ", Nivel de combustible: " + combustible + ", ¿Motor de salto activo? " + salto);
        //EJERCICIO # 2
        short sensores_activos = 128;
        int registro_procesador;
        registro_procesador = sensores_activos;
        double precision_total;
        precision_total = registro_procesador;
        Console.WriteLine("Procesador Central: " + precision_total);
        //EJERCICIO # 3
        double energia_generada = 987.65;
        int energia_limitada;
        energia_limitada = (int)energia_generada;
        Console.WriteLine("Energía generada: " + energia_generada);
        Console.WriteLine("Energía limitada: " + energia_limitada);
        //EJERCICIO # 4
        Console.WriteLine("Ingrese la distancia al planeta más cercano: ");
        string entrada_radar = Console.ReadLine();
        int numero = int.Parse(entrada_radar);
        int total = numero + 100;
        Console.WriteLine("Distancia total: " + total);
        //EJERCICIO # 5
        string oxigeno = "true";
        bool estado_oxigeno = Convert.ToBoolean(oxigeno);
        string temperatura = "22.8";
        double temperatura_cabina = Convert.ToDouble(temperatura);
        Console.WriteLine("Señal de oxigeno: " + estado_oxigeno);
        Console.WriteLine("Temperatura de la cabina: " + temperatura_cabina);
        //EJERCICIO # 6
        double velocidad_luz = 299792.4589075;
        string velocidad = velocidad_luz.ToString("N3");
        Console.WriteLine("Reporte de velocidad: " + velocidad);
        //EJERCICIO # 7
        Console.WriteLine("Ingrese el precio (Por Galón) del litio: ");
        string precio = Console.ReadLine();
        double precio_exacto = Convert.ToDouble(precio);
        double impuesto = precio_exacto + (precio_exacto * 0.12);
        int total_precio = (int)impuesto;   //Al convertir un valor a int, no se toman en cuenta las reglas de aproximación
        Console.WriteLine("El precio total del suministro es de: " + total_precio);









    }
}
