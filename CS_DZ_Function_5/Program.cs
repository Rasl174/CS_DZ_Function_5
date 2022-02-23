using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Function_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var shuffleArray = new[] { 3, 5, 6, 7, 8, 12, 67, 44, 23, 105, 34, 11 };
            Shuffle(shuffleArray);
            Console.WriteLine(string.Join(" ", shuffleArray));
            Console.ReadKey();
        }

        static void Shuffle(int [] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i + 1);

                int tempArray = array[j];
                array[j] = array[i];
                array[i] = tempArray;
            }
        }
    }
}
