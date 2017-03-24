using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementInArray
{
    class CountOfGivenElementInArray
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            var n = int.Parse(Console.ReadLine());
            var count = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (Convert.ToInt32(n) == Convert.ToInt32(array[i]))
                {
                    count++;
                }   
            }
            Console.WriteLine(count);
        }
    }
}
