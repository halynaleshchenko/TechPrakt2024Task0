using System;

namespace ConsoleSumLeshchenko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перший доданок:");          
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Другий доданок:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine($"Ваш вираз: {number1} + {number2} = {sum}");          
        }
    }
}
