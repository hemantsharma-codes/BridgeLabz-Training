using System;

class InventorySinglyLinkedList
{
    // Node representing each inventory item
    class ItemNode
    {
        public string ItemName;
        public int ItemID;
        public int Quantity;
        public double Price;
        public ItemNode Next;

        public ItemNode(string name, int id, int quantity, double price)
        {
            ItemName = name;
            ItemID = id;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }

    static ItemNode head = null;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1 Add At Beginning");
            Console.WriteLine("2 Add At End");
            Console.WriteLine("3 Add At Position");
            Console.WriteLine("4 Remove By Item ID");
            Console.WriteLine("5 Update Quantity");
            Console.WriteLine("6 Search By Item ID");
            Console.WriteLine("7 Search By Item Name");
            Console.WriteLine("8 Display Inventory");
            Console.WriteLine("9 Calculate Total Value");
            Console.WriteLine("10 Sort By Name");
            Console.WriteLine("11 Sort By Price");
            Console.WriteLine("12 Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) AddAtBeginning();
            else if (choice == 2) AddAtEnd();
            else if (choice == 3) AddAtPosition();
            else if (choice == 4) RemoveByID();
            else if (choice == 5) UpdateQuantity();
            else if (choice == 6) SearchByID();
            else if (choice == 7) SearchByName();
            else if (choice == 8) DisplayInventory();
            else if (choice == 9) CalculateTotalValue();
            else if (choice == 10) SortByName();
            else if (choice == 11) SortByPrice();
            else if (choice == 12) break;
        }
    }

    // Create a new item node by taking user input
    static ItemNode CreateItem()
    {
        Console.WriteLine("Enter Item Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Item ID");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Quantity");
        int quantity = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Price");
        double price = double.Parse(Console.ReadLine());

        return new ItemNode(name, id, quantity, price);
    }

    static void AddAtBeginning()
    {
        ItemNode newNode = CreateItem();
        newNode.Next = head;
        head = newNode;
    }

    static void AddAtEnd()
    {
        ItemNode newNode = CreateItem();
        if (head == null)
        {
            head = newNode;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null) temp = temp.Next;
        temp.Next = newNode;
    }

    static void AddAtPosition()
    {
        Console.WriteLine("Enter Position");
        int pos = int.Parse(Console.ReadLine());
        if (pos <= 1)
        {
            AddAtBeginning();
            return;
        }

        ItemNode newNode = CreateItem();
        ItemNode temp = head;
        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Invalid Position");
            return;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    static void RemoveByID()
    {
        Console.WriteLine("Enter Item ID");
        int id = int.Parse(Console.ReadLine());
        if (head == null) return;

        if (head.ItemID == id)
        {
            head = head.Next;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemID != id)
            temp = temp.Next;

        if (temp.Next != null)
            temp.Next = temp.Next.Next;
    }

    static void UpdateQuantity()
    {
        Console.WriteLine("Enter Item ID");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter New Quantity");
        int qty = int.Parse(Console.ReadLine());

        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemID == id)
            {
                temp.Quantity = qty;
                return;
            }
            temp = temp.Next;
        }
    }

    static void SearchByID()
    {
        Console.WriteLine("Enter Item ID");
        int id = int.Parse(Console.ReadLine());
        ItemNode temp = head;

        while (temp != null)
        {
            if (temp.ItemID == id)
            {
                PrintItem(temp);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Item Not Found");
    }

    static void SearchByName()
    {
        Console.WriteLine("Enter Item Name");
        string name = Console.ReadLine();
        ItemNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.ItemName == name)
            {
                PrintItem(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found) Console.WriteLine("Item Not Found");
    }

    static void DisplayInventory()
    {
        ItemNode temp = head;
        while (temp != null)
        {
            PrintItem(temp);
            temp = temp.Next;
        }
    }

    static void CalculateTotalValue()
    {
        double total = 0;
        ItemNode temp = head;
        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value: " + total);
    }

    // Sort items by name ascending
    static void SortByName()
    {
        if (head == null) return;
        for (ItemNode i = head; i != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if (string.Compare(i.ItemName, j.ItemName) > 0)
                {
                    Swap(i, j);
                }
            }
        }
    }

    // Sort items by price ascending
    static void SortByPrice()
    {
        if (head == null) return;
        for (ItemNode i = head; i != null; i = i.Next)
        {
            for (ItemNode j = i.Next; j != null; j = j.Next)
            {
                if (i.Price > j.Price)
                {
                    Swap(i, j);
                }
            }
        }
    }

    // Swap values of two nodes
    static void Swap(ItemNode a, ItemNode b)
    {
        string tempName = a.ItemName;
        int tempID = a.ItemID;
        int tempQty = a.Quantity;
        double tempPrice = a.Price;

        a.ItemName = b.ItemName;
        a.ItemID = b.ItemID;
        a.Quantity = b.Quantity;
        a.Price = b.Price;

        b.ItemName = tempName;
        b.ItemID = tempID;
        b.Quantity = tempQty;
        b.Price = tempPrice;
    }

    // Print details of a single item
    static void PrintItem(ItemNode node)
    {
        Console.WriteLine(node.ItemID);
        Console.WriteLine(node.ItemName);
        Console.WriteLine(node.Quantity);
        Console.WriteLine(node.Price);
    }
}
