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
                if (!IsAmountTooBig((cupsToMake * 5), BeanAmountCurrent))
                {
                    for (int i = 0; i < cupsToMake; i++)
                    {
                        BeanAmountCurrent -= cupsToMake * 5;
                    }
                    return "Brewed " + cupsToMake + " amount of coffee";
                }
                return "There is not enough coffee to make " + cupsToMake + " cup/s of coffee";
            }

            return "The machine is not turned on";
        }

        public string AddCoffeeIngredient(float coffeeIngredient)
        {
            if (!IsAmountTooBig(coffeeIngredient + BeanAmountCurrent, BeanAmountMax))
            {
                BeanAmountCurrent += coffeeIngredient;
                return "Added " + coffeeIngredient + " grams of beans to the machine";
            }
            return "You tried adding too much coffee";
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
