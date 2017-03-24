using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceОfElementsInArray
{
    class EqualSequenceОfElementsInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool isEqual = true;

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] != numbers[i + 1])
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
}
