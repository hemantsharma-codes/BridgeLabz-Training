using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBook : IAddressBook
    {
        private string name;
        private List<Contact> Contacts;

        public AddressBook(string name)
        {
            this.name = name;
            Contacts = new List<Contact>();
        }

        public string GetName()
        {
            return name;
        }

        // Add new contact
        public void AddContact()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            if (CheckDuplicate(firstName, lastName))
            {
                throw new BusinessException(BusinessErrorCode.DuplicateContact, "Contact already exists");
            }

            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code:");
            string zipCode = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            string emailId = Console.ReadLine();

            Contact contact = new Contact(firstName, lastName, address, city, state, zipCode, phoneNumber, emailId);
            Validate(contact);

            Contacts.Add(contact);
            Console.WriteLine("Contact Added Successfully!");
        }

        private bool CheckDuplicate(string firstName, string lastName)
        {
            foreach (Contact contact in Contacts)
            {
                if (contact.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                    contact.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public void EditContactByName()
        {
            Console.WriteLine("Enter full name:");
            string[] arr = Console.ReadLine().Split(' ');
            if (arr.Length < 2) return;

            foreach (Contact contact in Contacts)
            {
                if (contact.GetFirstName().Equals(arr[0], StringComparison.OrdinalIgnoreCase) &&
                    contact.GetLastName().Equals(arr[1], StringComparison.OrdinalIgnoreCase))
                {
                    EditDetails(contact);
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter full name:");
            string[] arr = Console.ReadLine().Split(' ');
            if (arr.Length < 2) return;

            for (int i = 0; i < Contacts.Count; i++)
            {
                Contact c = Contacts[i];
                if (c.GetFirstName().Equals(arr[0], StringComparison.OrdinalIgnoreCase) &&
                    c.GetLastName().Equals(arr[1], StringComparison.OrdinalIgnoreCase))
                {
                    Contacts.RemoveAt(i);
                    Console.WriteLine("Contact Deleted.");
                    return;
                }
            }
            throw new BusinessException(BusinessErrorCode.ContactNotFound, "Contact does not exist");
        }

        // Bubble Sort (manual)
        public void SortContactsByName()
        {
            for (int i = 0; i < Contacts.Count - 1; i++)
            {
                for (int j = 0; j < Contacts.Count - i - 1; j++)
                {
                    string name1 = Contacts[j].GetFirstName() + Contacts[j].GetLastName();
                    string name2 = Contacts[j + 1].GetFirstName() + Contacts[j + 1].GetLastName();

                    if (string.Compare(name1, name2, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Contact temp = Contacts[j];
                        Contacts[j] = Contacts[j + 1];
                        Contacts[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Contacts Sorted.");
        }

        public void DisplayAllContacts()
        {
            if (Contacts.Count == 0)
            {
                Console.WriteLine("Address Book is empty.");
                return;
            }

            foreach (Contact contact in Contacts)
            {
                Console.WriteLine(contact);
                Console.WriteLine("--------------------------------");
            }
        }

        public void ViewContactByCity(string city)
        {
            foreach (Contact c in Contacts)
            {
                if (c.GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine(c);
            }
        }

        public void ViewContactByState(string state)
        {
            foreach (Contact c in Contacts)
            {
                if (c.GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine(c);
            }
        }

        public bool SearchPersonByCity(string f, string l, string city)
        {
            foreach (Contact c in Contacts)
            {
                if (c.GetFirstName().Equals(f, StringComparison.OrdinalIgnoreCase) &&
                    c.GetLastName().Equals(l, StringComparison.OrdinalIgnoreCase) &&
                    c.GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(c);
                    return true;
                }
            }
            return false;
        }

        public bool SearchPersonByState(string f, string l, string state)
        {
            foreach (Contact c in Contacts)
            {
                if (c.GetFirstName().Equals(f, StringComparison.OrdinalIgnoreCase) &&
                    c.GetLastName().Equals(l, StringComparison.OrdinalIgnoreCase) &&
                    c.GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(c);
                    return true;
                }
            }
            return false;
        }

        public int CountByCity(string city)
        {
            int count = 0;
            foreach (Contact c in Contacts)
                if (c.GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                    count++;
            return count;
            }

        public int CountByState(string state)
        {
            int count = 0;
            foreach (Contact c in Contacts)
                if (c.GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                    count++;
            return count;
        }

        private void EditDetails(Contact contact)
        {
            Console.WriteLine("Editing contact...");
        }


        // validation logic for custom attribute and built-in attribute
        private static void Validate(object obj)
        {
            Type type = obj.GetType();

            // get all private instance fields
            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                string value = field.GetValue(obj)?.ToString();

                // Built-in Required
                var required = field.GetCustomAttribute<RequiredAttribute>();
                if (required != null && string.IsNullOrWhiteSpace(value))
                {
                    throw new BusinessException(
                        BusinessErrorCode.ValidationFailed,
                        $"{field.Name} is required"
                    );
                }

                // Custom validation attributes
                var customAttributes = field.GetCustomAttributes<CustomValidationAttribute>();
                foreach (var attr in customAttributes)
                {
                    if (!attr.IsValid(value))
                    {
                        throw new BusinessException(
                            BusinessErrorCode.ValidationFailed,
                            attr.ErrorMessage
                        );
                    }
                }
            }
        }

    }
}
