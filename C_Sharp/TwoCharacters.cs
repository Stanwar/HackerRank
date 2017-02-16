using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TwoCharacters
    {
        public static void Main(string[] args)
        {

        }

        public static void CorrectLength(string input)
        {
            StringBuilder strB = new StringBuilder(input);
            char[,] matrix = new char[26,26];
            char[] str = input.ToCharArray();

            StringBuilder output = new StringBuilder();
            HashSet<char> invalids = new HashSet<char>();
            // Run loop for the length of the input string.
            for (int i=0;i<input.Length;i++)
            {
                int position = (int)str[i]-65; // Get position of the character in the matrix
                ////
                for (int j=0;j<input.Length; j++)
                {
                    if (matrix[position,j] == str[i])
                    {
                        invalids.Add(str[i]);
                    }
                    matrix[position, j] = str[i];
                }
                ////
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[j,position] = str[i];
                }
            }
            
            //Loop over Stringbuilder for one character and check against the string 
            // again to find the maximum length possible after deleting every other 
            // character. 
            HashSet<char> uniqueChars = new HashSet<char>();
            // This hashset will contain unique characters from the input string
            // This will help remove certain characters. 

            foreach(char ch in input.ToCharArray())
            {
                uniqueChars.Add(ch);
            }
            for (int i=0;i<strB.Length;i++)
            {
                //for (int j=0;j<strB.Length;j++)
                //{
                    
                //    char[] toBeDeleted = 

                //}
            }
        }
    }
}
