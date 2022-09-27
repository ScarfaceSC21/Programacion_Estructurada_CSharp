using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P001_Letras
{
    /* PRACTICA #1 - LETRAS EN MATRIZ
    Realice un programa de consola tomando en cuenta las siguientes indicaciones: 
    Codifique un programa que imprima por consola una letra en forma de matriz de tamaño 5x5
    El programa debe preguntar al usuario que letra es la que desea imprimir
    El programa debe poder reconocer si la letra es mayuscula o en minuscula y imprimirla
    La letra se imprimira en mayuscula
    Por ultimo el programa preguntara al usuario si quiere imprimir otra letra y terminara cuando el usuario ingrese (no) o la letra (n)
    Utilizar las estructuras vistas en clase
    
    Ejemplo Letra a:
      *
     * *
    *   *
    *****
    *   *
    
    Ejemplo Letra C:
     ****
    *
    *
    *
     ****
    
     */
    class Program
    {
        public static void Main(string[] args)
        {
            char letra, respuesta;
            do
            {
                Console.Write("Ingrese una letra: ");
                letra = Console.ReadLine()[0];
                letra = Char.ToLower(letra);
                Console.WriteLine("");
                for (int renglon = 0; renglon < 5; renglon++)
                {
                    for (int columna = 0; columna < 5; columna++)
                    {
                        switch (renglon)
                        {
                            case 0: 
                                switch (columna)
                                {
                                    case 0:
                                        if (letra == 'b' || letra == 'd' || letra == 'e' || letra == 'f' || letra == 'h' || letra == 'i' || letra == 'j' || letra == 'k' || letra == 'l' || letra == 'm' || letra == 'n' || letra == 'p' || letra == 'r' || letra == 't' || letra == 'u' || letra == 'v' || letra == 'w' || letra == 'x' || letra == 'y' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 1:
                                        if (letra == 'b' || letra == 'd' || letra == 'c' || letra == 'e' || letra == 'f' || letra == 'g' || letra == 'i' || letra == 'j' || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 's' || letra == 't' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 2:
                                        if (letra == 'a' || letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'f' || letra == 'g' || letra == 'i' || letra == 'j' || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 's' || letra == 't' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 3:
                                        if (letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'f' || letra == 'g' || letra == 'i' || letra == 'j' || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 's' || letra == 't' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 4:
                                        if (letra == 'c' || letra == 'e' || letra == 'f' || letra == 'g' || letra == 'h' || letra == 'i' || letra == 'j' || letra == 'k' || letra == 'm' || letra == 'n' || letra == 's' || letra == 't' || letra == 'u' || letra == 'v' || letra == 'w' || letra == 'x' || letra == 'y' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                }
                                break; 
                            case 1:
                                switch (columna)
                                {
                                    case 0:
                                        if (letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'f' || letra == 'g' || letra == 'h' || letra == 'k' || letra == 'l' || letra == 'm' || letra == 'n' || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 's' || letra == 'u' || letra == 'v' || letra == 'w')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 1:
                                        if (letra == 'a' || letra == 'm' || letra == 'n' || letra == 'x' || letra == 'y')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 2:
                                        if (letra == 'i' || letra == 't')
                                        {
                                            Console.Write("*");
                                        }
                                        else  Console.Write(" "); 
                                        break;
                                    case 3:
                                        if (letra == 'a' || letra == 'k' || letra == 'm' || letra == 'x' || letra == 'y' || letra == 'z' || letra == 'j')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 4:
                                        if (letra == 'b' || letra == 'd' || letra == 'h' || letra == 'm' || letra == 'n' || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 'u' || letra == 'v' || letra == 'w')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                }
                                break; 
                            case 2:
                                switch (columna)
                                {
                                    case 0:
                                        if (letra == 'a' || letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'f' || letra == 'g' || letra == 'h' || letra == 'k' || letra == 'l' || letra == 'm' || letra == 'n' || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 'u' || letra == 'v' || letra == 'w')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 1:
                                        if (letra == 'b' || letra == 'e' || letra == 'f' || letra == 'h' || letra == 'k' || letra == 'p' || letra == 'r' || letra == 's')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 2:
                                        if (letra == 'b' || letra == 'e' || letra == 'f' || letra == 'h' || letra == 'i' || letra == 'k' || letra == 'm' || letra == 'n' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 's' || letra == 't' || letra == 'w' || letra == 'x' || letra == 'y' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 3:
                                        if (letra == 'b' || letra == 'h' || letra == 'j' || letra == 'p' || letra == 'r' || letra == 's')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 4:
                                        if (letra == 'a' || letra == 'd' || letra == 'g' || letra == 'h' || letra == 'm' || letra == 'n' || letra == 'o' || letra == 'q' || letra == 'u' || letra == 'v' || letra == 'w')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                }
                                break; 
                            case 3:
                                switch (columna)
                                {
                                    case 0:
                                        if (letra == 'a' || letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'f' || letra == 'g' || letra == 'h' || letra == 'j' || letra == 'k' || letra == 'l' || letra == 'm' || letra == 'n' || letra == 'o' || letra == 'p' || letra == 'q' || letra == 'r' || letra == 'u' || letra == 'w')
                                        {
                                            Console.Write("*");
                                        }
                                        else  Console.Write(" "); 
                                        break;
                                    case 1:
                                        if (letra == 'a' || letra == 'v' || letra == 'w' || letra == 'x' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 2:
                                        if (letra == 'a' || letra == 'i' || letra == 't' || letra == 'y')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 3:
                                        if (letra == 'a' || letra == 'j' || letra == 'k' || letra == 'n' || letra == 'q' || letra == 'v' || letra == 'w' || letra == 'x')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 4:
                                        if (letra == 'a' || letra == 'b' || letra == 'd' || letra == 'g' || letra == 'h' || letra == 'm' || letra == 'n' || letra == 'o' || letra == 'r' || letra == 's' || letra == 'u' || letra == 'w')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                }
                                break; 
                            case 4:
                                switch (columna)
                                {
                                    case 0:
                                        if (letra == 'a' || letra == 'b' || letra == 'd' || letra == 'e' || letra == 'f' || letra == 'h' || letra == 'i' || letra == 'k' || letra == 'l' || letra == 'm' || letra == 'n' || letra == 'p' || letra == 'r' || letra == 's' || letra == 'w' || letra == 'x' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 1:
                                        if (letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'g' || letra == 'i' || letra == 'j' || letra == 'l' || letra == 'o' || letra == 'q' || letra == 's' || letra == 'u' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 2:
                                        if (letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'g' || letra == 'i' || letra == 'j' || letra == 'l' || letra == 'o' || letra == 'q' || letra == 's' || letra == 't' || letra == 'u' || letra == 'v' || letra == 'y' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else  Console.Write(" "); 
                                        break;
                                    case 3:
                                        if (letra == 'b' || letra == 'c' || letra == 'd' || letra == 'e' || letra == 'g' || letra == 'i' || letra == 'l' || letra == 'o' || letra == 's' || letra == 'u' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" "); 
                                        break;
                                    case 4:
                                        if (letra == 'a' || letra == 'c' || letra == 'e' || letra == 'g' || letra == 'h' || letra == 'i' || letra == 'k' || letra == 'l' || letra == 'm' || letra == 'n' || letra == 'q' || letra == 'r' || letra == 'w' || letra == 'x' || letra == 'z')
                                        {
                                            Console.Write("*");
                                        }
                                        else Console.Write(" ");
                                        break;
                                }
                                break;
                        }
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("\n¿Deseas escribir otra letra?(s/n)");
                respuesta = char.Parse(Console.ReadLine()); 
            } while (respuesta == 's');
        }
    }
}
