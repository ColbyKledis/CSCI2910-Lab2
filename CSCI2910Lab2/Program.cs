Console.WriteLine(" ===== Welcome to Lab 2! ===== \n");

//display menu and allow user to choose option

int choice = 0;
do
{
    DisplayMenu();
    Console.WriteLine("Enter choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
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
            AddNumbers();
            break;
        case 2:
            MultiTable();
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

// Sum method for Question 1
static void AddNumbers()
{
    Console.WriteLine("Add Numbers:");
    Console.WriteLine("Enter First Number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Second Number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
} 

// Multiplication table method for Question 2

static void MultiTable()
{
    Console.WriteLine("Multiplication Table:");
    Console.WriteLine("Enter a number to multiply:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the size of the muliplication table:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < num2; i++)
    {
        Console.WriteLine(num1 + " * " + i + " = " + num1 * i + "\n");
    }
}