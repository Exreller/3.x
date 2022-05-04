using System;

namespace _3.x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут {0} и вам {1}", name, age);
            Console.Write("Введите дату вашего рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Дата вашего рождения: {0}", birthdate);
        }
    }
}
