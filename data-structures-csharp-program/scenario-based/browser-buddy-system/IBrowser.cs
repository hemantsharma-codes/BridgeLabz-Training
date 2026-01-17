using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    internal interface IBrowser
    {
        void ListAllTabs();
        void CreateATab();
        void SwitchTab();
        void CloseTab();
        void RestoredClosedTab();

    }
}
