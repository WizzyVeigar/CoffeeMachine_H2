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

        private bool isOn;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }


        public virtual string ChangePower()
        {
            if (IsOn)
            {
                IsOn = false;
                return "Turned off " + Name;
            }
            else
            {
                IsOn = true;
                return "Turned on " + Name;
            }
        }

        protected Machine(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Checks Whether the <paramref name="amount"/> is bigger than the <paramref name="capacity"/>
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="capacity"></param>
        /// <returns>Returns true if the amount is too big, otherwise false</returns>
        protected virtual bool IsAmountTooBig(float amount, float capacity)
        { 
            return amount > capacity ? true : false;
        }
    }
}
