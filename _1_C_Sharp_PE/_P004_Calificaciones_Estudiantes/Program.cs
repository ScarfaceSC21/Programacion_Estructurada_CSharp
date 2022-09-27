using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _P004_Calificaciones_Estudiantes
{
    /*  PRACTICA #4 - CALIFICACIONES DE ESTUDIANTES - (PRACTICA FINAL)
    Realice un programa de consola tomando en cuenta las siguientes indicaciones:
    Menú horizontal (principal)
        • Estudiantes
        • Calificaciones
        • Salir
    Nota este menú debe ser visible en todo momento

    Menú vertical Estudiantes
        • Ingresar estudiante
        • Imprimir lista de estudiantes
        • Regresar

    Menú vertical Calificaciones
        • Ingresar calificaciones de estudiante
        • Imprimir calificaciones de estudiante
        • Estudiante con el mejor promedio
        • Estudiante con el promedio mas bajo
        • Regresar

    Manejo de estudiantes
    Se utilizará un archivo llamado Estudiantes.txt el cual contendrá los siguientes campos
        • Matricula
        • Grupo
        • Nombre
        • APP
        • APM
    
    En la opción “Ingresar estudiante” se solicitará la información necesaria para cubrir los campos y se guardará en el archivo aplicando el modo Append.
    En la opción “Imprimir lista de estudiantes”, se leerá el archivo y se imprimirá en pantalla de modo que las columnas siempre se encuentren alineadas.

    Nota: El programa debe regresar el control al menú vertical estudiantes después de procesar cualquiera de las dos opciones.
    
    Manejo Menú Calificaciones
    Se utilizará un archivo llamado Calificaciones.txt el cual contendrá los siguientes campos:
        • Matricula
        • Matemáticas
        • Ingles
        • Programación
        • Redes
    
    En la opción Ingresar calificaciones de estudiante se pedirá la calificación de 4 materias
        • Matemáticas
        • Ingles
        • Programación
        • Redes

    Para ingresar una calificación de estudiante se debe solicitar una matrícula existente en el archivo de estudiantes. Adicionalmente debe permitir cancelar 
    la captura de calificaciones.
    En la opción Imprimir calificaciones de estudiante se presentará el contenido del archivo alineando las columnas.
    En la opción Estudiante con el mejor promedio. Se calculará el mejor promedio entre todos los estudiantes y se imprimirán los datos generales del estudiante, 
    el promedio general y las calificaciones de todas sus materias
    En la opción Estudiante con el promedio más bajo. Se calculará el promedio más bajo entre todos los estudiantes y se imprimirán los datos generales del estudiante, 
    el promedio general y las calificaciones de todas sus materias*/

    class Program
    {
        StreamWriter Escribir;
        StreamReader Leer;

        String Nombre, APP, APM, Grupo, Matricula_Buscar, Matricula;
        double CaliProg = 0.0, CaliRed = 0.0, CaliMate = 0.0, CaliIng = 0.0, promedio = 0.0, promedio_buscar;
        char respuesta;
        bool encontrado = false;
        string[] Matriculas = new string[10];
        double[,] promedios = new double[6, 10];

        static void Main(string[] args)
        {
            new Program().Menu();
        }

        void Menu()
        {
            bool ejecutar = false;

            for (int tecla = 0; ;)
            {
                PintaMenu(tecla);

                Console.CursorVisible = false;

                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow: tecla--; break;
                    case ConsoleKey.RightArrow: tecla++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (tecla > 2) tecla = 0; else if (tecla < 0) tecla = 2;

                if (ejecutar)
                {
                    ejecutar = false;

                    switch (tecla)
                    {
                        case 0: MenuEstudiantes(); Console.Clear(); break;
                        case 1: MenuCalificaciones(); Console.Clear(); break;
                        case 2: return;
                    }
                }
            }
        }

        void PintaMenu(int tecla)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.DarkRed;

            Console.SetCursorPosition(17, 5);
            Console.ForegroundColor = tecla == 0 ? sel : cc;
            Console.WriteLine("Estudiantes");

            Marco(3, 4, 42, 6);

            Console.SetCursorPosition(62, 5);
            Console.ForegroundColor = tecla == 1 ? sel : cc;
            Console.WriteLine("Calificaciones");

            Marco(45, 4, 88, 6);

            Console.SetCursorPosition(93, 5);
            Console.ForegroundColor = tecla == 2 ? sel : cc;
            Console.WriteLine("Salir");

            Marco(91, 4, 99, 6);
        }

        void MenuEstudiantes()
        {
            bool ejecutar = false;

            for (int tecla = 0; ;)
            {
                PintaMenuEstudiantes(tecla);

                Console.CursorVisible = false;

                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: tecla--; break; 
                    case ConsoleKey.DownArrow: tecla++; break; 
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (tecla > 2) tecla = 0; else if (tecla < 0) tecla = 2;

                if (ejecutar)
                {
                    ejecutar = false;

                    switch (tecla)
                    {
                        case 0: IngresarEstudiantes(); Console.Clear(); break; 
                        case 1: ImprimirEstudiantes(); Console.Clear(); break; 
                        case 2: return;
                    }
                }
            }
        }

        void PintaMenuEstudiantes(int tecla)
        {
            PintaMenu(0);

            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.DarkRed;

            Console.SetCursorPosition(4, 8);
            Console.ForegroundColor = tecla == 0 ? sel : cc;
            Console.WriteLine(" 1. Ingresar estudiante ");

            Console.SetCursorPosition(4, 10);
            Console.ForegroundColor = tecla == 1 ? sel : cc;
            Console.WriteLine(" 2. Imprimir lista de estudiantes ");

            Console.SetCursorPosition(4, 12);
            Console.ForegroundColor = tecla == 2 ? sel : cc;
            Console.WriteLine(" 3. Regresar ");
        }

        void IngresarEstudiantes()
        {
            Escribir = File.AppendText("Estudiantes.txt");
            Console.SetCursorPosition(5, 15);
            Console.Write("Matricula: ");
            Matricula = Console.ReadLine();
            Console.SetCursorPosition(5, 16);
            Console.Write("Grupo: ");
            Grupo = Console.ReadLine();
            Console.SetCursorPosition(5, 17);
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.SetCursorPosition(5, 18);
            Console.Write("Apellido Paterno: ");
            APP = Console.ReadLine();
            Console.SetCursorPosition(5, 19);
            Console.Write("Apellido Materno: ");
            APM = Console.ReadLine();
            Console.SetCursorPosition(5, 20);
            Console.WriteLine("¿Quiere cancelar la informacion?(s/n)");
            Console.SetCursorPosition(5, 21);
            respuesta = char.Parse(Console.ReadLine());

            if (respuesta == 'n')
            {
                Escribir.WriteLine(Matricula);
                Escribir.WriteLine(Grupo);
                Escribir.WriteLine(Nombre);
                Escribir.WriteLine(APP);
                Escribir.WriteLine(APM);
            }

            Escribir.Close();
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        void ImprimirEstudiantes()
        {
            int renglon = 14;
            Leer = new StreamReader("Estudiantes.txt");
            
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("=========DATOS DEL ARCHIVO=========");

            while (!Leer.EndOfStream)
            {
                Matricula = Leer.ReadLine();
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("Matricula: {0}", Matricula);
                Grupo = Leer.ReadLine();
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("Grupo: {0}", Grupo);
                Nombre = Leer.ReadLine();
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("Nombre: {0}", Nombre);
                APP = Leer.ReadLine();
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("Apellido Paterno: {0}", APP);
                APM = Leer.ReadLine();
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("Apellido Materno: {0}", APM);
                Console.SetCursorPosition(5, renglon++);
                Console.WriteLine("===================================");
            }

            Leer.Close();
            Console.SetCursorPosition(5, renglon++);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }

        void MenuCalificaciones()
        {
            bool ejecutar = false;

            for (int tecla = 0; ;)
            {
                PintaMenuCalificaciones(tecla);

                Console.CursorVisible = false;

                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: tecla--; break; 
                    case ConsoleKey.DownArrow: tecla++; break; 
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (tecla > 4) tecla = 0; else if (tecla < 0) tecla = 4;

                if (ejecutar)
                {
                    ejecutar = false;

                    switch (tecla)
                    {
                        case 0: IngresarCalificaciones(); Console.Clear(); break; 
                        case 1: ImprimirCalificaciones(); Console.Clear(); break; 
                        case 2: MejorPromedio(); Console.Clear(); break; 
                        case 3: PeorPromedio(); Console.Clear(); break; 
                        case 4: return;
                    }
                }
            }
        }

        void PintaMenuCalificaciones(int tecla)
        {
            PintaMenu(1);

            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.DarkRed;

            Console.SetCursorPosition(45, 8);
            Console.ForegroundColor = tecla == 0 ? sel : cc;
            Console.WriteLine(" 1. Ingresar calificaciones de estudiante ");

            Console.SetCursorPosition(45, 10);
            Console.ForegroundColor = tecla == 1 ? sel : cc;
            Console.WriteLine(" 2. Imprimir calificaciones de estudiante ");

            Console.SetCursorPosition(45, 12);
            Console.ForegroundColor = tecla == 2 ? sel : cc;
            Console.WriteLine(" 3. Estudiante con el mejor promedio ");

            Console.SetCursorPosition(45, 14);
            Console.ForegroundColor = tecla == 3 ? sel : cc;
            Console.WriteLine(" 4. Estudiante con el peor promedio");

            Console.SetCursorPosition(45, 16);
            Console.ForegroundColor = tecla == 4 ? sel : cc;
            Console.WriteLine(" 5. Regresar");
        }

        void IngresarCalificaciones()
        {
            int renglon = 18;
            Console.SetCursorPosition(46, renglon++);
            Console.Write("Ingrese la matricula del estudiante: ");
            Matricula_Buscar = Console.ReadLine();
            Leer = new StreamReader("Estudiantes.txt");
            Escribir = File.AppendText("Calificaciones.txt");
            while (!Leer.EndOfStream)
            {
                Matricula = Leer.ReadLine();
                if (Matricula == Matricula_Buscar)
                {
                    encontrado = true;

                    Console.SetCursorPosition(46, renglon++);
                    Console.Write("Calificacion Programacion: ");
                    CaliProg = double.Parse(Console.ReadLine());

                    Console.SetCursorPosition(46, renglon++);
                    Console.Write("Calificacion Redes: ");
                    CaliRed = double.Parse(Console.ReadLine());

                    Console.SetCursorPosition(46, renglon++);
                    Console.Write("Calificacion Matematicas: ");
                    CaliMate = double.Parse(Console.ReadLine());

                    Console.SetCursorPosition(46, renglon++);
                    Console.Write("Calificacion Ingles: ");
                    CaliIng = double.Parse(Console.ReadLine());

                    Console.SetCursorPosition(46, renglon++);
                    Console.WriteLine("¿Quiere cancelar la informacion?(s/n)");

                    Console.SetCursorPosition(46, renglon++);
                    respuesta = char.Parse(Console.ReadLine());

                    promedio = (CaliProg + CaliRed + CaliMate + CaliIng) / 4;

                    if (respuesta == 'n')
                    {
                        Escribir.WriteLine(Matricula);
                        Escribir.WriteLine(CaliProg);
                        Escribir.WriteLine(CaliRed);
                        Escribir.WriteLine(CaliMate);
                        Escribir.WriteLine(CaliIng);
                        Escribir.WriteLine(promedio);
                    }
                }
            }

            if (!encontrado)
            {
                Console.SetCursorPosition(46, renglon++);
                Console.WriteLine("La matricula no esta en el sistema.");
            }

            Escribir.Close();
            Leer.Close();
            Console.SetCursorPosition(46, renglon++);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        void ImprimirCalificaciones()
        {
            int renglon = 18;

            Leer = new StreamReader("Calificaciones.txt");
            Console.SetCursorPosition(47, renglon++);
            Console.WriteLine("=========DATOS DEL ARCHIVO=========");

            while (!Leer.EndOfStream)
            {
                Matricula = Leer.ReadLine();
                Console.SetCursorPosition(47, renglon++);
                Console.WriteLine("Matricula: {0}", Matricula);
                CaliProg = double.Parse(Leer.ReadLine());
                Console.SetCursorPosition(47, renglon++);
                Console.WriteLine("Programacion: {0}", CaliProg);
                CaliRed = double.Parse(Leer.ReadLine());
                Console.SetCursorPosition(47, renglon++);
                Console.WriteLine("Redes: {0}", CaliRed);
                CaliMate = double.Parse(Leer.ReadLine());
                Console.SetCursorPosition(47, renglon++);
                Console.WriteLine("Matematicas: {0}", CaliMate);
                CaliIng = double.Parse(Leer.ReadLine());
                Console.SetCursorPosition(47, renglon++);
                Console.WriteLine("Ingles: {0}", CaliIng);
                promedio = double.Parse(Leer.ReadLine());
                //Console.SetCursorPosition(47, renglo++);
                //Console.WriteLine("Promedio: {0}", promedio);
                Console.SetCursorPosition(47, renglon++);
                Console.WriteLine("===================================");
            }

            Leer.Close();
            Console.SetCursorPosition(47, renglon++);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        void MejorPromedio()
        {
            Leer = new StreamReader("Calificaciones.txt");

            int renglon, columna = 0;

            while (!Leer.EndOfStream)
            {
                Matricula = Leer.ReadLine();
                Matriculas[columna] = Matricula;
                renglon = 0;
                CaliProg = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = CaliProg;
                renglon++;
                CaliRed = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = CaliRed;
                renglon++;
                CaliMate = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = CaliMate;
                renglon++;
                CaliIng = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = CaliIng;
                renglon++;
                promedio = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = promedio;
                columna++;
            }

            double promedioMayor = promedios[4, 0];

            String mayor = Matriculas[0];

            for (int i = 0; i < 9; i++)
            {
                if (promedios[4, i] > promedioMayor)
                {
                    promedioMayor = promedios[4, i];
                    mayor = Matriculas[i];
                }
            }

            Leer.Close();

            Matricula_Buscar = mayor;
            Leer = new StreamReader("Estudiantes.txt");
            renglon = 18;
            Console.SetCursorPosition(47, renglon++);
            Console.WriteLine("=========DATOS DEL ARCHIVO=========");
            while (!Leer.EndOfStream)
            { 
                Matricula = Leer.ReadLine();
                Grupo = Leer.ReadLine();
                Nombre = Leer.ReadLine();
                APP = Leer.ReadLine();
                APM = Leer.ReadLine();

                if (Matricula == Matricula_Buscar)
                {
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Matricula: {0}", Matricula);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Grupo: {0}", Grupo);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Nombre: {0}", Nombre);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Apellido Paterno: {0}", APP);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Apellido Materno: {0}", APM);
                }
            }
            Leer.Close();

            int Indice = 0;
            promedio_buscar = promedioMayor;
            Leer = new StreamReader("Calificaciones.txt");
            while (!Leer.EndOfStream)
            { 
                Matricula = Leer.ReadLine();
                Matriculas[Indice] = Matricula;
                CaliProg = double.Parse(Leer.ReadLine());
                CaliRed = double.Parse(Leer.ReadLine());
                CaliMate = double.Parse(Leer.ReadLine());
                CaliIng = double.Parse(Leer.ReadLine());
                promedio = double.Parse(Leer.ReadLine());

                Indice++;

                if (promedio == promedio_buscar)
                {
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Calificacion Programacion: {0}", CaliProg);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Calificacion Redes: {0}", CaliRed);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Calificacion Matematicas: {0}", CaliMate);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Calificacion Ingles: {0}", CaliIng);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Promedio: {0}", promedio);
                }
            }
            Leer.Close();

            Console.SetCursorPosition(47, renglon++);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        void PeorPromedio()
        {
            Leer = new StreamReader("Calificaciones.txt");

            int renglon, columna = 0;

            while (!Leer.EndOfStream)
            {
                Matricula = Leer.ReadLine();
                Matriculas[columna] = Matricula;
                renglon = 0;
                CaliProg = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = CaliProg;
                renglon++;
                CaliRed = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = CaliRed;
                renglon++;
                CaliMate = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = CaliMate;
                renglon++;
                CaliIng = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = CaliIng;
                renglon++;
                promedio = double.Parse(Leer.ReadLine());
                promedios[renglon, columna] = promedio;
                columna++;
            }

            double promedioMenor = promedios[4, 0];

            String menor = Matriculas[0];

            for (int i = 0; i < 9; i++)
            {
                if (promedios[4, i] < promedioMenor && promedios[4, i] > 0)
                {
                    promedioMenor = promedios[4, i];
                    menor = Matriculas[i];
                }
            }

            Leer.Close();

            Matricula_Buscar = menor;
            Leer = new StreamReader("Estudiantes.txt");
            renglon = 18;
            Console.SetCursorPosition(47, renglon++);
            Console.WriteLine("=========DATOS DEL ARCHIVO=========");
            while (!Leer.EndOfStream)
            { // Leemos los datos del archivo
                Matricula = Leer.ReadLine();
                Grupo = Leer.ReadLine();
                Nombre = Leer.ReadLine();
                APP = Leer.ReadLine();
                APM = Leer.ReadLine();

                if (Matricula == Matricula_Buscar)
                {
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Matricula: {0}", Matricula);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Grupo: {0}", Grupo);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Nombre: {0}", Nombre);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Apellido Paterno: {0}", APP);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Apellido Materno: {0}", APM);
                }
            }
            Leer.Close();

            promedio_buscar = promedioMenor;
            int Indice = 0;
            Leer = new StreamReader("Calificaciones.txt");
            while (!Leer.EndOfStream)
            { 
                Matricula = Leer.ReadLine();
                Matriculas[Indice] = Matricula;
                CaliProg = double.Parse(Leer.ReadLine());
                CaliRed = double.Parse(Leer.ReadLine());
                CaliMate = double.Parse(Leer.ReadLine());
                CaliIng = double.Parse(Leer.ReadLine());
                promedio = double.Parse(Leer.ReadLine());
                Indice++;

                if (promedio == promedio_buscar)
                {
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Calificacion Programacion: {0}", CaliProg);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Calificacion Redes: {0}", CaliRed);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Calificacion Matematicas: {0}", CaliMate);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Calificacion Ingles: {0}", CaliIng);
                    Console.SetCursorPosition(47, renglon++);
                    Console.WriteLine("Promedio: {0}", promedio);
                }
            }
            Leer.Close();

            Console.SetCursorPosition(47, renglon++);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        void Marco(int col1, int ren1, int col2, int ren2)
        {
            Console.SetCursorPosition(col1, ren1);
            Console.WriteLine("╔");
            Console.SetCursorPosition(col2, ren1);
            Console.WriteLine("╗");
            Console.SetCursorPosition(col1, ren2);
            Console.WriteLine("╚");
            Console.SetCursorPosition(col2, ren2);
            Console.WriteLine("╝");

            for (int i = col1 + 1; i <= col2 - 1; i++)
            {
                Console.SetCursorPosition(i, ren1);
                Console.WriteLine("═");
                Console.SetCursorPosition(i, ren2);
                Console.WriteLine("═");
            }

            for (int i = ren1 + 1; i <= ren2 - 1; i++)
            {
                Console.SetCursorPosition(col1, i);
                Console.WriteLine("║");
                Console.SetCursorPosition(col2, i);
                Console.WriteLine("║");
            }
        }
    }
}
