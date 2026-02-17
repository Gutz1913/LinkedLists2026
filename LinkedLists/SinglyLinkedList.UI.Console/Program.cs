using SinglyLinkedList.Backend;

var list = new SinglyLinkedList<string>();
var opt = string.Empty;
do
{
    opt = Menu();
    switch (opt)
    {
        case "0":
            Console.WriteLine("Bye");
            break;

        case "1":
            Console.Write("Enter value: ");
            list.InsertAtBeginning(Console.ReadLine()!);
            Console.WriteLine("Value inserted at the beginning");
            break;

        case "2":
            Console.Write("Enter value: ");
            list.InsertAtEnd(Console.ReadLine()!);
            Console.WriteLine("Value inserted at the end");
            break;

        case "3":
            Console.Write("Enter value to search: ");
            var value = Console.ReadLine()!;
            Console.WriteLine(list.Contains(value) ? "Value found" : "Value not found");
            break;

        case "4":
            Console.Write("Enter value to remove: ");
            var valueToRemove = Console.ReadLine()!;
            if (valueToRemove != null)
            {
                if (list.Contains(valueToRemove))
                {
                    list.Remove(valueToRemove);
                    Console.WriteLine($"The value {valueToRemove} has been removed to the list");
                }
                else
                {
                    Console.WriteLine($"The value {valueToRemove} does not exist in the list");
                }
            }
            break;

        case "5":
            list.Clear();
            Console.WriteLine("The list has been cleared");
            break;

        case "6":
            list.PrintList();
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }
} while (opt != "0");

string Menu()
{
    Console.WriteLine();
    Console.WriteLine(":::::::: Menu ::::::::");
    Console.WriteLine();
    Console.WriteLine("1. Insert at beginning");
    Console.WriteLine("2. Insert at end");
    Console.WriteLine("3. Search value");
    Console.WriteLine("4. Remove value");
    Console.WriteLine("5. Clear list");
    Console.WriteLine("6. Print list");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine() ?? "0";
}