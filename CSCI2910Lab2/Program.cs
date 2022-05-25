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
            ByteSize();
            break;
        case 4:
            Calc();
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

static void ByteSize()
{
    var types = new[] { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(decimal) };
    Console.WriteLine("| {0, -10} | {1, 7} | {2, 30} | {3, 30} |", "Type", "Byte(s)", "Min", "Max");
    Console.WriteLine("|------------|---------|--------------------------------|--------------------------------|");

    foreach (var type in types)
    {
        Console.WriteLine(
            "| {0, -10} | {1, 7} | {2, 30} | {3, 30} |",
            type.Name,
            System.Runtime.InteropServices.Marshal.SizeOf(Activator.CreateInstance(type)),
            type.GetField("MinValue").GetValue(null),
            type.GetField("MaxValue").GetValue(null));
    }
}


// Calculator Method for Question 4

static void Calc()
{
    char op;
    double num1, num2;

    while (true)
    {
        Console.WriteLine("Calculator: Press ESC to leave");
        Console.WriteLine("Enter a Number");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Function (+, -, *, /, %");
        op = Console.ReadLine()[0];
        Console.WriteLine("Enter Second Number");
        num2 = Convert.ToInt32(Console.ReadLine());
        

        switch (op)
        {
            case '+':
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case '/':
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            case '%':
                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                break;
            default:
                Console.WriteLine("Invalid Operation choice. Try Again");
                break;
        }
        ConsoleKeyInfo ch;
        ch = Console.ReadKey();
        if (ch.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }

}