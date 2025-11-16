using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsProject
{
    public static class Calculations
    {
        // methods with numeric calculations
        public static int add2Numbers(int firstNum, int secondNum)
        {
            return (firstNum +secondNum);
        }

        public static double divide2Numbers(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException();
            // TODO Fixme - deliberate error (31/2 does not return correct result)
            return Math.Round((double)numerator / (double)denominator,4);
        }

        // methods with string manipulation
        public static bool StartsWithUpper(String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            Char ch = str[0];
            return Char.IsUpper(ch);
        }

        public static char ConvertToUpper(char anyAlphaChar)
        {
            return Char.ToUpper(anyAlphaChar);
        }

        public static bool ContainsChar(string keyString, char c)
        {
            // TODO Make this a case insensitive search
            return keyString.IndexOf(c) >= 0;            
        }


    }
}
