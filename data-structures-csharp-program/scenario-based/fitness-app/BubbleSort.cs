using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FitnessApp
{
    internal class BubbleSort
    {
        public void SortUserLeaderboard(User[] users, int currentIdx)
        {
            for (int i=0;i<currentIdx-1;i++)
            {
                for (int j=0;j<currentIdx-i-1;j++)
                {
                    if (users[j] != null && users[j + 1] != null)
                    {
                        // DESCENDING ORDER
                        if (users[j].GetUserStepsCount() < users[j + 1].GetUserStepsCount())
                        {
                            User temp = users[j];
                            users[j] = users[j + 1];
                            users[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
