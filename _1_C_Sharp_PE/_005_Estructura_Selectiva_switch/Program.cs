using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Estructura_Selectiva_switch
{
    class Program
    {
        /*
         uso de switch
        Cuando usamos switch es necesario colocar entre paréntesis la variable que utilizaremos para llevar a cabo las comparaciones. 
        Luego tenemos que crear un bloque de código y colocar adentro de él los casos y el código a ejecutar para cada caso. 
        Para indicar un caso, usamos case seguido del valor de comparación y dos puntos.
        Existe un caso llamado default, que podemos utilizar si lo deseamos. Este caso siempre debe ser el último caso definido. 
        Cuando la variable de comparación no ha encontrado su valor en ninguno de los casos, entonces se ejecuta el código del caso default.
        Para indicar dónde termina el código de un caso debemos hacer uso de break, que nos permitirá salir de la ejecución de una estructura 
        selectiva o repetitiva. Esto lo veremos con más detalle en otro capítulo. Si no hacemos uso de break y el caso está vacío, 
        entonces el programa continuará ejecutando el código del próximo caso y así sucesivamente hasta el final del bloque del código que 
        pertenece al switch
         */
        static void Main(string[] args)
        {
            // Variables necesarias
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;

            // Mostramos el menú
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - División");
            Console.WriteLine("4 - Multiplicación");
            Console.Write("Que operación deseas hacer: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            // Pedimos el primer número
            Console.Write("Dame el primer numero: ");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);

            // Pedimos el segundo número
            Console.Write("Dame el segundo numero: ");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);

            switch (opcion)
            {
                case 1: // Verificamos para suma
                    resultado = a + b;
                    break;
                case 2: // Verificamos para resta
                    resultado = a - b;
                    break;
                case 3: // Verificamos para división
                    if (b != 0) // este if esta anidado
                        resultado = a / b;
                    else // Este else pertenece al segundo if
                        Console.WriteLine("Divisor no valido");
                    break;
                case 4: // Verificamos para la multiplicación
                    resultado = a * b;
                    break;

                default:// Si no se cumple ninguno de los casos anteriores
                    Console.WriteLine("Opción no valida");
                    break;
            }

            Console.WriteLine("El resultado es: {0}", resultado);   // Mostramos el resultado

            Console.ReadKey();
        }
    }
}
