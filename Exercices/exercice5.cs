using System;

namespace Exercices
{
    public class Exercice5
    {
        //     public static void Answer()
        //     {
        //         Console.Write("Enter numbers separated by a coma (1, 3, 7, ...) ");
        //         var inputStr = Console.ReadLine();

        //         var max = 0;
        //         foreach (char num in inputStr)
        //         {
        //             if (num == Convert.ToChar(" ") || num == Convert.ToChar(",")) continue;
        //             else
        //             {
        //                 if (Convert.ToInt32(num.ToString()) > max) max = Convert.ToInt32(num.ToString());
        //             }
        //         }
        //         Console.WriteLine(max);
        //     }

        public static void Answer()
        {
            Console.Write("Enter numbers separated by a coma (1, 3, 7, ...) ");
            var inputStr = Console.ReadLine();
            var numArr = inputStr.Split(", ", inputStr.Length);
            var max = Convert.ToInt32(numArr[0]);

            for (var i = 1; i < numArr.Length; i++)
            {
                if (Convert.ToInt32(numArr[i]) > max) max = Convert.ToInt32(numArr[i]);
            }

            Console.WriteLine(max);

        }
    }
}