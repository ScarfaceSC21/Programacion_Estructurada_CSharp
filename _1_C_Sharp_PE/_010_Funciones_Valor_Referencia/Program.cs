using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Funciones_Valor_Referencia_Default
{
    /*                          PASO POR VALOR Y PASO POR REFERENCIA
     
    Paso por valor: 
    Los parámetros se tratan como variables locales y los valores iniciales se proporcionan copiando los valores de 
    los correspondientes argumentos. 
    Los parámetros formales —locales a la función— reciben como valores iniciales los valores de los parámetros
    actuales y con ello se ejecutan las acciones descritas en el subprograma.
    No se hace diferencia entre un argumento que es variable, constante o expresión, ya que sólo importa el valor del
    argumento.
    Aunque el paso por valor es sencillo, tiene una limitación acusada: no existe ninguna otra conexión con los parámetros
    actuales, y entonces los cambios que se produzcan por efecto del subprograma no producen cambios en los
    argumentos originales y, por consiguiente, no se pueden pasar valores de retorno al punto de llamada: es decir, todos
    los parámetros son sólo de entrada. El parámetro actual no puede modificarse por el subprograma. Cualquier cambio
    realizado en los valores de los parámetros formales durante la ejecución del subprograma se destruye cuando se termina
    el subprograma. La llamada por valor no devuelve información al programa que llama

    Paso por referencia:
    En numerosas ocasiones se requiere que ciertos parámetros sirvan como parámetros de salida, es decir, se devuelvan
    los resultados a la unidad o programas que llama. Este método se denomina paso por referencia o también de llamada
    por dirección o variable. La unidad que llama pasa a la unidad llamada la dirección del parámetro actual (que
    está en el ámbito de la unidad llamante). Una referencia al correspondiente parámetro formal se trata como una referencia
    a la posición de memoria, cuya dirección se ha pasado. Entonces una variable pasada como parámetro real
    es compartida, es decir, se puede modificar directamente por el subprograma.

    El paso de un parámetro por valor significa que el valor del argumento —parámetro actual o real— se asigna al
    parámetro formal. En otras palabras, antes de que el subprograma comience a ejecutarse, el argumento se evalúa a
    un valor específico (por ejemplo, 8 o 12). Este valor se copia entonces en el correspondiente parámetro formal dentro
    del subprograma.

    Una vez que el procedimiento arranca, cualquier cambio del valor de tal parámetro formal no se refleja en un
    cambio en el correspondiente argumento. Esto es, cuando el subprograma se termine, el argumento actual tendrá
    exactamente el mismo valor que cuando el subprograma comenzó, con independencia de lo que haya sucedido al
    parámetro formal.
    Estos parámetros de entrada se denominan parámetros valor. En los algoritmos indicaremos como < modo > E (entrada). 
    El paso de un parámetro por referencia o dirección se llama parámetro variable, en oposición al parámetro por valor. 
    En este caso, la posición o dirección (no el valor) del argumento o parámetro actual se envía al subprograma. 
    Si a un parámetro formal se le da el atributo de parámetro variable —en Pascal con la palabra reservada var— y si el parámetro
    actual es una variable, entonces un cambio en el parámetro formal se refleja en un cambio en el correspondiente
    parámetro actual, ya que ambos tienen la misma posición de memoria

            Parametros de Default:
    Con los parámetros de default es posible colocar un valor predeterminado al parámetro, de tal forma que si en la invocación 
    de la función no se da explícitamente el valor, entonces se usa el valor predeterminado. Esto puede resultar útil cuando tenemos
    parámetros que en la gran mayoría de los casos usan el mismo valor. De esta forma cuando invocamos a la función lo hacemos usando 
    solamente los valores que cambien, lo cual nos permite escribir menos y solamente cuando es necesario colocamos el valor en el parámetro.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int var_1 = 10;

            Console.WriteLine("Valor de la variable var_1 antes de la funcion Por_Valor: " + var_1);

            Paso_Valor(var_1);

            Console.WriteLine("Valor de la variable var_1 antes de la funcion Por_Valor: " + var_1);

            Console.WriteLine("Valor de la variable var_1 despues de la funcion Por_Referencia: " + var_1);

            Paso_Referencia(ref var_1);

            Console.WriteLine("Valor de la variable var_1 despues de la funcion Por_Referencia: " + var_1);



            // Parametro default:

            double costo = 50.0, imp = 0.0, total = 0.0;

            // Hacemos uso de la funcion de manera tradicional
            imp = CalculaImpuesto(costo, 0.25);
            total = costo + imp;

            // Imprimimos resultado
            Console.WriteLine("El total es ${0}", total);

            // Hacemos uso de la funcion con parametro de default
            // Hay que notar que solamente pasamos un parametro,  el otro usa

            // el valor predeterminado
            imp = CalculaImpuesto(costo);
            total = costo + imp;

            // Imprimimos resultado
            Console.WriteLine("El total es ${0}", total);

            Console.ReadKey();
        }

        static void Paso_Valor(int var_1)
        {
            var_1 = 20;
        }

        static void Paso_Referencia(ref int var_1)
        {
            var_1 = 20;
        }

        public static double CalculaImpuesto(double cantidad, double impuesto = 0.16f)
        {
            double impuestoCalculado;

            impuestoCalculado = cantidad * impuesto;

            return impuestoCalculado;
        }
    }
}
