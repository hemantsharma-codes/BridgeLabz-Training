using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.RailwayReservationSystem
{
    internal class RailwayManagerUtility : IRailwayManager
    {
        private int _capacityOfConfirmedList;
        private Passenger[] _confirmedTicketList;
        private int _currIdx;

        private WaitingList _waitingList;
        public RailwayManagerUtility()
        {
            this._capacityOfConfirmedList = 5;
            _confirmedTicketList = new Passenger[_capacityOfConfirmedList];
            _currIdx = 0;
            _waitingList = new WaitingList();
        }


        public void BookTicket()
        {
            Console.WriteLine("Enter the name of passenger");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age of passenger");
            int age = Convert.ToInt32(Console.ReadLine());

            // first check if confirmed seat list is empty then we will add passenger direclty in confirmed list

            if (_currIdx < _capacityOfConfirmedList)
            {
                Passenger newPassenger = new Passenger(name, age, true);
                _confirmedTicketList[_currIdx++] = newPassenger;
                Console.WriteLine("Your ticket has been confirmed..");
            }
            else
            {
                Passenger newPassenger = new Passenger(name, age, false);
                _waitingList.Enqueue(newPassenger);
                Console.WriteLine("You are in waiting list, please wait to confirm your seat");
            }
        }

        //public void CancelTicket()
        //{
        //    Console.WriteLine("Please enter your name : ");
        //    string name = Console.ReadLine();


        //}

        public void CheckStatus()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine().ToLower();

            Passenger currPassenger = SearchPassenger(name);

            if(currPassenger != null)
            {
                Console.WriteLine(currPassenger+"\t Status : Confirmed");
            }
            else
            {
                currPassenger = _waitingList.CheckStatus(name);
                if (currPassenger != null)
                {
                    Console.WriteLine(currPassenger+"\t Status : Not Confirmed");
                }
                else
                {
                    Console.WriteLine("Enter valid details...");
                }
            }

        }

        private Passenger SearchPassenger(string name)
        {
            for (int i = 0; i < _currIdx; i++)
            {
                Passenger currPassenger = _confirmedTicketList[i];

                if (currPassenger != null && currPassenger.GetName().ToLower().Equals(name))
                {
                    return currPassenger;
                }
            }
            return null;
        }

        
    }
}
