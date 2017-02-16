using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Mars_Exploration
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(discrepancy(input));
            Console.ReadKey();
        }

        public static int discrepancy(string input)
        {
            int numberOfMessages = input.Length / 3;
            int count = 0;
            char[] inCh = input.ToCharArray();
            char[] SOS = "SOS".ToCharArray();
            for (int i=0;i<input.Length;i++)
            {
                if (inCh[i] != SOS[i%3])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
 