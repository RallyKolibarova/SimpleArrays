using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNegativeElementsInArray
{
    class CountOfNegativeElementsInArray
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            var count = 0;

            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    count = count + 1;
                }
                
            }

            Console.WriteLine(count);            
        }
    }
}
