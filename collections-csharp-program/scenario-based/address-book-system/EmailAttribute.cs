using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class EmailAttribute : CustomValidationAttribute
    {
        public override string ErrorMessage => "Invalid Email Formate.";

        public override bool IsValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;
            return Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

    }
}
