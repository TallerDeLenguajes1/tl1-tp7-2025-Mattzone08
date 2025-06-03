using EspacioCalculadora;

double dato, datoPrevio;
int option;
string operacion = "";
bool successA, successB;

do
{
    Console.WriteLine("INgrese el valor del Dato INICILAL:");
    successA = double.TryParse(Console.ReadLine(), out dato);
} while (!successA);

Calculadora NuevaCalculadora = new Calculadora(dato);

do
{
    Console.WriteLine("----------CALCULADORA 1 ----------");
    Console.WriteLine($"--> VALOR DE DATO ACTUAL: {NuevaCalculadora.Resultado} ");
    Console.WriteLine("1- Suma");
    Console.WriteLine("2- Resta");
    Console.WriteLine("3- Multiplicacion");
    Console.WriteLine("4- Division");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("6- Salir");
    successB = int.TryParse(Console.ReadLine(), out option);

    if (successB && option >= 1 && option <= 6)
    {
        datoPrevio = NuevaCalculadora.Resultado;
        switch (option)
        {
            case 1:
                NuevaCalculadora.Sumar(datoPrevio);
                operacion = "suma";
                break;
            case 2:
                NuevaCalculadora.Restar(datoPrevio);
                operacion = "resta";
                break;
            case 3:
                NuevaCalculadora.Multiplicar(datoPrevio);
                operacion = "multuplicacion";
                break;
            case 4:
                operacion = "division";
                if (datoPrevio != 0)
                {
                    NuevaCalculadora.Dividir(datoPrevio);
                }
                else
                {
                    Console.WriteLine("No se puede dividir por 0.");
                    operacion = "";
                }
                break;
            case 5:
                operacion = "";
                NuevaCalculadora.Limpiar();
                Console.WriteLine($"El dato ha sido limpiado. Ahora vale: {NuevaCalculadora.Resultado}");
                break;
            case 6:
                Console.WriteLine("Saliendo... FIN.");
                break;
            default:
                Console.WriteLine("Caso default.");
                break;
        }
        if (operacion != "")
        {
            Console.WriteLine($"La {operacion} de {datoPrevio} y {datoPrevio} es igual a: {NuevaCalculadora.Resultado}");
        }
        Console.WriteLine("¿Desea realizar otro cálculo? Ingrese 6 para salir:");
        int.TryParse(Console.ReadLine(), out option);
        operacion = "";

        if (option==6) {
            Console.WriteLine("Saliendo... FIN.");
        }
    }
    else
    {
        Console.WriteLine("Opcion ingresada no valida.");
    }
} while (option != 6);


