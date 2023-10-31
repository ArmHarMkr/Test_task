using FlexobaseTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexobaseTest.Class
{
    public class LastNumberReplacer : AdvancedNumReplacer
    {
        public override string GetReplacement(int num)
        {
            string replacement = base.GetReplacement(num);
            if (num % 3 == 0 && num % 5 == 0)
                replacement = "good-boy";
            else if (num % 3 == 0)
                replacement = "dog";
            else if (num % 5 == 0)
                replacement = "cat";
            return replacement;
        }
    }
}
