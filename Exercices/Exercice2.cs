using System;

namespace Exercices
{
    public class Exercice2
    {
        public static void Answer()
        {
            var result = 0;
            while (true)
            {
                Console.Write("Enter a number or OK to exit ");
                var input = Console.ReadLine();
                if (input == "OK")
                {
                    Console.WriteLine($"Total is {result}");
                    break;
                }
                else result += Convert.ToInt32(input);
            }
        }
    }
}