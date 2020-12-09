using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброго времени суток. Как тебя зовут мой друг?");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}. Спрашиваешь сколько времени? {DateTime.Now}.");
        }
    }
}
