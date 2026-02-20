using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookSystem : IAddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>(StringComparer.OrdinalIgnoreCase);
        }

        public void AddAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                throw new BusinessException(BusinessErrorCode.DupilcateAddressBook, "Book already exists");
            }

            addressBooks.Add(name, new AddressBook(name));
            Console.WriteLine("Address Book Added.");
        }

        public IAddressBook GetAddressBook(string name)
        {
            if (!addressBooks.ContainsKey(name))
            {
                throw new BusinessException(BusinessErrorCode.AddressBookNotFound, "Address book does not exist");
            }
            return addressBooks[name];
        }

        public void DisplayAllAddressBook()
        {
            if(addressBooks.Count == 0)
            {
                throw new BusinessException(BusinessErrorCode.EmptyAddressBook,"No Address book available");
            }
            foreach (var book in addressBooks)
            {
                Console.WriteLine("\n==== " + book.Key + " ====");
                book.Value.DisplayAllContacts();
            }
        }

        // View total number of persons in a city or state
        public void ViewPersonInACityOrState()
        {

            int choice = GetCityOrStateChoice();
            Console.WriteLine("Enter name:");
            string value = Console.ReadLine();

            foreach (AddressBook book in addressBooks.Values)
            {
                if (choice == 1)
                {
                    book.ViewContactByCity(value);
                }
                else
                {
                    book.ViewContactByState(value);
                }
            }
        }

        // Search person in a city Or state
        public void SearchPersonByCityOrState()
        {
            Console.WriteLine("Enter First Last Name:");
            string[] arr = Console.ReadLine().Split(' ');

            if (arr.Length < 2) return;

            int choice = GetCityOrStateChoice();

            Console.WriteLine("Enter value:");
            string val = Console.ReadLine();

            foreach (AddressBook book in addressBooks.Values)
            {
                if (choice == 1 && book.SearchPersonByCity(arr[0], arr[1], val)) return;
                if (choice == 2 && book.SearchPersonByState(arr[0], arr[1], val)) return;
            }
            Console.WriteLine("Person not found.");
        }


        // method for get count of total number of persons by city or state
        public void CountPersonByCityOrState()
        {
            int choice = GetCityOrStateChoice();

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            int total = 0;
            foreach (AddressBook book in addressBooks.Values)
            {
                total += (choice == 1) ? book.CountByCity(name) : book.CountByState(name);
            }
            Console.WriteLine("Total Contacts: " + total);
        }

        // helper method for taking input for city or state choice
        private int GetCityOrStateChoice()
        {
            int choice;

            while (true)
            {
                Console.WriteLine("1. City\n2. State");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && (choice == 1 || choice == 2))
                    return choice;

                Console.WriteLine("Invalid input! Please enter 1 or 2.\n");
            }
        }

    }
}
