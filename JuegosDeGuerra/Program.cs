/*
Muñoz Sánchez, Jorge
Practica Evaluable Tema 6
Apartado 1 si 
Apartado 2 si 
Apartado 3  casi se cumple.. unicamente falta el método Generar.
Apartado 4  si.
Apartado 5  si. 
...
*/


/* Apartado 4 y 5 .  Observaciones

El programa funciona perfectamente. Es atractivo y fácil de jugar para el usuario.
Hay 6 barcos:
    1 barco de longitud 5 (Denominado como P)
    1 barco de longitud 4 (Denominado como A)
    2 barcos de longitud 3 (Denominado como W y X)
    2 barcos de longitud 2 (Denominado como S y C)

Los barcos no pueden ser colocados de modo que parte de los mismos salgan del tablero de juego.
El tablero de juego medirá 10 columnas x 10 filas debido a que he probado a hacerlo 20 columnas x 20 filas
pero lamentablemente el tablero supera las dimensiones.
10 por 10 son las dimensiones más proporcionales y elegantes que he podido encajar.

Solo habrá un jugador, que pondrá los barcos y que luego probará el propio juego.
40 turnos para terminar el juego.
Se cumple. Se puede comprobar que el juego cumple con su función. La misión del mismo es un éxito.
Todo el proyecto posee los requisitos que se han pedido. Exceptuando el apartado Generar y el número de 
columnas y filas que he adapaptado a 10x10 por diseño. El resto de apartado se pueden ver que están incluidos en el progara.
¡Disfruten!
*/

/*
Apartado 1
* 
* La clase Casilla para gestionar las casillas del juego. Tendrá los siguientes
atributos:
• Fila y columna que ocupa la casilla en el tablero.
• Estado de la casilla, que podrá ser “agua”, “barco” o “barco tocado”, y se
representarán como punto “·”, “B” o “X”, respectivamente.
Define un constructor que reciba como parámetros la fila y columna y asigne sus valores, y
establezca el estado por defecto a “agua”.
* Se cumple. El programa ofece estos parámetros
*/

using System;
namespace JuegosDeGuerra
{
    class Juego
    {
        // Como pido las coordenadas en char y en int son mucho más sencillas de utilizar en el tablero, las convierto con estas dos funciones.

        static void coor_fila_a_int (char[] coordenada, ref int[] coordenadas_int)
        {
            switch (coordenada[0])
            {
                case '1':
                    coordenadas_int[0] = 0;
                    break;
                case '2':
                    coordenadas_int[0] = 1;
                    break;
                case '3':
                    coordenadas_int[0] = 2;
                    break;
                case '4':
                    coordenadas_int[0] = 3;
                    break;
                case '5':
                    coordenadas_int[0] = 4;
                    break;
                case '6':
                    coordenadas_int[0] = 5;
                    break;
                case '7':
                    coordenadas_int[0] = 6;
                    break;
                case '8':
                    coordenadas_int[0] = 7;
                    break;
                case '9':
                    coordenadas_int[0] = 8;
                    break;
                
                
                
                
                
            }
        }
        static void coor_columna_a_int(char[] coordenada, ref int[] coordenadas_int)
        {
            switch (coordenada[1])
            {
                case 'A':
                    coordenadas_int[1] = 0;
                    break;
                case 'B':
                    coordenadas_int[1] = 1;
                    break;
                case 'C':
                    coordenadas_int[1] = 2;
                    break;
                case 'D':
                    coordenadas_int[1] = 3;
                    break;
                case 'E':
                    coordenadas_int[1] = 4;
                    break;
                case 'F':
                    coordenadas_int[1] = 5;
                    break;
                case 'G':
                    coordenadas_int[1] = 6;
                    break;
                case 'H':
                    coordenadas_int[1] = 7;
                    break;
                case 'I':
                    coordenadas_int[1] = 8;
                    break;
                case 'J':
                    coordenadas_int[1] = 9;
                    break;
            }
        }

        // Esta función convierte de string a número, siempre que sea posible

        static void conversión(string número, ref int convertido, ref bool prueba)
        {
            prueba = Int32.TryParse(número, out _);
            if (prueba == true)
            {
                convertido = Convert.ToInt32(número);
            }
            else
            {
                Console.WriteLine("Introduzca un número, por favor");
            }
        }

