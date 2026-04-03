using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    class Browser : IBrowser
    {
        private TabSinglyLinkedList openTabs = new TabSinglyLinkedList();
        private TabStack closedTabs = new TabStack();
        private Tab currentTab;

        public void CreateATab()
        {
            Console.Write("Enter tab name: ");
            string name = Console.ReadLine();

            Tab tab = new Tab(name);
            openTabs.AddTab(tab);
            currentTab = tab;

            Console.WriteLine("Tab created & switched.");
        }

        public void ListAllTabs()
        {
            openTabs.DisplayTabs();
        }

        public void SwitchTab()
        {
            Console.Write("Enter tab name: ");
            string name = Console.ReadLine();

            Tab tab = openTabs.FindTab(name);
            if (tab != null)
            {
                currentTab = tab;
                Console.WriteLine("Switched to tab: " + name);
            }
            else
            {
                Console.WriteLine("Tab not found.");
            }
        }

        public void CloseTab()
        {
            if (currentTab == null)
            {
                Console.WriteLine("No active tab.");
                return;
            }

            closedTabs.Push(currentTab);
            openTabs.RemoveTab(currentTab.GetTabName());
            Console.WriteLine("Tab closed.");
            currentTab = null;
        }

        public void RestoredClosedTab()
        {
            if (closedTabs.IsEmpty())
            {
                Console.WriteLine("No closed tabs.");
                return;
            }

            Tab tab = closedTabs.Pop();
            openTabs.AddTab(tab);
            currentTab = tab;
            Console.WriteLine("Tab restored.");
        }

        // 🔥 Extra helper
        public Tab GetCurrentTab()
        {
            return currentTab;
        }
    }

}
