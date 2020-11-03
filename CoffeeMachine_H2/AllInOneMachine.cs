using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    class AllInOneMachine : Machine, IBrewCocoa, IBrewCoffee, IBrewTea
    {

        public AllInOneMachine(string name) : base(name)
        {
        }

        private float cocoaPowderAmountMax;
        public float CocoaPowderAmountMax
        {
            get
            {
                return cocoaPowderAmountMax;
            }
            private set
            {
                cocoaPowderAmountMax = value;
            }
        }

        public float CocoaPowderAmountCurrent
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

        public string BrewCocoa(int cupsToMake)
        {
            throw new NotImplementedException();
        }
    }
}
