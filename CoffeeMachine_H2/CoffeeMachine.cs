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
            private set { beanAmountCurrent = value; }
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
            private set { waterAmountCurrent = value; }
        }

        public CoffeeMachine(string name, float maxBeanCapacity) : base(name)
        {
            BeanAmountMax = maxBeanCapacity;
        }

        public CoffeeMachine(string name, float maxBeanCapacity, float maxWaterCapacity) : this(name, maxBeanCapacity)
        {
            WaterAmountMax = maxWaterCapacity;
        }

        public override void TurnOn()
        {
            //Power on or off
        }

        public string BrewCoffee(int cupsToMake)
        {
            return "Brewed X amount of coffee"; 
        }

        public string AddCoffeeIngredient(float coffeeIngredient)
        {
            return "Added" + coffeeIngredient + "grams of beans to the machine";
        }

        public string AddWater(float amountToAdd)
        {
            WaterAmountCurrent += amountToAdd;
            return ""
        }
    }
}
