using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Review.RailwayReservationSystem
{
    internal class Passenger
    {
        private string _name;
        private int _age;
        private bool _status;

        public Passenger() { }
        public Passenger(string name, int age,bool status)
        {
            this._name = name;
            this._age = age;
            this._status = status;
        }
        public string GetName()
        {
            return this._name;
        }

        public int GetAge()
        {
            return this._age;
        }
        public bool GetStatus()
        {
            return this._status;
        }
        public void SetStatus(bool status)
        {
            this._status = status;
        }
        public override string ToString()
        {
            return $"\tName : {_name}\tAge : {_age}";
        }
    }
}
