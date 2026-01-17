using System;
using System.Xml.Schema;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.FlashDealz
{
    internal class LinkedList
    {
        private ProductNode Head;
        private ProductNode Tail;
        private int Count;

        // default constructor
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        // getter and setter for head
        public ProductNode GetHead()
        {
            return Head;
        }

        public void SetHead(ProductNode head)
        {
            Head = head;

            // fix Tail after sorting
            ProductNode temp = Head;
            while (temp != null && temp.Next != null)
            {
                temp = temp.Next;
            }
            Tail = temp;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Add(Product product)
        {
            ProductNode newNode = new ProductNode(product);

            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }

            Count++;
        }

        public Product SearchProduct(string productName)
        {
            if (Head == null)
            {
                Console.WriteLine("Product list is empty...");
                return null;
            }

            ProductNode temp = Head;

            while (temp != null)
            {
                if (temp.ProductInformation
                        .GetProductName()
                        .Trim()
                        .ToLower()
                        .Equals(productName))
                {
                    return temp.ProductInformation;
                }

                temp = temp.Next;
            }

            return null;
        }

        public void DisplayList()
        {
            if (Head == null)
            {
                Console.WriteLine("Product list is empty...");
                return;
            }

            ProductNode temp = Head;

            while (temp != null)
            {
                Console.WriteLine(
                    $"Product Name : {temp.ProductInformation.GetProductName()}, " +
                    $"Product Rate : {temp.ProductInformation.GetProductRate()}, " +
                    $"Product Discount : {temp.ProductInformation.GetProductDiscount()}%, " +
                    $"Product Final Rate : {temp.ProductInformation.GetProductFinalRate()}"
                );

                temp = temp.Next;
            }
        }

        // sorting method
        public void SortByDiscountDescending()
        {
            MergeSort mergeSort = new MergeSort();
            Head = mergeSort.Sort(Head);
        }

    }
}
