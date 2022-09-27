using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Estructura_Datos_Arreglo
{
    /*      ESTRUCTURA DE DATOS: ARREGLOS
   Una estructura de datos es una colección de datos que pueden ser caracterizados por su organización y las operaciones
   que se definen en ella.

   Los tipos de datos simples o primitivos significan que no están compuestos de otras estructuras de datos; los más
   frecuentes y utilizados por casi todos los lenguajes son: enteros, reales y carácter (char), siendo los tipos lógicos,
   subrango y enumerativos propios de lenguajes estructurados  

   Los tipos de datos compuestos están construidos basados en tipos de datos primitivos; el ejemplo más representativo 
   es la cadena (string) de caracteres.
   Los tipos de datos simples pueden ser organizados en diferentes estructuras de datos: estáticas y dinámicas.
   Las estructuras de datos estáticas son aquellas en las que el tamaño ocupado en memoria se define antes de que el
   programa se ejecute y no puede modificarse dicho tamaño durante la ejecución del programa. Estas estructuras están
   implementadas en casi todos los lenguajes: array (vectores/tablas-matrices), registros, ficheros o archivos.
   Las estructuras de datos dinámicas no tienen las limitaciones o restricciones en el tamaño de memoria ocupada 
   que son propias de las estructuras estáticas.

   Una característica importante que diferencia a los tipos de datos es la siguiente: los tipos de datos simples tienen
   como característica común que cada variable representa a un elemento; los tipos de datos estructurados tienen como
   característica común que un identificador (nombre) puede representar múltiples datos individuales, pudiendo cada
   uno de éstos ser referenciado independientemente.

   Un array o arreglo (matriz o vector) es un conjunto finito y ordenado de elementos homogéneos. La propiedad 
   “ordenado” significa que el elemento primero, segundo, tercero, ..., enésimo de un array puede ser identificado.
   Los elementos de un array son homogéneos, es decir, del mismo tipo de datos.

   Otro punto que notamos es que las variables están numeradas, como si tuvieran un índice que nos sirve para identificarlas.
   Los arreglos son similares a estos conceptos ya que son grupos de variables y estas variables serán referenciadas por el mismo nombre. 
   Para poder acceder a una variable del arreglo usaremos un número de índice, ya que todas las variables adentro de un arreglo serán de un mismo tipo. 
   Un punto muy importante que no debemos olvidar cuando trabajemos con los arreglos es que éstos están basados en índice cero, esto quiere decir 
   que el primer elemento del arreglo se encuentra en la posición 0, no en la posición 1 como podríamos pensar.

               Declaración de los arreglos de una dimensión
   Los arreglos pueden tener diferentes dimensiones, y si el arreglo se parece a unasimple lista, como la lista de calificaciones que tenemos, 
   entonces decimos que es de una dimensión. Estos arreglos también se conocen como monodimensionales o unidimensionales. 
   Si el arreglo es como una tabla con varios renglones y varias columnas, entonces es un arreglo de dos dimensiones o bidimensional.

           En la declaración nosotros indicamos su tipo, su nombre y su tamaño.
                       tipo[] nombre = new tipo[tamaño];

    */
    class Program
    {
        static void Main(string[] args)
        {
            /*float[] arreglo = new float[5]; // Declaracion de un arreglo de 5 elementos

             //En algunas ocasiones podemos conocer los valores que colocaremos adentro del arreglo, por lo que podemos declararlo y 
             //asignarle sus valores en la misma sentencia.

            float[] valores = { 7.5f, 8.4f, 9.5f };     //Declaracion y asignacion de valores en el arreglo en la misma linea

            arreglo[0] = 10; //  Asignacion del valor 10 al arreglo en el indice 0
            */

            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int n = 0; // Variable de control de ciclo
            string valor = "";

            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;// Variable para la calificación mínima
            float maxima = 0.0f; // Variable para la calificación maxima

            // Pedimos la cantidad de alumnos
            Console.Write("Dame la cantidad de alumnos: ");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            Console.WriteLine();

            // Creamos el arreglo
            float[] calif = new float[cantidad];

            // Capturamos la información
            for (n = 0; n < cantidad; n++)
            {
                Console.Write("Dame la calificación: ");
                valor = Console.ReadLine();
                calif[n] = Convert.ToSingle(valor);
            }

            // Encontramos el promedio
            for (n = 0; n < cantidad; n++)
            {
                suma += calif[n];
            }
            promedio = suma / cantidad;

            // Encontramos la calificación mínima
            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] < minima)
                    minima = calif[n];
            }

            // Encontramos la calificación maxima
            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] > maxima)
                    maxima = calif[n];
            }

            Console.WriteLine();

            // Desplegamos los resultados
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);

            Console.ReadKey();
        }
    }
}
