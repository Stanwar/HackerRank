using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class CamelCase
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            NumberOfWords(input);
        }

        public static void NumberOfWords(string input)
        {
            int count = 0;
            if ((int)input.ToCharArray()[0]>=97 && (int)input.ToCharArray()[0] <= 122)
            {
                count = 1;
            }
            count = count + input.Count( x => (int)x >= 65 && (int)x <= 90);
            Console.WriteLine(count);
        }
    }
}
