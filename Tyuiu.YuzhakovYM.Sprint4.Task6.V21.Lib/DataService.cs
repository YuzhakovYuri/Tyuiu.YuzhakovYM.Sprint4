using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YuzhakovYM.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(s => s.Length > 8);
            return count;
        }
    }
}
