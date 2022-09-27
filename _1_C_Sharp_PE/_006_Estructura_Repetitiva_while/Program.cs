using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Estructura_Repetitiva_while
{
    /*      Estructuras repetitivas
    Las estructuras que repiten una secuencia de instrucciones un número determinado de veces se denominan bucles y
    se denomina iteración al hecho de repetir la ejecución de una secuencia de acciones. 
    Las opciones repetidas se denominan bucles o lazos. La acción (o acciones) que se repite en un bucle se denomina
    iteración.
    Para detener la ejecución de los bucles se utiliza una condición de parada. El pseudocódigo de una estructura
    repetitiva tendrá siempre este formato:

        inicio
        //inicialización de variables
        repetir
            acciones S1, S2, ...
            salir según condición
            acciones Sn, Sn+1, ...
        fin_repetir

            Bucles infinitos
    Algunos bucles no exigen fin y otros no encuentran el fin por error en su diseño.
    En ocasiones un bucle no se termina nunca porque nunca se cumple la condición.
    Un bucle que nunca se termina se denomina bucle infinito o sin fin. Los bucles sin fin no intencionados son perjudiciales
    para la programación y se deben evitar siempre.

           Estructura repetitiva While 
    La estructura repetitiva mientras (en inglés while o  mientras) es aquella en que el cuerpo del bucle se repite mientras 
    se cumple una determinada condición. Cuando se ejecuta la instrucción mientras, la primera cosa que sucede es que se evalúa 
    la condición (una expresión booleana). Si se evalúa falsa, no se toma ninguna acción y el programa prosigue en la siguiente 
    instrucción del bucle. Si la expresión booleana es verdadera, entonces se ejecuta el cuerpo del bucle, después de lo cual se 
    evalúa de nuevo la expresión booleana. Este proceso se repite una y otra vez mientras la expresión booleana (condición) sea verdadera. 

        while(condicion) 
        {
            Código
        } 

            Terminación de bucles con datos de entrada
    Si un algoritmo o programa está leyendo una lista de valores con un bucle mientras, se debe incluir algún tipo de
    mecanismo para terminar el bucle. Existen cuatro métodos típicos para terminar un bucle de entrada:

            1. preguntar antes de la iteración,
            2. encabezar la lista de datos con su tamaño,
            3. finalizar la lista con su valor de entrada,
            4. agotar los datos de entrada.

     Lista encabezada por el tamaño
    Si su programa puede determinar el tamaño de una lista de entrada por anticipado, bien preguntando al usuario o por
    algún otro método, se puede utilizar un bucle “repetir n veces” para leer la entrada exactamente n veces, en
    donde n es el tamaño de la lista.
        
        Preguntar antes de la iteración
    El segundo método para la terminación de un bucle de entrada es preguntar, simplemente, al usuario, después de cada
    iteración del bucle, si el bucle debe ser o no iterado de nuevo,

        Valor centinela
    El método más práctico y eficiente para terminar un bucle que lee una lista de valores del teclado es mediante un
    valor centinela. Un valor centinela es aquél que es totalmente distinto de todos los valores posibles de la lista que
    se está leyendo y de este modo sirve para indicar el final de la lista. Un ejemplo típico se presenta cuando se lee una
    lista de números positivos; un número negativo se puede utilizar como un valor centinela para indicar el final de la
    lista.

        Agotamiento de la entrada
    Cuando se leen entradas de un archivo, se puede utilizar un valor centinela. Aunque el método más frecuente es
    comprobar simplemente si todas las entradas del archivo se han leído y se alcanza el final del bucle cuando no hay
    más entradas a leer. Éste es el método usual en la lectura de archivos, que suele utilizar una marca al final de archivo.

    El método más correcto para terminar un bucle que lee una lista de valores es con un centinela. 
    Un valor centinela es un valor especial usado para indicar el final de una lista de datos
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Imaginemos que tenemos que hacer un programa de control para enfriar una caldera. 
            La caldera debe ser enfriada a 20 grados centígrados.
            El ciclo while será usado para reducir la temperatura de uno en uno para cada vuelta
            del ciclo hasta que lleguemos a 20 grados centígrados. 
            La ventaja es que si la temperatura es menor a 20 grados, ni siquiera se entra al ciclo 
            y no se lleva a cabo ningún enfriamiento.
            */
            
            int temperatura; // Variables necesarias

            Console.Write("Dame la temperatura actual: ");  // Pedimos la temperatura
            int.TryParse(Console.ReadLine(), out temperatura);

            while (temperatura > 20)    // El ciclo reduce la temperatura
            {                 
                temperatura--;      // Disminuimos la temperatura

                Console.WriteLine("Temperatura ---> {0}", temperatura);
            }

            Console.WriteLine("La temperatura final es {0}", temperatura);      // Mostramos la temperatura final

            Console.ReadKey();
        }
    }
}
