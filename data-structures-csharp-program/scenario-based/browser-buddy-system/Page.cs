using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    internal class Page
    {
        private string Title;
        private string Url;
        private DateTime VisitedAt;

        public Page(string title,string url)
        {
            this.Title = title;
            this.Url = url;
            VisitedAt = DateTime.Now;
        }

        // getter for each fields
        public string GetTitle()
        {
            return this.Title;
        }
        public string GetUrl()
        {
            return this.Url;
        }
        public DateTime GetVisitedAt()
        {
            return this.VisitedAt;
        }
        public void Display()
        {
            Console.WriteLine($"Title: {Title}, URL: {Url}, Visited At: {VisitedAt}");
        }
    }
}
