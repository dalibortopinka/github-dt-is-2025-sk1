string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("******* Vykreslení 3. obrazce *******");
    Console.WriteLine("***********************************");
    Console.WriteLine("********** Dalibor Topinka **********");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    Console.Write("Zadejte velikost 3. obrazce (celé číslo): ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    Console.WriteLine();

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if ((i + j) % 2 != 0)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }

            Thread.Sleep(TimeSpan.FromMilliseconds(150));
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
