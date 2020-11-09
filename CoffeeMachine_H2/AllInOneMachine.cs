using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    //This machine simply put, does it all.
    class AllInOneMachine : CombiMachine, IBrewCocoa, IBrewCoffee, IBrewTea
    {
        public AllInOneMachine(string name, float maxBeanCapacity, float maxWaterCapacity, float cocoaMaxCapacity) : base(name, maxBeanCapacity, maxWaterCapacity)
        {
            CocoaPowderAmountMax = cocoaMaxCapacity;
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

        private float cocoaPowderAmountCurrent;
        public float CocoaPowderAmountCurrent
        {
            get
            {
                return cocoaPowderAmountCurrent;
            }
            protected set
            {
                cocoaPowderAmountCurrent = value;
            }
        }

        public string BrewCocoa(int cupsToMake)
        {
            if (IsOn)
            {
                for (int i = 0; i < cupsToMake; i++)
                {
                    if (IsAmountTooBig(10, cocoaPowderAmountCurrent) || IsAmountTooBig(5, CocoaPowderAmountMax))
                    {
                        return "Because of missing water/cocoa, we made only " + i + " cup/s of cocoa";
                    }
                    cocoaPowderAmountCurrent -= 10;
                    CocoaPowderAmountMax -= 5;
                }
                return "Made " + cupsToMake + " cups of cocoa";
            }
            return "The machine is not turned on";
        }

        public string AddCocoaPowder(float amountToAdd)
        {
            if (!IsAmountTooBig(amountToAdd + CocoaPowderAmountCurrent, BeanAmountMax))
            {
                CocoaPowderAmountCurrent += amountToAdd;
                return "Added " + amountToAdd + " grams of powder to the machine";
            }
            CocoaPowderAmountCurrent = CocoaPowderAmountMax;
            return "You tried adding too much cocoa, it has instead been fully filled";
        }

        public override string ToString()
        {
            return "Current Water: " + WaterAmountCurrent + "\n" +
                "Current Coffee: " + BeanAmountCurrent + "\n" +
                "Current Cocoa:" + CocoaPowderAmountCurrent;
        }
    }
}
