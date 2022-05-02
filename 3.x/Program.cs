using System;

namespace _3.x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цвет световора {0}", Semaphore.Green);

       
        }

        enum Semaphore 
        {
            Red = 100, 
            Yellow = 200, 
            Green = 300

        }


    }

}
