using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Estructura_Repetitiva_for
{
    /*
            ESTRUCTURA desde/para ("for")
    En muchas ocasiones se conoce de antemano el número de veces que se desean ejecutar las acciones de un bucle.
    En estos casos, en el que el número de iteraciones es fijo, se debe usar la estructura desde o para (for, en inglés).
    La estructura desde ejecuta las acciones del cuerpo del bucle un número especificado de veces y de modo automático
    controla el número de iteraciones o pasos a través del cuerpo del bucle.
    La estructura desde comienza con un valor inicial de la variable índice y las acciones especificadas se ejecutan,
    a menos que el valor inicial sea mayor que el valor final. La variable índice se incrementa en uno y si este nuevo valor
    no excede al final, se ejecutan de nuevo las acciones. Por consiguiente, las acciones específicas en el bucle se ejecutan
    para cada valor de la variable índice desde el valor inicial hasta el valor final con el incremento de uno en uno.
    El incremento de la variable índice siempre es 1 si no se indica expresamente lo contrario.
    La variable índice o de control normalmente será de tipo entero y es normal emplear como nombres las letras I, J, K.
    Si el valor inicial de la variable índice es menor que el valor final, los incrementos deben ser positivos, ya que
    en caso contrario la secuencia de acciones no se ejecutaría. De igual modo, si el valor inicial es mayor que el valor
    final, el incremento debe ser en este caso negativo, es decir, decremento. Al incremento se le suele denominar también
    paso (“step”, en inglés).

            SALIDAS INTERNAS DE LOS BUCLES
    Aunque no se incluye dentro de las estructuras básicas de la programación estructurada, en ocasiones es necesario
    disponer de una estructura repetitiva que permita la salida en un punto intermedio del bucle cuando se cumpla una
    condición.

            Sentencia interrumpir (break)
    En ocasiones, los programadores desean terminar un bucle en un lugar determinado del cuerpo del bucle en vez de
    esperar que el bucle termine de modo natural por su entrada o por su salida. Un método de conseguir esta acción
    siempre utilizada con precaución y con un control completo del bucle— es mediante la sentencia interrumpir
    (break) que se suele utilizar en la sentencia según_sea (switch).
    La sentencia interrumpir se puede utilizar para terminar una sentencia de iteración y cuando se ejecuta produce
    que el flujo de control salte fuera a la siguiente sentencia inmediatamente a continuación de la sentencia de iteración.
    La sentencia interrumpir se puede colocar en el interior del cuerpo del bucle para implementar este efecto.
        La sentencia interrumpir (break) se utiliza frecuentemente junto con una sentencia si (if) actuando como
        una condición interna del bucle

            var entero: t
            desde t ← 0 hasta t < 100 incremento 1 hacer
                escribir (t)
                si (t = 1d) entonces
                    interrumpir
                fin_si
            fin_desde

            Sentencia continuar (continue)
    La sentencia continuar (continue) hace que el flujo de ejecución salte el resto de un cuerpo del bucle para continuar
    con el siguiente bucle o iteración. Esta característica suele ser útil en algunas circunstancias.
    La sentencia continuar sólo se puede utilizar dentro de una iteración de un bucle. La sentencia continuar no
    interfiere con el número de veces que se repite el cuerpo del bucle como sucede con interrumpir, sino que simplemente
    influye en el flujo de control en cualquier iteración específica.

            for(inicializacion; condicion; incremento)
                código

            ESTRUCTURAS REPETITIVAS ANIDADAS
    De igual forma que se pueden anidar o encajar estructuras de selección, es posible insertar un bucle dentro de otro.
    Las reglas para construir estructuras repetitivas anidadas son iguales en ambos casos: la estructura interna debe estar
    incluida totalmente dentro de la externa y no puede existir solapamiento.

     */
    class Program
    {
        static void Main(string[] args)
        {
            // Tabla de multiplicar:

            /*int numero;

            Console.Write("De cual tabla quieres hacer la multiplicacion: ");

            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }*/


            // Ahora tenemos que calcular el factorial de un número.

            /*int n = 0; // Variable de control
            int numero = 0; // Número al que sacamos factorial
            int factorial = 1; // Factorial calculado
            
            Console.Write("Dame el número al que se le saca el factorial: ");   // Pedimos el numero
            numero = int.Parse(Console.ReadLine());
            
            for (n = numero; n >= 1; n--)   // Calculamos el factorial en el ciclo
                factorial *= n;
            
            Console.WriteLine("{0}! = {1}", numero, factorial); // Mostramos el resultado
            */


            /*
            Escribir un programa que visualice un triángulo isósceles. 
                                    *
                                  * * *
                                * * * * *
                              * * * * * * *
                            * * * * * * * * * 
             */

            // datos locales...
            const int num_lineas = 5;
            const char blanco = ' ';
            const char asterisco = '*';
            // comienzo de una nueva línea
            Console.WriteLine();
            // dibujar cada línea: bucle externo
            for (int fila = 1; fila <= num_lineas; fila++)
            {
                for (int blancos = num_lineas - fila; blancos > 0; blancos--)        // imprimir espacios en blanco: primer bucle interno
                    Console.Write(blanco);
                for (int cuenta_as = 1; cuenta_as < 2 * fila; cuenta_as++)
                    Console.Write(asterisco);
                // terminar línea
                Console.WriteLine();
            } // fin del bucle externo

            Console.ReadKey();
        }
    }
}
