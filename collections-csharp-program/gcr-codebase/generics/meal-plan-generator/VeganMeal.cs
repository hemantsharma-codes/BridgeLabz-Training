using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MealPlanGenerator
{
    class VeganMeal : IMealPlan
    {
        public string MealType => "Vegan";

        public void ShowMeal()
        {
            Console.WriteLine("Vegan Meal: Salad, Beans, Fruits");
        }
    }

}
