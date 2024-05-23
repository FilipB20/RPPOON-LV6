using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    class CareTaker
    {
        List<Memento> states;
        Memento lastState;
        public CareTaker()
        {
            states=new List<Memento>();
        }
        public void AddState(Memento memento)
        {
            states.Add(memento);
            lastState = memento;
        }
        public Memento PreviousState { get { return lastState; } }
    }
}
