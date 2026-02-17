using DoublyLinkedList.Backend;

var list = new DoublyLinkedList<string>();
var opt = string.Empty;

do
{
    opt = Menu();
    switch (opt)
    {
        case "0":
            Console.WriteLine(":::::::::: GAME OVER ::::::::::");
            Console.WriteLine("Thank you for using the program");
            break;

        case "1":
            Console.Write("Enter the data to insert at the beginning: ");
            var dataAtBeginning = Console.ReadLine();
            if (dataAtBeginning != null)
            {
                list.InsertAtBeginning(dataAtBeginning);
            }
            break;

        case "2":
            Console.Write("Enter the data to insert at the end: ");
            var dataAtEnd = Console.ReadLine();
            if (dataAtEnd != null)
            {
                list.InsertAtEnd(dataAtEnd);
            }
            break;

        case "3":
            Console.WriteLine(list.GetForward());
            break;

        case "4":
            Console.WriteLine(list.GetBackward());
            break;

        case "5":
            Console.Write("Enter the data to remove: ");
            var dataToRemove = Console.ReadLine();
            if (dataToRemove != null)
            {
                list.Remove(dataToRemove);
                Console.WriteLine("Item removed.");
            }
            break;
    }
} while (opt != "0");

string Menu()
{
    Console.WriteLine(":::::::: MENÚ ::::::::");
    Console.WriteLine();
    Console.WriteLine("1. Insert at Beginning");
    Console.WriteLine("2. Insert at End");
    Console.WriteLine("3. Show list  forward");
    Console.WriteLine("4. Show list backward");
    Console.WriteLine("5. Remove");
    Console.WriteLine("0. Exit");
    Console.Write("Select an option: ");
    return Console.ReadLine() ?? "0";
}