using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MealPlanGenerator
{
    class VegetarianMeal : IMealPlan
    {
        public string MealType => "Vegetarian";

        public void ShowMeal()
        {
            Console.WriteLine("Vegetarian Meal: Dal, Rice, Vegetables");
        }
    }

}
