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

        public string BrewCocoa()
        {
            if (IsOn)
            {
                if (!IsAmountTooBig(50, CocoaPowderAmountCurrent) || IsAmountTooBig(20, WaterAmountCurrent))
                {
                    CocoaPowderAmountCurrent -= 50;
                    WaterAmountCurrent -= 20;
                    return "Made a single cup of cocoa";
                }
                return "There was not enough powder/Water in the machine";
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
