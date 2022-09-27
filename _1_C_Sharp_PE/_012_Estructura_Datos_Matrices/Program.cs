using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Estructura_Datos_Matrices
{
    /*          MATRICES
    El array bidimensional se puede considerar como un vector de vectores. Es, por consiguiente, un conjunto de elementos,
    todos del mismo tipo, en el cual el orden de los componentes es significativo y en el que se necesita especificar
    dos subíndices para poder identificar cada elemento del array.
    Los elementos de un array bidimensional se referencian con dos subíndices: el primer subíndice se refiere a la fila y 
    el segundo subíndice se refiere a la columna.
    Un array bidimensional M, también denominado matriz (términos matemáticos) o tabla (términos financieros), se
    considera que tiene dos dimensiones (una dimensión por cada subíndice) y necesita un valor para cada subíndice para
    poder identificar un elemento individual. En notación estándar, normalmente el primer subíndice se refiere a la fila
    del array, mientras que el segundo subíndice se refiere a la columna del array. Es decir, es el elemento de B[I, J]
    que ocupa la Iª fila y la Jª columna.
    Al igual que con los arreglos de una sola dimensión, los índices están basados en 0.
    
        Declaración de los arreglos de dos dimensiones
    La declaración es similar al arreglo de una dimensión, pero indicamos la cantidad de elementos en cada dimensión.

        tipo[,] nombre = new tipo[fila,columna];
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones
            int m = 0; // Variable de control del ciclo alumnos
            string valor = "";

            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;// Variable para la calificación mínima
            float maxima = 0.0f; // Variable para la calificación maxima
            
            // Pedimos la cantidad de salones
            Console.Write("Dame la cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            // Pedimos la cantidad de alumnos
            Console.Write("Dame la cantidad de alumnos por salon: ");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            // Creamos el arreglo
            float[,] calif = new float[salones, cantidad];

            // Capturamos la información
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n+1);
                for (m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    Console.Write("Dame la calificación: ");
                    valor = Console.ReadLine();
                    calif[n, m] = Convert.ToSingle(valor);
                }
            }

            // Encontramos el promedio
            for (n = 0; n<salones; n++) // Ciclo salones
            {
                for (m = 0; m<cantidad; m++) // Ciclo alumnos
                {
                    suma += calif[n, m];
                }
            }
            promedio = suma / (cantidad * salones);

            // Encontramos la calificación mínima
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                for (m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    if (calif[n, m] < minima)
                        minima = calif[n, m];
                }
            }

            // Encontramos la calificación maxima
            for (n = 0; n < salones; n++) // Ciclo salones
            {
                for (m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    if (calif[n, m] > maxima)
                        maxima = calif[n, m];
                }
            }

            // Desplegamos los resultados
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);

            Console.ReadKey();
        }
    }
}
