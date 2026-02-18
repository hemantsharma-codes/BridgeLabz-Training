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

        // Serach Person by city or state
        public void SearchPersonByCityOrState()
        {
            Console.WriteLine("Enter full name (FirstName LastName): ");
            string fullName = Console.ReadLine();

            string[] nameArr = fullName.Split(' ');
            if (nameArr.Length < 2)
            {
                Console.WriteLine("Please enter both first and last name.");
                return;
            }

            string firstName = nameArr[0];
            string lastName = nameArr[1];

            Console.WriteLine("1. Search by City");
            Console.WriteLine("2. Search by State");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter City/State name:");
            string location = Console.ReadLine();

            bool isFound = false;

            for (int i = 0; i < CurrentIdx; i++)
            {
                AddressBook addressBook = AddressBooks[i];
                if (addressBook == null) continue;

                if (choice == 1)
                {
                    if (addressBook.SearchPersonByCity(firstName, lastName, location))
                        isFound = true;
                }
                else if (choice == 2)
                {
                    if (addressBook.SearchPersonByState(firstName, lastName, location))
                        isFound = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    return;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Person not found in any address book.");
            }
        }

        // Ability to get number of contact persons by city or state
        public void CountPersonByCityOrState()
        {
            Console.WriteLine("1. Count by City");
            Console.WriteLine("2. Count by State");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter City/State name:");
            string name = Console.ReadLine();

            int totalCount = 0;

            for (int i = 0; i < CurrentIdx; i++)
            {
                AddressBook addressBook = AddressBooks[i];
                if (addressBook == null) continue;

                if (choice == 1)
                {
                    totalCount += addressBook.CountByCity(name);
                }
                else if (choice == 2)
                {
                    totalCount += addressBook.CountByState(name);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    return;
                }
            }

            Console.WriteLine("\nTotal number of contacts : " + totalCount);
        }


    }
}
