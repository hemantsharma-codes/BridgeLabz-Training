using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    internal interface ITab
    {   
        void GoToPreviousPage();
        void GoToNextPage();
        void VisitNewPage(string title,string url);
        void DisplayCurrentPage();
    }
}
