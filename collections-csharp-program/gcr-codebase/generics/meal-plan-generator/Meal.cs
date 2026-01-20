using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.MealPlanGenerator
{
    class Meal<T> where T : IMealPlan, new()
    {
        public T GenerateMeal()
        {
            return new T();
        }
    }

}
