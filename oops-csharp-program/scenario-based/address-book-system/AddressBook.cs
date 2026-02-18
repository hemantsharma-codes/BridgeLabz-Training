using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBook : IAddressBook
    {
        // declaration of array of Contact to store the all contact
        private string name;
        private readonly Contact[] Contacts;
        private readonly int MaxSizeContacts;
        private int CurrentIdx;

        // constructor
        public AddressBook(string name,int maxSize)
        {
            this.name = name;
            MaxSizeContacts = maxSize;
            Contacts = new Contact[MaxSizeContacts];
            CurrentIdx = 0;
        }

        public string GetName()
        {
            return this.name;
        }

        // add new contact
        public void AddContact()
        {  
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            bool isPresent = CheckDuplicate(firstName.ToLower(), lastName.ToLower());

            if (isPresent)
            {
                Console.WriteLine(firstName+" "+lastName+" is already present in address book.");
                return;
            }

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

        // check contact duplication every time when you are adding new contact
        private bool CheckDuplicate(string firstName,string lastName)
        {
            for(int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if(contact != null && contact.GetFirstName().ToLower().Equals(firstName) && contact.GetLastName().ToLower().Equals(lastName))
                {
                    return true;
                }
            }
            return false;
        }

        // edit contact by name
        public void EditContactByName()
        {
            Console.WriteLine("Enter the name full name that you want to edit : ");
            string name = Console.ReadLine();

            string[] nameArr = name.Split(' ');
            if(nameArr.Length < 2)
            {
                Console.WriteLine("Please enter both first and last name.");
                return;
            }

            string firstName = nameArr[0].ToLower();
            string lastName = nameArr[1].ToLower();
            bool isChanged = false;
            foreach(Contact contact in Contacts)
            {
                if(contact != null && contact.GetFirstName().ToLower().Equals(firstName) && contact.GetLastName().ToLower().Equals(lastName))
                {
                    EditDetails(contact);
                    isChanged = true;

                    Console.WriteLine("Contact details has been edited succesfully.....");
                    return;
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
            // if Contact array is empty and we are trying to edit details
            if(CurrentIdx == 0)
            {
                Console.WriteLine("Address book is empty...");
                return;
            }
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

        // delete contact by person name
        public void DeleteContact()
        {
            Console.WriteLine("Enter the person name for whom you want to delete contact");
            string personName = Console.ReadLine();

            string[] personArr = personName.Split(' ');
            if (personArr.Length < 2)
            {
                Console.WriteLine("Please enter both first and last name.");
                return;
            }

            string firstName = personArr[0].ToLower();
            string lastName = personArr[1].ToLower();

            if (CurrentIdx == 0)
            {
                Console.WriteLine("Address Book is empty.");
                return;
            }

            int personIdx = -1;
            for (int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if (contact != null && contact.GetFirstName().ToLower().Equals(firstName) && contact.GetLastName().ToLower().Equals(lastName))
                {
                    personIdx = i;
                    break;
                }
            }

            if (personIdx == -1)
            {
                Console.WriteLine($"Contact '{firstName} {lastName}' not found.");
                return;
            }

            // Shift contacts to remove the deleted one
            for (int i = personIdx; i < CurrentIdx - 1; i++)
            {
                Contacts[i] = Contacts[i + 1];
            }
            Contacts[CurrentIdx - 1] = null; // clear last duplicate
            CurrentIdx--;

            Console.WriteLine($"Contact '{firstName} {lastName}' has been removed from the address book.");
        }

        // helper logic for displaying address book
        public void DisplayAllContacts()
        {
            Console.WriteLine("\n====Details of all Contacts==========\n");

            // if address book is empty and we are trying to display details
            if (CurrentIdx == 0)
            {
                Console.WriteLine("Address book is empty....");
                return;
            }

            for (int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if(contact != null)
                {
                    Console.WriteLine(contact);
                }
            }
        }

        // view contact by city name
        public void ViewContactByCity(string cityName)
        { 
            for(int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if (contact.GetCity().Equals(cityName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n"+contact);
                }
            }
        }

        // view contact by state name
        public void ViewContactByState(string stateName)
        {

            for (int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if (contact.GetState().Equals(stateName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n"+contact);
                }
            }
        }
        // search person by name and city
        public bool SearchPersonByCity(string firstName, string lastName, string city)
        {
            for (int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if (contact != null &&
                    contact.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contact.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                    contact.GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nFound in Address Book: " + name);
                    Console.WriteLine(contact);
                    return true;
                }
            }
            return false;
        }

        // search person by name and state
        public bool SearchPersonByState(string firstName, string lastName, string state)
        {
            for (int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if (contact != null &&
                    contact.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contact.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                    contact.GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nFound in Address Book: " + name);
                    Console.WriteLine(contact);
                    return true;
                }
            }
            return false;
        }

        // count contacts by city
        public int CountByCity(string cityName)
        {
            int count = 0;

            for (int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if (contact != null &&
                    contact.GetCity().Equals(cityName, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }

        // count contacts by state
        public int CountByState(string stateName)
        {
            int count = 0;

            for (int i = 0; i < CurrentIdx; i++)
            {
                Contact contact = Contacts[i];
                if (contact != null &&
                    contact.GetState().Equals(stateName, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }

    }
}