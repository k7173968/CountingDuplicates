using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates
{
    class CountingDuplicates
    {
        public int countingDuplicates(string str)
        {
            if (str == "")
                return 0;

            int sumOfDuplicates = str.ToUpper().Distinct().Select(a => str.Count(c => c == a)).Max();

            if (sumOfDuplicates == 1)
                return 0;

            return sumOfDuplicates < 6 ? sumOfDuplicates : sumOfDuplicates >= 6 && sumOfDuplicates < 7 ? sumOfDuplicates = 1 : sumOfDuplicates = 2;
        }
    }
}
