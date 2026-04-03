using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MealPlanGenerator
{
    class HighProteinMeal : IMealPlan
    {
        public string MealType => "High Protein";

        public void ShowMeal()
        {
            Console.WriteLine("High Protein Meal: Paneer, Lentils, Nuts");
        }
    }

}
