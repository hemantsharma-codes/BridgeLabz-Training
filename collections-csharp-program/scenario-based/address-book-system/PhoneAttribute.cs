using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class PhoneAttribute : CustomValidationAttribute
    {
        public override string ErrorMessage => "Invalid Phone Number.";
        public override bool IsValid(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;
            return Regex.IsMatch(value, @"^[6-9]\d{9}$");
        }
    }
}
