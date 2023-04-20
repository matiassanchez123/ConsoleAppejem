using System.Collections.Concurrent;

namespace TestProject1
{
    public class UnitTest1
    {
        

        [Fact]
        public void almacenar()
        {
            //Creación de una cola simultánea para almacenar valores enteros
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            //Agregar elementos a ConcurrentQueue usando el método Enqueue
            for (int i = 0; i < 2000; ++i)
            {
                concurrentQueue.Enqueue(i);

            }

          

            //Como int no es un tipo de referencia, este ConcurrentQueue no puede aceptar nulo
            //concurrentQueue.Enqueue(null); //Compile-Time Error

            //Como concurrentQueue es de tipo entero, no se pueden aceptar valores de cadena
            //concurrentQueue.Enqueue("Hell0"); //Compile-Time Error

            //Accediendo a todos los Elementos de concurrentQueue usando For Each
            
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }
        }

        [Fact]
        public void almacenarcola()
        {
            Queue<int> l = new Queue<int>();

            for (int i = 0; i < 2000; ++i)
            {
                l.Enqueue(i);
               
            }


            Assert.True(true);
        }

        [Fact]
        public void removerelemento()
        {
            
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            concurrentQueue.Enqueue(5);
            concurrentQueue.Enqueue(7);
            concurrentQueue.Enqueue(30);
            concurrentQueue.Enqueue(80);
            concurrentQueue.Enqueue(90);


            
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }
            bool IsRemoved = concurrentQueue.TryDequeue(out int Result);
            IsRemoved = concurrentQueue.TryDequeue(out int Result22);

           
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }
        }

        [Fact]
        public void usandopeek()
        {
            
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

          
            concurrentQueue.Enqueue(5);
            concurrentQueue.Enqueue(7);
            concurrentQueue.Enqueue(30);
            concurrentQueue.Enqueue(80);
            concurrentQueue.Enqueue(90);


            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }
            bool IsRemoved = concurrentQueue.TryDequeue(out int Result);
            IsRemoved = concurrentQueue.TryDequeue(out int Result22);

           
            foreach (var item in concurrentQueue)
            {
                Console.WriteLine(item);
            }

            bool IsPeeked = concurrentQueue.TryPeek(out int Result2);
            
           
            foreach (var element in concurrentQueue)
            {
                Console.WriteLine($"{element} ");
            }
        }

        

    }
}