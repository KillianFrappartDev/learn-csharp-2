using System;

namespace Exercices
{
    public class Exercice4
    {
        public static void Answer()
        {
            var random = new Random().Next(1, 10);
            var chances = 4;
            while (chances > 0)
            {
                Console.Write($"Guess the number (1 to 10), {chances} attempts remaining ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (input == random)
                {
                    Console.WriteLine("Well done");
                    break;
                }
                else chances--;
            }

            if (chances == 0) Console.WriteLine("You lost...");
        }
    }
}