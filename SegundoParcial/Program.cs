int[,]  tablero = new int[6, 6];
List<int> numerosPermitidos = new List<int> { 0, 1, 2, 3,4,};

    void paso1_crear_tablero()
{
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            tablero[f, c] = 0;
        }
    }
}

void paso2_colocar_barcos()
{
    tablero[4, 3] = 1;
    tablero[1, 1] = 1;
    tablero[2, 1] = 1;
    tablero[3, 4] = 1;
}

void paso3_imprimir_tablero()
{
  
    String caracter_imprimir = "";
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            switch (tablero[f, c])
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    caracter_imprimir = "^";
                    break;

                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    caracter_imprimir = "~";
                    break;

                case -1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    caracter_imprimir = ".";
                    break;

                case -2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    caracter_imprimir = "*";
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    caracter_imprimir = "-";
                    break;
            }
            Console.Write(caracter_imprimir + "");
        }
        Console.WriteLine();
    }
}

    
void paso4_ingreso_coordenadas()

{
 
        int filas, columna = 0;
        int i1= 10;
     

    Console.Clear();
    do
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tienes 30 segundos para ganarr.");
        int timeRemaining = 30;
        Timer timer = new Timer(state =>
        {
            timeRemaining--;

            if (timeRemaining == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Auchhh se te acabo el tiempo.");
                Environment.Exit(0);
            }
        }, null, 0, 1000);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("******************************************************");
        Console.WriteLine("****************Bienvenido a Battleship***************");
        Console.WriteLine("******************************************************");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Solo puede usar numeros del 0 al 5");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;


        Console.WriteLine($"Tienes {i1} intentos");
        Console.Write("Ingresa la fila: ");
        filas = Convert.ToInt32(Console.ReadLine());
        if (!numerosPermitidos.Contains(filas))
        {
            Console.WriteLine("El numero ingresado no es valido");
        }
        Console.Write("Ingresa la columna: ");
        columna = Convert.ToInt32(Console.ReadLine());
        if (!numerosPermitidos.Contains(columna))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("El numero ingresado no es valido");
        }
        if (tablero[filas, columna] == 1)
        {
            Console.Beep();
      
            tablero[filas, columna] = -1;
        }
        else
        {
            tablero[filas, columna] = -2;
        }
        Console.Clear();
        paso3_imprimir_tablero();
    } while (true);
}
paso1_crear_tablero();
paso2_colocar_barcos();
paso3_imprimir_tablero();
paso4_ingreso_coordenadas();
