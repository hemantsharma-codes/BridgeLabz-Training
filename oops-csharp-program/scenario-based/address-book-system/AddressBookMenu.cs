using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    sealed class AddressBookMenu
    {
        private IAddressBook addressBook;
        public void Choice()
        {
            Console.WriteLine("==========Address Book System============");

            Console.WriteLine("Enter the maximum size of the Contact list : ");
            int maxSize = Convert.ToInt32(Console.ReadLine());
            addressBook = new AddressBook(maxSize);
            while (true)
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Edit contact by Name");
                Console.WriteLine("3. Diplay details");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your choice");
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
                        // Explicit cast
                        ((AddressBook)addressBook).DisplayAllContacts();
                        break;
                    case 4:
                        Console.WriteLine("Exiting....");
                        return;
                }
            }
        }
    }
}
