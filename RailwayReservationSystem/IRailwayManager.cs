using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.RailwayReservationSystem
{
    internal interface IRailwayManager
    {
        void BookTicket();
        void CheckStatus();

        //void Cancelticket();
    }
}
