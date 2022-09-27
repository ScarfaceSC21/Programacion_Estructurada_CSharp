using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Cadenas_Caracteres
{
    /*      CADENAS DE CARACTERES
    Una cadena de caracteres es una secuencia de cero o más símbolos, que incluyen letras del alfabeto, dígitos y caracteres especiales.
    Para poder utilizar cadenas necesitamos hacer uso de la clase String, que nos da todo lo necesario para poder trabajar con ellas. 
    En su interior la cadena se guarda como una colección y cada carácter es un elemento.

            Cómo declarar la cadena
    Cuando necesitamos declararla, creamos una instancia de la clase String y le asignamos el valor que contendrá. 
    Este valor deberá estar colocado entre comillas.
    Podemos declarar la variable y asignarle una cadena vacía.

            String miCadena = “Hola a todos”;
            String dato = “”;

    En este caso la variable miCadena contendrá la frase “Hola a todos” y la variable dato contendría una cadena vacía.
    Siempre representaremos las cadenas entre comillas

            El método ToString()
    Un método común para muchas clases que existen en C# y .NET es ToString(). Éste es usado para convertir el tipo de dato o su representación 
    a una cadena y es muy útil cuando necesitamos desplegar esa información para que el usuario la pueda leer.
    Si nosotros hacemos nuestras propias clases también lo podemos implementar. El método siempre regresará una cadena, que puede ser formateada 
    para nuestras necesidades. Imaginemos que tenemos una variable de tipo entero llamada valor y queremos desplegársela al usuario. 
    Para esto podemos convertir la cadena agregando el código que se muestra a continuación:

            String Cadena = valor.ToString();

            Cómo convertir y formatear fechas a cadenas
    Uno de los usos más comunes de las cadenas es el de poder formatear información, que puede ser de cualquier tipo. Para utilizar la fecha y la hora, 
    lo haremos mediante una clase conocida como DateTime. Esta clase provee todos los elementos necesarios para poder trabajar con la información 
    relacionada con el tiempo, como son la fecha y las horas del día. Si deseamos tener un objeto de este tipo y que tenga la hora actual de la máquina 
    en el momento en que se instanció podemos hacerlo de la siguiente manera:

            DateTime miTiempo = DateTime.Now;

    La propiedad Now de DateTime contiene el tiempo actual del sistema en su interior. Ahora lo único que necesitamos es poder pasar esa información a 
    un formato útil y práctico de trabajar para nosotros. Podemos hacer uso del método Format() de String. Este método nos permite reemplazar 
    los contenidos de la cadena por una cadena con un formato en particular.
    Para llevar a cabo un formato debemos usar los especificadores de formato. DateTime contiene un conjunto de estos especificadotes.

            ESPECIFICADOR       DESCRIPCION
                d               Día del mes.
                dd              Día del mes, pero los primeros días se representan con 01, 02, 03, etcétera.
                ddd             Presenta el nombre del día abreviado.
                dddd            Presenta el nombre del día completo.
                h               Hora en el rango de 1 a 12.
                hh              Hora en el rango de 1 a 12. Las primeras horas se presentan como 01, 02, 03, etcétera.
                H               Hora en el rango de 0 a 23.
                HH              Hora en el rango de 0 a 23. Las primeras horas se presentan como 01, 02, 03, etcétera.
                m               Minuto.
                mm              Minuto. Los primeros minutos se muestran como 01, 02, 03, etcétera.
                M               Mes.
                MM              Mes. Los primeros meses se presentan como 01, 02, 03, etcétera.
                MMM             Nombre del mes abreviado.
                MMMM            Nombre del mes completo.
                s               Segundos.
                ss              Segundos. Los primeros segundos se presentan como 01, 02, 03, etcétera.
                t               Despliega A o P según AM o PM.
                tt              Despliega AM o PM.
                yyyy            Muestra el año.

    si deseamos tener una cadena en la que se muestre la información de la fecha de forma tal que primero esté escrito el día de la semana, 
    seguido del año y por último el mes en número, podemos hacerlo de la siguiente manera:

            String formato;
            formato=String.Format(“La fecha es: {0:dddd yyyy M}”,DateTime.Now);

    Adentro de Format colocamos la cadena de formato y como solamente debemos desplegar un valor, hacemos uso de {0}, pero este valor tendrá 
    un formato en particular. Ponemos el formato al colocar : y los especificadores necesarios adentro de {}. De esta forma, ese valor tendrá 
    el formato correspondiente. Nosotros podemos usar los especificadores que queramos siempre y cuando sean válidos para el tipo que deseamos
    formatear en la cadena.
    
            Para darles formato a valores numéricos
    Al igual que con la información de la fecha y hora, es posible darles formato a los valores numéricos que deseemos mostrar. Para éstos también 
    tendremos una serie de especificadores que podemos utilizar.

            ESPECIFICADOR       DESCRIPCIÓN
                 #                 Dígito
                 .                 Punto decimal
                 ,                 Separador de miles
                 %                 Porcentaje
                 E0                Notación científica
                 ;                 Separador de secciones

    Cuando especificamos un formato podemos tener diferentes secciones. Podemos utilizar un formato en particular para cuando los números sean positivos
    y otro formato para cuando los números sean negativos. Estas secciones se separan por medio del carácter ;.
    Si usamos dos secciones, el formato colocado en la primera será utilizado para los números positivos y el cero. El formato que coloquemos en la segunda 
    sección será el que se utilizará para los números negativos. En el caso que definamos tres secciones, el formato colocado en la primera sección será 
    utilizado para los números positivos. En la segunda sección colocaremos el formato que se utilizará cuando el valor sea negativo. La tercera sección 
    tendrá el formato usado para cuando el valor sea cero.

            Console.WriteLine(String.Format(“{0:$#,###0.00;Negativo$#,###0.00;Cero}”,valor));

    En este caso, si el número contenido adentro de valor es positivo se presentará normalmente y con un signo de moneda antes de él, pero si el valor es 
    negativo aparecerá con la palabra Negativo y el signo de moneda antes de él. Si el contenido de valor fuera cero, aparecería la palabra Cero. */
    class Program
    {   
        static void Main(string[] args)
        {
            /*Cómo concatenar cadenas
    Otra de las manipulaciones que podemos hacer es la concatenación, que en C# a diferencia de otros lenguajes es muy natural e intuitiva. Esto se debe a 
    que podemos utilizar una función especializada para esto o aprovechar la sobrecarga del operador + para la clase String. Si deseamos llevar a cabo 
    la concatenación por medio del operador + podemos hacerlo de la siguiente manera:*/

            String nombre = "Uriel";
            String apellido = "Armenta";
            String NombreCompleto = "";
            NombreCompleto = nombre + " "+ apellido;

    /*De esta forma, obtendremos una cadena que tendrá en su interior “Juan Lopez”. Al hacer la concatenación, hemos incluido otra cadena. 
    En este caso contiene un espacio. De no hacerlo, el nombre y el apellido hubieran quedado juntos  y la cadena sería: “JuanLopez”.
    Otra forma de concatenar es hacer uso del método Concat(). Este método pertenece a String, es muy sencillo de utilizar y solamente requiere de dos parámetros, 
    que serán las cadenas que deseamos concatenar. El método regresa una cadena, que es la cadena resultante de la concatenación de los parámetros.
    Veamos un ejemplo de cómo podemos concatenar:*/

            NombreCompleto = String.Concat(nombre, apellido);

    /*El método Concat() es estático, por eso es posible usarlo sin tener que declarar un objeto de la clase String. Para llevar a cabo una concatenación múltiple, 
    podemos hacerlo de la siguiente manera:*/

            NombreCompleto =String.Concat(nombre, String.Concat(" ", apellido));

            /*Uso de StringBuilder
    StringBuilder es una clase que provee .NET y podemos utilizar con C#. Nos permite construir cadenas de forma eficiente y a su vez podemos utilizarla en lugar 
    de las concatenaciones si fuera necesario. Aquí sólo veremos los métodos más importantes. Su constructor tiene varias versiones. Podemos utilizar el constructor 
    de default que no necesita de ningún parámetro. Hay una versión en la que podemos pasar como parámetro una cadena con la que podemos inicializar el objeto StringBuilder.
    La clase tiene varias propiedades que podemos usar, como la propiedad Capacity, que nos indica la capacidad actual, que puede o no ser igual a la cantidad de caracteres
    que tenemos guardados en su interior, aunque generalmente será mayor.
    Otra opción es la propiedad Chars, mediante la que podemos obtener o modificar un carácter en particular. La modificación se hace indicando el índice donde se encuentra
    ese carácter. Lo podemos hacer de la siguiente manera:*/

            //StringBuilder sb = new StringBuilder("Hola a todos");
            
            //sb.Chars[6] = 'o';

    /*Si leemos la propiedad de Length obtenemos la longitud que tiene el StringBuilder. Si colocamos un valor en esta propiedad entonces el StringBuilder tendrá el tamaño
    que indicamos. Si el nuevo tamaño es menor que el actual, entonces se trunca el contenido del StringBuilder.
    Para llevar a cabo una concatenación, debemos usar el método Append(). Este método tiene muchas sobrecargas ya que no solamente puede concatenar cadenas. El método 
    necesita solamente un parámetro y es el valor a concatenar en la cadena.
    Hay que recordar que Append() es eficiente.*/

            StringBuilder sb = new StringBuilder("Hola a todos");
            sb.Append(" Hola mundo");

    /*En sb ahora tendremos el contenido de “Hola a todos Hola mundo”.
    También podemos agregar una cadena de formato construida de forma similar a la forma como trabajamos con los formatos de WriteLine(). Para esto usamos el método
    AppendFormat(). Este método necesitará dos parámetros, pero puede llevar más si fuera necesario. En el primero colocamos la cadena de forma y en el segundo y/o
    los siguientes la lista de variables a utilizar. Por ejemplo:*/

            StringBuilder stb = new StringBuilder();
            int valor = 5;
            stb.AppendFormat("El valor es {0}", valor);

    /*Un método importante en esta clase es ToString(), que permitirá convertir StringBuilder en una cadena, y de esta manera poder utilizar los contenidos creados por
    medio de esta clase. Para usarlo simplemente hacemos una asignación:*/

            String cadena = "";
            cadena = stb.ToString();

    /*De esta forma, la cadena tendrá en su interior la cadena creada por medio del StringBuilder

            Comparación de cadenas
    La comparación de cadenas es una herramienta muy importante para solucionar diversos problemas y lograr resultados que de otra forma serían muy complejos.
    La clase String nos da el método Compare(). Este método es estático, por lo que podemos hacer uso de éste sin necesidad de declarar un objeto de tipo String. 
    El método necesitará dos parámetros, que son las cadenas a comparar. Los llamaremos en nuestro ejemplo Cadena1 y Cadena2. El método regresará luego del análisis, 
    un valor entero y el valor de este entero será el que se encargue de indicarnos la relación que existe entre las cadenas que acabamos de comparar.
    Si el valor regresado es igual a 0, esto significa que Cadena1 y Cadena2 son iguales. En el caso de que el valor sea menor que 0, es decir, un número negativo, 
    Cadena1 es menor que Cadena2. Si se recibe un número mayor que 0 significa que Cadena1 es mayor que Cadena2.*/

            int comparacion=0;
            String nom= "Juan";
            comparacion=String.Compare("Pedro", nom);
            if(comparacion==0) Console.WriteLine("Los nombres son iguales");
            else Console.WriteLine("Los nombres son diferentes");

    /*Otra forma que podemos utilizar para saber si dos cadenas son iguales es hacer uso del método Equals(), que solamente dirá si dos cadenas son iguales, 
    no realiza ninguna otra comparación. La versión que veremos aquí es estática y requiere dos parámetros. Los parámetros son las cadenas a comparar.
    El método regresa un bool con el valor de true si las cadenas son iguales y el valor de false si son diferentes.*/

            String cadena1 = "Hola";
            String cadena2 = "Todos!";
            if(String.Equals(cadena1,cadena2) == true) Console.WriteLine("Las cadenas son iguales");

            /*Para encontrar una subcadena
    La cadena puede contener una frase con muchas palabras y para algunas aplicaciones necesitamos saber si determinada palabra se encuentra en esa cadena. 
    Es decir que buscaremos una subcadena adentro de otra cadena. Esta subcadena es una cadena que queremos saber si se encuentra en la cadena principal.
    Esto puede servirnos en búsquedas o cuando necesitamos llevar a cabo determinada lógica si se encuentra una palabra o frase en particular. El método que usaremos
    se llama Contains() y debe ser invocado por la cadena a la que se le realizará la búsqueda.
    Esto es importante y no debemos olvidarlo ya que la invocación de Contains() en la cadena incorrecta nos puede llevar a errores de lógica.
    El método Contains() sólo necesita un parámetro. Este parámetro es la subcadena a buscar. Ésta puede ser dada explícitamente o por medio de una variable de tipo
    String que la contenga. El método regresa un bool. Si la subcadena se encontró, el valor regresado es true y si no se encontró el valor regresado es false.
    El uso de Contains() puede ser como se muestra a continuación:*/

            String NomCom = "Juan Pedro Lopez";
            String NombreBuscar = "Pedro";
            if (NomCom.Contains(NombreBuscar)   == true) Console.WriteLine("El nombre se encuentra");

    /*Para poder usar este método necesitamos contar con dos parámetros, que son valores de tipo entero. El primero indica el índice adentro de la cadena original
    donde inicia la subcadena que nos interesa obtener y el segundo es la cantidad de caracteres que tiene la subcadena. El método regresa una cadena que contiene
    a la subcadena que hemos obtenido.
    El siguiente ejemplo nos muestra cómo podemos usar este método:*/

            String cad= "Hola mundo redondo";
            String resultado= "";
            resultado=cad.Substring(5,5);

    /*Ahora la cadena resultado tendrá en su interior a “mundo”, que es la subcadena que hemos obtenido de la variable cadena.

            Para determinar si una cadena finaliza en una subcadena
    Es posible saber si una cadena finaliza en una subcadena en particular. Por ejemplo, si analizamos la cadena, y ésta termina en punto, o si la cadena termina
    en una palabra en particular.
    Al igual que en los casos anteriores, tenemos un método que nos permite llevar a cabo esto. El método es EndsWith() y necesita un parámetro, que será la subcadena
    que deseamos verificar en la terminación de la cadena principal. La función regresa un valor de tipo bool, si es true la cadena termina en la subcadena en caso
    contrario el valor regresado es de false.
    Un ejemplo de cómo podemos usar esta función es el siguiente:*/

            String cad1 = "Juan Pedro Lopez";
            String cad2 = "Lopez";
            if(cad1.EndsWith(cad2) == true) Console.WriteLine("La cadena finaliza en Lopez");

            /*Cómo copiar una parte de la cadena
    En muchas aplicaciones es necesario obtener o copiar una parte en particular de una cadena, y si la cadena contiene una frase, podemos extraer una palabra en particular.
    El método que usaremos se conoce como CopyTo() y aunque es un poco más complejo que los anteriores es fácil de utilizar ya que necesita el mismo de cuatro parámetros.
    Antes de ver los parámetros es necesario comentar que la cadena extraída será colocada en un arreglo de tipo char. El método no regresa ningún valor.
    El primer parámetro es el índice adentro de la cadena principal desde donde se empezará copiar. El segundo parámetro es la cadena de tipo char donde se colocará
    la cadena a extraer. El tercer parámetro es el índice del arreglo a partir de donde se empezarán a colocar los caracteres de la cadena copiada. Esto es útil ya que podemos
    hacer la copia en cualquier posición del arreglo, no solamente al inicio. El cuarto parámetro indica la cantidad de caracteres a copiar. Con estos parámetros
    podemos indicar sin problema cualquier sección a copiar.
    Veamos un ejemplo de esto último a continuación:*/

            char[] destino = new char[10];
            String caden = "Hola a todos mis amigos";
            caden.CopyTo(7, destino, 0, 5);

    /*En este caso hemos extraído la cadena “todos” y se ha guardado en el arreglo destino.

            Cómo insertar una cadena
    Es posible llevar a cabo la inserción de una cadena en otra.
    Esto nos ayuda cuando necesitamos colocar información nueva en la cadena, pero ya no es posible hacerlo por medio de concatenación o formato.
    Para poder hacer esto, recurriremos a utilizar al método Insert(), que nos brinda C#. Este método coloca la cadena dentro de la cadena principal. 
    Este también necesitará dos parámetros. El primero indicará el índice dentro de la cadena principal donde se va a insertar la nueva cadena. 
    Este valor debe de ser de tipo entero y nunca podemos pasarle un valor negativo. El segundo parámetro es la cadena que deseamos insertar, 
    que puede ser colocada explícitamente o mediante una variable de tipo String.
    El método Insert() regresa un valor de tipo String. Este valor regresado sería la instancia de la nueva cadena que ya contiene la inserción. 
    Un ejemplo para llevar a cabo la inserción sería de la siguiente forma:*/

            String cadena_1 = "Hola a todos";
            String cadena_2 = "hola ";
            String res = "";
            res = cadena_1.Insert(5, cadena_2);

            /*Para encontrar la posición de una subcadena
    En algunas situaciones necesitamos encontrar dónde se encuentra determinada subcadena para poder llevar a cabo alguna operación en ese índice en particular.
    Para poder hacer esto hacemos uso del método LastIndexOf(). Un punto importante a tener en cuenta es que este método nos regresa el índice de la última posición 
    encontrada, es decir que si la cadena principal tiene dos repeticiones de esa cadena, nos da el índice de la segunda repetición.
    Este método tiene varias sobrecargas, pero la que veremos sólo necesita un parámetro y es la subcadena a encontrar. Como siempre la cadena puede ser dada de forma
    explícita o por medio de una variable de tipo String. El método regresa un valor
    de tipo entero que contiene el índice de la última ocurrencia de la subcadena.
    La forma para usar este método es la siguiente:*/

            int índice = 0;
            String cadena_tex = "Hola a todos. Hola";
            índice=cadena_tex.LastIndexOf("Hola");

            /*Justificación del texto
    Si necesitamos justificar el texto hacia la derecha es posible hacerlo. La forma cómo funciona esto es la siguiente. Supongamos que tenemos una cadena de 10 caracteres
    como “0123456789”. Para justificarla necesitamos saber el tamaño de la cadena resultante con la justificación incluida. Supongamos que la cadena resultante será
    de 25 caracteres. Esto nos daría 15 caracteres del que tenemos que insertar del lado izquierdo para obtener “0123456789” que se encuentra justificada hacia la derecha.
    Para esto necesitamos un método que nos permita empotrar esos caracteres de espacio.
    El método PadLeft() se encarga de esto. Requiere de un parámetro que es la cantidad de caracteres de la cadena final. Éste es un valor entero y representa los caracteres
    originales más los espacios en blanco. Regresa la cadena final justificada.
        Un ejemplo de uso sería el que vemos a continuación:*/

            String cadena_3= "Hola";
            String resul="";
            resul=cadena_3.PadLeft(10);

    /*De forma similar, podemos hacer una justificación hacia la izquierda. En este caso, los caracteres en blanco serán insertados a la derecha de la cadena. Se insertarán tantos
    caracteres como sean necesarios hasta llegar al tamaño deseado
    Para esto usaremos un método equivalente a PadLeft(), pero hacia la derecha. Este método es conocido como PadRight(). El método necesita un parámetro, que es
    un valor entero que indica la cantidad total de caracteres de la cadena final. Este total debe ser igual a los caracteres de la cadena original más los caracteres vacíos.
    El método regresa la cadena justificada.
    
            Para eliminar caracteres de la cadena
    Es posible borrar determinada parte de la cadena, según sea lo que necesitemos en la lógica del programa.
    El método que podemos utilizar se conoce como Remove(). Este método está sobrecargado, pero veremos la versión que es más flexible. La eliminación de los
    caracteres puede hacerse en cualquier parte de la cadena, sólo debemos tener cuidado de no generar ningún error.
    El método Remove() necesita dos parámetros, ambos de valores enteros. El primer parámetro se usa para indicar el índice a partir del cual se empezarán a eliminar 
    los caracteres de la cadena, y en el segundo parámetro colocamos la cantidad de caracteres a eliminar. El método regresa una cadena, que es la cadena resultante 
    de la eliminación.
        Para poder eliminarla realicemos el siguiente ejercicio:*/

            String cadena_4= "Hola mundo, hola a todos";
            String resultado_1="";
            resultado_1=cadena_4.Remove(12,4);

            /*Cómo reemplazar una subcadena
    Reemplazar una parte de la cadena principal con otra cadena puede ser un proceso que toma tiempo programar. Esto se debe a que necesitamos encontrar la subcadena
    a eliminar, luego eliminarla y al final introducir los caracteres de la nueva cadena. Como siempre, la clase String nos provee de un método que nos facilita la
    manipulación de la cadena para el reemplazo. Éste es el método Replace(). Existen dos versiones del método Replace(), una de ellas funciona con caracteres y la que
    aprenderemos en esta ocasión hace uso de cadenas.
    Esto nos puede permitir reemplazar una palabra en particular contenida dentro de la cadena por otra palabra. El método llevará a cabo el reemplazo en todas las
    ocurrencias de la palabra que tengamos.
    El método es sencillo de utilizar y necesita dos parámetros. El primero es la cadena que simboliza la palabra que deseamos reemplazar. El segundo es la cadena
    con la que la reemplazaremos. El método regresa una cadena, que es la resultante con los reemplazos ya llevados a cabo.
        Veamos un ejemplo de la utilización de este método:*/

            String cadena_5= "Hola a todos. Hola mundo";
            String cadena_6= "Adios";
            String resultado_2="";
            resultado_2=cadena_5.Replace("Hola", cadena_6);

    /*Por el ejemplo, vemos que es posible colocar el parámetro ya sea de forma explícita o por medio de una variable.

            Cómo dividir la cadena
    Otro problema clásico con la manipulación de las cadenas es la subdivisión cuando se encuentra algún carácter en particular. Por ejemplo, si la cadena contiene 
    un párrafo de un texto, podemos dividirla en subcadenas, cada una de ellas delimitada por un signo de puntuación. Para lograr esto necesitamos tener un arreglo 
    de caracteres que contenga los caracteres que tomaremos como delimitadores. Cada vez que el método encuentre uno de estos caracteres, llevará a cabo el corte de 
    la subcadena.
    El método que usaremos se conoce como Split(), éste sólo requiere de un parámetro, que es el arreglo de caracteres delimitadores. El método regresará un arreglo
    de tipo String. Cada uno de los elementos presentes en el arreglo regresado será una de las subcadenas que se habrán recortado. Después debemos proceder a
    hacer uso de las cadenas en el arreglo y procesarlas o utilizarlas según sea necesario en la aplicación que estamos desarrollando.
        Un ejemplo de cómo podemos usar este método es el siguiente:*/

            String cadena_7= "Hola a todos. Este es un ejemplo, de lo que podemos hacer.";
            String[] resultado_23 = cadena_7.Split(new char[] { ',', '.', ';' });

    /*Como podemos ver en el ejemplo, usamos los caracteres punto, coma y punto y coma como delimitadores. Adentro de resultado estarán las cadenas que han sido
    recortadas de cadena1.

            Intercambiar mayúsculas y minúsculas
    En muchas ocasiones tendremos cadenas que estarán escritas con letras en mayúscula y minúscula mezcladas, pero puede suceder que para facilitar la lógica de
    aplicación debamos tener la cadena exclusivamente en mayúscula o minúscula.
    Esto nos puede ayudar a reducir la cantidad de comparaciones o búsquedas que necesitamos hacer. Si lo que deseamos hacer es convertir la cadena a minúscula, 
    entonces debemos hacer uso del método ToLower(). Este método no necesita ningún parámetro. La fuente de información para hacer la conversión es la misma
    cadena que lo invoca, pero en esta ocasión nos daremos cuenta de que el método sí se encargará de regresar un valor, el valor que se devuelve será la cadena convertida
    totalmente a letras minúsculas.
        Por ejemplo, podemos tener lo siguiente:*/

            String cadenas= "Hola Hola";
            String resultados="";
            resultados=cadenas.ToLower();

    /*Al finalizar el código la variable resultado tendrá en su interior a la cadena “hola hola”. De forma similar, podemos pasar la cadena a mayúscula. 
    La forma de hacer esto es con el método ToUpper(), que toma la cadena y pasa todas sus letras a mayúscula.
    El método no necesita ningún parámetro, ya que al igual que ToLower(), toma la información directamente de la cadena que lo invoca y regresa una cadena, que es
    la resultante con todas las letras en mayúscula.
        Veamos un ejemplo de cómo aplicar esto:*/

            String cadena_8= "Hola Hola";
            String resultado_3="";
            resultado_3=cadena_8.ToUpper();

    /*Los dos métodos tienen otra versión que tiene en cuenta las reglas culturales para poder llevar a cabo la conversión. 
    En ese caso tendríamos que pasar como parámetro el identificador de la cultura que se usará como base para convertir los caracteres.
    En MSDN podemos encontrar la información sobre los diferentes identificadores de cultura que puede manejar .NET. Para hacer uso del identificador de cultura
    debemos usar un objeto de tipo CultureInfo. En su constructor debemos pasar el ID de la cultura correspondiente. Por ejemplo, para pasar a mayúscula con las reglas de
    la cultura en México podemos colocar lo siguiente:*/

            String cadena_9= "Hola Hola";
            String resultado_4=""; 
            resultado_4=cadena_9.ToUpper(new System.Globalization.CultureInfo("es-MX"));

            /*Cómo podar la cadena
    Cuando trabajamos con las cadenas podemos encontrarnos con situaciones como cuando la cadena tiene exceso de espacios, ya sea al inicio o al final. Algunas veces
    esto puede ser útil, como cuando justificamos, pero otras veces estos espacios extras pueden ser indeseados. Los espacios extras al inicio o al final pueden deberse 
    a operaciones realizadas sobre la cadena o simplemente a entradas erróneas del usuario, y para librarnos de estos caracteres tenemos diferentes opciones. En primer 
    lugar conoceremos un método que elimina los espacios en blanco extras tanto al inicio como al final de la cadena. Este método se conoce como Trim().
    El uso de Trim() es muy sencillo ya que no necesita ningún parámetro, simplemente trabajará sobre la cadena que lo invoca. Este método regresará una cadena nueva,
    que es la cadena original sin los espacios extras.
    Es necesario que tengamos en cuenta que la cadena original no se modifica, por esta razón recibiremos una cadena completamente nueva.*/

            String cadena_10= " Hola a todos. ";
            String resultado_5="";
            resultado_5=cadena_10.Trim();

    /*En la cadena resultado tendremos “Hola a todos”, que es la cadena sin los espaciosextras. El método Trim() poda los espacios tanto del inicio como del final de la cadena.
    Sin embargo, puede haber ocasiones en las que necesitemos podar únicamente el inicio de la cadena. El método para lograr esto es TrimStart(). Este método es un poco
    más complejo que Trim() ya que necesita un parámetro. Este parámetro es un arreglo de caracteres y en él tenemos que colocar los caracteres que nos interesa extraer del
    inicio de la cadena. El método regresará otra cadena, que es la resultante de la cadena original sin los caracteres podados a su inicio.
    Es posible que creemos el arreglo de caracteres o también que lo coloquemos explícitamente.
    Es conveniente pensar bien cuáles serán los caracteres a podar para evitar la eliminación de caracteres que sí pueden ser útiles.
        Veamos cómo podemos utilizar este método:*/

            String cadena_11= "x x x x x x Hola a todos. ";
            String resultado_11=""; 
            resultado_11=cadena_11.TrimStart(' ', 'x');

    /*En este ejemplo se podan los caracteres espacio y x. La cadena final resultante es “Hola a todos. “. Debemos notar que los caracteres al final no han sido podados,
    y   a que solamente trabaja sobre los caracteres al inicio de la cadena.
    Si lo que necesitamos es podar el final de la cadena, entonces tenemos que usar el método TrimEnd(). Este método es equivalente a TrimStart(), pero funciona
    únicamente al final de la cadena.
    Recordemos que el método necesita un parámetro. El parámetro es un arreglo de caracteres. En este arreglo es necesario que coloquemos los caracteres que deseamos
    eliminar del final de la cadena con la que trabajamos. El método correspondiente se encargará de regresar una cadena, está será el resultado sin los caracteres que fueron
    eliminados al final de la cadena original.*/

            String cadena_12= "x x x x x x Hola a todos. ";
            String resultado_12 = "";
            resultado_12=cadena_12.TrimEnd(' ', 'x');

    //En la cadena de resultado tendremos “x x x x x x Hola a todos”, el espacio fue eliminado al final ya que se encuentra dentro de la lista de caracteres a podar. 
             
        }
    }
}
