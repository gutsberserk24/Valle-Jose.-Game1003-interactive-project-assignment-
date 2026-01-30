using System;

namespace JosesPizzeria
{
    class Program
    {
        static void Main()
        {
            // Start of program
            Console.WriteLine("Welcome to Jose's Pizzeria!");

            Console.Write("Please enter your name: ");
            string customerName = Console.ReadLine() ?? "";

            double money = 50.00;

            Console.WriteLine($"\nGood evening {customerName}.");
            Console.WriteLine($"You have ${money:F2} to spend.\n");

            // Pizza selection
            Console.WriteLine("Pizza Menu:");
            Console.WriteLine("1 - Pepperoni ($15.85)");
            Console.WriteLine("2 - Cheese ($10.00)");
            Console.WriteLine("3 - Anchovies ($23.45)");
            Console.WriteLine("4 - Chicken Barbecue ($35.67)");

            Console.Write("Choose a pizza (1-4): ");
            string pizzaInput = Console.ReadLine() ?? "";

            if (pizzaInput == "1")
            {
                money -= 15.85;
                Console.WriteLine("You ordered Pepperoni Pizza.");
            }
            else if (pizzaInput == "2")
            {
                money -= 10.00;
                Console.WriteLine("You ordered Cheese Pizza.");
            }
            else if (pizzaInput == "3")
            {
                money -= 23.45;
                Console.WriteLine("You ordered Anchovies Pizza.");
            }
            else if (pizzaInput == "4")
            {
                money -= 35.67;
                Console.WriteLine("You ordered Chicken Barbecue Pizza.");
            }
            else
            {
                Console.WriteLine("Invalid pizza choice.");
            }

            Console.WriteLine($"\nRemaining balance: ${money:F2}");

            // Drink selection (only if money remains)
            if (money > 0)
            {
                Console.WriteLine("\nDrink Menu:");
                Console.WriteLine("1 - Chocolate Milk ($5.00)");
                Console.WriteLine("2 - Beer ($7.00)");
                Console.WriteLine("3 - Orange Juice ($2.00)");

                Console.Write("Choose a drink (1-3): ");
                string drinkInput = Console.ReadLine() ?? "";

                if (drinkInput == "1")
                {
                    money -= 5.00;
                    Console.WriteLine("You ordered Chocolate Milk.");
                }
                else if (drinkInput == "2")
                {
                    money -= 7.00;
                    Console.WriteLine("You ordered Beer.");
                }
                else if (drinkInput == "3")
                {
                    money -= 2.00;
                    Console.WriteLine("You ordered Orange Juice.");
                }
                else
                {
                    Console.WriteLine("No drink selected.");
                }
            }

            // End condition
            Console.WriteLine($"\nFinal balance: ${money:F2}");

            if (money <= 0)
            {
                Console.WriteLine("You have no money left!.");
            }

            Console.WriteLine("Thank you for visiting Jose's Pizzeria!.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
















