using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

using System;
namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    sealed class AddressBookMenu
    {
        private IAddressBookSystem addressBookSystem;

        public void Choice()
        {
            Console.WriteLine("==========Address Book System============");

            // Initialize AddressBookSystem via interface
            Console.WriteLine("Enter the maximum size of the Address Book System : ");
            int maxSize = Convert.ToInt32(Console.ReadLine());
            addressBookSystem = new AddressBookSystem(maxSize);

            while (true)
            {
                Console.WriteLine("\n1. Add New Address Book");
                Console.WriteLine("2. Open Existing Address Book");
                Console.WriteLine("3. Search Person by a city or state");
                Console.WriteLine("4. View Persons by city or state");
                Console.WriteLine("5. Get number of contact i.e. count by city or state");
                Console.WriteLine("6. Display all Address Book");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add a new address book
                        addressBookSystem.AddAddressBook();
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of address book");
                        string name = Console.ReadLine().ToLower();
                        IAddressBook addressBook = addressBookSystem.GetAddressBook(name);

                        if (addressBook != null)
                        {
                            HandleAddressBook(addressBook);
                        }
                        else
                        {
                            Console.WriteLine(name + " is not present in address book system");
                        }
                        break;
                    case 3:
                        addressBookSystem.SearchPersonByCityOrState();
                        break;

                    case 4:
                        addressBookSystem.ViewPersonInACityOrState();
                        break;
                    case 5:
                        addressBookSystem.CountPersonByCityOrState();
                        break;
                    case 6:
                        addressBookSystem.DisplayAllAddressBook();
                        break;
                    case 0:
                        Console.WriteLine("Exiting....");
                        return;
                    default:
                        Console.WriteLine("Please enter the valid choice...");
                        break;
                }

                  
            }
        }

        public void HandleAddressBook(IAddressBook addressBook)
        {

            while (true)
            {
                Console.WriteLine("\n1. Add New Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Sort Contact by Name");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice..");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.EditContactByName();
                        break;
                    case 3:
                        addressBook.DeleteContact();
                        break;
                    case 4:
                        addressBook.SortContactsByName();
                        break;
                    case 0:
                        Console.WriteLine("Exiting..");
                        return;
                    default:
                        Console.WriteLine("Please enter valid choice..");
                        break;
                }
            }
        }

    }
}

