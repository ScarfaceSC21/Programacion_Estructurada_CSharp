using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Estructura_Selectiva_if
{
    /*
       Expresiones Selectivas
   Las estructuras selectivas son aquellas que nos permiten hacer una selección entre dos o varias rutas de ejecución posibles. 
   La selección se llevará a cabo según el valor de una expresión. Esta expresión puede ser una expresión relacional.
   Las expresiones relacionales se usan para expresar la relación que existe entre dos valores. 
   Los valores pueden estar contenidos adentro de variables o ser colocados explícitamente. 
   Estas expresiones, al igual que las expresiones aritméticas, tienen sus propios operadores. 
   La expresión será evaluada, pero el resultado de la evaluación tendrá únicamente dos valores posibles: true o false.
           Operadores relacionales
               ==     Igualdad
               !=     No Igual (Diferene que)
               >      Mayor que
               <      Menor que
               >=     Mayor o igual que
               <=     Menor o igual que
    */
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 15;

            bool expresion = a == b; // Evaluamos si (a) es igual a (b) y la almacenamos el resultado en la variable en la variable expresion

            Console.WriteLine("(a = 5) ==  (b = 15) = " + expresion);

            //Condicional if
            /*
             if(expresión)
             {
                Sentencia 1;
                Sentencia 2;
                …
                Sentencia n;
             }
             */

            int numero = 0; // Donde guardamos el número
            string valor = ""; // Para guardar la cadena dada por el usuario

            // Pedimos el número
            Console.Write("Dame un numero entero:");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);    // Convertimos la cadena a entero

            // Hacemos uso de if con la expresión para el caso de los positivos
            if (numero >= 0) Console.WriteLine("El numero {0} es positivo", numero); // se ejecuta si se cumple numero>= 0

            // Hacemos uso de if con la expresión para el caso de los negativos
            if (numero < 0) Console.WriteLine("El numero {0} es negativo", numero); // se ejecuta si se cumple numero<0

            // Variables necesarias
            float dividendo = 0.0f;
            float divisor = 1.0f;
            float resultado = 0.0f;
            valor = "";

            // Pedimos el dividendo
            Console.Write("Dame el dividendo: ");
            valor = Console.ReadLine();
            dividendo = Convert.ToInt32(valor);

            // Pedimos el divisor
            Console.Write("Dame el divisor: ");
            valor = Console.ReadLine();
            divisor = Convert.ToInt32(valor);

            if (divisor != 0.0f)    // Si el divisor es válido, entonces hacemos la división
            {
                resultado = dividendo / divisor;    // Hacemos la operación

                Console.WriteLine("El resultado de la división es {0}", resultado); // Mostramos el resultado
            }


            //  El uso de else.
            //Si una condicion no se cumlpe podemos hacer que el programa 
            //realice una accion en caso de que no se haya cumplido la condicion primaria para esto utilizamos el else
            //Siempre utilizaremos else a continuación de una sentencia if, ya que else no se puede usar sólo.
            /*
            if(condición)
                Sentencia1;
            else
                Sentencia2;
             */

            numero = 0; // Donde guardamos el número
            valor = ""; // Para guardar la cadena dada por el usuario

            // Pedimos el numero
            Console.Write("Dame un número entero: ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor); // Convertimos la cadena a entero

            if (numero >= 0)    // Hacemos uso de if con la expresión para el caso de los positivos
                Console.WriteLine("El número {0} es positivo ", numero); // se ejecuta si se cumple numero >= 0
            else
                Console.WriteLine("El numero {0} es negativo", numero); // se ejecuta si NO se cumple numero>= 0

            /*  El uso de else con bloque de código 
            Al igual que con if, nosotros podemos colocar un bloque de código en else. 
            Esto nos permitiría que más de una sentencia se ejecute cuando no se cumple la condició del if. 
            No debemos olvidar colocar el bloque de código empezando con una llave, {, y finalizándolo con la llave de cierre }. 
            Adentro del bloque de código podemos colocar cualquier sentencia válida de C#.
             */

            // Variables necesarias
            dividendo = 0.0f;
            divisor = 1.0f;
            resultado = 0.0f;
            valor = "";

            // Pedimos el dividendo
            Console.Write("Dame el dividendo: ");
            valor = Console.ReadLine();
            dividendo = Convert.ToInt32(valor);

            // Pedimos el divisor
            Console.Write("Dame el divisor: ");
            valor = Console.ReadLine();
            divisor = Convert.ToInt32(valor);

            if (divisor == 0) Console.WriteLine("El divisor no es válido");

            else
            {
                resultado = dividendo / divisor;    // Hacemos la operacion

                Console.WriteLine("El resultado de la división es {0}", resultado); // Mostramos el resultado
            }

            //  if anidados
            /*
             La sentencia o el bloque de código que ejecuta if puede ser cualquier sentencia válida o bloque de código válido en C#, 
            esto incluye a otro if. Esto significa que nosotros podemos colocar if adentro del código a ejecutar de un if anterior. 
            Cuando hacemos esto hay que ser cuidadosos para evitar errores de lógica. Esto se conoce como if anidados.
             */

            // Variables necesarias
            float x = 0.0f;
            float y = 0.0f;
            resultado = 0.0f;
            valor = "";
            int opcion = 0;

            // Mostramos el menu
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
            x = Convert.ToSingle(valor);

            // Pedimos el segundo número
            Console.Write("Dame el segundo numero: ");
            valor = Console.ReadLine();
            y = Convert.ToSingle(valor);

            if (opcion == 1)    // Verificamos para suma
                resultado = x + y;

            if (opcion == 2)    // Verificamos para resta
                resultado = x - y;

            if (opcion == 3)    // Verificamos para division
                if (b != 0) // este if esta anidado
                    resultado = x / y;
                else // Este else pertenece al segundo if
                    Console.WriteLine("Divisor no valido");

            if (opcion == 4)    // Verificamos para la multiplicacion
                resultado = x * y;

            Console.WriteLine("El resultado es: {0}", resultado);   // Mostramos el resultado

            /*
                Escalera de if-else
            Otra estructura que se puede utilizar es la escalera de if-else. 
            Una de sus funciones principales es optimizar la ejecución del código. 
            Algunas veces son necesarias porque así lo requiere la lógica del programa.

            if(expresión 1)
                Sentencia 1
            else if(expresión 2)
                 Sentencia 2
            else if(expresión 3)
                Sentencia 3
             */

            // Variables necesarias
            x = 0.0f;
            y = 0.0f;
            resultado = 0.0f;
            valor = "";
            opcion = 0;

            // Mostramos el menu
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - División");
            Console.WriteLine("4 - Multiplicación");
            Console.Write("Que operación deseas hacer: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            // Pedimos el primer numero
            Console.Write("Dame el primer numero: ");
            valor = Console.ReadLine();
            x = Convert.ToSingle(valor);

            // Pedimos el segundo número
            Console.Write("Dame el segundo número: ");
            valor = Console.ReadLine();
            y = Convert.ToSingle(valor);

            if (opcion == 1)    // Verificamos para suma
                resultado = x + y;

            else if (opcion == 2)   // Verificamos para resta
                resultado = x - y;

            else if (opcion == 3)   // Verificamos para division
                if (b != 0) // este if esta anidado
                    resultado = x / y;
                else // Este else pertenece al segundo if
                    Console.WriteLine("Divisor no válido");

            else if (opcion == 4)   // Verificamos para la multiplicacion
                resultado = x * y;

            Console.WriteLine("El resultado es: {0}", resultado); // Mostramos el resultado

            /*
                Expresiones lógicas
            Al igual que las expresiones aritméticas y relacionales, las expresiones lógicas tienen sus propios operadores. 
            Éstos son: y, o y no. En inglés los conocemos como: and, or y not.
                
                    &&      y
                    ||      o
                    !       no

                El uso de la conjunción
            El primer operador es y, conocido como conjunción. Para usar este operador es necesario tener dos expresiones. 
            Una expresión a la izquierda y la otra a la derecha. Las expresiones se evalúan devolviendo valores true o false. 
            Con la conjunción, la expresión se evalúa como verdadera únicamente cuando ambas expresiones son verdaderas.

                    P       Q       P&&Q
                   true    true     true
                   true    false    false
                   false   true     false
                   false   false    false

            if(tanque < 50 && distancia > 200)      si el tanque tiene menos del 50% y si la distancia a recorrer es de más de 200 km
                Cargar gasolina

            if(true && true)        Supongamos que tanque es 25 y distancia es 350, al evaluar 25 < 50 y 350 > 200 tenemos lo siguiente
                Cargar gasolina

            Ahora supongamos que tanque tiene el valor de 90 y distancia es nuevamente 350.
            Las primeras evaluaciones nos darían:
            if(false && tue)
                Cargar gasolina

                El uso de la disyunción
            Para la disyunción hacemos uso del operador o. Éste también necesita dos expresiones, una en el lado derecho y otra en el lado izquierdo. 
            Esta disyunción tiene la siguiente tabla de verdad:
                    
                    P       Q       P||Q
                   true    true     true
                   true    false    true
                   false   true     true
                   false   flase    false

            Tenemos que tomar la sombrilla si llueve o si hay mucho sol. La expresión podría quedar de la siguiente manera: 
            if(lluvia == true || muchosol == true)
                Tomar sombrilla
            
            Supongamos que hay lluvia pero no hay sol, tendríamos la expresión:
            if(true || false)
                Tomar sombrilla

            Ahora veamos qué sucede si no hay lluvia y no hay sol. La expresión quedaría como:
            if(false || false)
                Tomar sombrilla

                El uso de la negación
            Nos falta conocer un operador más, el de la negación. Ese operador es muy sencillo y solamente necesita hacer uso de un operando del lado derecho.

                     P      Negacion
                    true    false
                    false   true

            Tenemos una habitación con una bombilla eléctrica y supongamos que tenemos que prender la luz del cuarto cuando no es de día. 
            Entonces nuestra expresión queda de la siguiente forma:

            if(!dia == true)
                Prender la luz
             */

            // Variables necesarias
            int edad = 0;
            bool permiso = false;
            valor = "";

            // Obtenemos los datos
            Console.Write("Dame la edad: ");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);
            Console.Write("Tiene permiso de conducir (true / false): ");
            valor = Console.ReadLine();
            permiso = Convert.ToBoolean(valor);

            // Verificamos que se cumpla la regla
            if (edad > 18 || (edad > 15 && permiso == true)) Console.WriteLine("Es posible conducir");
            else Console.WriteLine("No puedes conducir");


            Console.ReadKey();
        }
    }
}
