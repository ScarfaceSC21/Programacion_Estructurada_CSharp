using System;                       // Libreria
using System.Collections.Generic;   // Libreria
using System.Linq;                  // Libreria
using System.Text;                  // Libreria
using System.Threading.Tasks;       // Libreria

namespace _000_HolaMundo            // Espacio de nombre donde se almacenara nuestro proyecto
{
    class Program                   // Clase del proyecto
    {
        static void Main(string[] args) // Metodo Main() Aqui inicia el programa
        {
            // Aqui se escriben las instruccion 

            Console.WriteLine("Hola Mundo!"); // Imprime en pantalla: Hola Mundo!

            //Clase: Console    Metodo: WriteLine   Argumento: "Hola mundo!" , El metodo recibe el argumento Hola Mundo! y lo imprime en pantalla

            Console.ReadKey();  //Metodo que se queda a la espera de recibir una tecla para continuar.

            // Clase: Console   Metodo: ReadKey , El metodo queda a la espera de recibir una tecla ara continuar.

            // Este es un comentario de una sola linea. El compilador lo ignora y continua con su ejecucion.

            /*
             Este es un comentario de varias lineas.
             El compilador la ignora y continua con su ejecucion.
             */
        }
    }
}