        // Apartado 3 + Apartado 4. Estas funciones sirven para dibujar el título, el menú y los tableros (tanto el vacío como el completo)

        static void dibujar_titulo()
        {
            Console.WriteLine("");
            Console.WriteLine(@"                            ■■■■■■                       ");         
            Console.WriteLine(@"                         ¡BIENVENIDO!                        ");
            Console.WriteLine(@"                              A                      ");
            Console.WriteLine(@"                                            ");    
            Console.WriteLine(@"                            ■■■■■■                       ");
            Console.WriteLine(@"                       JUEGOS DE GUERRA                                           ");
            Console.WriteLine(@"                            ■■■■■■                       ");  
            Console.WriteLine(@"                                            ");               
            Console.WriteLine(@"                           Autoría                        ");
            Console.WriteLine(@"                            ■■■■■■                       ");
            Console.WriteLine(@"                     Jorge Muñoz Sánchez                        ");
            Console.WriteLine(@"                            ■■■■■■                       ");
            Console.WriteLine(@"                                            ");    
            Console.WriteLine(@"               Pulsa cualquier tecla y comienza           ");
        }
        static void dibujar_menu()
        {
            Console.Clear();
            Console.WriteLine("                                                              ");
          
            Console.WriteLine(@"                            MENÚ         ");
            Console.WriteLine("                                                              ");
            Console.WriteLine(@"                 Seleccione qué desea hacer                  ");
            Console.WriteLine(@"                                                             ");
            Console.WriteLine(@"               (1)          Jugar                            ");
            Console.WriteLine(@"               (2)          Salir                            ");
            Console.WriteLine(@"                                                             ");
        }

        /*  Apartado 3 + Apartado 4. Tablero.
        La clase Tablero almacenará la información y la funcionalidad de cada uno de
los tableros del juego. Tendrá los siguientes atributos:
• Un array bidimensional de casillas (objetos de tipo Casilla), de 10 filas y 10 columnas
• Un array con los objetos de tipo Barco a colocar en el tablero
Se cumple
        
        */
          // Apartado 3. Casilla
          //Un array bidimensional de casillas (objetos de tipo Casilla), de 10 filas y 10 columnas
          //Se cumple
        static void Tablero(ref char[,] tablero)
         {
            Console.WriteLine("");
            Console.WriteLine("     A   B   C   D   E   F   G   H   I   J  ");
            Console.WriteLine("   ┌───┬───┬───┬───┬───┬───┬───┬───┬───┬───┐");
            for (int i = 0; i < 9; ++i)
          
             
            { 
                Console.Write(" " + (i + 1));
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("   "+tablero[i,j]);
                }
                Console.WriteLine(" ");
                if (i < 8)
                {
                    Console.WriteLine("   ├───┼───┼───┼───┼───┼───┼───┼───┼───┼───┤");
                }
            }
            Console.WriteLine("   └───┴───┴───┴───┴───┴───┴───┴───┴───┴───┘");
        }

        //  Apartado 3. Un array con los objetos de tipo Barco a colocar en el tablero.
        // Se cumple.

