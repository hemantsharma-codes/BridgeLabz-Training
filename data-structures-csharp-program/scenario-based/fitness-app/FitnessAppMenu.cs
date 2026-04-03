using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FitnessApp
{

    sealed class FitnessAppMenu
    {
        private IFitnessTracker fitnessTracker;

        public FitnessAppMenu()
        {
            fitnessTracker = new FitnessTracker(20);
        }

        public void StartApp()
        {
            Console.WriteLine("==========Fitness Tracker==============");

            while (true)
            {
                Console.WriteLine("\n1. Add User");
                Console.WriteLine("2. Take Steps");
                Console.WriteLine("3. Display leaderboard");
                Console.WriteLine("0. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        fitnessTracker.AddUser();
                        break;

                    case 2:
                        BubbleSort bubbleSort = new BubbleSort();
                        fitnessTracker.DailyStepCountRanking(bubbleSort);
                        break;

                    case 3:
                        fitnessTracker.DisplayLeaderBoard();
                        break;

                    case 0:
                        Console.WriteLine("Exiting.......");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }

}
