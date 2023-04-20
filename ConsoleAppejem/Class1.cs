using System;
using System.Collections.Concurrent;
namespace ConcurrentQueueDemo
{
    class Program
    {
        static void Main()
        {
            //Creación de una cola simultánea para almacenar valores enteros
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            //Agregar elementos a ConcurrentQueue usando el método Enqueue
            concurrentQueue.Enqueue(5);
            concurrentQueue.Enqueue(7);
            concurrentQueue.Enqueue(30);
            concurrentQueue.Enqueue(80);
            concurrentQueue.Enqueue(90);

            //Como int no es un tipo de referencia, este ConcurrentQueue no puede aceptar nulo
            //concurrentQueue.Enqueue(null); //Compile-Time Error

            //Como concurrentQueue es de tipo entero, no se pueden aceptar valores de cadena
            //concurrentQueue.Enqueue("Hell0"); //Compile-Time Error

            //Accediendo a todos los Elementos de concurrentQueue usando For Each
            Console.WriteLine("Elementos de cola concurrentes");
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }
            bool IsRemoved = concurrentQueue.TryDequeue(out int Result);
            IsRemoved = concurrentQueue.TryDequeue(out int Result22);

            Console.WriteLine($"\nTryDequeue Return : {IsRemoved}");
            Console.WriteLine($"TryDequeue Result Value : {Result}");
            Console.WriteLine("\nTodos los elementos de cola concurrentes después de TryDequeue");
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }

            bool IsPeeked = concurrentQueue.TryPeek(out int Result2);
            Console.WriteLine($"\nTryPeek Return : {IsPeeked}");
            Console.WriteLine($"TryPeek Result Value : {Result2}");
            //Elementos de impresión después de echar un vistazo al primer elemento
            Console.WriteLine($"Todos los elementos de cola simultáneos después  de TryPeek: Count {concurrentQueue.Count}");
            foreach (var element in concurrentQueue)
            {
                Console.WriteLine($"{element} ");
            }
            Console.ReadKey();
        }
    }
}