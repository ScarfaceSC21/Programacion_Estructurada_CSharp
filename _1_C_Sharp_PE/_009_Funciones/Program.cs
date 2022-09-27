using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Funciones
{
    /*      Funciones
    Un método ya citado para solucionar un problema complejo es dividirlo en subproblemas —problemas más sencillos—
    y a continuación dividir estos subproblemas en otros más simples, hasta que los problemas más pequeños sean
    fáciles de resolver. Esta técnica de dividir el problema principal en subproblemas se suele denominar “divide y vencerás”
    (divide and conquer). Este método de diseñar la solución de un problema principal obteniendo las soluciones
    de sus subproblemas se conoce como diseño descendente (top-down design). Se denomina descendente, ya que se
    inicia en la parte superior con un problema general y el diseño específico de las soluciones de los subproblemas. 
    Matemáticamente una función es una operación que toma uno o más valores llamados argumentos y produce un valor
    denominado resultado —valor de la función para los argumentos dados—.

    La función es un elemento del programa que contiene código y se puede ejecutar, es decir, lleva a cabo una operación.
    La función puede llamarse o invocarse cuando sea necesario y entonces el código que se encuentra en su interior 
    se va a ejecutar. Una vez que la función termina de ejecutarse el programa continúa en la sentencia siguiente de donde fue llamada.
    Las funciones son diseñadas para realizar tareas específicas: toman una lista de valores —llamados argumentos—
    y devolver un único valor.

    A una función no se le llama explícitamente, sino que se le invoca o referencia mediante un nombre y una lista
    de parámetros actuales. El algoritmo o programa llama o invoca a la función con el nombre de esta última en una
    expresión seguida de una lista de argumentos que deben coincidir en cantidad, tipo y orden con los de la función que
    fue definida. La función devuelve un único valor.

    La declaración de una función requiere una serie de pasos que la definen. Una función como tal subalgoritmo o
    subprograma tiene una constitución similar a los algoritmos, por consiguiente, constará de una cabecera que comenzará
    con el tipo del valor devuelto por la función, seguido de la palabra función y del nombre y argumentos de
    dicha función. A continuación irá el cuerpo de la función, que será una serie de acciones o instrucciones cuya ejecución
    hará que se asigne un valor al nombre de la función. Esto determina el valor particular del resultado que ha de
    devolverse al programa llamador.
    La declaración de la función en pseudo codigo será:
        
            <tipo_de_resultado> funcion <nombre_fun> (lista de parametros)
            [declaraciones locales]
            inicio
            <acciones> //cuerpo de la funcion
            devolver (<expresion>)
            fin_función

    La sentencia devolver (return, volver) se utiliza para regresar de una función (un método en programación orientada
    a objetos); devolver hace que el control del programa se transfiera al llamador de la función (método). 
    Esta sentencia se puede utilizar para hacer que la ejecución regrese de nuevo al llamador de la función.

    Declaracion de un metodo en C#:
            
            modificador tipo Nombre(parámetros)
            {
                código
            }
    Las funciones pueden regresar información y esta información  puede ser cadena, entero, flotante o cualquier otro tipo. 
    En la sección de tipo tenemos que indicar precisamente la clase de información que regresa. 
    Si la función no regresa ningún valor entonces tenemos que indicar a su tipo como void.
    Todas las funciones deben identificarse y lo hacemos por medio de su nombre. Las funciones que coloquemos adentro de las 
    clases deben de tener un nombre único.
    El nombre también es utilizado para invocar o ejecutar a la función.
    
    Las funciones pueden necesitar de datos o información para poder trabajar. Nosotros
    le damos esta información por medio de sus parámetros. Los parámetros no
    son otra cosa que una lista de variables que reciben estos datos. Si la función no necesita
    usar a los parámetros, entonces simplemente podemos dejar los paréntesis vacíos.
    Nunca debemos olvidar colocar los paréntesis aunque no haya parámetros.

    Las funciones al ser declaradas pueden llevar un modificador antes del tipo. 
    Los modificadores cambian la forma como trabaja la función. Nosotros estaremos utilizando
    un modificador conocido como static. Este modificador nos permite usar a
    la función sin tener que declarar un objeto de la clase a la que pertenece.
     */
    class Program
    {
        static void Main(string[] args)
        {
            float numero_1, numero_2;
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Multilicacion");
                Console.WriteLine("4 - Divicion");
                Console.WriteLine("5 - Salir");
                Console.Write("Cual operacion deseas realizar: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        Suma();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Ingresa el primer numero: ");
                        numero_1 = float.Parse(Console.ReadLine());

                        Console.Write("Ingresa el segundo numero: ");
                        numero_2 = float.Parse(Console.ReadLine());

                        Resta(numero_1,numero_2);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(Multiplicacion());
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Ingresa el primer numero: ");
                        numero_1 = float.Parse(Console.ReadLine());

                        Console.Write("Ingresa el segundo numero: ");
                        numero_2 = float.Parse(Console.ReadLine());

                        Console.WriteLine($"{numero_1} / {numero_2} = {Divicion(numero_1, numero_2)}");
                        Console.ReadKey();
                        break;
                    case 5: 
                        Console.WriteLine("El programa a llegado a su fin...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 5);
        }

        static void Suma()
        {
            float numero_1 = 0.0f;
            float numero_2 = 0.0f;

            Console.Write("Ingresa el primer numero: ");
            numero_1 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            numero_2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{numero_1} + {numero_2} = {numero_1 + numero_2}");
        }

        static void Resta(float num_1, float num_2)
        {
            Console.WriteLine($"{num_1} - {num_2} = {num_1 - num_2}");
        }

        static string Multiplicacion()
        {
            float numero_1 = 0.0f;
            float numero_2 = 0.0f;

            Console.Write("Ingresa el primer numero: ");
            numero_1 = float.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            numero_2 = float.Parse(Console.ReadLine());

            return numero_1+" x "+ numero_2 + " = "+ (numero_1 * numero_2);
        }

        static float Divicion(float num_1, float num_2)
        {
            return num_1 / num_2;   
        }

    }
}
