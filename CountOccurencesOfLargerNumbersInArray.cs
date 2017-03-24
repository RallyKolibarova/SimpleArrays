using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurencesOfLargerNumbersInArray
{
    class CountOccurencesOfLargerNumbersInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(Double.Parse)
                .ToArray();
            var elem = Double.Parse(Console.ReadLine());
            var count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(elem < numbers[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
