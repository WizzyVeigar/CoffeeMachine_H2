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

        public string BrewCoffee(int cupsToMake)
        {
            if (IsOn)
            {
                for (int i = 0; i < cupsToMake; i++)
                {
                    if (IsAmountTooBig((cupsToMake * 5),BeanAmountCurrent) || IsAmountTooBig(cupsToMake * 10, WaterAmountCurrent))
                    {
                        return "Because of missing water/coffee, we made only " + i +" cup/s of coffee";
                    } 
                }
                return "Made " + cupsToMake + " cups of coffee";
            }

            return "The machine is not turned on";
        }

        public string AddCoffeeIngredient(float coffeeIngredient)
        {
            //Checks if the coffee amount you want to add + current amount is bigger than the capacity
            if (!IsAmountTooBig(coffeeIngredient + BeanAmountCurrent, BeanAmountMax))
            {
                BeanAmountCurrent += coffeeIngredient;
                return "Added " + coffeeIngredient + " grams of beans to the machine";
            }
            BeanAmountCurrent = beanAmountMax;
            return "You tried adding too much coffee, it has instead been fully filled";
        }

        public string AddWater(float amountToAdd)
        {
            //Checks if the water amount you want to add + current amount is bigger than the capacity
            if (!IsAmountTooBig(amountToAdd + WaterAmountCurrent, WaterAmountMax))
            {
                WaterAmountCurrent += amountToAdd;
                return "Added " + amountToAdd + " units of water";
            }
            WaterAmountCurrent = WaterAmountMax;
            return "You tried adding too much water, it has instead fully been filled";
        }
    }
}
