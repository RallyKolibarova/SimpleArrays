using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSymmetric
{
    class IsSymmetric
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().Split(' ');

            bool isSymmetric = true;

            for(int i = 0; i < word.Length / 2; i++)
            {
                string firstWord = word[i];
                string secondWord = word[word.Length - i - 1];

                if(firstWord != secondWord)
                {
                    isSymmetric = false;
                    break;
                }

            }
            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
}
