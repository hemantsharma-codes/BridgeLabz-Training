using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.ParcelTracker
{
    sealed class ParcelTrackerMenu
    {
        private IParcelTracker Tracker;

        public ParcelTrackerMenu()
        {
            Tracker = new ParcelTracker(10);
        }
        public void Run()
        {

            Console.WriteLine("==========Parcel Tracker==========\n");

            while (true)
            {
                Console.WriteLine("\n1. Add Parcel");
                Console.WriteLine("2. Add Stage");
                Console.WriteLine("3. Track Parcel");
                Console.WriteLine("4. Get Current Status");
                Console.WriteLine("5. Add Custom CheckPoint");
                Console.WriteLine("6. Display all parcels");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Tracker.AddParcel();
                        break;
                    case 2:
                        Tracker.AddStage();
                        break;
                    case 3:
                        Tracker.TrackStage();
                        break;
                    case 4:
                        Tracker.GetCurrentStatus();
                        break;
                    case 5:
                        Tracker.AddCustomIntermediateCheckPoint();
                        break;
                    case 6:
                        Tracker.DisplayAllParcel();
                        break;
                    case 0:
                        Console.WriteLine("Exiting.....");
                        return;
                    default:
                        Console.WriteLine("Enter the valid choice");
                        break;
                }
            }
        }
    }
}
