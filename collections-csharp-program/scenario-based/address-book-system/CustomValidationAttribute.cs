using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal abstract class CustomValidationAttribute : Attribute
    {
        public abstract string ErrorMessage { get; }

        public abstract bool IsValid(string value);
    }
}
