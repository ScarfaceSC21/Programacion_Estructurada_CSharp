using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Imprimir_Variables
{
    /*      Variables
    Las variables son espacios en memoria (RAM) que permiten almacenar valores en memoria.
    Las variables siguen una serie de pautas y/o tips para poder crearlas.
    Las pautas y/o tips a seguir son los siguientes:

       1.- Los nombres de las variables deben empezar con letra.
       2.- Es posible colocar números en los nombres de las variables, pero no empezar el nombre con ellos.
       3.- Los nombres de las variables no pueden llevar signos a excepción del guión bajo _ .
       4.- Las variables no pueden llevar acentos en sus nombres.

    Para crear una variable necesitamos saber el tipo de dato que va a almacenar, el nombre de la variable que
    permitira identificarla y el valor que almacenara.

    Cuando nombramos las variables, hay que tener en cuenta que C# es sensible a las mayúsculas y minúsculas, 
    por lo que una variable llamada costo no es la misma que otra variable llamada COSTO u otra llamada Costo.
    Es recomendable nombrar a las variables con nombres que hagan referencia a la información que guardarán.

                       Tipos de variables en C#:
       byte = Puede guardar un byte de información. Esto equivale a un valor entero positivo entre 0 y 255
       sbyte = Guarda un byte con signo de información. Podemos guardar un valor entero con signo desde –128 hasta 127
       ushort = Puede guardar valores numéricos enteros positivos con un rango desde 0 hasta 65,535
       short = Guarda valores numéricos enteros, pero su rango es menor y varía desde -32,768 hasta 32,767
       uint = Para valores numéricos enteros positivos, su rango de valores es desde 0 hasta 4,294,967,295
       int = Cuando queremos guardar valores numéricos enteros con signo, en el rango de -2,147,483,648 hasta 2,147,483,647.
       decimal = Este tipo puede guardar un valor numérico con decimales. Su rango es desde ±1.0 ? 10?28 hasta ±7.9 ? 1028
       float = Otro tipo muy utilizado para guardar valores numéricos con decimales. Para este tipo el rango es desde ±1.5 ? 10?45 hasta ±3.4 ? 1038
       double = También nos permite guardar valores numéricos que tengan decimales. El rango aproximado es desde ±5.0 ? 10?324 hasta ±1.7 ? 10 308
       ulong = Guarda valores numéricos enteros positivos. Su rango de valores varía desde 0 hasta 18,446,744,073,709,551,615
       long = Guarda valores numéricos enteros realmente grandes con un rango desde –9,223,372,036,854,775,808 hasta 9,223,372,036,854,775,807
       bool = Es una variable booleana, es decir que solamente puede guardar los valores verdadero o falso (true o false)   
       char = Puede guardar un carácter de tipo Unicode
       string = Este tipo nos permite guardar cadenas
       */

    class Program
    {
        static void Main(string[] args)
        {
            // Se puede declarar una variable en una linea y inciarla despues en otra linea

            int costo; // Declaracion en una linea de una variable de tipo entero 
            costo = 50; // Inicializacion de la variable en otra linea

            // Se puede declarar varias variables en una misma linea y inicializarlas despues

            int valor, impuesto; // Declaracion en una linea de varias variables de tipo entero
            valor = 7;      // Inicializacion de la variable en otra linea
            impuesto = 10;  // Inicializacion de la variable en otra linea

            bool Hace_Frio = false; // Declaracion e inicializacion de la variable Hace_Frio en la misma linea

            string nombre = "Uriel Armenta Medina"; // Declaracion e inicializacion de la variable nombre en la misma linea

            /* Imprimir variables 
             Se puede imprimir variables en consola de diferentes maneras
             */

            Console.WriteLine("El valor de la variable costo es: " + costo); // Imprime la variable costo en forma de concatenacion
            Console.WriteLine("El valor de la variable valor es: {0}", valor); // Imprime la variable valor como argumento
            Console.WriteLine($"El valor de la variable impuesto es: {impuesto}"); // Imprime la variable impuesto como argumento de diferente manera
            Console.WriteLine($"El valor de la variable Hace_Frio es: {Hace_Frio}");  // Imprime la variable Hace_Frio 
            Console.WriteLine("El valor de la variable nombre es: {0} ", nombre);  // Imprime la variable nombre 

            // Tambien se pueden declara constantes, las constantes no cambian su valor desues de ser declaradas ni durante toda la ejecucion del programa.

            const float pi = 3.1416F;

            Console.WriteLine("Valor de la constante: {0}", pi);

            Console.ReadKey();

        }
    }
}