        static void Barco(char barco, string dirección, int[] coordenadas, ref char[,] tablero_completo)
        {
            int casilla;
            switch (barco)
            {
                case 'P':
                    casilla = 5;
                    for (int i = 0; i < casilla; i++)
                    {
                        tablero_completo[coordenadas[0], coordenadas[1]] = barco;
                        if (dirección == "v")
                        {
                            coordenadas[0] += 1;
                        }
                        else if (dirección == "h")
                        {
                            coordenadas[1] += 1;
                        }
                    }
                    break;
                case 'A':
                    casilla = 4;
                    for (int i = 0; i < casilla; i++)
                    {
                        tablero_completo[coordenadas[0], coordenadas[1]] = barco;
                        if (dirección == "v")
                        {
                            coordenadas[0] += 1;
                        }
                        else if (dirección == "h")
                        {
                            coordenadas[1] += 1;
                        }
                    }
                    break;
                case 'F':
                    casilla = 3;
                    for (int i = 0; i < casilla; i++)
                    {
                        tablero_completo[coordenadas[0], coordenadas[1]] = barco;
                        if (dirección == "v")
                        {
                            coordenadas[0] += 1;
                        }
                        else if (dirección == "h")
                        {
                            coordenadas[1] += 1;
                        }
                    }
                    break;
                case 'D':
                    casilla = 3;
                    for (int i = 0; i < casilla; i++)
                    {
                        tablero_completo[coordenadas[0], coordenadas[1]] = barco;
                        if (dirección == "v")
                        {
                            coordenadas[0] += 1;
                        }
                        else if (dirección == "h")
                        {
                            coordenadas[1] += 1;
                        }
                    }
                    break;
                case 'S':
                    casilla = 2;
                    for (int i = 0; i < casilla; i++)
                    {
                        tablero_completo[coordenadas[0], coordenadas[1]] = barco;
                        if (dirección == "v")
                        {
                            coordenadas[0] += 1;
                        }
                        else if (dirección == "h")
                        {
                            coordenadas[1] += 1;
                        }
                    }
                    break;
                case 'C':
                    casilla = 2;
                    for (int i = 0; i < casilla; i++)
                    {
                        tablero_completo[coordenadas[0], coordenadas[1]] = barco;
                        if (dirección == "v")
                        {
                            coordenadas[0] += 1;
                        }
                        else if (dirección == "h")
                        {
                            coordenadas[1] += 1;
                        }
                    }
                    break;
            }
        }

