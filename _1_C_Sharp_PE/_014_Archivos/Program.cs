using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _014_Archivos
{
        /*        ARCHIVOS Y FLUJOS (STREAM)
    El almacenamiento de datos en variables y arrays (arreglos) es temporal; los datos se pierden cuando una variable
    sale de su ámbito o alcance de influencia, o bien cuando se termina el programa. La mayoría de las aplicaciones
    requieren que la información se almacene de forma persistente, es decir que no se borre o elimine cuando se termina
    la ejecución del programa. Por otra parte, en numerosas aplicaciones se requiere utilizar grandes cantidades de información
    que, normalmente, no caben en la memoria principal. Debido a estas causas se requiere utilizar archivos
    (ficheros) para almacenar de modo permanente grandes cantidades de datos, incluso después que los programas que
    crean los datos se terminan. Estos datos almacenados en archivos se conocen como datos persistentes y permanecen
    después de la duración de la ejecución del programa.
     
    El lenguaje C# puede almacenar y recuperar información, utilizando sistemas de comunicaciones denominados flujos que se implementan
    en bibliotecas estándar de funciones de E/S (en archivos de cabecera System.IO).

    Las estructuras de datos aplicadas a colección de datos en almacenamientos secundarios se llaman organización de archivos. 
    La noción de archivo o fichero está relacionada con los conceptos de:
        • Almacenamiento permanente de datos.
        • Fraccionamiento o partición de grandes volúmenes de información en unidades más pequeñas que puedan ser
          almacenadas en memoria central y procesadas por un programa.

    Un archivo o fichero es un conjunto de datos estructurados en una colección de entidades elementales o básicas denominadas registros o artículos, 
    que son de igual tipo y constan a su vez de diferentes entidades de nivel más bajo denominadas campos.

    Los flujos también son conocidos como streams por su nombre en inglés. Se los llama de esta forma porque nos recuerdan como fluye el agua, 
    pero en este caso se tratará de flujos de información. El stream es utilizado para poder mover información de un lugar a otro. 
    A veces, moveremos la información de la memoria a otra parte de la memoria, pero generalmente lo que haremos será mover la información
    de la memoria a un dispositivo de almacenamiento como el disco duro o del dispositivo nuevamente a la memoria.
    Cuando hacemos uso de los flujos, la información no es enviada en un solo movimiento, sino que se envía byte por byte de forma ordenada. 
    Como el envío es de esta forma, tenemos que tener cuidado sobre qué byte procesamos en ese momento.

    Para poder tener control sobre el byte a enviar, imaginaremos que tenemos un apuntador o indicador en nuestro flujo. Este indicador siempre nos 
    señala cuál es el siguientebyte a enviar. Cada vez que enviamos un byte a su nuevo lugar por mediodel flujo, el indicador se actualiza y nos 
    señala el siguiente byte. Esta forma de trabajo funciona muy bien si el envío de datos es secuencial, pero también debemos tener un mecanismo 
    que nos permita seleccionar a nosotros mismos el byte a enviar. Para hacer esto tenemos que indicar de alguna manera el byte y esto solamente
    lo podemos llevar a cabo si tenemos un punto de referencia dentro del flujo.
    En el flujo encontramos tres puntos de referencia. El primero es el inicio del flujo. Si queremos colocarnos en un byte en particular para enviar, 
    simplemente tenemos que decir a cuántos bytes de distancia desde el inicio se encuentra el byte que deseamos procesar. El segundo punto de referencia 
    será el final del flujo. De manera similar tenemos que decir a cuántos bytes de distancia se encuentra el byte a procesar desde el final del flujo. 
    El tercer punto de referencia es la posición actual dentro del flujo, de igual forma a los casos anteriores, debemos dar la distancia desde nuestra 
    posición actual al byte que nos interesa procesar. En todos los casos, este byte se volverá nuestro nuevo byte actual.
    */
    class Program
    {
        static void Main(string[] args)
        {
            /*          Los stream en la memoria
            Para trabajar con streams en la memoria nos apoyaremos de una clase conocida como MemoryStream. Cuando necesitemos usar esta clase debemos agregar 
            el namespace al que pertenece. Para esto colocamos el siguiente código en la parte superior de nuestro programa, antes de las declaraciones de las clases.
            Adicionamos para el uso de los stream 
            using System.IO;
            Esta clase crea un stream, pero el lugar donde guarda la información es un sitio en memoria. La información es guardada como un arreglo de bytes sin signo. 
            La clase MemoryStream tiene sobrecargado su constructor y seguramente podemos encontrar una versión de acuerdo con nuestras necesidades.El constructor puede 
            crear el arreglo en la memoria vacío o puede inicializarlo a un tamaño en particular.  Hay que recordar que el tamaño está en bytes.
            Nosotros usaremos la versión en la que podemos indicar el tamaño inicial del arreglo y para instanciar MemoryStream podemos hacerlo de la siguiente manera: 
            Creamos el stream en memory
            La iniciamos con una capacidad de 50 bytes
             */

            //MemoryStream ms = new MemoryStream(50);

            /*          Cómo obtener información sobre el stream
            Nosotros podemos obtener ciertos datos sobre el stream. Estos datos nos pueden servir en la lógica de nuestro programa y resulta útil poder conocerlos. 
            Los datos que podemos obtener son: la capacidad, la longitud y la posición.
            La capacidad nos indica cuántos bytes puede almacenar el stream. En el ejemplo anterior es de 50, ya que le hemos colocado ese tamaño en su instanciación. 
            El valor de la capacidad se guarda en la propiedad Capacity y ésta es de tipo entero. Si deseamos obtener la capacidad lo podemos hacer de la siguiente forma:
             */

            //int capacidad = ms.Capacity;

            /*
            El siguiente dato que podemos obtener es la longitud. Ésta nos indica el tamañode la información actual que tiene el stream. El tamaño está dado en bytes. 
            La propiedad relacionada con esta información es Length. Esta propiedad es de tipo long. A continuación veamos un ejemplo de cómo podemos obtener este dato:
             */

            //long longitud = ms.Length;

            /*
            Por último tenemos la posición. Este dato es sumamente importante ya que nos indica el lugar donde se encuentra el byte actual, es decir el siguiente a ser 
            procesado. Esta posición está referenciada con relación al inicio del stream. La propiedad para este dato se llama Position y al igual que la anterior también 
            es de tipo long. La forma de obtener estos datos es similar a las anteriores. 
             */

            //long posicion = ms.Position;

            /*          Cómo colocar la posición en el stream
            Una de las actividades más importantes y frecuentes que realizaremos con los streams es colocar la posición actual en un sitio determinado. Para esto hacemos 
            uso de un método conocido como Seek(). Éste necesita dos parámetros. El primero es la distancia desde el punto de referencia donde quedará la nueva posición 
            actual en el stream. El segundo indica el punto de referencia que utilizaremos.
            El punto de referencia tiene que ser de tipo SeekOrigin. Este tipo tiene tres valores posibles: Begin, Current y End. El valor Begin es usado para indicar 
            que estamos referenciados con relación al origen del stream. Cuando se utiliza el valor Current nuestra posición actual será usada como punto de referencia. 
            Si usamos End, la parte final del stream será el punto de referencia para encontrar nuestra nueva posición. Por ejemplo, si deseamos colocarnos en el inicio 
            del stream, podemos hacerlo de la siguiente manera:
             */

            //ms.Seek(0, SeekOrigin.Begin);               // nos colocamos a 0 distancia desde el inicio

            /*
            En este caso, indicamos que nos encontramos a 0 distancia desde el inicio del stream. Si lo que deseamos es encontrarnos a 10 bytes de distancia desde el inicio, 
            la forma de usar Seek() es la siguiente: 
             */

            //ms.Seek(10, SeekOrigin.Begin);

            //Pero también podemos colocarnos desde otro punto de referencia. Por ejemplo, para colocarnos a 10 bytes de distancia desde el final del stream usaremos: 

            //ms.Seek(-10, SeekOrigin.End);

            /*
            Hay que observar que el valor usado es -10, ya que, como vimos anteriormente, las distancias que se miden hacia la izquierda del punto de referencia son negativas.
            Por último, si lo que deseamos es movernos con relación a nuestra posición actual, por ejemplo avanzar 5 bytes, lo que usaremos es: 
             */

            //ms.Seek(5, SeekOrigin.Current);

            //Y si lo que deseamos es retroceder 10 bytes desde nuestra posición actual, usaremos el código que veremos a continuación: 

            //ms.Seek(-10, SeekOrigin.Current);

            /*              Cómo leer datos del stream
            Ahora que ya nos hemos posicionado en algún lugar en particular del stream, podemos proceder a leer información, que se lee byte por byte. Cuando hacemos una
            lectura, el byte que se lee es el que se encuentra en la posición actual. Inmediatamente después de leer, la posición actual se actualiza y nuestra nueva 
            posición actual será la del byte consecutivo al que acabamos de leer. Esta lectura se lleva a cabo de forma automática y nosotros no la controlamos.
            Para realizar la lectura podemos usar el método Read(). Este método necesita tres parámetros. El primero es un arreglo de bytes. Este arreglo es necesario 
            porque será el lugar donde se guarde la información leída por el stream. El segundo nos da la capacidad de colocar un offset para el arreglo de bytes. 
            Generalmente usaremos el valor cero en este parámetro, ya que queremos que la información leída se coloque desde el inicio en el arreglo. El tercero es la 
            cantidad de bytes a leer.
            El arreglo de bytes para guardar la información es colocado de la siguiente manera:
             */

            //byte[] buffer = new byte[50];

            /*
            En este caso lo llamamos búfer y tendrá capacidad para 50 bytes.
            Supongamos que deseamos leer cinco bytes a partir de la posición actual donde nos encontramos. Para ello hacemos uso de Read() de la siguiente manera: 
             */

            //ms.Read(buffer, 0, 5);

            //Después de ejecutarse esta línea, buffer contendrá los cinco bytes leídos y los podemos encontrar al inicio de buffer. 

            /*              Cómo escribir información el stream
            No solamente es posible leer información del stream, también podemos agregarla o escribirla. Para esto tendremos un método especializado que se llama Write(). 
            Para el uso de este método utilizaremos tres parámetros. En el primer parámetro tenemos que colocar el búfer o el arreglo de bytes desde el que tomaremos 
            la información para colocarla en el stream. El segundo parámetro es la posición en el stream desde donde empezaremos a escribir. Generalmente utilizaremos 
            el valor de cero, y de esta forma empezará a escribirse desde el inicio del stream. El último parámetro es la cantidad máxima de bytes que se escribirán.
            Un ejemplo práctico de esto es el siguiente:
             */

            //ms.Write(buffer, 0, 15);

            /*              Cómo cerrar el stream
            Algo que no debemos olvidar hacer es cerrar el stream. Cuando éste está cerrado, los recursos que se hayan necesitado se liberan. Si el stream está cerrado 
            no es posible llevar a cabo ningún tipo de operación sobre él. El cierre del stream se lleva a cabo por medio del método Close(), que no necesita ningún parámetro. 
            La forma de utilizar el método se muestra a continuación: 
             */

            //ms.Close();


            /*              Programa de ejemplo
            Ahora podemos crear un pequeño programa de ejemplo que utilice lo que hemos realizado con los streams. El programa será sencillo, ya que únicamente nos interesa
            conocer y experimentar con el código. Nuestro programa le pedirá al usuario una cadena que será colocada en el stream y luego podremos leer diferentes partes del
            stream con los métodos que hemos aprendido.
            Como siempre, tenemos que empezar por definir las variables que son necesarias.
             */

            // Creamos el stream en memory
            // La iniciamos con una capacidad de 50 bytes
            MemoryStream ms = new MemoryStream(50);
            // Cadena con información
            String informacion = "";
            // Variables necesarias
            long capacidad = 0;
            long longitud = 0;
            long posicion = 0;
            byte[] buffer = new byte[50];

            /*
            En primer lugar tenemos un objeto llamado ms que es de tipo MemoryStream y que puede guardar hasta 50 bytes en su interior. Luego creamos la cadena que utilizaremos
            para guardar la frase escrita por el usuario. Como experimentaremos con el stream creamos tres variables. Cada una de ellas se usa para guardar la capacidad,
            la longitud y la posición, respectivamente. Al final creamos un arreglo de bytes llamado buffer y de tamaño 50.
            Pedir los datos será de la forma usual y no necesitamos explicarlo en este momento. 
             */

            // El usuario da los datos
            Console.WriteLine("Dame la cadena para el flujo: ");
            informacion = Console.ReadLine();

            //Ahora que ya tenemos una cadena, podemos escribirla adentro del stream.

            ms.Write(ASCIIEncoding.ASCII.GetBytes(informacion), 0, informacion.Length);

            /*
            Lo primero que hacemos es obtener los bytes de la cadena, pero éstos estarán codificados como ASCII. Luego indicamos que escribiremos en el stream desde su inicio. 
            Por último, indicamos la cantidad de bytes a escribir, que lo obtenemos por medio de la longitud de la cadena. Ahora mostraremos la información que podemos obtener 
            sobre el stream. 
             */

            // Obtenemos información de la cadena
            capacidad = ms.Capacity;
            longitud = ms.Length;
            posicion = ms.Position;
            // Mostramos la información
            Console.WriteLine("Capacidad {0}, longitud {1}, posicion {2}", capacidad, longitud, posicion);

            /*
            Ahora podemos empezar a experimentar con stream. Nos colocaremos en diferentes posiciones y leeremos información desde ahí. Empecemos por lo más sencillo.
            Leeremos los primeros cinco bytes que se encuentran en el stream.
             */

            // Colocamos y leemos datos basándonos en el inicio
            ms.Seek(0, SeekOrigin.Begin); // nos colocamos a 0 distancia desde el inicio
            ms.Read(buffer, 0, 5); // desde donde nos encontramos, 5 caracteres
            // Mostramos la información
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            /*
            Lo primero que hacemos es usar el método Seek(). Con este método decimos que queremos encontrarnos a distancia cero desde el inicio del stream. Evidentemente
            ésta es la primera posición disponible. Como nuestra posición actual ya está definida, procedemos a hacer uso del método Read(). En este caso leemos cinco bytes 
            desde donde nos encontramos. Los bytes leídos desde el stream ahora se encuentran guardados en el arreglo de bytes que llamamos búfer. 
            Para mostrar lo que acabamos de obtener usamos el método WriteLine(), y como solamente tenemos una colección de bytes, debemos codificarlas adecuadamente con
            GetString(). La codificación que deseamos es ASCII. En la consola aparecen los primeros cinco caracteres de la frase que escribimos.

            En el código que veremos a continuación, haremos una prueba, realizando otra lectura en una posición diferente. 
             */

            // Otra lectura desde el inicio
            ms.Seek(10, SeekOrigin.Begin); // nos colocamos a 10 distancia desde el inicio
            ms.Read(buffer, 0, 5); // desde donde nos encontramos, 5 caracteres
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            /*
            En este caso, por medio del método Seek() nos posicionamos a 10 bytes de distancia desde que es iniciado el stream. Nuevamente procedemos a leer cinco bytes desde
            esa posición que serán colocados en el buffer. Para poder comprobar que esto es óptimo y que funciona en forma adecuada lo mostramos en la consola.
            Para mostrar lo que acabamos de obtener usamos el método WriteLine(), y como solamente tenemos una colección de bytes, debemos codificarlas adecuadamente con
            GetString(). La codificación que deseamos es ASCII. En la consola aparecen los primeros cinco caracteres de la frase que escribimos.
            
            Pero sabemos que no solamente podemos utilizar el inicio del stream como referencia para indicar la posición actual. Ahora realizaremos otra prueba con el final
            del stream como punto de referencia.
             */

            // Lectura relativa al final del flujo
            ms.Seek(-10, SeekOrigin.End); // nos colocamos a 10 distancia desde el final
            ms.Read(buffer, 0, 5); // desde donde nos encontramos, 5 caracteres
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            /*
            Para este ejemplo usamos nuevamente el método Seek(), pero con la diferencia que ahora indicaremos que el punto de referencia es el final del stream. Nuestra nueva
            posición actual se encontrará a una distancia de diez bytes desde el final del stream. Por esta razón, vamos a colocar el valor -10 en el primer parámetro. 
            Ya colocados en esta distancia simplemente procedemos a leer sólo cinco bytes. Al final de la lectura mostramos lo que hemos obtenido en la consola.
            
            Debemos recordar que cuando se lleva a cabo una lectura o escritura en el stream, la posición actual se modifica. La última posición colocada explícitamente
            se encontraba a diez bytes del final del stream, pero después de la lectura se ha modificado en cinco bytes.
            Comprobemos esto de forma sencilla:
             */

            // Obtenemos nuestra posición actual
            posicion = ms.Position;
            Console.WriteLine("La posicion es {0}", posicion);

            /*
            Simplemente obtenemos nuestra posición actual y la mostramos en la consola. Esto lo podemos hacer en cada operación y verificar cómo se altera la posición actual.
            Desde nuestra nueva posición actual podemos continuar leyendo. 
             */

            // Lectura relativa desde la posición actual
            ms.Read(buffer, 0, 5); // desde donde nos encontramos, 5 caracteres
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            /*
            Ahora no hemos utilizado el método Seek() ya que deseamos continuar leyendo desde donde nos encontramos.
            Por último, no debemos olvidar cerrar el stream. 
             */

            ms.Close();


            /*              Uso de Archivos
            Los streams no solamente funcionan en la memoria, sino que también nos pueden servir para mover información de la memoria a un dispositivo
            de almacenamiento masivo. Este dispositivo generalmente será el disco duro. Nosotros podemos crear, escribir y leer archivos en el disco duro apoyándonos en
            los streams. 

                            Cómo crear un stream a archivo
            Lo primero que tenemos que hacer es crear un stream a archivo. En lugar de crear el stream en la memoria, éste utilizará un medio de almacenamiento masivo. 
            Para poder llevar a cabo esto, necesitamos utilizar la clase FileStream. Esta clase nos provee de toda la funcionalidad que necesitamos.
            El constructor de esta clase necesita dos parámetros. El primero tiene que ser una cadena que contenga el nombre del archivo con el que trabajaremos. 
            Es útil que el nombre del archivo también tenga su extensión.
            El segundo parámetro es más interesante. En este parámetro colocaremos el modo del archivo, que indica cómo funcionará y se manipulará el archivo. El valor 
            colocado debe ser del tipo de la enumeración FileMode. Los valores posibles son: Append, Create, CreateNew, Open, OpenOrCreate, Truncate.
            Es importante conocer lo que significa cada uno de estos modos, por lo que lo comentaremos aquí. El modo Create nos permite crear un nuevo archivo. En caso de
            que el archivo ya existiera, simplemente se sobrescribe. El modo CreateNew también nos permite crear un archivo, pero si el archivo ya existe, se produce una 
            excepción.
            El modo Open nos permite abrir un archivo. Si el archivo que intentamos abrir no existe, entonces se produce una excepción. En el modo OpenOrCreate si el archivo
            existe, se abre, pero en el caso de que el archivo no exista, se crea.
            En el modo Append, si el archivo existe será abiero, y la posición actual será colocada al final del archivo, de forma tal que cualquier información escrita, sea
            agregada al archivo sin modificar lo anterior. En el caso de que el archivo no exista, será creado un nuevo archivo.
            El modo Truncate es especial y debemos tener cuidado con él ya que abre el archivo. Entonces, los contenidos se eliminan hasta que el archivo tenga una longitud de
            0 bytes. Por ejemplo, podemos crear un stream a disco en modo de creación, como podemos ver en el código a continuación:
             */

            FileStream fs = new FileStream("miTexto.txt", FileMode.Create);

            /*
            El archivo a crear se llama miTexto.txt y será creado en el mismo directorio que el ejecutable de nuestra aplicación. El nombre del stream es fs y ya podemos llevar a
            cabo las operaciones necesarias sobre él.

                            Cómo escribir información en el archivo
            Ya que tenemos el stream, es posible empezar a trabajar con él, y al igual que con los streams de la memoria, podemos llevar a cabo diferentes operaciones, entre
            ellas la de escritura. Para escribir el archivo usaremos el método Write(), que pertenece al stream. Por ejemplo, si deseamos escribir una cadena al archivo, podemos
            hacerlo de la siguiente forma: 
             */

            String cadena = "Nombre y Apellido";

            // Escribimos al stream la cadena capturada
            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);

            /*
            El método necesita tres parámetros, el primer parámetro es el arreglo de bytes que escribiremos, el segundo es la posición a partir de donde empezaremos a escribir 
            con respecto a nuestra posición actual, y el último parámetro nos sirve para indicar la cantidad de bytes que colocaremos. Es importante no olvidar que esta posición 
            se actualiza después de hacer uso del método Write().
            En nuestro ejemplo a realizar vamos a suponer que una cadena será escrita al archivo. A esta cadena la tenemos que colocar como un arreglo de bytes, pero éstos
            deben estar codificados como ASCII, para lo cual usaremos la clase ASCIIEncoding.
            Para poder obtener los bytes de la cadena deberemos hacer uso del método GetBytes() por el que se pasa la cadena escrita como parámetro.
            La cantidad de bytes que deseamos colocar será la longitud de la cadena, que obtenemos al hacer uso de la propiedad Length.

                            Cómo cerrar el archivo
            El cierre del archivo es muy sencillo ya que únicamente debemos cerrar el stream. Sabemos que esto lo realizamos por medio del método Close(). 
             */

            fs.Close();


            //Existe otra forma de escribir y leer archivos de texto

            //Creacion del archivo

            TextWriter archivo = new StreamWriter("texto.txt");  

            Console.WriteLine("Ingresa el texto ");

            string texto = Console.ReadLine().ToString();

            archivo.WriteLine(texto);

            archivo.Close();

            //De esta forma siempre que ejecutemos el programa se sobreescribira lo que ya tenga el archivo de texto, por el nuev texto que ingresemos 

            //Lectura del archivo

            TextReader lectura = new StreamReader("texto.txt");

            Console.WriteLine(lectura.ReadToEnd());

            Console.ReadKey();

            //Para agregar texto a un archivo sin que se borre lo que ya se tenga en el archivo existento se hace de la siguiente manera:

            TextWriter archivo2 = File.AppendText("texto.txt");

            Console.WriteLine("Ingresa el texto ");

            string texto2 = Console.ReadLine().ToString();

            archivo2.WriteLine(texto2);

            archivo2.Close();


            //Una ultima forma de escribir y leer archivos es la siguiente:

            StreamWriter Escribir;

            StreamReader Leer;

            //Crear y Escribir en un archivo:

            Escribir = File.AppendText("datos.txt");

            Console.WriteLine("Ingrese el texto que deseas ingresar al archivo");

            string texto3 = Console.ReadLine();

            Escribir.WriteLine(texto3);

            //Leer el archivo:

            Leer = new StreamReader("datos.txt");

            while (!Leer.EndOfStream)
            {
                Console.WriteLine(Leer.ReadToEnd());
            }

        }
    }
}
