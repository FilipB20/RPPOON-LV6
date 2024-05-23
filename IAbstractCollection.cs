using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
