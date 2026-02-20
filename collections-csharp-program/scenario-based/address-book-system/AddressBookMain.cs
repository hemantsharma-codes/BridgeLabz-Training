using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {

            IAddressBookSystem addressBookSystem = new AddressBookSystem();
            AddressBookMenu addressBookMenu = new AddressBookMenu(addressBookSystem);

            addressBookMenu.Choice();
        }
    }
}
