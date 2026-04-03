using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.BrowserBuddySystem
{
    class TabStack
    {
        // 🔒 Private Node class
        private class StackNode
        {
            public Tab tab;
            public StackNode next;

            public StackNode(Tab tab)
            {
                this.tab = tab;
                next = null;
            }
        }

        private StackNode top;

        public void Push(Tab tab)
        {
            StackNode node = new StackNode(tab);
            node.next = top;
            top = node;
        }

        public Tab Pop()
        {
            if (top == null)
                return null;

            Tab tab = top.tab;
            top = top.next;
            return tab;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public Tab Peek()
        {
            if (top == null)
                return null;

            return top.tab;
        }
    }

}
