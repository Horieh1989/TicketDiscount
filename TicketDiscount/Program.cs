
using System;
namespace TicketDiscount

{
    class Program
    {
        static void Main()
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                // Display the main menu options.
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Check Youth or Senior Discount");
                Console.WriteLine("2. Calculate Group Ticket Prices");
                Console.WriteLine("3. Repeat Text 10 Times");
                Console.WriteLine("4. Find the Third Word");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CheckDiscount();
                        break;
                    case "2":
                        CalculateGroupTicketPrices();
                        break;
                    case "3":
                        RepeatTextTenTimes();
                        break;
                    case "4":
                        FindThirdWord();
                        break;
                    case "0":
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static void CheckDiscount()
        {
            // Prompt the user to enter their age.
            Console.Write("Enter age: ");

            // Read the age input from the user and convert it to an integer.
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                // Check if the person qualifies for a discount based on age.
                if (age < 20)
                {
                    Console.WriteLine("Youth Discount: $80");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Senior Discount: $90");
                }
                else
                {
                    Console.WriteLine("Standard Price: $120");
                }
            }
            else
            {
                // Handle invalid age input.
                Console.WriteLine("Invalid age input. Please enter a valid number.");
            }
        }

        static void CalculateGroupTicketPrices()
        {
            // Prompt the user to enter the number of people in the group.
            Console.Write("Enter the number of people: ");

            // Read the number of people input from the user and convert it to an integer.
            if (int.TryParse(Console.ReadLine(), out int numPeople))
            {
                double totalCost = 0;

                // Loop through each person in the group.
                for (int i = 1; i <= numPeople; i++)
                {
                    // Prompt the user to enter the age of each person.
                    Console.Write($"Enter age of person {i}: ");

                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        if (age < 5 || age > 100)
                        {
                            // Children under 5 and seniors over 100 go free.
                            continue;
                        }
                        else if (age < 20)
                        {
                            totalCost += 80;
                        }
                        else if (age > 64)
                        {
                            totalCost += 90;
                        }
                        else
                        {
                            totalCost += 120;
                        }
                    }
                    else
                    {
                        // Handle invalid age input for a person.
                        Console.WriteLine($"Invalid age input for person {i}. Please enter a valid number.");
                    }
                }

                // Display the number of people and the total cost for the group.
                Console.WriteLine($"Number of people: {numPeople}");
                Console.WriteLine($"Total cost for the group: ${totalCost}");
            }
            else
            {
                // Handle invalid input for the number of people.
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void RepeatTextTenTimes()
        {
            // Prompt the user to enter a text to be repeated.
            Console.Write("Enter a text to repeat: ");

            // Read the text input from the user.
            string inputText = Console.ReadLine();

            // Repeat the input text ten times using a for loop.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}. {inputText}");
            }
        }

        static void FindThirdWord()
        {
            // Prompt the user to enter a sentence.
            Console.Write("Enter a sentence with at least 3 words: ");

            // Read the sentence input from the user.
            string inputSentence = Console.ReadLine();

            // Split the sentence into words using spaces as separators.
            string[] words = inputSentence.Split(' ');

            if (words.Length >= 3)
            {
                // Display the third word from the input sentence.
                Console.WriteLine($"The third word is: {words[2]}");
            }
            else
            {
                // Handle cases where the input doesn't contain at least 3 words.
                Console.WriteLine("Input does not contain at least 3 words.");
            }
        }
    }

}