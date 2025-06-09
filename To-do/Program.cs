using System.Collections.Generic;
using System;
using Tareas;

class Program
{
    static List<tareas> TareasPendientes = new List<tareas>();
    static List<tareas> TareasRealizadas = new List<tareas>();
    static int Contadorid = 1000;
    static void main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Crear tareas aleatorias");
            Console.WriteLine("2. Marcar tarea como realizada");
            Console.WriteLine("3. Buscar tarea por descripción");
            Console.WriteLine("4. Mostrar todas las tareas");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());
        } while (opcion != 5);
        switch (opcion)
        {
            case 1:
                crearTarea();
                break;
            case 2:
                MoverTareaRealizada();
                break;
            case 3:
                buscarPorDes();
                break;
            case 4:
                Mostrar();
                break;
        }
    }
    static void crearTarea()
    {
        int numeroDeTareas;
        Console.WriteLine("¿Cuantas tarea desea realizar: ");
        numeroDeTareas = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numeroDeTareas; i++)
        {
            Console.Write($"Ingrese descripción para tarea #{i + 1}: ");
            string? desc = Console.ReadLine();
            Console.WriteLine("Ingresar la duracion de la tarea: ");
            int dur = Convert.ToInt32(Console.ReadLine());
            TareasPendientes.Add(new tareas(Contadorid++, desc!, dur));
        }
    }
    static void MoverTareaRealizada()
    {
        int id;
        Console.WriteLine("Ingrese el id de la tarea realizada: ");
        id = Convert.ToInt32(Console.ReadLine());
        tareas Tarea = TareasPendientes.Find(t => t.TareaID == id)!;
        if (Tarea != null)
        {
            TareasPendientes.Remove(Tarea);
            TareasRealizadas.Add(Tarea);
            Console.WriteLine("Tarea marcada como realizada.");
        }
        else
        {
            Console.WriteLine("Tarea no encontrada.");
        }
    }
}

