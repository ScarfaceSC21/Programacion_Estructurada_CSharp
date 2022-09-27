using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Operaciones_Aritmeticas
{
    /*
    Operadores aritmeticas:
    = Asignacion
    + Suma
    - Resta
    * Multiplicacion
    / Divicion
    % Residuo o Modulo
     */
    class Program
    {
        /*
            Precedencia de operadores
        * Multiplicacion
        / Division
        % Residuo o Modulo
        + Suma
        - Resta
         */
        static void Main(string[] args)
        {
            int suma = 5 + 5;

            int a = 7;

            int resta = 14 - a;

            int b = 8;

            int multiplicacion = a * b;

            double divicion = a / 7;

            int residuo = 10 % b; 

            Console.WriteLine("Valor de la suma [5 + 5] = {0}",suma);

            Console.WriteLine("Valor de la resta [14 - 7] = {0}",resta);

            Console.WriteLine("Valor de la multiplicacion [7 * 8] = {0}",multiplicacion);

            Console.WriteLine("Valor de la divicion [7 / 7] = {0}",divicion);

            Console.WriteLine("Valor del residuo [10 % 8] = {0}",residuo);

            double resultado = (3 + 7) * (36 + 4 * (2 + 5));

            Console.WriteLine("Valor de la variable resultado despues de la operacion (3 + 7) * (36 + 4 * (2 + 5)) = " + resultado);

            Console.ReadKey();
        }
    }
}
