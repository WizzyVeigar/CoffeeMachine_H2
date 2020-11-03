using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    interface IBrewTea : IBrewHotWater
    {
        string BrewTea(int cupsToMake);
    }
}
