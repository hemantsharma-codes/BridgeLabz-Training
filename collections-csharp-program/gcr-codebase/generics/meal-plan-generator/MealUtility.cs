using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MealPlanGenerator
{
    class MealUtility
    {
        public static void GenerateAndShowMeal<T>() where T : IMealPlan, new()
        {
            Meal<T> meal = new Meal<T>();
            T mealPlan = meal.GenerateMeal();

            Console.WriteLine($"Meal Type Selected: {mealPlan.MealType}");
            mealPlan.ShowMeal();
        }
    }

}
