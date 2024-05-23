using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    class StringLengthChecker : StringChecker
    {
        int length;

        public StringLengthChecker(int length)
        {
            this.length = length;
        }
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Length > length;
        }
    }
}
