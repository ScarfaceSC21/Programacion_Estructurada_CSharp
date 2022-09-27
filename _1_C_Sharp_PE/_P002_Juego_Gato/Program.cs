using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P002_Juego_Gato
{
    /* PRACTICA #2
    Realice un programa de consola tomando en cuenta las siguientes indicaciones: 
    Codifique un programa que permita jugar el juego del Gato (Tres en raya) por consola
    El programa debe de ser capas de simular y mostrar por consola un hashtag # para poder jugar al gato
    El programa le pedira al usuario ingresar su marca por teclado ademas de indicar de quien es el truno
    El juego terminara cuando haya un ganador o cuando ya no haya espacios para agregar marca.
    Utilizar las estructuras vistas en clase.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato(); 
            gato.jugar();
        }
    }

    public class Gato
    {
        public bool fin;
        int turno;
        int ubicacion;
        int ganador;
        int tiros;
        // creamos una matriz de 3x3 que va almacenar los datos del tablero del juego
        char[,] tablero = {
                    {' ',' ',' '},
                    {' ',' ',' '},
                    {' ',' ',' '}
                    };

        public void jugar()
        {
            fin = false;
            turno = 1;
            ganador = 0;
            tiros = 0;
            dibujaTablero();

            while (fin == false && tiros < 9)
            {
                Console.SetCursorPosition(30, 22);
                Console.WriteLine("Jugador: {0}", turno);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("Elige una posicion disponible (1-9)");
                ubicacion = int.Parse(Console.ReadLine());

                switch (ubicacion)
                {
                    case 1:
                        if (tablero[0, 0] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[0, 0] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[0, 0] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        if (tablero[0, 1] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[0, 1] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[0, 1] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        if (tablero[0, 2] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[0, 2] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[0, 2] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        if (tablero[1, 0] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[1, 0] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[1, 0] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        if (tablero[1, 1] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[1, 1] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[1, 1] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    case 6:
                        if (tablero[1, 2] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[1, 2] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[1, 2] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        if (tablero[2, 0] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[2, 0] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[2, 0] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    case 8:
                        if (tablero[2, 1] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[2, 1] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[2, 1] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    case 9:
                        if (tablero[2, 2] == ' ')
                        {
                            if (turno == 1)
                            {
                                tablero[2, 2] = 'O';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 2;
                            }
                            else
                            {
                                tablero[2, 2] = 'X';
                                tiros++;
                                fin = hayGanador(turno);
                                turno = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("Error, valor de posicion no valido");
                        Console.ReadKey();
                        break;
                }
                dibujaTablero();
            } 
            if (ganador == 1 || ganador == 2)
            {
                Console.SetCursorPosition(30, 22);
                Console.WriteLine("El ganador es el Jugador {0}", ganador);
                Console.WriteLine("\n\n\n\n");
            }
            else
            {
                Console.SetCursorPosition(30, 22);
                Console.WriteLine("No hay ganador");
            }
            Console.ReadKey();
        }
        // jugador1 = O
        // jugador2 = X
        public void dibujaTablero()
        {
            // Limpiamos pantalla
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            // dibujamos el tablero en la pantalla
            Console.WriteLine(" 1 | 2 | 3 "); // c=1,f=0   c=5,f=0    c=9,f=0
            Console.WriteLine("___|___|___");
            Console.WriteLine(" 4 | 5 | 6 "); // c=1,f=2   5,2    9,2
            Console.WriteLine("___|___|___");
            Console.WriteLine(" 7 | 8 | 9 "); // 1,4   5,4    9,4
            Console.WriteLine("   |   |   ");

            int y = 0; // fila en pantalla
            
            /*x= 1
              y= 2
              i= 1
              j= 0
                tablero[0,1]  */

            for (int i = 0; i < 3; i++)
            {  
                int x = 1;  
                for (int j = 0; j < 3; j++)
                {  
                    if (tablero[i, j] != ' ')
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(tablero[i, j]);
                    }
                    x = x + 4;
                }
                y = y + 2;
            }
        }

        //Funcion para verificar si hay un ganador
        public bool hayGanador(int turno)
        {
            /*
            Primero debemos definir las jugadas que pueden ganar el juego
            independientemente de la marca del jugador

            jugadaHorizontal1 {1,2,3} ganador = turno; return true;
            jugadaHorizontal2 {4,5,6}
            jugadaHorizontal3 {7,8,9}

            jugadaVertical1 {1,4,7}
            jugadaVertical2 {2,5,6}
            jugadaVertical3 {3,6,9}

            jugadaDiagonal1 {1,5,9}
            jugadaDiagonal2 {3,5,7}

        char[,] tablero = {
                          {'O','O','O'}, // [0,0]  [0,1]  [0,2]
                          {' ',' ',' '}, // [1,0]  [1,1]  [1,2]
                          {' ',' ',' '}  // [2,0]  [2,1]  [2,2]
                          };

            */
            char marca; //'X' 'O'
            if (turno == 1) { marca = 'O'; } else { marca = 'X'; }
            //marca= 'O'
            // AND o el Y logico     expresion A Y expresion B 

            //JUGADAS HORIZONTALES
            if (tablero[0, 0] == marca && tablero[0, 1] == marca && tablero[0, 2] == marca)
            {
                ganador = turno;
                return true;
            }

            if (tablero[1, 0] == marca && tablero[1, 1] == marca && tablero[1, 2] == marca)
            {
                ganador = turno;
                return true;
            }
            if (tablero[2, 0] == marca && tablero[2, 1] == marca && tablero[2, 2] == marca)
            {
                ganador = turno;
                return true;
            }

            //JUGADAS VERTICALES
            if (tablero[0, 0] == marca && tablero[1, 0] == marca && tablero[2, 0] == marca)
            {
                ganador = turno;
                return true;
            }

            if (tablero[0, 1] == marca && tablero[1, 1] == marca && tablero[2, 1] == marca)
            {
                ganador = turno;
                return true;
            }
            if (tablero[0, 2] == marca && tablero[1, 2] == marca && tablero[2, 2] == marca)
            {
                ganador = turno;
                return true;
            }

            //JUGADAS DIAGONALES
            if (tablero[0, 0] == marca && tablero[1, 1] == marca && tablero[2, 2] == marca)
            {
                ganador = turno;
                return true;
            }

            if (tablero[0, 2] == marca && tablero[1, 1] == marca && tablero[2, 0] == marca)
            {
                ganador = turno;
                return true;
            }
            return false;
        }
    }
}
