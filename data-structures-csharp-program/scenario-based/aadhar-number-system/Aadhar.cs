using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.SortAdhar
{
    internal class Aadhar
    {
        private string _name;
        private string _address;
        private string _adharNumber;

        public Aadhar(string name,string address,string adharNumber)
        {
            this._name = name;
            this._address = address;
            this._adharNumber = adharNumber;
        }
        // getter for every field
        public string GetName()
        {
            return this._name;
        }
        public string GetAddress()
        {
            return this._address;
        }
        public string GetAdharNumber()
        {
            return this._adharNumber;
        }


        public override string ToString()
        {
            return $"Name : {_name}\nAddress : {_address}\nAdhar Number : {_adharNumber}";
        }
    }
}
