using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.ParcelTracker
{
    internal class StageNode
    {
        public string Status;
        public StageNode Next;

        public StageNode(string status)
        {
            this.Status = status;
        }
    }
}
