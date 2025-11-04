string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************");
    Console.WriteLine("***** Vykreslování obrazce N *****");
    Console.WriteLine("*********************************");
    Console.WriteLine();

    Console.Write("Zadejte výšku obrazce N (celé číslo): ");
    int height;

    while (!int.TryParse(Console.ReadLine(), out height)) 
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");
    }


    for (int i = 0; i < height; i++)
    {
       
        for (int j = 0; j < height; j++)
        {
            if (j == 0 || j == (height - 1) || i == j)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }

            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150)); 
        }
        Console.WriteLine();
    }
    
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}