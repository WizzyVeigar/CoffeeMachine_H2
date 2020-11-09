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
        public CombiMachine(string name, float maxBeanCapacity) : base(name, maxBeanCapacity)
        {
        }

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
                    if (IsAmountTooBig((cupsToMake * 5), BeanAmountCurrent) || IsAmountTooBig(cupsToMake * 10, WaterAmountCurrent))
                    {
                        return "Because of missing water/coffee, we made only " + i + " cup/s of coffee";
                    }
                    BeanAmountCurrent -= 5;
                    WaterAmountCurrent -= 10;
                }
                return "Made " + cupsToMake + " cups of coffee";
            }

            return "The machine is not turned on";
        }



    }
}
