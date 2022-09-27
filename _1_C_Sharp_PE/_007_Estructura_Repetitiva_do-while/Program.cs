using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Estructura_Repetitiva_do_while
{
    /*
            ESTRUCTURA hacer-mientras ("do-while")
    El bucle hacer-mientras es análogo al bucle mientras y el cuerpo del bucle se ejecuta una y otra vez mientras
    la condición (expresión booleana) sea verdadera. Existe, sin embargo, una gran diferencia y es que el cuerpo del
    bucle está encerrado entre las palabras reservadas hacer y mientras, de modo que las sentencias de dicho cuerpo se
    ejecutan, al menos una vez, antes de que se evalúe la expresión booleana. En otras palabras, el cuerpo del bucle
    siempre se ejecuta, al menos una vez, incluso aunque la expresión booleana sea falsa.
    El bucle hacer-mientras se termina de ejecutar cuando el valor de la condición es falsa. 
    La elección entre un bucle mientras y un bucle hacer-mientras depende del problema de cómputo a resolver.

            do 
            {
                Código
            }(condición);

    El ciclo do while nos da flexibilidad extra, pero siempre es necesario usar el tipo de ciclo adecuado al problema que tenemos.
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crearemos el programa para la carpintería y usaremos el ciclo do while para que el programa se repita 
            el número de veces necesarias, aun sin saber cuántas veces son. Para lograr esto tenemos que pensar bien 
            en nuestra condición y cuál es el estado del programa que evaluaremos en ella. 
            */

            // Variables necesarias
            /*float pies = 0.0f; // Cantidad de pies
            float pulgadas = 0.0f; // Cantidad de pulgadas
            float centimetros = 0.0f; // Resultado en centímetros
            string respuesta = ""; // Respuesta para otro cálculo

            do
            {
                Console.Write("Cuántos pies: ");        // Pedimos los pies
                float.TryParse(Console.ReadLine(), out pies);

                Console.Write("Cuántas pulgadas: ");        // Pedimos las pulgadas
                float.TryParse(Console.ReadLine(), out pulgadas);
                
                centimetros = ((pies * 12) + pulgadas) * 2.54f;     // Convertimos a centimetros

                Console.WriteLine("Son {0} centimetros", centimetros); // Mostramos el resultado
               
                Console.Write("Deseas hacer otra conversión (si / no): ");  // Preguntamos si otra conversión
                respuesta = Console.ReadLine();
            } while (respuesta == "si");*/


            // Otro programa utilizando el ciclo do-while

            // Variables necesarias
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            int opcion = 0;
            // Tenemos el ciclo
            do
            {
                // Mostramos el menú
                Console.WriteLine("\n1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - División");
                Console.WriteLine("4 - Multiplicación");
                Console.WriteLine("5 - Salir");
                Console.Write("Que operación deseas hacer: ");
                int.TryParse(Console.ReadLine(), out opcion);

                if (opcion != 5)
                {
                    // Pedimos el primer número
                    Console.Write("Dame el primer número: ");
                    a = float.Parse(Console.ReadLine());

                    // Pedimos el segundo número
                    Console.Write("Dame el segundo número: ");
                    b = float.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:     // Verificamos para suma
                            resultado = a + b;
                            break;
                        case 2:     // Verificamos para resta
                            resultado = a - b;
                            break;
                        case 3:     // Verificamos para división
                            if (b != 0) // este if esta anidado
                                resultado = a / b;
                            else // Este else pertenece al segundo if
                                Console.WriteLine("Divisor no válido");
                            break;
                        case 4:     // Verificamos para la multiplicación
                            resultado = a * b;
                            break; 
                        default:    // Si no se cumple ninguno de los casos anteriores
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    
                    Console.WriteLine("El resultado es: {0}", resultado);       // Mostramos el resultado
                }
            } while (opcion != 5);
        }
    }
}
