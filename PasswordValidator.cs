using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    class PasswordValidator
    {
        StringChecker stringChecker;
        private List<StringChecker> stringCheckers;
        public PasswordValidator(StringChecker stringChecker)
        {
            this.stringChecker = stringChecker;
        }

        public void AddStringChecker(StringChecker stringChecker)
        {
            stringCheckers.Add(stringChecker);
            this.stringChecker.SetNext(stringChecker);
        }

        public bool CheckString(string password)
        {
            foreach(StringChecker stringChecker in stringCheckers)
            {
                return stringChecker.PerformCheck(password);
            }
            return false;
        }
    }
}
