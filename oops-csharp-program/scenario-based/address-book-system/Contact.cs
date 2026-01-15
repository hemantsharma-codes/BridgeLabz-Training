using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class Contact
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private int ZipCode;
        private long PhoneNumber;
        private string EmailId;


        // Constructor
        public Contact(string firstName,string lastName,string address,string city,string state,int zipCode,long phoneNumber,string emailId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
            this.EmailId = emailId;
        }

        // getter and setter
        public string GetFirstName()
        {
            return this.FirstName;
        }
        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }
        public string GetLastName()
        {
            return this.LastName;
        }
        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }
        public string GetAddress()
        {
            return this.Address;
        }
        public void SetAddress(string address)
        {
            this.Address = address;
        }
        public string GetCity()
        {
            return this.City;
        }
        public void SetCity(string city)
        {
            this.City = city;
        }
        public string GetState()
        {
            return this.State;
        }
        public void SetState(string state)
        {
            this.State = state;
        }
        public int GetZipCode()
        {
            return this.ZipCode;
        }
        public void SetZipCode(int zipCode)
        {
            this.ZipCode = zipCode;
        }
        public long GetPhoneNumber()
        {
            return this.PhoneNumber;
        }
        public void SetPhoneNumber(long phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
        public string GetEmailId()
        {
            return this.EmailId;
        }
        public void SetEmailId(string emailId)
        {
            this.EmailId = emailId;
        }
    }
}
