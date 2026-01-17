namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FlashDealz
{
    internal class MergeSort
    {
        public ProductNode Sort(ProductNode head)
        {
            if (head == null || head.Next == null)
                return head;

            ProductNode middle = GetMiddle(head);
            ProductNode nextOfMiddle = middle.Next;
            middle.Next = null;

            ProductNode left = Sort(head);
            ProductNode right = Sort(nextOfMiddle);

            return MergeDescending(left, right);
        }

        // DESCENDING by DISCOUNT
        private ProductNode MergeDescending(ProductNode left, ProductNode right)
        {
            if (left == null)
                return right;
            if (right == null)
                return left;

            ProductNode result;

            if (left.ProductInformation.GetProductDiscount() >=
                right.ProductInformation.GetProductDiscount())
            {
                result = left;
                result.Next = MergeDescending(left.Next, right);
            }
            else
            {
                result = right;
                result.Next = MergeDescending(left, right.Next);
            }

            return result;
        }

        private ProductNode GetMiddle(ProductNode head)
        {
            if (head == null)
                return head;

            ProductNode slow = head;
            ProductNode fast = head.Next;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}
