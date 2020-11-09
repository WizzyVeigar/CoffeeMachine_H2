using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    interface IBrewHotWater
    {
        float WaterAmountCurrent { get; }
        float WaterAmountMax { get; }
        string AddWater(float amountToAdd);
    }
}
