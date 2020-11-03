using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    class CoffeeMachine : Machine, IBrewCoffee
    {
        private float beanAmountMax;
        public float BeanAmountMax
        {
            get { return beanAmountMax; }
            private set { beanAmountMax = value; }
        }

        private float beanAmountCurrent;

        public float BeanAmountCurrent
        {
            get { return beanAmountCurrent; }
            private set
            {
                if (beanAmountCurrent + value > BeanAmountMax)
                {
                    beanAmountCurrent = BeanAmountMax;
                    //Maybe log you filled too much
                }
                else
                {
                    beanAmountCurrent = value;
                }
            }
        }

        private float waterAmountMax;
        public float WaterAmountMax
        {
            get { return waterAmountMax; }
            private set { waterAmountMax = value; }
        }

        private float waterAmountCurrent;

        public float WaterAmountCurrent
        {
            get { return waterAmountCurrent; }
            private set
            {
                if (waterAmountCurrent + value > WaterAmountMax)
                {
                    waterAmountCurrent = WaterAmountMax;
                    //Maybe log you filled too much
                }
                else
                {
                    waterAmountCurrent = value;
                }
            }
        }




        public CoffeeMachine(string name, float maxBeanCapacity) : base(name)
        {
            BeanAmountMax = maxBeanCapacity;
        }

        public CoffeeMachine(string name, float maxBeanCapacity, float maxWaterCapacity) : this(name, maxBeanCapacity)
        {
            WaterAmountMax = maxBeanCapacity;
        }

        public override void TurnOn()
        {
            throw new NotImplementedException();
        }

        public string BrewCoffee(int cupsToMake)
        {
            throw new NotImplementedException();
        }
    }
}
