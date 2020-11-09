using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    //This class makes Coffee and Tea, representing a CombiMachine
    class CombiMachine : CoffeeMachine, IBrewCoffee, IBrewTea
    { 

        public CombiMachine(string name, float maxBeanCapacity, float maxWaterCapacity) : base(name, maxBeanCapacity, maxWaterCapacity)
        {
        }

        //Normally you can't make coffeebeans to tea, but in my machine you can.
        public string BrewTea(int cupsToMake)
        {
            if (IsOn)
            {
                for (int i = 0; i < cupsToMake; i++)
                {                    
                    if (IsAmountTooBig(3, BeanAmountCurrent) || IsAmountTooBig(15, WaterAmountCurrent))
                    {
                        return "Because of missing water/coffee, we made only " + i + " cup/s of tea";
                    }
                    BeanAmountCurrent -= 3;
                    WaterAmountCurrent -= 15;
                }
                return "Made " + cupsToMake + " cups of tea";
            }
            return "The machine is not turned on";
        }
    }
}
