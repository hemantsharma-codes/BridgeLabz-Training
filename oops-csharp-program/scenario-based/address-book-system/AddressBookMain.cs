using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookMain
    {
        private static AddressBookMenu addressBookMenu;
        static void Main(string[] args)
        {
            addressBookMenu = new AddressBookMenu();

            addressBookMenu.Choice();
        }
    }
}
