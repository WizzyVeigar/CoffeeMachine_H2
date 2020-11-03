using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    class CombiMachine : Machine, IBrewCoffee, IBrewTea
    {
        public CombiMachine(string name) : base(name)
        {
        }

        public float BeanAmountMax
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float BeanAmountCurrent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float WaterAmountCurrent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float WaterAmountMax
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string BrewCoffee(int cupsToMake)
        {
            throw new NotImplementedException();
        }

        public string BrewTea(int cupsToMake)
        {
            throw new NotImplementedException();
        }

        public override void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
