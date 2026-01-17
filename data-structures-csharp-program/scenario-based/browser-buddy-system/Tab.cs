using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    class Tab : ITab
    {
        private string tabName;
        private PageDoublyLinkedList pages;

        public Tab(string name)
        {
            tabName = name;
            pages = new PageDoublyLinkedList();
        }

        // ✅ Proper Getter
        public string GetTabName()
        {
            return tabName;
        }

        public void VisitNewPage(string title, string url)
        {
            pages.AddPage(new Page(title, url));
        }

        public void GoToPreviousPage()
        {
            pages.GoBack();
        }

        public void GoToNextPage()
        {
            pages.GoForward();
        }

        public void DisplayCurrentPage()
        {
            pages.DisplayCurrentPage();
        }

        public void PrintHistory()
        {
            pages.PrintAllPages();
        }
    }

}
