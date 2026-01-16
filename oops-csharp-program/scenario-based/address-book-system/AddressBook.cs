using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBook : IAddressBook
    {
        // declaration of array of Contact to store the all contact
        private readonly Contact[] Contacts;
        private readonly int MaxSizeContacts;
        private int CurrentIdx;

        // constructor
        public AddressBook(int maxSize)
        {
            MaxSizeContacts = maxSize;
            Contacts = new Contact[MaxSizeContacts];
            CurrentIdx = 0;
        }


        public void AddContact()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code:");
            int zipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number:");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Email:");
            string emailId = Console.ReadLine();

            Contact contact = new Contact(firstName, lastName, address,
                                          city, state, zipCode,
                                          phoneNumber, emailId);

            if(CurrentIdx == MaxSizeContacts)
            {
                Console.WriteLine("The Address Book is full, you can't add any more contacts in this address book...");
            }
            else
            {
                if(contact != null)
                {
                    Contacts[CurrentIdx++] = contact;
                    Console.WriteLine("Contact Added Successfully!");
                }
            }
        }
    }
}
