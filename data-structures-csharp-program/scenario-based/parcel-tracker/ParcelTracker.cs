using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.ParcelTracker
{
    internal class ParcelTracker : IParcelTracker
    {
        private Parcel[] Parcels;
        private int MaxSize;
        private int CurrentIdx;
        private Parcel parcel;
        private StageNode Stage;

        // constructor
        public ParcelTracker(int size)
        {
            this.MaxSize = size;
            Parcels = new Parcel[MaxSize];
            CurrentIdx = 0;
        }


        // Add new Parcel method
        public void AddParcel()
        {
            Console.WriteLine("Enter the name of the parcel : ");
            string parcel = Console.ReadLine();

            Parcel newParcel = new Parcel(parcel);

            if(newParcel != null)
            {
                Parcels[CurrentIdx++] = newParcel;
                Console.WriteLine("Parcel has been added successfully....");
            }
            else
            {
                Console.WriteLine("Please enter the valid details of parcel...");
            }
        }


        // Add new stage method
        public void AddStage()
        {
            Console.WriteLine("Enter id of the Parcel");
            int parcelId = Convert.ToInt32(Console.ReadLine());

            bool isAdded = false;

            for(int i= 0;i < CurrentIdx;i++){

                Parcel parcel = Parcels[i];

                if (parcel.GetParcelId() == parcelId)
                {
                    Console.WriteLine("Enter the name of stage");
                    string stageName = Console.ReadLine();

                    parcel.Add(stageName);
                    isAdded = true;

                    Console.WriteLine("New stage added succesfully..");
                }
            }
            if (!isAdded)
            {
                Console.WriteLine("Please enter the valid parcel id");
            }
        }

        // Track Stage method
        public void TrackStage()
        {
            Console.WriteLine("Enter the id of parcel");
            int parcelId = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<CurrentIdx;i++)
            {
                Parcel parcel = Parcels[i];
                if (parcel.GetParcelId() == parcelId)
                {
                    parcel.DisplayParcel();
                }
            }
        }

        // get Current status of the method
        public void GetCurrentStatus()
        {
            Console.WriteLine("Enter the id of parcel");
            int parcelId = Convert.ToInt32(Console.ReadLine());

            for (int i=0;i<CurrentIdx;i++)
            {
                Parcel parcel = Parcels[i];
                if (parcel.GetParcelId() == parcelId)
                {
                    parcel.GetCurrentStatus();
                }
            }
        }


        // method for adding custom intermediate node
        public void AddCustomIntermediateCheckPoint()
        {
            Console.WriteLine("Enter the id of the Parcel");
            int parcelId = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < CurrentIdx; i++)
            {
                Parcel parcel = Parcels[i];

                if (parcel != null && parcel.GetParcelId() == parcelId)
                {
                    Console.WriteLine("Enter existing stage name (after which to insert): ");
                    string existingStage = Console.ReadLine();

                    StageNode prevStage = parcel.SearchStage(existingStage);

                    Console.WriteLine("Enter new stage name: ");
                    string newStageName = Console.ReadLine();

                    StageNode newStage = new StageNode(newStageName);
                    parcel.AddMiddle(prevStage, newStage);

                    Console.WriteLine("Custom checkpoint added successfully");
                    return;
                }
            }

            Console.WriteLine("Parcel not found");
        }


        // method for displaying all parcels

        public void DisplayAllParcel()
        {
            for(int i = 0; i < CurrentIdx; i++)
            {
                Console.WriteLine();
                Parcel parcel = Parcels[i];
                parcel.DisplayParcel();
            }
        }
    }
}
