using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FitnessApp
{
    internal class User
    {
        private string UserName;
        private string UserAddress;
        private int UserStepsCount;

        // getter for all fields , and setter only for steps count

        public User(string name,string address)
        {
            this.UserName = name;
            this.UserAddress = address;
            this.UserStepsCount = 0;
        }
        public string GetUserName()
        {
            return UserName;
        }
        public string GetUserAddress()
        {
            return UserAddress;
        }
        public int GetUserStepsCount()
        {
            return UserStepsCount;
        }

        public void SetUserStepsCount(int steps)
        {
            this.UserStepsCount = steps;
        }


    }
}
