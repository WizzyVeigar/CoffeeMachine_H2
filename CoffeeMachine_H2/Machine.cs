using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    abstract class Machine
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public abstract void TurnOn();

        protected Machine(string name)
        {
            Name = name;
        }
    }
}
