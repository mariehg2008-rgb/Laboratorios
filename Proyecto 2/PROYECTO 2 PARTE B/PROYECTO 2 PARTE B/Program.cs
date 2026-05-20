using System;

public class granja//CLASE GRANJA
{
    private double dineroInicial, sueldo;
    private int empleados, meses;
    private int[] cosechas = new int[3], sembradas = new int[3];
    public granja(double dinero, int empleados, double sueldo, int meses)//CONSTRUCTOR GRANJA
    {
        this.dineroInicial = dinero;
        this.sueldo = sueldo;
        this.empleados = empleados;
        this.meses = meses;
        for (int i = 0; i < 3; i++)
        {
            cosechas[i] = 0;
            sembradas[i] = 0;
        }
    }
    public int nocosechas(int c)//DEVUELVE EL NÚMERO DE COSECHAS
    {
        return cosechas[c];
    }
    public int nosembradas(int c)//DEVUELVE EL NÚMERO DE SIEMBRAS
    {
        return sembradas[c];
    }
    public int contarcosechas(int c)//CONTADOR DE TIPOS DE PLANTAS COSECHADAS
    {
        cosechas[c]++;
        return cosechas[c];
    }
    public int contarsembradas(int c)//CONTADOR DE TIPOS DE PLANTAS SIEMBRA
    {
        sembradas[c]++;
        return sembradas[c];
    }
    public double getdinero()//COPIA DEL DINERO INICIAL
    {
        return this.dineroInicial;
    }

