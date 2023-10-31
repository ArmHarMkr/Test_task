using FlexobaseTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexobaseTest.Class
{
    public class AdvancedNumReplacer : NumberReplacer
    {
        public override string GetReplacement(int num)
        {
            string replacement = base.GetReplacement(num);

            if(num % 4 == 0)
            {
                replacement = "muzz";
            }
            else if(num % 7 == 0)
            {
                replacement = "guzz";
            }
            return replacement; 
        }
    }
}
