using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class StringReducer
    {
        public static void Main(String[] args)
        {
            string input = "aabb";
            Console.WriteLine(Reduce(input));
        }

        public static string Reduce(string input)
        {
            char[] charArr = input.ToArray<char>();

            if (charArr.Length == 1)
            {
                return charArr.ToString();
            }else if (charArr.Length == 2 && charArr[0] == charArr[1])
            {
                return "Empty String";
            }else
            {
                StringBuilder strBuilder = new StringBuilder(
                    );
                for(int i = 1; i < charArr.Length; i++)
                {
                    if (charArr[i-1] == charArr[i])
                    {
                        i = i + 1;
                    }else
                    {
                        strBuilder.Append(charArr[i - 1]);
                    }
                }

                if (strBuilder.Length>0)
                {
                    return strBuilder.ToString();
                }else
                {
                    return "Empty String";
                }
            }
            return null;
        }
    }
}