    public void cobraregresos(double d, ref double egresos)//COBRO DE COSTOS
    {
        this.dineroInicial = this.dineroInicial - d;
        egresos = egresos + d;
        Console.Write("Se registro un egreso de Q" + d);
    }
    public void ingresos(double d, ref double ingresos)//SUMA DE INGRESOS
    {
        this.dineroInicial = this.dineroInicial + d;
        ingresos = ingresos + d;
        Console.WriteLine("Se registro el ingreso de Q" + d);
    }
}
class parcela//CLASE PARCELA
{
    string tiposiembra;
    private int tiempoCosecha, tiempoSiembra;
    private double dineroSiembra;
    private bool ocupada, regada;
    public parcela(string tipoS, int tc, double d)//CONSTRUCTOR PARCELA
    {
        this.tiposiembra = tipoS;
        this.tiempoCosecha = tc;
        this.tiempoSiembra = 0;
        this.dineroSiembra = d;
        this.ocupada = true;
        this.regada = false;
    }
    public void mostrarInfo()//MUESTRA "CIERTA" INFORMACIÓN DE LA PARCELA
    {
        Console.WriteLine("Tipo de siembra: " + this.tiposiembra);
        Console.WriteLine("Meses de cosecha: " + this.tiempoCosecha);
        Console.WriteLine("Dinero al cosechar: " + this.dineroSiembra);
    }
    public void mostrar()//MUESTRA OTRO TIPO DE INFORMACION DE LA PARCELA
    {
        Console.WriteLine("Tipo de siembra: " + this.tiposiembra);
        Console.WriteLine("Crecimiento: " + this.tiempoSiembra + " meses");
        if (this.regada)
        {
            Console.WriteLine("¿Fue regada este mes?: SI");
        }
        else
        {
            Console.WriteLine("¿Fue regada este mes?: NO");
        }

    }
    public string gettiposiembra()//COPIA DEL TIPO DE SIEMBRA
    {
        return this.tiposiembra;
    }
    public int gettiempocosecha()//COPIA DEL TIEMPO PARA LA COSECHA
    {
        return this.tiempoCosecha;
    }
    public int gettiempoSiembra()//COPIA DEL CRECIMIENTO DE LA PLANTA
    {
        return this.tiempoSiembra;
    }
    public bool getocupada()//COPIA DEL VALOR DE OCUPADA
    {
        return this.ocupada;
    }
    public bool getregada()//COPIA DEL VALOR DE REGADA
    {
        return this.regada;
    }
    public void regadatrue()//CAMBIO DEL VALOR DE REGADA A VERDADERO
    {
        this.regada = true;
        Console.WriteLine("La parcela fue regada correctamente, puede regarla otra vez el proximo mes");
    }
    public void regadafalse()//CAMBIO DEL VALOR DE REGADA A FALSO
    {
        this.regada = false;
    }
    public void aumentarmeses()//AUMENTO DE LOS MESES DE CRECIMIENTO DE UNA PLANTA
    {
        this.tiempoSiembra++;
    }
    public void desocupar()//CAMBIO DEL VALOR DE OCUPADA A FALSO
    {
        this.ocupada = false;
    }

}
class program
{
    static void Main()//PROGRAMA PRINCIPAL
    {
        int empleados = 0, meses = 0, filas = 0, columnas = 0, opcion = 0, mesess = 0, filaa = 0, columnaa = 0, riegos = 0, tipoSiembra = 0, ocupadas = 0;//INICIALIZACIÓN DE VARIABLES
        double dineroInicial = 0, sueldo = 0, egresos = 0, ingresos = 0;
        bool nul;//VARIABLE PARA VALIDAR VALORES NULOS Y ENTRADA A CICLOS
        Console.WriteLine("SISTEMA DE GESTIÓN DE GRANJA Y PARCELAS");
        Console.WriteLine("Ingrese los siguientes datos para continuar: ");
        Console.WriteLine();
        validacionInt("Cantidad de empleados (entero):", 1, ref empleados, "La granja tiene que tener por lo menos un (1) empleado");
        validacionDouble("Sueldo por empleado (solo la cantidad):", 50, ref sueldo, "El sueldo de los empleados debe ser de minimo Q50.00");
        validacionDouble("Dinero Inicial: ", (2 * (empleados * sueldo)), ref dineroInicial, "El dinero inicial no es suficiente para pagar a los empleados por lo menos por 2 meses, ingrese otro monto");
        validacionInt("Meses a (entero):", 1, ref meses, "El programa debe simular por lo menos un (1) mes");
        validacionInt("Cantidad de filas de las parcelas", 1, ref filas, "Las parcelas tiene que tener por lo menos una (1) fila");
        validacionInt("Cantidad de columnas de las parcelas", 1, ref columnas, "Las parcelas tiene que tener por lo menos una (1) columna");
        granja granja = new granja(dineroInicial, empleados, sueldo, meses);//CREACIÓN DE LA GRANJA
        parcela[,] parcelas = new parcela[filas, columnas];//CREACIÓN DE LA MAATRIZ DE PARCELAS
        Console.WriteLine();
        Console.WriteLine("Bienvenid@ al sistema de gestion");
        do//CICLO DO WHILE PARA EL MENÚ
        {
            Console.WriteLine("1. SEMBRAR");
            Console.WriteLine("2. REGAR PARCELAS");
            Console.WriteLine("3. CONSULTAR PARCELA");
            Console.WriteLine("4. AVANZAR DE MES");
            Console.WriteLine("5. SALIR");
            Console.WriteLine();
            validacionInt("Ingrese la opción que desea realizar: ", -100000, ref opcion, "Opción invalida, ingrese un número entre las opciones");
            switch (opcion)//CASE PARA LA OPCIÓN DEL MENÚ
            {
                case 1:
                    do//CASO UNO, SEMBRAR PARCELAS. NO PERMITE SEMBRAR SI YA HAY UNA PLANTA EN LA PARCELA.
                    {
                        Console.WriteLine("1. SEMBRAR");
                        Console.WriteLine("Ingresa la posición donde deseas sembrar");
                        validacionfc("Fila: ", 1, filas, ref filaa, "Opción invalida, el número sobrepasa las dimenciones de las parcelas" + filas + "x" + columnas);
                        validacionfc("Columna: ", 1, columnas, ref columnaa, "Opción invalida, el número sobrepasa las dimenciones de las parcelas" + filas + "x" + columnas);
                        nul = false;
                        if (parcelas[(filaa - 1), (columnaa - 1)] != null)//VALIDACIÓN DE VALOR NULO
                        {
                            if (parcelas[(filaa - 1), (columnaa - 1)].getocupada() == true)//VALIDACIÓN DE VALOR OCUPADA
                            {
                                Console.WriteLine("Esta parcela esta ocupada, ingrese otra");
                            }
                            else
                            {
                                nul = true;
                            }
                        }
                        else
                        {
                            nul = true;
                        }
                        if (nul)
                        {
                            Console.WriteLine();
                            Console.WriteLine("OPCIONES DE SIEMBRA");
                            Console.WriteLine("1. Papa");
                            Console.WriteLine("2. Tomate");
                            Console.WriteLine("3. Fresa");
                            tipoSiembra = 0;
                            validacionfc("Ingresa el número de la opción que deseas plantar: ", 1, 3, ref tipoSiembra, "Opción invalida, seleccione una de las opciones");
                            Console.WriteLine();
                            switch (tipoSiembra)//CASE PARA CREAR LOS OBJETOS DE LA MATRIZ
                            {
                                case 1:
                                    parcelas[(filaa - 1), (columnaa - 1)] = new parcela("Papa", 2, 450);
                                    granja.contarsembradas(0);

                                    break;
                                case 2:
                                    parcelas[(filaa - 1), (columnaa - 1)] = new parcela("Tomate", 3, 650);
                                    granja.contarsembradas(1);
                                    break;
                                case 3:
                                    parcelas[(filaa - 1), (columnaa - 1)] = new parcela("Fresa", 4, 900);
                                    granja.contarsembradas(2);
                                    break;
                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                            Console.WriteLine("Parcela sembrada correctamente");
                            parcelas[(filaa - 1), (columnaa - 1)].mostrarInfo();
                            Console.WriteLine();
                        }
                    } while (!nul);

                    break;
                case 2://REGAR PARCELAS. NO PERMITE REGAR PARCELAS SI NO HAY SIEMBRA Y SI YA FUE REGADA DURANTE EL MES. QUITA Q40.00 Y VUELVE TRUE EL VALOR DE REGADA.
                    Console.WriteLine("2. REGAR PARCELA");
                    if (granja.getdinero() < 40)
                    {
                        Console.WriteLine();
                        Console.WriteLine("No tiene suficiente dinero para regar la parcela. Necesita por lo menos Q40.00");//VALIDACIÓN DE DINERO SUFICIENTE.
                    }
                    else
                    {
                        Console.WriteLine("Ingresa la posición de la parcela que desea regar:");
                        validacionfc("Fila: ", 1, filas, ref filaa, "Opción invalida, el número sobrepasa las dimenciones de las parcelas" + filas + "x" + columnas);
                        validacionfc("Columna: ", 1, columnas, ref columnaa, "Opción invalida, el número sobrepasa las dimenciones de las parcelas" + filas + "x" + columnas);
                        Console.WriteLine();
                        nul = false;
                        if (parcelas[(filaa - 1), (columnaa - 1)] != null)//VALIDACIÓN VALOR NULO
                        {
                            if (!parcelas[(filaa - 1), (columnaa - 1)].getocupada())//VALIDACIÓN VALOR OCUPADA
                            {
                                Console.WriteLine("No se puede regar una parcela donde no hay ninguna planta.");
                            }
                            else
                            {
                                if (parcelas[(filaa - 1), (columnaa - 1)].getregada())
                                {
                                    Console.WriteLine("Esta parcela ya fue regada este mes");

                                }
                                else
                                {
                                    parcelas[(filaa - 1), (columnaa - 1)].regadatrue();
                                    riegos++;
                                    granja.cobraregresos(40, ref egresos);
                                    Console.WriteLine(", por regar la parcela");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se puede regar una parcela donde no hay ninguna planta");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("3. CONSULTAR PARCELA");//MUESTRA LA INFORMACIÓN DISPONIBLE DE LAS PARCELAS.
                    Console.WriteLine("Ingresa la posición de la parcela que deseas consultar");
                    validacionfc("Fila: ", 1, filas, ref filaa, "Opción invalida, el número sobrepasa las dimenciones de las parcelas" + filas + "x" + columnas);
                    validacionfc("Columna: ", 1, columnas, ref columnaa, "Opción invalida, el número sobrepasa las dimenciones de las parcelas" + filas + "x" + columnas);
                    Console.WriteLine();
                    nul = false;
                    if (parcelas[(filaa - 1), (columnaa - 1)] != null)
                    {
                        if (parcelas[(filaa - 1), (columnaa - 1)].getocupada() == false)
                        {
                            Console.WriteLine("Esta parcela esta desocupada y disponible para la siembra");
                        }
                        else
                        {
                            parcelas[(filaa - 1), (columnaa - 1)].mostrar();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Esta parcela esta desocupada y disponible para la siembra");
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("4. AVANZAR DE MES");//COMPLETA
                    if (granja.getdinero() < (empleados * sueldo))
                    {
                        Console.WriteLine();
                        Console.WriteLine("No tiene suficiente dinero para pagarle a los empleados. El programa se cerrara automaticamente, pues no es posible avanzar de mes");
                        opcion = 5;//SI EL DINERO NO ALCANZA PARA PAGAR A LOS EMPLEADOS EL PROGRAMA SE CIERRA AUTOMATICAMENTE AL NO PODER PAGAR A LOS EMPLEADOS Y POR ENDE NO PODER CAMBIAR DE MES
                    }
                    else
                    {
                        Console.WriteLine();
                        for (int i = 0; i < filas; i++)
                        {
                            for (int j = 0; j < columnas; j++)
                            {
                                if (parcelas[(i), (j)] != null)
                                {
                                    if (parcelas[(i), (j)].getocupada() == true)
                                    {
                                        parcelas[i, j].aumentarmeses();

                                        if (parcelas[i, j].getregada() == true)
                                        {
                                            parcelas[i, j].aumentarmeses();
                                            Console.WriteLine("La parcela en la fila " + (i + 1) + " columna " + (j + 1) + " fue regada durante el mes entonces su crecimiento aumenta 2 meses");
                                            parcelas[i, j].regadafalse();
                                        }
                                        if (parcelas[i, j].gettiempoSiembra() == parcelas[i, j].gettiempocosecha())
                                        {
                                            parcelas[i, j].desocupar();
                                            Console.WriteLine("¡Parcela cosechada! Se desocupo la parcela en la fila " + (i + 1) + " columna " + (j + 1));
                                            if (parcelas[i, j].gettiposiembra() == "Papa")
                                            {
                                                granja.contarcosechas(0);
                                                granja.ingresos(450, ref ingresos);
                                            }
                                            if (parcelas[i, j].gettiposiembra() == "Tomate")
                                            {
                                                granja.contarcosechas(1);
                                                granja.ingresos(650, ref ingresos);
                                            }
                                            if (parcelas[i, j].gettiposiembra() == "Fresa")
                                            {
                                                granja.contarcosechas(2);
                                                granja.ingresos(900, ref ingresos);
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        Console.WriteLine();
                        mesess++;
                        granja.cobraregresos((empleados * sueldo), ref egresos);
                        Console.WriteLine(", por el sueldo de los empleados");//NO PUEDE AVANZAR DE MES SI NO LE PAGA A LOS EMPLEADOS
                        Console.WriteLine("Meses avanzado");
                        Console.WriteLine();
                    }

                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");

                    break;
                default:
                    Console.WriteLine("Opción invalida, ingrese un número entre las opciones");
                    break;
            }
            Console.WriteLine();
            if (granja.getdinero() <= 0)
            {
                Console.WriteLine("El dinero se acabo, la simulacion terminara...");
                opcion = 5;
            }
            if (mesess == meses)
            {
                Console.WriteLine("Los meses a simular finalizaron, la simulacion terminara...");
                opcion = 5;
            }
        } while (opcion != 5);
        Console.WriteLine();
        Console.WriteLine("Dinero final: Q" + granja.getdinero());
        Console.WriteLine("Ingresos: Q" + ingresos);
        Console.WriteLine("Egresos: Q" + egresos);
        Console.WriteLine("Meses simulados: " + mesess);
        Console.WriteLine("Parcelas con papa:");
        Console.WriteLine("Sembradas: " + granja.nosembradas(0));
        Console.WriteLine("Cosechadas: " + granja.nocosechas(0));
        Console.WriteLine("Parcelas con tomate:");
        Console.WriteLine("Sembradas: " + granja.nosembradas(1));
        Console.WriteLine("Cosechadas: " + granja.nocosechas(1));
        Console.WriteLine("Parcelas con fresa:");
        Console.WriteLine("Sembradas: " + granja.nosembradas(2));
        Console.WriteLine("Cosechadas: " + granja.nocosechas(2));
        Console.WriteLine("Riegos totales: " + riegos);
        nul = false;
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (parcelas[i, j] != null)
                {
                    if (parcelas[(i), j].getocupada() == true)
                    {
                        ocupadas++;
                    }
                }

            }
        }
        Console.WriteLine("Parcelas ocupadas: " + ocupadas);
    }
    static void validacionDouble(string intru, double comparador, ref double z, string m)//PROCEMIENTO PARA EVITAR QUE INGRESEN LETRAS EN VEZ DE NÚMEROS PARA DOUBLE
    {
        bool v = false;
        do
        {
            Console.WriteLine(intru);
            string x = Console.ReadLine();

            if (!double.TryParse(x, out z))
            {
                Console.WriteLine("Dato incorrecto, por favor, ingrese un número");
            }
            else
            {
                if (z < comparador)
                {
                    Console.WriteLine(m);
                }
                else
                {
                    v = true;
                }
            }
        } while (!v);
    }

    static void validacionInt(string intru, double comparador, ref int z, string m)//PROCEMIENTO PARA EVITAR QUE INGRESEN LETRAS EN VEZ DE NÚMEROS PARA INT
    {
        bool v = false;
        do
        {
            Console.WriteLine(intru);
            string x = Console.ReadLine();

            if (!int.TryParse(x, out z))
            {
                Console.WriteLine("Dato incorrecto, por favor, ingrese el tipo de dato que se le solicita");
            }
            else
            {
                if (z < comparador)
                {
                    Console.WriteLine(m);
                }
                else
                {
                    v = true;
                }
            }
        } while (!v);
    }
    static void validacionfc(string intru, double c1, double c2, ref int z, string m)//VALIDACIÓN PARA FILAS Y COLUMNAS PARA QUE NO SE INGRESEN LETRAS NI SE PASE DEL RANGO DE LA PARCELA
    {
        bool v = false;
        do
        {
            Console.WriteLine(intru);
            string x = Console.ReadLine();

            if (!int.TryParse(x, out z))
            {
                Console.WriteLine("Dato incorrecto, por favor, ingrese un número entero");
            }
            else
            {
                if (z < c1 || z > c2)
                {
                    Console.WriteLine(m);
                }
                else
                {
                    v = true;
                }
            }
        } while (!v);
    }
}
