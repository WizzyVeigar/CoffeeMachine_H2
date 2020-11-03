using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    interface IBrewCocoa : IBrewHotWater
    {
        float CocoaPowderAmountMax { get; }
        float CocoaPowderAmountCurrent { get; }

        string BrewCocoa(int cupsToMake);
    }
}
