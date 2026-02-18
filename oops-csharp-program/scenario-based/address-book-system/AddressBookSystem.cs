using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                    Console.WriteLine("\n==========="+addressBook.GetName()+"==========");
                    addressBook.DisplayAllContacts();
                }
            }
        }

        // abiltiy to view person in a city or state across the multiple address book
        public void ViewPersonInACityOrState()
        {
            Console.WriteLine("1. View by City");
            Console.WriteLine("2. View by State");

            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    ViewByCityName();
                    break;
                case 2:
                    ViewByStateName();
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    break;
            }
        }
        private void ViewByCityName()
        {
            Console.WriteLine("Enter the full name of city");
            string cityName = Console.ReadLine();

            for(int i = 0; i < CurrentIdx; i++)
            {
                AddressBook addressBook = AddressBooks[i];
                if(addressBook != null)
                {
                    addressBook.ViewContactByCity(cityName);
                }
            }
        }

        private void ViewByStateName()
        {
            Console.WriteLine("Enter the full name of state");
            string stateName = Console.ReadLine();

            for(int i = 0; i < CurrentIdx; i++)
            {
                AddressBook addressBook = AddressBooks[i];
                if(addressBook != null)
                {
                    addressBook.ViewContactByState(stateName);

                }
            }
        }
    }
}
