using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.PasswordCrackerSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordCrackerMenu menu = new PasswordCrackerMenu();
            menu.Run();
        }
    }
}
