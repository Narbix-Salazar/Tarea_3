using System;
using System.Linq;

class Program
{
    static int num = 2;
    static string[] nombre = new string[num];
    static int[] edad = new int[num];
    static string[] cita = new string[num];

    static void Main()
    {
        int opcion = 0;
        do
        {
            MostrarMenu();
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Iniciar();
                    break;
                case 2:
                    AgregarPaciente();
                    break;
                case 3:
                    MostrarReporte();
                    break;
                case 4:
                    EliminarPaciente();
                    break;
                case 5:
                    AsignarCita();
                    break;
                case 6:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        } while (opcion != 6);
    }

    static void Iniciar()
    {
        nombre = Enumerable.Repeat("", num).ToArray<string>();
        edad = Enumerable.Repeat(0, num).ToArray<int>();
        cita = Enumerable.Repeat("", num).ToArray<string>();

        Console.WriteLine("Los arreglos fueron iniciados");
        Console.ReadKey();
        Console.Clear();
    }

    static void AgregarPaciente()
    {
        for (int i = 0; i < nombre.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ingrese el nombre: ");
            nombre[i] = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            edad[i] = int.Parse(Console.ReadLine());
        }
    }

    static void MostrarReporte()
    {
        for (int i = 0; i < nombre.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Nombre: ");
            Console.WriteLine($"{nombre[i]}");
            Console.Write("Edad: ");
            Console.WriteLine($"{edad[i]}");
            Console.Write("Cita: ");
            Console.WriteLine($"{cita[i]}");
        }
    }

    static void EliminarPaciente()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ingrese el nombre del paciente a eliminar: ");
        string nombreEliminar = Console.ReadLine();
        int index = Array.IndexOf(nombre, nombreEliminar);

        if (index != -1)
        {
            nombre[index] = "";
            edad[index] = 0;
            cita[index] = "";
            Console.WriteLine("Paciente eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Paciente no encontrado.");
        }
    }

    static void AsignarCita()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Ingrese el nombre del paciente: ");
        string nombrePaciente = Console.ReadLine();
        int index = Array.IndexOf(nombre, nombrePaciente);

        if (index != -1)
        {
            Console.Write("Ingrese el día y hora de la cita: ");
            cita[index] = Console.ReadLine();
            Console.WriteLine("Cita asignada exitosamente.");
        }
        else
        {
            Console.WriteLine("Paciente no encontrado.");
        }
    }

    static void MostrarMenu()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*****CONSULTORIO MEDICO*****");
        Console.WriteLine("1- Iniciar arreglos");
        Console.WriteLine("2- Agregar paciente");
        Console.WriteLine("3- Mostrar reporte");
        Console.WriteLine("4- Eliminar paciente");
        Console.WriteLine("5- Asignar cita");
        Console.WriteLine("6- Salir");
        Console.Write("Seleccione una opción: ");
    }
}
