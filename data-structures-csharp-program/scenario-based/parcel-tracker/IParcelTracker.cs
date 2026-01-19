using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.ParcelTracker
{
    internal interface IParcelTracker
    {
        void AddParcel();
        void AddStage();
        void TrackStage();
        void GetCurrentStatus();
        void AddCustomIntermediateCheckPoint();
        void DisplayAllParcel();
    }
}
