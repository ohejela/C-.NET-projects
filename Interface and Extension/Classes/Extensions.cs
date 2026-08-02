using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_Extension.Classes
{
    public static class Extensions
    {
        public static string Reverse(this string input)
        {
            if(input == null)
            {
                return null;
            }

            char[] chars = input.ToCharArray();
            char[] result = new char[chars.Length];

            int j = result.Length - 1;

            foreach (char c in chars)
            {
                result[j] = c;
                j--;
            }
            return new string(result);
        }
        public static bool IsTooLong(this string input)
        {

            bool result = false;
            if(input.Length <= 50)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        public static string ToHashLong(this string input)
        {
            string[] hashTag = input.Split(' ');
            return string.Join("", hashTag);
        }

    }
}
