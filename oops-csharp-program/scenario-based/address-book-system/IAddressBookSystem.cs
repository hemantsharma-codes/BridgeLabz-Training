using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal interface IAddressBookSystem
    {
        IAddressBook GetAddressBook(string name);
        void AddAddressBook();
        void DisplayAllAddressBook();
        void SearchPersonByCityOrState();
        void ViewPersonInACityOrState();

    }
}
