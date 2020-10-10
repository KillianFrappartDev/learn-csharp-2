using System;

namespace Exercices
{
    public class Exercice3
    {
        private static int Factorial(int num)
        {
            if (num == 1) return 1;
            return num * Factorial(num - 1);
        }
        public static void Answer()
        {
            Console.Write("Enter a number ");
            var input = Console.ReadLine();
            Console.WriteLine($"{input}! = {Factorial(Convert.ToInt32(input))}");
        }
    }
}