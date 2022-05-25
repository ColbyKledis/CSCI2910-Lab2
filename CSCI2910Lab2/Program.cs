﻿Console.WriteLine(" ===== Welcome to Lab 2! ===== \n");

//display menu and allow user to choose option

int choice = 0;
do
{
    DisplayMenu();
    Console.WriteLine("Enter choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    MenuOption(choice);
} while (choice != 0);

// display a goodbye message
Console.WriteLine("Thank you for calcin' have a good one");

//Method to display Menu
static void DisplayMenu()
{
    Console.WriteLine(" ----- Menu ----- ");
    Console.WriteLine("1. Add two numbers");
    Console.WriteLine("2. Multiplication table");
    Console.WriteLine("3. Memory size of data types");
    Console.WriteLine("4. Five-function calculator");
    Console.WriteLine("0. Exit");
    Console.WriteLine(" ---------------- ");
}

// Method to choose from menu
static void MenuOption(int option)
{
    switch (option)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            break;
        default:
            Console.WriteLine("Invalid Menu choice. Try Again");
            break;
    }
}