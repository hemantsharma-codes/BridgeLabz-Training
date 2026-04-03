using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    class TabSinglyLinkedList
    {
        private class TabNode
        {
            public Tab tab;
            public TabNode next;

            public TabNode(Tab tab)
            {
                this.tab = tab;
                next = null;
            }
        }

        private TabNode head;

        public void AddTab(Tab tab)
        {
            TabNode newNode = new TabNode(tab);

            if (head == null)
            {
                head = newNode;
                return;
            }

            TabNode temp = head;
            while (temp.next != null)
                temp = temp.next;

            temp.next = newNode;
        }

        public void DisplayTabs()
        {
            TabNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.tab.GetTabName());
                temp = temp.next;
            }
        }

        public Tab FindTab(string tabName)
        {
            TabNode temp = head;
            while (temp != null)
            {
                if (temp.tab.GetTabName() == tabName)
                    return temp.tab;

                temp = temp.next;
            }
            return null;
        }

        public void RemoveTab(string tabName)
        {
            if (head == null) return;

            if (head.tab.GetTabName() == tabName)
            {
                head = head.next;
                return;
            }

            TabNode prev = head;
            TabNode curr = head.next;

            while (curr != null)
            {
                if (curr.tab.GetTabName() == tabName)
                {
                    prev.next = curr.next;
                    return;
                }
                prev = curr;
                curr = curr.next;
            }
        }
    }

}
