using System;
using System.Collections.Generic;

namespace task1
{
    public class CLIMenu
    {
        List<string> shoppingList = new List<string>(); // List to store shopping items
        List<decimal> prices = new List<decimal>(); // List to store item prices

        // Method to display the home screen
        public void CLIHomeScreen()
        {
            Console.WriteLine("=== Shopping List ===");
            Console.WriteLine();
        }

        // Method to display all shopping items
        public void CLIShow()
        {
            Console.WriteLine("=== Shopping List ===");
            Console.WriteLine("Items in your shopping list:");
            Console.WriteLine();

            if (shoppingList.Count == 0)
            {
                Console.WriteLine("Your shopping list is empty.");
            }
            else
            {
                decimal total = 0;
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {shoppingList[i]} - £{prices[i]}"); // Print each item with price and a number
                    total += prices[i]; // Calculate the total price
                }
                Console.WriteLine();
                Console.WriteLine($"Total price: £{total}"); // Display the total price
            }

            Console.WriteLine();
        }

        // Method to add a new item to the shopping list
        public void CLIAdd()
        {
            Console.WriteLine("Enter the item you would like to add: ");
            string addItem = Console.ReadLine(); // Read input from user

            Console.WriteLine("Enter the price for the item (in the format £x.xx): ");
            string priceInput = Console.ReadLine(); // Read price input from user

            decimal price;

            if (decimal.TryParse(priceInput.Replace("£", ""), out price))
            {
                shoppingList.Add(addItem); // Add the item to the shopping list
                prices.Add(price); // Add the price to the prices list
                Console.WriteLine("Item added to the shopping list.");
            }
            else
            {
                Console.WriteLine("Invalid price format. Item not added to the shopping list.");
            }

            Console.WriteLine();
        }

        // Method to search for a specific item in the shopping list
        public void CLISearch()
        {
            Console.WriteLine("Enter the item you would like to find: ");
            string searchedItem = Console.ReadLine(); // Read input from user
            bool foundItem = false;

            Console.WriteLine("Search results:");
            Console.WriteLine();

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].Contains(searchedItem)) // Check if the item contains the searched word
                {
                    Console.WriteLine($"{i + 1}. {shoppingList[i]} - £{prices[i]}"); // Print the item with price and a number if it's found
                    foundItem = true;
                }
            }

            if (!foundItem)
            {
                Console.WriteLine("No matching items found in the shopping list."); // Print a message if no items are found
            }

            Console.WriteLine();
        }

        // Method to quit the program
        public void CLIQuit()
        {
            Console.WriteLine("Exiting the shopping list application...");
            System.Environment.Exit(0); // Exit the program
        }
    }

    class Task1
    {
        static void Main()
        {
            CLIMenu cli = new CLIMenu(); // Create an instance of CLIMenu

            cli.CLIHomeScreen(); // Display the home screen initially

            while (true)
            {
                Console.WriteLine("What action you would like to do?  Add, Search, Show or Quit: ");
                string action = Console.ReadLine(); // Read user's action
                action = action.ToLower(); // Convert the action to lowercase for case-insensitive comparison

                switch (action)
                {
                    case "show":
                        cli.CLIShow(); // Call CLIShow method to display the shopping items
                        break;

                    case "add":
                        cli.CLIAdd(); // Call CLIAdd method to add a new item to the shopping list
                        break;

                    case "search":
                        cli.CLISearch(); // Call CLISearch method to search for a specific item in the shopping list
                        break;

                    case "quit":
                        cli.CLIQuit(); // Call CLIQuit method to quit the program
                        break;

                    default:
                        Console.WriteLine("Invalid action. Please try again."); // Print a message for incorrect input
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
