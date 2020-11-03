using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    class CoffeeBean : Ingredient
    {
        public CoffeeBean(Flavor flavor) : base(flavor)
        {
            IngredientName = "CoffeeBean";
        }
    }
}
