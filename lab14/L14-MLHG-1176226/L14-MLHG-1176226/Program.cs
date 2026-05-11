using System;
class libro
{
    private string titulo, autor;
    private int anio;
    private bool disponible;
    public libro(string titulo, string autor, int anio)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anio = anio;
        disponible = true;
    }
    public void mostrarInfo()
    {
        Console.WriteLine("Título: " + this.titulo);
        Console.WriteLine("Autor: " + this.autor);
        Console.WriteLine("Año: " +  this.anio);
        Console.Write("¿Esta disponible? ");
        if (this.disponible)
        {
            Console.WriteLine("Si esta disponible");
        }
        else
        {
            Console.WriteLine("No esta disponible");
        }
    }
    public void prestar()
    {
        this.disponible = false;
    }
    public void devolver()
    {
        this.disponible = true;
    }
}
class mascota
{
    private string nombre, especie;
    private int edad;
    private bool vacunado;
    public mascota(string nombre, string especie, int edad)
    {
        this.nombre = nombre;
        this.especie = especie;
        this.edad = edad;
        vacunado = false;
    }
    public void mostrarInfo()
    {
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("Especie: " + this.especie);
        Console.WriteLine("Edad: " + this.edad);
        Console.Write("¿Esta vacunado? ");
        if (this.vacunado)
        {
            Console.WriteLine("Si esta vacunado");
        }
        else
        {
            Console.WriteLine("No esta vacunado");
        }
    }
    public void vacunar()
    {
        this.vacunado = true;
    }
    public void CumplirAnios()
    {
        this.edad++;
    }
}
class estudiante
{
    private string nombre, grado;
    private int edad;
    private double[] notas;
    public estudiante(string nombre, string grado, int edad, double[] notas)
    {
        this.nombre = nombre;
        this.grado = grado;
        this.edad = edad;
        this.notas = notas;
    }
    public void mostrarInfo()
    {
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("grado: " + this.grado);
        Console.WriteLine("Edad: " + this.edad);
        Console.WriteLine("Notas:");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine(this.notas[i]);
        }
    }
    public double pro()
    {
        double suma = 0, promedio;
        for (int i = 0; i < this.notas.Length; i++)
        {
            suma = suma + (this.notas[i]);
        }
        promedio = suma / this.notas.Length;
        return promedio;
    }
    public void aprobado(double promedi)
    {
        if (promedi >= 61)
        {
            Console.WriteLine("El estudiante aprobo");
        }
        else
        {
            Console.WriteLine("El estudiante reprobo");
        }
    }
    public void agregarNota(double nota)
    {
        double[] notas = new double[this.notas.Length + 1];

        for (int i = 0; i < this.notas.Length; i++)
        {
            notas[i] = this.notas[i];
        }

        notas[this.notas.Length] = nota;

        this.notas = notas;
    }
}
class program
{
    static void Main()
    {
        Console.WriteLine("EJERCICIO #1");
        libro libro1 = new libro("Los arboles mueren de pie", "Alejandro Casona", 1949);
        Console.WriteLine("Primer Libro");
        libro1.mostrarInfo();
        libro libro2 = new libro("Señor Presidente", "Miguel Ángel Asturias", 1946);
        Console.WriteLine("Segundo Libro");
        libro2.mostrarInfo();
        Console.WriteLine();
        int opcion;
        do
        {
            Console.WriteLine("Elija una opción: ");
            Console.WriteLine("1. Mostrar datos");
            Console.WriteLine("2. Prestar un libro");
            Console.WriteLine("3. Devolver un libro");
            Console.WriteLine("4. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Primer Libro");
                    libro1.mostrarInfo();
                    Console.WriteLine("Segundo Libro");
                    libro2.mostrarInfo();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el número de libro que desea prestar: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        libro1.prestar();
                    }
                    else
                    {
                        libro2.prestar();
                    }
                    Console.WriteLine("Libro prestado");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Ingrese el número de libro que desea devolver: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        libro1.devolver();
                    }
                    else
                    {
                        libro2.devolver();
                    }
                    Console.WriteLine("Libro devuelto");
                    Console.WriteLine();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Ingrese una opción valida");
                    break;
            }
        } while (opcion != 4);
        Console.WriteLine();

        Console.WriteLine("EJERCICIO #2");
        mascota mascota1 = new mascota("Toffy", "perro", 6);
        Console.WriteLine("Primer mascota");
        mascota1.mostrarInfo();
        mascota mascota2 = new mascota("Peluza", "gato", 1);
        Console.WriteLine("Segunda mascota");
        mascota2.mostrarInfo();
        Console.WriteLine();
        do
        {
            Console.WriteLine("Elija una opción: ");
            Console.WriteLine("1. Vacunar");
            Console.WriteLine("2. Cumplir años");
            Console.WriteLine("3. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el número de mascota a vacunar: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mascota vacunada");
                    Console.WriteLine("Datos actualizados");
                    Console.WriteLine();
                    if (n == 1)
                    {
                        mascota1.vacunar();
                        mascota1.mostrarInfo();
                    }
                    else
                    {
                        mascota2.vacunar();
                        mascota2.mostrarInfo();
                    }

                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el número de mascota que cumple años: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Año aumentado");
                    Console.WriteLine("Datos actualizados");
                    Console.WriteLine();
                    if (n == 1)
                    {
                        mascota1.CumplirAnios();
                    }
                    else
                    {
                        mascota2.CumplirAnios();
                        mascota2.mostrarInfo();
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Ingrese una opción valida");
                    break;
            }
        } while (opcion != 3);
        Console.WriteLine();

        Console.WriteLine("EJERCICIO #3");
        double[] notas1 = { 70, 80, 90 };
        double[] notas2 = { 50, 60, 55 };

        estudiante estudiante1 = new estudiante("Lara", "Cuarto", 16, notas1);
        estudiante estudiante2 = new estudiante("Daniela", "Quinto", 17, notas2);
        Console.WriteLine("Se ingresaron los datos de 2 estudiantes");

        Console.WriteLine();
        double promedio = estudiante1.pro(), prome = estudiante2.pro();
        do
        {
            Console.WriteLine("Elija una opción: ");
            Console.WriteLine("1. Mostrar datos");
            Console.WriteLine("2. Verificar aprobado");
            Console.WriteLine("3. Agregar nota");
            Console.WriteLine("4. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el número de estudiante: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (n == 1)
                    {
                        estudiante1.mostrarInfo();
                    }
                    else
                    {
                        estudiante2.mostrarInfo();
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el número de estudiante: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (n == 1)
                    {
                        estudiante1.aprobado(promedio);
                    }
                    else
                    {
                        estudiante2.aprobado(prome);
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Ingrese el número de estudiante: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Ingrese la nota a agregar");
                    double nota = Convert.ToDouble(Console.ReadLine());
                    if (n == 1)
                    {
                        estudiante1.agregarNota(nota);
                        promedio = estudiante1.pro();
                    }
                    else
                    {
                        estudiante2.agregarNota(nota);
                        prome = estudiante2.pro();
                    }
                    Console.WriteLine("La nota fue agregada correctamente");
                    Console.WriteLine();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Ingrese una opción valida");
                    break;
            }
        } while (opcion != 4);

    }
}
