using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Leer_Datos
{
    class Program
    {
        //C# nos provee de un método que pertenece a la clase Console.
        //El metodo para poder pedirles datos al usuario es el metodo ReadLine() y no necesita ningun argumento.

        static void Main(string[] args)
        {
            string entrada = "";

            Console.Write("Escribe tu nombre: ");

            entrada = Console.ReadLine();

            Console.WriteLine("Hola {0}, Bienvenido.", entrada);

            //Si queremos convertir del tipo string al tipo int usaremos algunos de los siguientes metodos

            /*
            Convert.ToInt32() necesita un parámetro, que es la cadena que deseamos convertir. 
            El método regresa un valor de tipo int, por lo que es necesario tener una variable que lo reciba.
             */

            Console.WriteLine("Convertir una variable de tipo string (cadena) a tipo int (entero) con el metodo ToInt32()");

            Console.Write("Ingrese un valor: ");

            string Cadena = Console.ReadLine();

            int Entero;

            Entero = Convert.ToInt32(Cadena); // Convierte la variable de tipo Cadena a tipo Entero

            Console.WriteLine("Valor de la variable: {0}", Entero);

            // Otra forma de convertir del tipo string al tipo int usaremos algunos de los siguientes metodos

            Console.WriteLine("Convertir una variable de tipo string (cadena) a tipo int (entero) con el metodo int.Parse()");

            Console.Write("Ingrese un valor: ");

            Entero = int.Parse(Console.ReadLine()); // Convierte los datos leidos por teclado a tipo Entero

            Console.WriteLine("Valor de la variable: {0}", Entero);

            Console.WriteLine("Convertir una variable de tipo string (cadena) a tipo int (entero) con el metodo int.TryParse()");

            Console.Write("Ingrese un valor: ");

            int.TryParse(Console.ReadLine(), out Entero); // Convierte los datos leidos por teclado a tipo Entero

            //Si queremos convertir del tipo int al tipo float usaremos algunos de los siguientes metodos

            /*
            Convert.ToSingle() necesita un parámetro, que es la cadena que deseamos convertir. 
            El método regresa un valor de tipo int, por lo que es necesario tener una variable que lo reciba.
             */

            Console.WriteLine("Convertir una variable de tipo int (Entero) a tipo float (Flotante) con el metodo Convert.ToSingle()");

            Console.Write("Ingrese un valor: ");

            float Flotante = Convert.ToSingle(Entero); // Convierte la variable de tipo Entero a tipo Flotante

            Console.WriteLine("Valor de la variable: {0}", Flotante);

            Console.WriteLine("\nPresione una tecla para continuar...");

            Console.ReadKey();
        }
    }
}
