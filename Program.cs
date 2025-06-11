//simple console application that do a Task list for the week with a menu
using System;

while (true)// Loop to keep the program running until the user decides to exit
{ 
    string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};// Array to hold the names of the days of the week
    string[] tasks = new string[7];// Array to hold tasks for each day of the week
    Console.WriteLine("Welcome to your weekly task list!");
    Console.WriteLine("Please enter your tasks for each day of the week (Monday to Sunday):");
    for (int i = 0; i < days.Length; i++)// Loop through each day of the week
    {
        Console.Write($"Enter tasks for {days[i]}: ");// Prompt the user to enter tasks for the current day
        tasks[i] = Console.ReadLine();
    }
    

Console.WriteLine("\nTask for the week");
Console.WriteLine("Select the day you wanna view the task");
Console.WriteLine("1. Monday\n2. Tuesday\n3. Wednesday\n4. Thursday\n5. Friday\n6. Saturday\n7. Sunday\n8. Exit");
int choice1 = 0;
    while (choice1 < 1 || choice1 > 8)// Loop to ensure the user enters a valid choice
    {
        Console.Write("Enter your choice (1-8): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice >= 1 || choice <= 8) // Check if the choice is within the valid range
        {
            if (choice == 8)
            {
                Console.WriteLine("Exiting the program. Have a great week!");
                return;
            }
            else
            {
                Console.WriteLine($"Tasks for {days[choice - 1]}: {tasks[choice - 1]}");// Display the tasks for the selected day
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");// Prompt the user to enter a valid choice
        }
    }
    

}