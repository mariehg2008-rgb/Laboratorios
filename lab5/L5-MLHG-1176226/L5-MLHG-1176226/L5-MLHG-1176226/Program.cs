using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("PANEL DE CONTROL");
        Console.WriteLine();
        Console.WriteLine("Ingrese el ID del usuario");
        string id = Console.ReadLine();
        int ID = int.Parse(id);
        Console.WriteLine("Ingrese el PIN");
        string pin = Console.ReadLine();
        int PIN = int.Parse(pin);
        Console.WriteLine("¿Modo seguro activado? (Si/No)");
        string modo = Console.ReadLine();
        Console.WriteLine("Ingrese el token de seguridad");
        string token = Console.ReadLine();
        int TOKEN = int.Parse(token);
        if (ID == 2026)
        {
            Console.WriteLine("Usuario reconocido");
        }
        else
        {
            Console.WriteLine("Usuario no reconocido");
        }
        if (PIN == 1234)
        {
            Console.WriteLine("PIN correcto");
        }
        else
        {
            Console.WriteLine("PIN incorrecto");
        }
        if (modo.ToLower() == "si")
        {
            Console.WriteLine("Modo seguro activado, se aplican reglas extras");
        }
        else
        {
            Console.WriteLine("Modo seguro desactivado");
        }
        if (modo.ToLower() == "si")
        {
            if (TOKEN >= 700) ;
        }
        else
        {
            Console.WriteLine("Modo seguro desactivado");
        }
    }
}