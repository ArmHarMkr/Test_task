using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexobaseTest.Interfaces
{
    public interface INumberReplacer
    {
        string GetReplacement(int num);
        List<string> ReplaceNumbers(List<int> numbers);
    }
}
