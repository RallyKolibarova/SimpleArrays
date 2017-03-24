using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays
{
    class SimpleArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var temp = 0;
            
            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[array.Length - i - 1])
                {
                    temp = array[i];
                }
                else if(array[i] == array[array.Length - i - 1]) {
                    temp = array[i];
                }
            }
                
            Console.WriteLine(temp);
        }
    }
}
