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
                // Start with the input string. 
                StringBuilder strBuilder = new StringBuilder(input);
                // Have a flag variable to check for changes
                int flag = 1;
                // Loop over input string and delete until no changes are left. 
                while (flag>0)
                {
                    flag = 0;
                    //Console.WriteLine(strBuilder.ToString());
                    for (int i = 1; i < strBuilder.Length; i++)
                    {
                        if (strBuilder[i-1] == strBuilder[i])
                        {
                            //i = i + 1;
                            strBuilder.Remove(i - 1, 2);
                            flag = 1;
                        }
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
