using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class CaesarCipher
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ApplyCaesarCipher(n,s,k));
            Console.ReadKey();
        }

        public static string ApplyCaesarCipher(int length, string input, int key)
        {
            if (length != input.Length)
            {
                return string.Format("Valid");
            }

            char[] inCh = input.ToCharArray();
            StringBuilder output = new StringBuilder();
            foreach (char ch in inCh)
            {
                int ascii = (int)ch ; // convert ascii code to start from 0.

                key = key % 26;
                //ascii = ascii + key;
                // If the ascii code of the character is a valid alphabet - upper or lower case
                if ((ascii>=65 && ascii<=90) || (ascii >=90 && ascii <=122))
                {
                    if((ascii >=65 && ascii <= 90))
                    {
                        ascii = ascii + key;
                        if (ascii > 90)
                        {
                            ascii = ascii - 26;
                        }
                    }else if ((ascii >= 97 && ascii <= 122))
                    {
                        ascii = ascii + key;
                        if (ascii > 122)
                        {
                            ascii = ascii - 26;
                        }
                    }
                    output.Append(Convert.ToChar(ascii));
                }
                else
                {
                    // If not valid, add to stringbuilder
                    output.Append(ch);
                }
            }
            return output.ToString();
        }
    }
}
