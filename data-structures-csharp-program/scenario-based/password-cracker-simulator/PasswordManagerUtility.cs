using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.PasswordCrackerSimulator
{
    internal class PasswordManagerUtility : IPasswordManager
    {
        private string _charSets;
        private static string _password;

        public PasswordManagerUtility()
        {
            _charSets = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ@#$%!";
        }

        public void AddPassword()
        {
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            _password = password;
        }
        public void CrackPassword()
        {
            bool result = TryCrack("", _charSets);
            if (!result)
            {
                Console.WriteLine("Password couldn't crack!");
            }
        }

        private bool TryCrack(string current,string charSets)
        {
            if (current.Length == _password.Length)
            {
                Console.WriteLine("Trying: "+current);

                if (current.Equals(_password))
                {
                    Console.WriteLine("Password cracked: "+current);
                    return true;
                }
                return false;
            }

            for(int i = 0; i < charSets.Length; i++)
            {
                if (TryCrack(current + charSets[i], charSets))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
