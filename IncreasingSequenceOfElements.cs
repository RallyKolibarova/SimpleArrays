using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main(string[] args)
        {
            
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areAllEqual = true;

            int previous = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] <= previous)
                {
                    areAllEqual = false;
                    break;
                }


                previous = array[i];
            }
            if (areAllEqual)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
