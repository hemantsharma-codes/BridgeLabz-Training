using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    class BrowserBuddyMenu
    {
        private Browser browser = new Browser();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n--- BrowserBuddy Menu ---");
                Console.WriteLine("1. Create Tab");
                Console.WriteLine("2. List Tabs");
                Console.WriteLine("3. Switch Tab");
                Console.WriteLine("4. Close Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Visit New Page");
                Console.WriteLine("7. Back");
                Console.WriteLine("8. Forward");
                Console.WriteLine("9. Show Current Page");
                Console.WriteLine("0. Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: browser.CreateATab(); break;
                    case 2: browser.ListAllTabs(); break;
                    case 3: browser.SwitchTab(); break;
                    case 4: browser.CloseTab(); break;
                    case 5: browser.RestoredClosedTab(); break;

                    case 6:
                        Tab tab = browser.GetCurrentTab();
                        if (tab != null)
                        {
                            Console.Write("Title: ");
                            string title = Console.ReadLine();
                            Console.Write("URL: ");
                            string url = Console.ReadLine();
                            tab.VisitNewPage(title, url);
                        }
                        else Console.WriteLine("No active tab.");
                        break;

                    case 7:
                        browser.GetCurrentTab()?.GoToPreviousPage();
                        break;

                    case 8:
                        browser.GetCurrentTab()?.GoToNextPage();
                        break;

                    case 9:
                        browser.GetCurrentTab()?.DisplayCurrentPage();
                        break;

                    case 0:
                        return;
                }
            }
        }
    }

}
