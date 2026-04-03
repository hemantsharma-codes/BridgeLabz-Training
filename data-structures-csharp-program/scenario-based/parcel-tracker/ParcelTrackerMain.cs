using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.ParcelTracker
{
    internal class ParcelTrackerMain
    {
        static void Main(string[] args)
        {
            ParcelTrackerMenu menu = new ParcelTrackerMenu();
            menu.Run();
        }

    }
}
