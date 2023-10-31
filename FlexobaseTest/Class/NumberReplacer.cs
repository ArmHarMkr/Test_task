using FlexobaseTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FlexobaseTest.Class
{
    public class NumberReplacer : INumberReplacer
    {
        public List<string> ReplaceNumbers(List<int> numbers)
        {
            List<string> result = new List<string>();
            foreach(var num in numbers)
            {
                string replacement = GetReplacement(num);
                result.Add(replacement);
            }
            return result;
        }
        public virtual string GetReplacement(int num)
        {
            string replacement = String.Empty;
            if(num % 3 == 0)
            {
                replacement += "fizz";
            }
            if(num % 5 == 0)
            {
                replacement += "buzz";
            }
            if(num % 5 == 0 && num % 3 == 0)
            {
                replacement += "fizz-buzz";
            }
            if(string.IsNullOrEmpty(replacement))
            {
                replacement = num.ToString();
            }
            return replacement;
        }

    }
}
