using System;
using System.Drawing;
class Program
{
    static void Main()
    {
        //LAS VARIABLES DE LOS DATOS DE ENTRADA NUMERICOS SE DECLARAN COMO STRING PARA VALIDAR QUE EL ESPACIO NO QUEDE VACIO Y QUE NO SE INGRESEN LETRAS, LUEGO SE CONVIERTEN A INT PARA HACER LAS DEMÁS VALIDACIONES Y CÁLCULOS
        Console.WriteLine("SISTEMA PARQUEO INTELIGENTE: SMARTPARK");
        string nombreOperador, codigoTurno, capacidadParqueo;
        bool tipoDato = true;
        do
        {
            Console.WriteLine("Ingrese su nombre: ");//SOLICITA UN TEXTO PARA EL "NOMBRE DEL OPERADOR"
            nombreOperador = Console.ReadLine();
            if (nombreOperador == "")//VALIDACIÓN DE ENTRADA (EL ESPACIO NO PUEDE QUEDAR VACIO, SE REPITE HASTA QUE SE INGRESE UN CARACTERER)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este espacio no puede quedar vacio, ingrese su nombre correctamente");
                Console.ResetColor();
            }
            else
            {
                tipoDato = nombreOperador.Any(char.IsDigit);

                if (tipoDato)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La entrada no debe contener números.");
                    Console.ResetColor();
                }
                else
                {
                    tipoDato = false;
                }
            }
            Console.WriteLine();
        } while (nombreOperador == "" || tipoDato);//TERMINA EL CICLO PARA PEDIR EL NOMBRE
        do
        {
            tipoDato = false;//ESTA VARIABLE DE TIPO BOOL SIRVE PARA SIMPLIFICAR LA CONDICIÓN DE LOS CICLOS, SE REUTILIZA EN VARIAS CONDICIONES
            Console.WriteLine("Ingrese el código de turno: ");//SOLICITA UN NÚMERO DE 4 DÍGITOS PARA EL CÓDIGO DE TURNO
            codigoTurno = Console.ReadLine();
            if (!int.TryParse(codigoTurno, out int codigo))//VALIDACIÓN DE ENTRADA (AL SER UNA ENTRADA NÚMERICA NO PUEDE INGRESAR LETRAS, NI DEJAR EL ESPACIO EN BLANCO)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dato incorrecto, ingrese un número");
                Console.ResetColor();
            }
            else
            {
                if (codigo < 1000 || codigo > 9999)//VALIDACIÓN DE ENTRADA (EL CÓDIGO TIENE QUE TENER 4 DÍGITOS. SE ESTABLECIO QUE EL CÓDIGO SOLO TUVIERA NÚMEROS)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El código tiene que ser de exactamente 4 dígitos");
                    Console.ResetColor();
                }
                else
                {
                    tipoDato = true;
                }
            }
            Console.WriteLine();
        } while (!tipoDato);//TERMINA EL CICLO QUE VALIDA EL CÓDIGO DE TURNO
        do
        {
            tipoDato = false;
            Console.WriteLine("Ingrese la capacidad del parqueo (Mínimo 10 espacios): ");//SOLICITA UN NÚMERO MAYOR QUE 10 PARA LA CAPACIDAD DEL PARQUEO
            capacidadParqueo = Console.ReadLine();
            if (!int.TryParse(capacidadParqueo, out int capacidad))//VALIDACIÓN DE ENTRADA (AL SER UNA ENTRADA NÚMERICA NO PUEDE INGRESAR LETRAS, NI DEJAR EL ESPACIO EN BLANCO)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dato incorrecto, ingrese un número");
                Console.ResetColor();
            }
            else
            {
                if (Convert.ToInt32(capacidad) < 10)//VALIDACIÓN DE ENTRADA (LA CAPACIDAD TIENE QUE SER DE 10 O MÁS)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La capacidad del parqueo tiene que ser de mínimo 10 espacios, vuelva a ingresar la capacidad del parqueo");
                    Console.ResetColor();
                }
                else
                {
                    tipoDato = true;
                }
            }
            Console.WriteLine();
        } while (!tipoDato);//TERMINA EL CICLO QUE VALIDA LA CAPACIDAD DEL PARQUEO
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("INGRESANDO AL SISTEMA..");
        Console.ResetColor();
        //ES NECESARIO INICIALIZAR VARIAS VARIABLES A LAS QUE SE LES ASIGNA UN VALOR DENTRO DE OTROS CICLOS, PARA QUE EL PROGRAMA LAS RECONOZCA
        int ticketsCreados = 0, ticketsCerrados = 0, tiempoSimulado = 0, opcion, vehiculo = 0, minutoEntrada = 0, minutosEstacionados, parqueoActivo = 0;
        bool ticketActivo = false;
        string op, minutosSolicitados, nombreCliente, placa, tipoVehiculo, vip = "", tipo = "";
        double dineroRecaudado = 0, tarifa = 0, totalPagar = 0;
        do//ESTE DO WHILE ES EL CICLO PRINCIPAL, QUE REPITE EL PROGRAMA HASTA QUE EL USUARIO SELECCIONES SALIR
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Menú Sistema de parqueo inteligente SMARTPARK");
            Console.WriteLine("1. CREAR TICKET DE ENTRADA");
            Console.WriteLine("2. REGISTRAR SALIDA Y REGISTRAR COBRO");
            Console.WriteLine("3. VER ESTADO DE PARQUEO");
            Console.WriteLine("4. SIMULAR PASA DEL TIEMPO");
            Console.WriteLine("5. SALIR");
            Console.ResetColor();
            op = Console.ReadLine();//SE SOLICITA UN DATO NUMERICO PARA LA OPCIÓN DEL MENÚ
            Console.WriteLine();
            if (!int.TryParse(op, out opcion))//VALIDACIÓN DATO DE ENTRADA (AL SER UNA ENTRADA NÚMERICA, NO SE PERMITE QUE INGRESE LETRAS NI QUE DEJE EL ESPACIO VACIO)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dato incorrecto, ingrese un número");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                tipoDato = true;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("CREAR TICKET");
                        if (ticketActivo == true) {//VALIDACIÓN DE TICKET ACTIVO (NO SE PUEDE CREAR UNO SI YA HAY OTRO ACTIVO)
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No se puede crear un ticket si ya hay un ticket activo, cancele el ticket activo para crear otro");
                            Console.ResetColor();
                        }
                        else
                        {
                            if (Convert.ToInt32(capacidadParqueo) == ticketsCreados)//VALIDACIÓN PARQUEO (NO SE PUEDEN CREAR TICKETS SI EL PARQUEO ESTA LLENO)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("El parqueo ya esta lleno, no puede crear más ticket");
                                Console.ResetColor();
                            }
                            else
                            {
                                do
                                {
                                    Console.WriteLine("Ingrese el nombre del cliente: ");//SOLICITA UN TEXTO PARA EL "NOMBRE CLIENTE"
                                    nombreCliente = Console.ReadLine();
                                    if (nombreCliente == "")//VALIDACIÓN DE ENTRADA (EL ESPACIO NO PUEDE QUEDAR VACIO)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Este espacio no puede quedar vacio, ingrese su nombre correctamente");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        tipoDato = nombreOperador.Any(char.IsDigit);

                                        if (tipoDato)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("La entrada no debe contener números.");
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            tipoDato = false;
                                        }
                                    }
                                } while (nombreCliente == "" || tipoDato);//TERMINA EL CICLO PARA PEDIR EL NOMBRE DEL CLIENTE
                                do
                                {
                                    tipoDato = false;
                                    Console.WriteLine("Ingrese el número de la opción del tipo de vehiculo");
                                    Console.WriteLine("1. Moto 2. Carro 3. Pick-up");//SOLICITA 6 CARACTERES PARA LA PLACA
                                    tipoVehiculo = Console.ReadLine();
                                    if (!int.TryParse(tipoVehiculo, out vehiculo))//VALIDACIÓN DE ENTRADA (AL SER UNA ENTRADA NÚMERICA NO PUEDE INGRESAR LETRAS, NI DEJAR EL ESPACIO EN BLANCO)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Dato incorrecto, vuelva a ingresarlo");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        if (vehiculo < 1 || vehiculo > 3)//VALIDA QUE EL NÚMERO ESTE ENTRE LAS OPCIONES DADAS
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("La opción no existe, elija otra");
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            tipoDato = true;
                                        }
                                    }

                                } while (!tipoDato);//TERMINA EL CICLO QUE VALIDA EL TIPO DE VEHICULO
                                do
                                {
                                    tipoDato = false;
                                    Console.WriteLine("Ingrese la placa del vehiculo (Entre 6 y 8 caracteres)");//SOLICITA 6 CARACTERES PARA LA PLACA
                                    placa = Console.ReadLine();
                                    if (!long.TryParse(placa, out long placaVehiculo))//VALIDACIÓN DE ENTRADA (AL SER UNA ENTRADA NÚMERICA NO PUEDE INGRESAR LETRAS, NI DEJAR EL ESPACIO EN BLANCO)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Dato incorrecto, vuelva a ingresarlo");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        if (placaVehiculo < 100000 || placaVehiculo > 99999999)//VALIDACIÓN DE ENTRADA (LA PLACA TIENE QUE TENER ENTRE 6 Y 8 CARACTERES)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("El placa tiene que tener entre 6 y 8 caracteres");
                                            Console.ResetColor();
                                        }
                                        else
                                        {
                                            tipoDato = true;
                                        }
                                    }

                                } while (!tipoDato);//TERMINA EL CICLO QUE VALIDA LA PLACA DEL VEHICULO
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("TICKET CREADO CORRECTAMENTE");
                                Console.ResetColor();
                                ticketActivo = true;//SE LIBERA EL TICKETS
                                ticketsCreados++;//AUMENTAN LOS TICKETS CREADOS
                                minutoEntrada = tiempoSimulado;//SE GUARDA EL MINUTO DE ENTRADA
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("CANCELAR TICKET");
                        if (ticketActivo == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No es posible calcelar un ticket si no hay un ticket activo");//SI NO HAY UN TICKET ACTIVO NO SE PUEDE CANCELAR UN TICKET
                            Console.ResetColor();
                        }
                        else
                        {
                            minutosEstacionados = tiempoSimulado - minutoEntrada;//CALCULO DE LOS MINUTOS ESTACIONADOS
                            if (minutosEstacionados <= 15)//SI LOS MINUTOS ESTACIONADOS SON MENORES A 15 NINGÚN TIPO DE VEHICULO PAGA TARIFA, SINO SE COBRA DEPENDIENDO DEL VEHICULO
                            {
                                totalPagar = 0;
                            }
                            else
                            {
                                switch (vehiculo)//CASE PARA DETERMINAR QUE PARAMETROS SE USARAN PARA COBRAR DEPENDIENDO DEL TIPO DE VEHICULO
                                {
                                    case 1:
                                        if (minutosEstacionados > 360)
                                        {
                                            tarifa = 55;
                                        }
                                        else
                                        {
                                            tarifa = (minutosEstacionados * 5) / 60;
                                        }
                                        Console.WriteLine("Tipo de vehiculo: Moto");
                                        break;
                                    case 2:
                                        if (minutosEstacionados > 360)
                                        {
                                            tarifa = 85;
                                        }
                                        else
                                        {
                                            tarifa = (minutosEstacionados * 10) / 60;
                                        }
                                        Console.WriteLine("Tipo de vehiculo: Carro");
                                        break;
                                    case 3:
                                        if (minutosEstacionados > 360)
                                        {
                                            tarifa = 115;
                                        }
                                        else
                                        {
                                            tarifa = (minutosEstacionados * 15) / 60;
                                        }
                                        Console.WriteLine("Tipo de vehiculo: Pick-up");
                                        break;
                                    default:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("ERROR");//ES IMPORTANTE SIEMPRE COLOCAR EL DEFAULT, AUNQUE DEBERIA DE SER IMPOSIBLE QUE EL USUARIO LLEGUE A ÉL EN ESTE CASO
                                        Console.ResetColor();
                                        break;
                                        
                                }
                                do
                                {
                                    Console.WriteLine("¿Es un cliente VIP? (Si/NO) ");//INDICAR SI SE TRATA DE UN CLIENTE VIP O NO, PARA VER SI SE APLICA EL DESCUENTO
                                    vip = Console.ReadLine();
                                    if (vip == "")//VALIDACIÓN DE ENTRADA (EL ESPACIO NO PUEDE QUEDAR VACIO)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Este espacio no puede quedar vacio, ingrese el dato correctamente");
                                        Console.ResetColor();
                                    }
                                    Console.WriteLine();
                                } while (vip == "");//TERMINA EL CICLO PARA PEDIR SI ES VIP O NO
                                do
                                {
                                    tipoDato = false;
                                    if (vip.ToLower() == "si" || vip.ToLower() == "sí")
                                    {
                                        totalPagar = tarifa - (tarifa * 0.1);//SI ES VIP SE LE APLICA EL 10% DE DESCUENTO
                                        tipoDato = true;
                                    }
                                    else
                                    {
                                        if (vip.ToLower() == "no")
                                        {
                                            totalPagar = tarifa;//SINO ES VIP EL TOTAL A PAGAR SE IGUALA A LA TARIFA
                                            tipoDato = true;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Ingrese el dato correctamente, vuelva a intentarlo");
                                            Console.ResetColor();
                                        }
                                    }
                                } while (!tipoDato);//TERMINA EL CICLO QUE VALIDA SI EL CLIENTE EL VIP O NO
                            }
                            Console.WriteLine("Tiempo estacionado: " + minutosEstacionados + " minutos");
                            Console.WriteLine("La tarifa a pagar es de Q" + totalPagar);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("TICKET CANCELADO CORRECTAMENTE");
                            Console.ResetColor();
                            ticketActivo = false;//SE LIBERA EL TICKET ACTIVO
                            ticketsCerrados++;//AUMENTAN LOS TICKETS CERRADOS
                            dineroRecaudado = dineroRecaudado + totalPagar;//SE SUMA LA TARIFA A EL DINERO RECAUDADO
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("VER ESTADO DEL PARQUEO");
                        parqueoActivo = Convert.ToInt32(capacidadParqueo) - ticketsCreados;//SE CALCULAS LOS ESTACIOS DISPONIBLES, YA DESPUÉS SOLO RE IMPRIMEN RESULTADOS
                        Console.WriteLine("Capacidad total SmartPark: " + capacidadParqueo );
                        Console.WriteLine("Parqueos Ocupados: " + ticketsCreados);
                        Console.WriteLine("Parqueos Disponibles: " + parqueoActivo);
                        Console.WriteLine("Tiempo transcurrido: " + tiempoSimulado);
                        Console.WriteLine("Dinero recaudado: Q" + dineroRecaudado);
                        Console.WriteLine("Tickets creados: " + ticketsCreados);
                        Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("SIMULAR PASO DEL TIEMPO");
                        do
                        {
                            tipoDato = false;//ESTA VARIABLE DE TIPO BOOL SIRVE PARA SIMPLIFICAR LA CONDICIÓN DE LOS CICLOS, SE REUTILIZA EN VARIAS CONDICIONES
                            Console.WriteLine("Ingrese la cantidad de minutos trascurridos (De 1 a 1440):");
                            minutosSolicitados = Console.ReadLine();
                            if (!int.TryParse(minutosSolicitados, out int minutos))//VALIDACIÓN DE ENTRADA (AL SER UNA ENTRADA NÚMERICA NO PUEDE INGRESAR LETRAS, NI DEJAR EL ESPACIO EN BLANCO)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Dato incorrecto, ingrese un número");
                                Console.ResetColor();
                            }
                            else
                            {
                                if (minutos < 1 || minutos > 1440)//VALIDACIÓN DE ENTRADA (EL CÓDIGO TIENE QUE TENER 4 DÍGITOS. SE ESTABLECIO QUE EL CÓDIGO SOLO TUVIERA NÚMEROS)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("El tiempo que ingrese debe estar entre 1 y 1440 minutos");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    tipoDato = true;
                                }
                            }
                        } while (!tipoDato);//TERMINA EL CICLO QUE VALIDA EL CÓDIGO DE TURNO
                        tiempoSimulado = tiempoSimulado + Convert.ToInt32(minutosSolicitados);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("TIEMPO AGREGADO CORRECTAMENTE");
                        Console.ResetColor();
                        Console.WriteLine("Minutos ingresados: " + minutosSolicitados);
                        Console.WriteLine("Tiempo simulado: " + tiempoSimulado + " minutos");
                        Console.WriteLine();
                        break;
                    case 5://SOLO SE IMPRIMEN RESULTADOS
                        Console.WriteLine("Generando resumen del turno...");
                        Console.WriteLine();
                        Console.WriteLine("Operador: " + nombreOperador + " Código: " + codigoTurno);
                        Console.WriteLine("Capacidad parqueo: " + capacidadParqueo);
                        Console.WriteLine("Duración del turno: " + tiempoSimulado);
                        Console.WriteLine("Tickets creados: " + ticketsCreados);
                        Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
                        Console.WriteLine("Espacios disponibles: " + parqueoActivo);
                        Console.WriteLine("Total recaudado: " + dineroRecaudado);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("SALIENDO...");
                        Console.ResetColor();
                        break;
                    default://INFORMAR QUE LA OPCIÓN SELECCIONADA NO EXISTE EN EL MENÚ Y VOLVER A REPETIR EL CICLO DEL MENÚ SIN SALIR
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La opción no se encuentra en el menú, porfavor, ingrese una opción del menú");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                }
            }
            
        } while (opcion != 5);//CUANDO EL USUARIO INGRESE LA OPCIÓN "5" EL CICLO SE TERMINA Y SE TERMINA EL PROGRAMA
    }
}

