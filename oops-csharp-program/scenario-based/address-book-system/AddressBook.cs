using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

        // edit contact by name
        public void EditContactByName()
        {
            Console.WriteLine("Enter the name you want to edit : ");
            string name = Console.ReadLine();

            string[] nameArr = name.Split(' ');
            string firstName = nameArr[0].ToLower();
            string lastName = nameArr[1].ToLower();
            bool isChanged = false;
            foreach(Contact contact in Contacts)
            {
                if(contact.GetFirstName().ToLower().Equals(firstName) && contact.GetLastName().ToLower().Equals(lastName))
                {
                    EditDetails(contact);
                    isChanged = true;

                    Console.WriteLine("Contact details has been edited succesfully.....");
                }
            }
            if (!isChanged)
            {
                Console.WriteLine(name + " contact is not present in the address book that you want to edit....");
            }

        }

        // utility methods
        public void EditDetails(Contact contact)
        {
            while (true)
            {
                Console.WriteLine("\n1. Edit first name");
                Console.WriteLine("2. Edit last name");
                Console.WriteLine("3. Edit address");
                Console.WriteLine("4. Edit city");
                Console.WriteLine("5. Edit state");
                Console.WriteLine("6. Edit zip code");
                Console.WriteLine("7. Edit phone number");
                Console.WriteLine("8. email id");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new firstName");
                        string firstName = Console.ReadLine();
                        contact.SetFirstName(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter new lastName");
                        string lastName = Console.ReadLine();
                        contact.SetLastName(lastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter new address");
                        string address = Console.ReadLine();
                        contact.SetAddress(address);
                        break;
                    case 4:
                        Console.WriteLine("Enter new city ");
                        string city = Console.ReadLine();
                        contact.SetCity(city);
                        break;
                    case 5:
                        Console.WriteLine("Enter new state ");
                        string state = Console.ReadLine();
                        contact.SetState(state);
                        break;
                    case 6:
                        Console.WriteLine("Enter new zip code");
                        int zipCode = Convert.ToInt32(Console.ReadLine());
                        contact.SetZipCode(zipCode);
                        break;
                    case 7:
                        Console.WriteLine("Enter new phone number");
                        long phoneNumber = Convert.ToInt64(Console.ReadLine());
                        contact.SetPhoneNumber(phoneNumber);
                        break;
                    case 8:
                        Console.WriteLine("Enter new email-id");
                        string emailId = Console.ReadLine();
                        contact.SetEmailId(emailId);
                        break;
                    case 0:
                        Console.WriteLine("Exiting....");
                        return;

                }
            }
        }

        public void DisplayAllContacts()
        {
            Console.WriteLine("====Details of all Contacts==========");
            for(int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                Console.WriteLine($"\nFirst Name : {contact.GetFirstName()}, Last Name : {contact.GetLastName()}," +
                    $" Address : {contact.GetAddress()}, City : {contact.GetCity()}, State : {contact.GetState()}," +
                    $" ZipCode : {contact.GetZipCode()}, PhoneNumber : {contact.GetPhoneNumber()}, EmailId : {contact.GetEmailId()}");
            }
        }
    }
}