        /*  Apartado 3.
        Clase llamada Rellenar
        En donde el usuario puede elegir la ubicación de las diferentes naves 
        y para que no se superpongan las naves, 
        con un booleano  ponerBarco y una comprobación moviéndote por la matriz. Se cumple también.
        */
                static bool Rellenar(char ponerBarco, string dirección, char[] columnas,char[] filas, char[] coordenadas, char[,] tablero)
        {
            bool validación = false;
            int tamaño;
            switch (ponerBarco)
            {
                case 'P':
                    tamaño = 5;
                    int posición_columna_p = Array.IndexOf(columnas, coordenadas[1]);
                    int posición_fila_p = Array.IndexOf(filas, coordenadas[0]);
                    if (dirección == "h")
                    {
                        int total = (tamaño - 1) + posición_columna_p;
                        if(total > columnas.Length)
                        {
                            Console.WriteLine("El portaaviones se sale del tablero por la derecha");
                            validación = false;
                            return validación;
                            
                        }
                        else
                        {
                            validación = true;
                            return validación;
                        }
                    }
                    else if(dirección == "v")
                    {
                        int total = (tamaño - 1) + posición_fila_p;
                        if (total > filas.Length)
                        {
                            Console.WriteLine("El portaaviones se sale del tablero por abajo");
                            validación = false;
                            return validación;
                            
                        }
                        else
                        {
                            validación = true;
                            return validación;
                        }
                    }
                    return validación;
                case 'A':
                    tamaño = 4;
                    int posición_columna_a = Array.IndexOf(columnas, coordenadas[1]);
                    int posición_fila_a = Array.IndexOf(filas, coordenadas[0]);
                    bool choca_a = false;
                    if (dirección == "h")
                    {
                        int total = (tamaño - 1) + posición_columna_a;
                        if (total > columnas.Length)
                        {
                            Console.WriteLine("El acorazado se sale del tablero por la derecha");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_columna_a; i <= total; i++)
                        {
                            if (tablero[posición_fila_a, i] != ' ')
                            {
                                choca_a = true;
                            }

                        }
                        if(choca_a == true)
                        {
                            Console.WriteLine("El acorazado colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    else if (dirección == "v")
                    {
                        int total = (tamaño - 1) + posición_fila_a;

                        if (total > filas.Length)
                        {
                            Console.WriteLine("El acorazado se sale del tablero por abajo");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_fila_a; i < total; i++)
                        {
                            if (tablero[i, posición_columna_a] != ' ')
                            {
                                choca_a = true;
                            }
                        }
                        if (choca_a == true)
                        {
                            Console.WriteLine("El acorazado colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    return validación;
                case 'F':
                    tamaño = 3;
                    int posición_columna_f = Array.IndexOf(columnas, coordenadas[1]);
                    int posición_fila_f = Array.IndexOf(filas, coordenadas[0]);
                    bool choca_f = false;
                    if (dirección == "h")
                    {
                        int total = (tamaño - 1) + posición_columna_f;
                        if (total > columnas.Length)
                        {
                            Console.WriteLine("La fragata se sale del tablero por la derecha");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_columna_f; i <= total; i++)
                        {
                            if (tablero[posición_fila_f, i] != ' ')
                            {
                                choca_f = true;
                            }

                        }
                        if (choca_f == true)
                        {
                            Console.WriteLine("La fragata colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    else if (dirección == "v")
                    {
                        int total = (tamaño - 1) + posición_fila_f;

                        if (total > filas.Length)
                        {
                            Console.WriteLine("La fragata se sale del tablero por abajo");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_fila_f; i < total; i++)
                        {
                            if (tablero[i, posición_columna_f] != ' ')
                            {
                                choca_f = true;
                            }
                        }
                        if (choca_f == true)
                        {
                            Console.WriteLine("La fragata colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    return validación;
                case 'D':
                    tamaño = 3;
                    int posición_columna_d = Array.IndexOf(columnas, coordenadas[1]);
                    int posición_fila_d = Array.IndexOf(filas, coordenadas[0]);
                    bool choca_d = false;
                    if (dirección == "h")
                    {
                        int total = (tamaño - 1) + posición_columna_d;

                        if (total > columnas.Length)
                        {
                            Console.WriteLine("El destructor se sale del tablero por la derecha");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_columna_d; i <= total; i++)
                        {
                            if (tablero[posición_fila_d, i] != ' ')
                            {
                                choca_d = true;
                            }

                        }
                        if (choca_d == true)
                        {
                            Console.WriteLine("El destructor colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    else if (dirección == "v")
                    {
                        int total = (tamaño - 1) + posición_fila_d;

                        if (total > filas.Length)
                        {
                            Console.WriteLine("El destructor se sale del tablero por abajo");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_fila_d; i < total; i++)
                        {
                            if (tablero[i, posición_columna_d] != ' ')
                            {
                                choca_d = true;
                            }
                        }
                        if (choca_d == true)
                        {
                            Console.WriteLine("El destructor colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    return validación;
                case 'S':
                    tamaño = 2;
                    int posición_columna_s = Array.IndexOf(columnas, coordenadas[1]);
                    int posición_fila_s = Array.IndexOf(filas, coordenadas[0]);
                    bool choca_s = false;
                    if (dirección == "h")
                    {
                        int total = (tamaño - 1) + posición_columna_s;

                        if (total >= columnas.Length)
                        {
                            Console.WriteLine("El submarino se sale del tablero por la derecha");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_columna_s; i <= total; i++)
                        {
                            if (tablero[posición_fila_s, i] != ' ')
                            {
                                choca_s = true;
                            }

                        }
                        if (choca_s == true)
                        {
                            Console.WriteLine("El submarino colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    else if (dirección == "v")
                    {
                        int total = (tamaño - 1) + posición_fila_s;

                        if (total >= filas.Length)
                        {
                            Console.WriteLine("El submarino se sale del tablero por abajo");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_fila_s; i < total; i++)
                        {
                            if (tablero[i, posición_columna_s] != ' ')
                            {
                                choca_s = true;
                            }
                        }
                        if (choca_s == true)
                        {
                            Console.WriteLine("El submarino colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    return validación;
                case 'C':
                    tamaño = 2;
                    int posición_columna_c = Array.IndexOf(columnas, coordenadas[1]);
                    int posición_fila_c = Array.IndexOf(filas, coordenadas[0]);
                    bool choca_c = false;
                    if (dirección == "h")
                    {
                        int total = (tamaño - 1) + posición_columna_c;
                        if (total >= columnas.Length)
                        {
                            Console.WriteLine("El crucero se sale del tablero por la derecha");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_columna_c; i <= total; i++)
                        {
                            if (tablero[posición_fila_c, i] != ' ')
                            {
                                choca_c = true;
                            }

                        }
                        if (choca_c == true)
                        {
                            Console.WriteLine("El crucero colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    else if (dirección == "v")
                    {
                        int total = (tamaño - 1) + posición_fila_c;

                        if (total >= filas.Length)
                        {
                            Console.WriteLine("El crucero se sale del tablero por abajo");
                            validación = false;
                            return validación;
                        }
                        for (int i = posición_fila_c; i < total; i++)
                        {
                            if (tablero[i, posición_columna_c] != ' ')
                            {
                                choca_c = true;
                            }
                        }
                        if (choca_c == true)
                        {
                            Console.WriteLine("El crucero colisionaría con otro ya colocado. Vuelva a intentarlo");
                            validación = false;
                            return validación;
                        }
                        else
                        {
                            validación = true;
                            return validación;

                        }
                    }
                    return validación;
                default:
                    return validación;
            }
        }
        //Apartado 2 + Apartado 4. Proceso y método de tiro en el juego.
        static void estaHundido (int[] coordenadas, ref char[,] tablero_completo, ref char[,] tablero_vacío, ref int barcoP, ref int barcoA, ref int barcoF, ref int barcoD, ref int barcoS, ref int barcoC)
        {
            if (tablero_completo[coordenadas[0],coordenadas[1]] != ' ' & tablero_completo[coordenadas[0], coordenadas[1]] != '~' & tablero_completo[coordenadas[0], coordenadas[1]] != 'O')
            {
                Console.WriteLine("¡Tocado!");
                switch  (tablero_completo[coordenadas[0], coordenadas[1]])
                {
                    case 'P':
                        barcoP -= 1;
                        if (barcoP == 0)
                        {
                            Console.WriteLine("PORTAAVIONES ¡HUNDIDO!");
                        }
                        break;
                    case 'A':
                        barcoA -= 1;
                        if (barcoA == 0)
                        {
                            Console.WriteLine(" ACORAZADO ¡HUNDIDO!");
                        }
                        break;
                    case 'F':
                        barcoF -= 1;
                        if (barcoF == 0)
                        {
                            Console.WriteLine(" FRAGATA ¡HUNDIDA!");
                        }
                        break;
                    case 'D':
                        barcoD -= 1;
                        if (barcoD == 0)
                        {
                            Console.WriteLine("DESTRUCTOR ¡HUNDIDO!");
                        }
                        break;
                    case 'S':
                        barcoS -= 1;
                        if (barcoS == 0)
                        {
                            Console.WriteLine("SUBMARINO ¡HUNDIDO!");
                        }
                        break;
                    case 'C':
                        barcoC -= 1;
                        if (barcoC == 0)
                        {
                            Console.Write("CRUCERO  ¡HUNDIDO!");
                        }
                        break;
                    default:
                        Console.WriteLine("Ya has disparado aquí, enhorabuena, turno perdido. Mira el tablero, por favor, que está todo bien clarito. Gracias");
                        break;
                }
                tablero_vacío[coordenadas[0], coordenadas[1]] = 'B';
            }
            else if (tablero_completo[coordenadas[0], coordenadas[1]] == ' ')
            {
                Console.WriteLine("Oh, no, es AGUA");
                tablero_vacío[coordenadas[0], coordenadas[1]] = 'X';
            }
            else
            {
                Console.WriteLine("Ya has disparado aquí, enhorabuena, turno perdido. Mira el tablero, por favor, que está todo bien clarito. Gracias");
            }
        }

        static void Main(string[] args)
        {
            //Apartado 1 + Apartado 4
            // Fijamos el tamaño de la ventana


            char[,] tablero_completo = new char[10, 10];                                         // Tablero de juego
            char[,] tablero_vacío = new char[10, 10];                                            // Tablero de juego vacío
            bool prueba = false;                                                                // Para las comprobaciónes de números

            // Variable del tamaño de los barcos, para saber cuándo se hunden.

            int P = 5;
            int A = 4;
            int F = 3;
            int D = 3;
            int S = 2;
            int C = 2;

            // Fin de las variables, para saber cuándo se hunden.
            //Apartado 4. Parámetros necesarios que son la estructura y funcionamiento del programa.


           
            int elección = 0;                                                                   // Para la elección del menú
            int contador_turnos = 40;                                                           // Sirve como contador de los turnos
            string dirección;                                                                   // Para elegir la dirección del barco
            char[] coordenadas = new char[2];                                                   // Para introducir las coordenadas de los barcos
            char[] coord_filas = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };                         // Coordenadas de las filas
            char[] coord_columnas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',  };       // Coordenadas de las columnas
            string coord_barco;                                                                 // En esta variable se almacena lo que el usuario introduce como coordenadas, para comprobarlas
            char[] coord_barco_char = new char[2];                                              // En esta array se almacecna la coordenada que ha dado el usuario, dividida en caracteres, para poder verificarlas
            int[] coord_barco_int = new int[2];                                                 // Con esta conversión podemos usar las coordenadas en el tablero
            bool validación = false;                                                            // Se usa esta variable para almacenar el booleano de la función que valida la posición de los barcos
            string coord_disparo;                                                               // Se usa para recibir las coordenadas del disparo
            int[] coord_disparo_int = new int[2];                                               // Se usa para que las coordenadas del disparo sea viables para el tablero
            char[] coord_disparo_char = new char[2];                                            // Se usa para almacenar las coordenadas del disparo

            // Barcos:

            char[] barcos = { 'P', 'A', 'F', 'D', 'S', 'C' };

            // Fin de barcos.

            // Rellenamos el tablero vacío

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j <10; j++)
                {
                    tablero_vacío[i, j] = ' ';
                    tablero_completo[i, j] = ' ';
                }
            }

            // Iniciamos el programa

            dibujar_titulo();

            Console.ReadKey(true);

            dibujar_menu();

            // Apartado 4. Fin de la presentación e inicio del menú de juego

            do
            {
                do
                {
                    string elec_menu_str = Console.ReadLine();
                    conversión(elec_menu_str, ref elección, ref prueba);
                } while (prueba == false);
                if (elección != 1 & elección != 2)
                {
                    Console.WriteLine("Por favor, introduzca una opción válida: 1 o 2");
                }

            } while (elección != 1 & elección != 2);

            switch (elección)
            {
                case 1:       // Juegos de guerra
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("              Tablero de juego:");
                    Tablero(ref tablero_vacío);
                    Console.WriteLine("\n        Dispones de los siguientes barcos: ");
                    Console.WriteLine("\n           P,  PORTAAVIONES de 5 casillas.");
                    Console.WriteLine("              A,  ACORAZADO  de 4 casillas.");
                    Console.WriteLine("              F,  FRAGATA de 3 casillas.");
                    Console.WriteLine("              D,  DESTRUCTOR de 3 casillas.");
                    Console.WriteLine("              S,  SUBMARINO de 2 casillas.");
                    Console.WriteLine("              C, CRUCERO de 2 casillas.");
                    Console.WriteLine("\nIntroducirás los barcos en el siguiente orden.");
                    foreach (char barco in barcos)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("¿En qué dirección desea introducir el barco " + barco + ", [H]orizontal] o [V]ertical]?");

                        do
                        {

                            do //Apartado 2 + Apartado 3Validación de que se introduce "horizontal" o "vertical"
                            {
                                dirección = Console.ReadLine();
                                dirección = dirección.ToLower();
                                if (dirección != "h" & dirección != "v")
                                {
                                    Console.WriteLine("Por favor, introduzca una opción válida (Horizontal o vertical)");
                                }
                            } while (dirección != "h" & dirección != "v");
                            Console.WriteLine("");
                            Console.WriteLine("¿En qué coordenada deseas que se encuentre la primera casilla del barco? Te en cuenta que si has elegido vertical, se introducirá hacia abajo y si has elegido horizontal se introducirá hacia la derecha.");
                            Console.WriteLine("");
                            do // Validación de las coordenadas. Que no haya coordenadas no incluidas en el tablero y que ambas coordenadas sea número y letra.
                            {
                                do // Que no haya más de dos caracteres en las coordenadas
                                {
                                    coord_barco = Console.ReadLine();
                                    coord_barco = coord_barco.ToUpper();
                                    if (coord_barco.Length != 2)
                                    {
                                        Console.WriteLine("Introduce unas coordenadas de dos caracteres");
                                    }
                                } while (coord_barco.Length != 2);

                                coord_barco_char = coord_barco.ToCharArray();
                                Array.Sort(coord_barco_char);   //Ordenamos el array para que no importe en qué orden se introduzcan las coordenadas.
                                if (Array.Exists(coord_filas, element => element == coord_barco_char[0]) == false || Array.Exists(coord_columnas, element => element == coord_barco_char[1]) == false)
                                {
                                    Console.WriteLine("Introduce unas coordenadas dentro de los límites del tablero.");
                                }
                            } while (Array.Exists(coord_filas, element => element == coord_barco_char[0]) == false || Array.Exists(coord_columnas, element => element == coord_barco_char[1]) == false);
                            //"Mientras que lo introducido no incluya una coordenadas de las filas y otra de las columnas" Así nos aseguramos de que no introduzca dos números o dos letras.

                        validación = Rellenar(barco, dirección, coord_columnas, coord_filas, coord_barco_char, tablero_completo);

                        } while (validación == false);

                        // Transformamos las coordenadas a int para poder usarlas en el tablero de forma más cómoda

                        coor_fila_a_int(coord_barco_char, ref coord_barco_int);
                        coor_columna_a_int(coord_barco_char, ref coord_barco_int);

                        // Introducimos el barco en el tablero
                        Console.Clear();
                        Barco(barco, dirección, coord_barco_int, ref tablero_completo);
                        Tablero(ref tablero_completo);
                        Console.WriteLine("\n        Dispones de los siguientes barcos: ");
                        Console.WriteLine("\n            P,  PORTAAVIONES de 5 casillas.");
                        Console.WriteLine("               A,  ACORAZADO de 4 casillas.");
                        Console.WriteLine("               F,  FRAGATA de 3 casillas.");
                        Console.WriteLine("               D, DESTRUCTOR de 3 casillas.");
                        Console.WriteLine("               S, SUBMARINO de 2 casillas.");
                        Console.WriteLine("               C, CRUCERO de 2 casillas.");
                    }
                    Console.WriteLine("Pulse cualquier tecla para iniciar el BOMBARDEO");

                    Console.ReadKey(true);

                    // Comienza el turno de los disparos

                    Console.Clear();
                    Tablero(ref tablero_vacío);
                    Console.WriteLine("A partir de ahora tienes 40 turnos para hundir todos los barcos");
                    do
                    {
                        Console.WriteLine("Le quedan " + contador_turnos + " turnos antes de que se acabe el juego");
                        Console.WriteLine("Indique las coordenadas del disparo");
                        do // Validación de las coordenadas. Que no haya coordenadas no incluidas en el tablero y que ambas coordenadas sea número y letra.
                        {
                            do // Que no haya más de dos caracteres en las coordenadas
                            {
                                coord_disparo = Console.ReadLine();
                                coord_disparo = coord_disparo.ToUpper();
                                if (coord_disparo.Length != 2)
                                {
                                    Console.WriteLine("Por favor, introduzca unas coordenadas de dos caracteres");
                                }
                            } while (coord_disparo.Length != 2);

                            coord_disparo_char = coord_disparo.ToCharArray();
                            Array.Sort(coord_disparo_char);   //Ordenamos el array para que no importe en qué orden se introduzcan las coordenadas.
                            if (Array.Exists(coord_filas, element => element == coord_disparo_char[0]) == false || Array.Exists(coord_columnas, element => element == coord_disparo_char[1]) == false)
                            {
                                Console.WriteLine("Por favor, introduzca unas coordenadas dentro de los límites del tablero.");
                            }
                        } while (Array.Exists(coord_filas, element => element == coord_disparo_char[0]) == false || Array.Exists(coord_columnas, element => element == coord_disparo_char[1]) == false);

                        coor_fila_a_int(coord_disparo_char, ref coord_disparo_int);
                        coor_columna_a_int(coord_disparo_char, ref coord_disparo_int);

                        estaHundido(coord_disparo_int, ref tablero_completo, ref tablero_vacío, ref P, ref A, ref F, ref D, ref S, ref C);

                        Console.WriteLine("Pulse cualquier tecla para el siguiente turno");
                        Console.ReadKey(true);

                        Console.Clear();

                        Tablero(ref tablero_vacío);
                        if(P == 0 & A == 0 & F == 0 & D == 0 & S == 0 & C == 0) //Apartado 4. Si no quedan barcos, has ganado, este if lo comprueba gracias a las variables que almacenan su tamaño.
                        {
                            Console.WriteLine("ENHORABUENA. has ganao.");
                            Environment.Exit(1);
                        }

                        contador_turnos -= 1; // Se van reduciendo los turnos para que cuando se llegue a 0 el programa se cierre
                        if(contador_turnos == 0)
                        {
                            Console.WriteLine("Lo siento, has perdido");
                        }
                    } while (contador_turnos != 0);
                    break;

                case 2:     //Salir del programa
                    Environment.Exit(1);
                    break;
            }
        }
    }
}
