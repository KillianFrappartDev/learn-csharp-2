using System;

namespace Exercices
{
    public class Exercice1
    {
        public static void Answer()
        {
            var count = 0;
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0) count++;
            }
            Console.WriteLine(count);
        }
    }
}