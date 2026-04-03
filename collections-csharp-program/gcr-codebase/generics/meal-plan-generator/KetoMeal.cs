using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MealPlanGenerator
{
    class KetoMeal : IMealPlan
    {
        public string MealType => "Keto";

        public void ShowMeal()
        {
            Console.WriteLine("Keto Meal: Eggs, Cheese, Avocado");
        }
    }

}
