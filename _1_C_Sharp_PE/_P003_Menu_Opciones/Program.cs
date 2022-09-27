using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P003_Menu_Opciones
{
    /* PRACTICA #3
    Realice un programa de consola tomando en cuenta las siguientes indicaciones: 
    Codifique un programa que pueda ser capas de seleccionar varias opciones mediante el teclado
    Las opciones que el programa podra realizar sera las siguiente:
      Opcion 1:    Invertir Texto
                        Ejemplo:   
                        Texto ingresado: Anita lava la tina      Texto Invertido: anit al aval atinA
      Opcion 2:    Invertir Frase
                        Ejemplo:   
                        Frase ingresado: Aprendiendo programacion estructurada       Frase invertida: estructurada programacion Aprendiendo
      Opcion 3:    Desglose de Billetes
                        El programa le pedira al usuario la cantidad que desea desglosar en billetes de 500, 200, 100, 50 y 20 y monedas de 10, 5, 2, y 1 peso
                        Ejemplo:
                        Cantidad a desglosar 2850
                        5 billetes de 500, 1 billete de 200, 1 billete de 100, 1 billete de 50, 0 billetes de 20,
                        0 monedas de 10, 0 monedas de 5, 0 monedas de 2 y 0 monedas de 1.
      Opcion 4:   Salir
                  Esta opcion terminara el programa
    Cada una de las opciones se podra seleccionar con las felchas y presionando la tecla enter
    Ademas el programa imprimira un marco alrededor de las opciones y letras 
    Las letras que se imprimiran sera PRACTICA #3
    Las opciones y las letras se imprimiran de forma centrada dentro del marco
    Utilizar las estructuras vistas en clase

     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haga grande la pantalla y presione una tecla para continuar....");
            Console.ReadKey();
            Console.Clear();
            new Program().Menu();
        }

        void Menu()
        {
            bool ejecutar = false;

            for (int tecla = 0; ;)
            {
                Marco(3, 3, 168, 40);
                Letras();
                PintaMenu(tecla);
                ConsoleKeyInfo cki = Console.ReadKey(true);
                Console.CursorVisible = false;

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: tecla--; break;
                    case ConsoleKey.DownArrow: tecla++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (tecla < 0) tecla = 3; else if (tecla > 3) tecla = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (tecla)
                    {
                        case 0: InvertirTexto(); break;
                        case 1: InvertirFrase(); break;
                        case 2: DesgloseBilletes(); break;
                        case 3: return;
                    }
                }
            }
        }

        void PintaMenu(int tecla)
        {
            
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Red;

            Console.SetCursorPosition(80, 15);
            Console.ForegroundColor = tecla == 0 ? sel : cc;
            Console.WriteLine("1. Invertir Texto");
            Console.SetCursorPosition(80, 17);
            Console.ForegroundColor = tecla == 1 ? sel : cc;
            Console.WriteLine("2. Invertir Frase");
            Console.SetCursorPosition(80, 19);
            Console.ForegroundColor = tecla == 2 ? sel : cc;
            Console.WriteLine("3. Desglose de billetes");
            Console.SetCursorPosition(80, 21);
            Console.ForegroundColor = tecla == 3 ? sel : cc;
            Console.WriteLine("4. Salir");
        }

        void InvertirTexto()
        {
            Console.SetCursorPosition(80, 25);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Invertir Texto");

            Console.SetCursorPosition(80, 26);
            Console.WriteLine("Ingrese el texto que desea invertir");

            Console.SetCursorPosition(80, 28);
            string Texto = Console.ReadLine();

            char[] TextoCaracter = Texto.ToCharArray();

            string Invertido = String.Empty;

            for (int i = TextoCaracter.Length - 1; i >= 0; i--)
            {
                Invertido += TextoCaracter[i];
            }
            Console.SetCursorPosition(80, 30);
            Console.WriteLine(Invertido);

            Console.ReadKey(); 
            Console.Clear();
        }

        void InvertirFrase()
        {
            Console.SetCursorPosition(80, 25);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Invertir Frase");

            Console.SetCursorPosition(80, 26);

            Console.WriteLine("Ingrese el texto para invertir el orden de sus palabras");

            Console.SetCursorPosition(80, 28);

            string Texto = Console.ReadLine();

            string[] auxiliar = Texto.Split(' ');

            Array.Reverse(auxiliar);

            string texto2 = String.Join(" ", auxiliar);

            Console.SetCursorPosition(80, 30);

            Console.WriteLine(texto2);

            Console.ReadKey();

            Console.Clear();
        }

        void DesgloseBilletes()
        {
            Console.SetCursorPosition(80, 25);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Desglose de Billetes");

            Console.SetCursorPosition(80, 26);
            int monedas_10, billetes_100, billetes_20, billetes_200, monedas_5, billetes_50, billetes_500, cantidad_pesos, monedas_1, monedas_2;
            Console.Write("Ingresa el valor de cantidad de pesos: ");
            Console.SetCursorPosition(80, 28);
            cantidad_pesos = int.Parse(Console.ReadLine());
            monedas_1 = cantidad_pesos;
            billetes_500 = (monedas_1 - monedas_1 % 500) / 500;
            monedas_1 = monedas_1 % 500;
            billetes_200 = (monedas_1 - monedas_1 % 200) / 200;
            monedas_1 = monedas_1 % 200;
            billetes_100 = (monedas_1 - monedas_1 % 100) / 100;
            monedas_1 = monedas_1 % 100;
            billetes_50 = (monedas_1 - monedas_1 % 50) / 50;
            monedas_1 = monedas_1 % 50;
            billetes_20 = (monedas_1 - monedas_1 % 20) / 20;
            monedas_1 = monedas_1 % 20;
            monedas_10 = (monedas_1 - monedas_1 % 10) / 10;
            monedas_1 = monedas_1 % 10;
            monedas_5 = (monedas_1 - monedas_1 % 5) / 5;
            monedas_1 = monedas_1 % 5;
            monedas_2 = (monedas_1 - monedas_1 % 2) / 2;
            monedas_1 = monedas_1 % 2;

            Console.SetCursorPosition(56, 30);
            Console.WriteLine("Se entregan " + billetes_500 + " billete(s) de 500, " + billetes_200 + " billete(s) de 200, " + billetes_100 + " billete(s) de 100, \n");
            Console.SetCursorPosition(56, 31);
            Console.WriteLine(billetes_50 + " billete(s) de 50, " + billetes_20 + " billete(s) de 20, " + monedas_10 + " moneda(s) de 10, " + monedas_5 + " moneda(s) de 5, ");
            Console.SetCursorPosition(56, 32);
            Console.WriteLine(monedas_2 + " moneda(s) de 2, " + monedas_1 + " moneda(s) de 1.");

            Console.ReadKey();
            Console.Clear();
        }

        void Marco(int col1, int ren1, int col2, int ren2)
        {
            Console.SetCursorPosition(col1, ren1);
            Console.WriteLine("╔");
            Console.SetCursorPosition(col2, ren1);
            Console.WriteLine("╗");
            Console.SetCursorPosition(col1, ren2);
            Console.WriteLine("╚");
            Console.SetCursorPosition(col2, ren2);
            Console.WriteLine("╝");

            for (int i = col1 + 1; i <= col2 - 1; i++)
            {
                Console.SetCursorPosition(i, ren1);
                Console.WriteLine("═");
                Console.SetCursorPosition(i, ren2);
                Console.WriteLine("═");
            }

            for (int i = ren1 + 1; i <= ren2 - 1; i++)
            {
                Console.SetCursorPosition(col1, i);
                Console.WriteLine("║");
                Console.SetCursorPosition(col2, i);
                Console.WriteLine("║");
            }
        }

        static void Letras()
        {
            char[,] P = new char[5, 5];

            for (int j = 0; j < 4; j++)
            {
                P[0, j] = '*';
            }

            for (int r = 0; r < 5; r++)
            {
                P[r, 0] = '*';
            }
            //r,c
            P[1, 4] = '*';

            for (int i = 1; i < 4; i++)
            {
                P[2, i] = '*';
            }

            char[,] R = new char[5, 5];

            for (int j = 0; j < 4; j++)
            {
                R[0, j] = '*';
            }

            for (int r = 0; r < 5; r++)
            {
                R[r, 0] = '*';
            }
            //r,c
            R[1, 4] = '*';

            for (int i = 1; i < 4; i++)
            {
                R[2, i] = '*';
            }

            R[3, 4] = '*';
            R[4, 4] = '*';

            //A

            char[,] A = new char[5, 5];

            for (int j = 0; j < 5; j++)
            {
                A[3, j] = '*';
            }

            A[0, 2] = '*';
            A[1, 1] = '*';
            A[1, 3] = '*';
            A[2, 0] = '*';
            A[2, 4] = '*';
            A[4, 0] = '*';
            A[4, 4] = '*';

            //C

            char[,] C = new char[5, 5];

            for (int j = 0; j < 5; j++)
            {
                C[0, j] = '*';
            }

            for (int i = 0; i < 5; i++)
            {
                C[i, 0] = '*';
            }

            for (int i = 1; i < 5; i++)
            {
                C[4, i] = '*';
            }

            //T

            char[,] T = new char[5, 5];

            for (int j = 0; j < 5; j++)
            {
                T[0, j] = '*';
            }

            for (int j = 0; j < 5; j++)
            {
                T[j, 2] = '*';
            }

            //I

            char[,] I = new char[5, 5];

            for (int j = 0; j < 5; j++)
            {
                I[0, j] = '*';
            }

            for (int j = 0; j < 5; j++)
            {
                I[j, 2] = '*';
            }

            for (int i = 0; i < 5; i++)
            {
                I[4, i] = '*';
            }

            //#
            char[,] Hash = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                Hash[1, i] = '*';
                Hash[3, i] = '*';
            }

            for (int i = 0; i < 5; i++)
            {
                Hash[i, 1] = '*';
                Hash[i, 3] = '*';
            }

            //3
            char[,] tres = new char[5, 5]; 
            for (int i = 0; i < 5; i++)
            {
                tres[0, i] = '*';
            }
            for (int i = 0; i < 5; i++)
            {
                tres[i, 4] = '*';
            }
            for (int i = 0; i < 5; i++)
            {
                tres[2, i] = '*';
            }
            for (int i = 0; i < 5; i++)
            {
                tres[4, i] = '*';
            }

            int renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(56, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(P[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(63, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(R[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(70, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(77, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(C[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(84, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(T[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(91, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(I[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(98, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(C[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(105, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(A[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(114, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(Hash[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }

            renglon = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(121, renglon);
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tres[i, j]);
                }
                renglon++;
                Console.WriteLine();
            }
        }
    }
}
