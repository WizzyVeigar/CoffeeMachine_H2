using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeBean bean = new CoffeeBean("name", Flavor.Cool);

            Console.WriteLine(bean.Flavor);
            Console.WriteLine(bean.IngredientName);

            Console.ReadKey();
        }
    }
}
