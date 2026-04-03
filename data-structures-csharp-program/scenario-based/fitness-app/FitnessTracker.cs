using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FitnessApp
{
    internal class FitnessTracker : IFitnessTracker
    {
        private User[] Users;
        private int MaxSize;
        private int CurrentIdx;

        public FitnessTracker(int maxSize)
        {
            this.MaxSize = maxSize;
            Users = new User[MaxSize];
            CurrentIdx = 0;
        }

        public void AddUser()
        {
            if(CurrentIdx == MaxSize)
            {
                Console.WriteLine("The capacity is full, you can't add any more member ");
                return;
            }
            Console.WriteLine("Enter the user name");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter the user address ");
            string userAddress = Console.ReadLine();

            // initially we will have only 0 steps of every user
            User user = new User(userName, userAddress);

            if(user != null)
            {
                Users[CurrentIdx++] = user;
                Console.WriteLine("The member has been added succesfully....");
            }
            else
            {
                Console.WriteLine("Please enter the valid details....");
            }


        }
        public void DailyStepCountRanking(BubbleSort sort)
        {
            if (CurrentIdx == 0)
            {
                Console.WriteLine("Please first add user");
                return;
            }

            Console.WriteLine("Enter the user name that we need to keep track steps : ");
            string name = Console.ReadLine().ToLower();

            bool userFound = false;

            for (int i = 0; i < CurrentIdx; i++)
            {
                User user = Users[i];

                if (user.GetUserName().ToLower().Equals(name))
                {
                    Console.WriteLine("Enter the steps count that user is taking...");
                    int steps = Convert.ToInt32(Console.ReadLine());

                    steps += user.GetUserStepsCount();
                    user.SetUserStepsCount(steps);

                    // Sort leaderboard after update
                    sort.SortUserLeaderboard(Users, CurrentIdx);

                    userFound = true;
                    break;
                }
            }

            if (!userFound)
            {
                Console.WriteLine("User not found in the system.");
            }
        }


        public void DisplayLeaderBoard()
        {
            Console.WriteLine("=========Leader Board==========");

            for(int i = 0; i < CurrentIdx; i++)
            {
                User user = Users[i];
                Console.WriteLine($"\nUser Rank : {i+1}, User Name : {user.GetUserName()}, User Address : {user.GetUserAddress()}, User Steps : {user.GetUserStepsCount()}");
            }
        }
    }
}
