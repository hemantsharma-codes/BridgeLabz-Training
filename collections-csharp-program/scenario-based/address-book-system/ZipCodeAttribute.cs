using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class ZipCodeAttribute : CustomValidationAttribute
    {
        public override string ErrorMessage => "Invalid Zip Code.";

        public override bool IsValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;
            return Regex.IsMatch(value, @"^\d{6}$");
        }
    }
}
