using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.ParcelTracker
{
    internal class Parcel
    {
        private static int CountId;
        private int ParcelId;
        private string ParcelName;
        private StageNode Head;
        private StageNode Tail;
        private StageNode CurrentStageNode;

        static Parcel()
        {
            CountId = 0;
        }
        // constructor
        public Parcel(string name)
        {
            this.ParcelId = ++CountId;
            this.ParcelName = name;
            this.Head = null;
            this.Tail = null;
            this.CurrentStageNode = null;
        }

        // getters for every field
        public int GetParcelId()
        {
            return this.ParcelId;
        }
        public string GetParcelName()
        {
            return this.ParcelName;
        }
        public StageNode GetCurrentStageNode()
        {
            return this.CurrentStageNode;
        }

        // adding new stage
        public void Add(string status)
        {
            StageNode newStagetNode = new StageNode(status);
            if(Head == null)
            {
                Head = CurrentStageNode = Tail = newStagetNode;
                return;
            }
            Tail.Next = newStagetNode;
            Tail = Tail.Next;
            CurrentStageNode = newStagetNode;
        }

        // Display Parcel
        public void DisplayParcel()
        {
            StageNode temp = Head;

            Console.WriteLine("The Parcel Stages : \n");
            Console.WriteLine($"Parcel Id : {ParcelId}, Parcel Name : {ParcelName}");
            while (temp != null)
            {
                Console.Write($"{temp.Status}->");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }

        // get current stage
        public void GetCurrentStatus()
        {
            Console.WriteLine("Current Status : " +CurrentStageNode.Status);
        }

        public StageNode SearchStage(string status)
        {
            StageNode temp = Head;

            while (temp != null)
            {
                if (temp.Status.Equals(status))
                {
                    return temp;
                }
                temp = temp.Next;
            }

            return null;
        }


        //add middle funtion
        public void AddMiddle(StageNode prevNode, StageNode newNode)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Stage not found");
                return;
            }

            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;

            if (prevNode == Tail)
            {
                Tail = newNode;
            }
        }
    }
}
