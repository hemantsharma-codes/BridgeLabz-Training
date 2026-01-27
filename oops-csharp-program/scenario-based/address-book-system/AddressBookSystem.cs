using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookSystem : IAddressBookSystem
    {
        private int CapacityOfAddressBookSystem;
        private AddressBook[] AddressBooks;
        private int CurrentIdx;

        public AddressBookSystem(int size)
        {
            this.CapacityOfAddressBookSystem = size;
            AddressBooks = new AddressBook[CapacityOfAddressBookSystem];
            CurrentIdx = 0;
        }

        // get address book
        public IAddressBook GetAddressBook(string name)
        {
            for(int i = 0; i < CurrentIdx; i++)
            {
                AddressBook addressBook = AddressBooks[i];

                if (addressBook.GetName().ToLower().Equals(name))
                {
                    return AddressBooks[i];
                }
            }
            return null;
        }

        // Add Address Book
        public void AddAddressBook()
        {
            Console.WriteLine("Enter the name of address book");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the size of address book");
            int size = Convert.ToInt32(Console.ReadLine());

            AddressBook newAddressBook = new AddressBook(name,size);

            if(CurrentIdx == CapacityOfAddressBookSystem)
            {
                CapacityOfAddressBookSystem = CapacityOfAddressBookSystem*2;
                AddressBook[] temp = new AddressBook[CapacityOfAddressBookSystem];

                for(int i = 0; i < CurrentIdx; i++)
                {
                    temp[i] = AddressBooks[i];
                }
                AddressBooks = temp;
            }
            AddressBooks[CurrentIdx++] = newAddressBook;
            Console.WriteLine("New Address Book has been added succefully");
        }


        //displaying address book
        public void DisplayAllAddressBook()
        {
            if(CurrentIdx == 0)
            {
                Console.WriteLine("\nAddress Book System is empty...\n");
                return;
            }
            for(int i = 0; i < CurrentIdx; i++)
            {
                AddressBook addressBook = AddressBooks[i];

                if(addressBook != null)
                {
                    Console.WriteLine("==========="+addressBook.GetName()+"==========");
                    addressBook.DisplayAllContacts();
                }
            }
        }
    }
}
