using System;

class Persona
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}
class Vehiculo
{
    public string marca, modelo, color, placa;
    public int anio;
}
class Producto
{
    public string nombre, codigo;
    public int stock;
    public double precio;
    public bool disponible;
}
class Mascota
{
    public string nombre, especie;
    public int edad;
    public double peso;
    public bool vacunado;
}
class Program
{
    static void Main()
    {
        //EJERCICIO #1
        Console.WriteLine("EJERCICIO #1");
        Persona persona = new Persona();
        persona.nombre = "Mariela";
        persona.edad = 17;
        persona.altura = 1.62;
        persona.estudiante = true;

        Console.WriteLine("Nombre: " + persona.nombre);
        Console.WriteLine("Edad: " + persona.edad);
        Console.WriteLine("Altura " + persona.altura);
        Console.WriteLine("¿Es estudiante? " + persona.estudiante);
        Console.WriteLine();

        //EJERCICIO #2
        Console.WriteLine("EJERCICIO #2");
        Vehiculo vehiculo = new Vehiculo();
        vehiculo.marca = "Mazda";
        vehiculo.modelo = "Mazda CX-30";
        vehiculo.anio = 2024;
        vehiculo.color = "gris";
        vehiculo.placa = "P123ABC";

        Console.WriteLine("Marca: " + vehiculo.marca);
        Console.WriteLine("Modelo: " + vehiculo.modelo);
        Console.WriteLine("Año: " + vehiculo.anio);
        Console.WriteLine("Color: " + vehiculo.color);
        Console.WriteLine("Placa: " + vehiculo.placa);
        Console.WriteLine();

        //EJECICIO #3
        Console.WriteLine("EJERCICIO #3");
        Producto p1 = new Producto();
        p1.codigo = "8-3723872383";
        p1.nombre = "Paquete de tortillas de harina";
        p1.precio = 9.50;
        p1.stock = 13;
        p1.disponible = true;

        Producto p2 = new Producto();
        p2.codigo = "9-343434134134";
        p2.nombre = "Paquete de servilletas 3 unidades";
        p2.precio = 16.85;
        p2.stock = 0;
        p2.disponible = false;

        Console.WriteLine("PRODUCTO #1");
        Console.WriteLine("Código: " + p1.codigo);
        Console.WriteLine("Nombre: " + p1.nombre);
        Console.WriteLine("Precio: Q" + p1.precio);
        Console.WriteLine("Stock: " + p1.stock);
        Console.WriteLine("¿Esta disponible? " + p1.disponible);

        Console.WriteLine("PRODUCTO #2");
        Console.WriteLine("Código: " + p2.codigo);
        Console.WriteLine("Nombre: " + p2.nombre);
        Console.WriteLine("Precio: Q" + p2.precio);
        Console.WriteLine("Stock: " + p2.stock);
        Console.WriteLine("¿Esta disponible? " + p2.disponible);
        Console.WriteLine();

        //EJERCICIO #4
        Console.WriteLine("EJERCICIO #4");
        Mascota mas = new Mascota();
        mas.nombre = "Toffy";
        mas.especie = "Perro";
        mas.edad = 6;
        mas.peso = 5;
        mas.vacunado = true;

        Console.WriteLine("Nombre: " + mas.nombre);
        Console.WriteLine("Especie: " + mas.especie);
        Console.WriteLine("Edad: " + mas.edad + " años");
        Console.WriteLine("Peso: " + mas.peso + "kg");
        Console.WriteLine("¿Esta vacunado?" + mas.vacunado);
        Console.WriteLine();
    }
}
