using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.RailwayReservationSystem
{
    internal class WaitingList
    {
        private int _capacityOfWaitingList;
        private Passenger[] _passengersWaitingList;
        private int _currIdx;

        public WaitingList()
        {
            this._capacityOfWaitingList = 10;
            _passengersWaitingList = new Passenger[_capacityOfWaitingList];
            _currIdx = 0;
        }

        public void Enqueue(Passenger passenger)
        {
            if(_currIdx == _capacityOfWaitingList)
            {
                Console.WriteLine("Waiting list is Overflow");
                return;
            }
            _passengersWaitingList[_currIdx++] = passenger;
            SortBasedOnAge();
        }

        public Passenger Dequeue()
        {
            if(_currIdx == 0)
            {
                Console.WriteLine("Waiting list is empty");
                return null;
            }
            Passenger passenger = _passengersWaitingList[_currIdx - 1];
            _currIdx = _currIdx - 1;
            return passenger;
        }

        public Passenger Peek()
        {
            if(_currIdx == 0)
            {
                Console.WriteLine("Waiting list is empty");
                return null;
            }
           return _passengersWaitingList[_currIdx - 1];
        }
        public int Count()
        {
            return _currIdx;
        }


        private void SortBasedOnAge()
        {
            for(int i = 0; i < _currIdx-1; i++)
            {
                for(int j = 0; j < _currIdx - i - 1; j++)
                {
                    if (_passengersWaitingList[j].GetAge() < _passengersWaitingList[j + 1].GetAge())
                    {
                        Passenger temp = _passengersWaitingList[j];
                        _passengersWaitingList[j] = _passengersWaitingList[j + 1];
                        _passengersWaitingList[j + 1] = temp;
                    }
                }
            }
        }

        public Passenger CheckStatus(string name)
        {
            Passenger currPassenger = SearchPassenger(name);
            return currPassenger;
        }

        public Passenger SearchPassenger(string name)
        {
            for(int i = 0; i < _currIdx; i++)
            {
                Passenger currPassenger = _passengersWaitingList[i];

                if(currPassenger != null && currPassenger.GetName().ToLower().Equals(name))
                {
                    return currPassenger;
                }
            }

            return null;
        }
    }
}
