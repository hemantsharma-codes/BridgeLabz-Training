using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MealPlanGenerator
{
    class Menu
    {
        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Personalized Meal Plan Generator ---");
                Console.WriteLine("1. Vegetarian Meal");
                Console.WriteLine("2. Vegan Meal");
                Console.WriteLine("3. Keto Meal");
                Console.WriteLine("4. High Protein Meal");
                Console.WriteLine("0. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        MealUtility.GenerateAndShowMeal<VegetarianMeal>();
                        break;
                    case 2:
                        MealUtility.GenerateAndShowMeal<VeganMeal>();
                        break;
                    case 3:
                        MealUtility.GenerateAndShowMeal<KetoMeal>();
                        break;
                    case 4:
                        MealUtility.GenerateAndShowMeal<HighProteinMeal>();
                        break;
                }

            } while (choice != 0);
        }
    }

}
