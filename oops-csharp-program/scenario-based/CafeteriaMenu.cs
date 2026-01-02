using System;
class CafeteriaMenu{
    // Array to store 10 fixed items
    static string[] menuItems = new string[]{
        "Tea",
        "Coffee",
        "Sandwich",
        "Burger",
        "Pizza",
        "Pasta",
        "Samosa",
        "Noodles",
        "Cold Drink",
        "Ice Cream"
    };

    static void Main(){
        DisplayMenu();

        Console.Write("\nEnter item index to order: ");
        int index = int.Parse(Console.ReadLine());
        string selectedItem = GetItemByIndex(index);
        if (selectedItem != null){
            Console.WriteLine("You have ordered: "+selectedItem);
        }else{
            Console.WriteLine("Invalid index! Please select a valid menu item.");
        }
    }

    // Method to display menu
    static void DisplayMenu(){
        Console.WriteLine("📋 Cafeteria Menu");
        for (int i = 0; i < menuItems.Length; i++){
            Console.WriteLine(i+": "+menuItems[i]);
        }
    }

    // Method to get item by index
    static string GetItemByIndex(int index){
        if (index >= 0 && index < menuItems.Length){
            return menuItems[index];
        }
        return null;
    }
}

