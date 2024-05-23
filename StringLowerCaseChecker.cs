using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    class StringLowerCaseChecker : StringChecker
    {

        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(char.IsLower);
        }
    }
}
