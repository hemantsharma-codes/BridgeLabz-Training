using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.PasswordCrackerSimulator
{
    internal interface IPasswordManager
    {
        void AddPassword();
        void CrackPassword();
    }
}
