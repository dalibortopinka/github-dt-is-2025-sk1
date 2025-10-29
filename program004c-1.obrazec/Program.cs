string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Vykreslování obrazce Z *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Dalibor Topinka ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    Console.Write("Zadejte výšku obrazce Z (celé číslo): ");
    int height;

    while (!int.TryParse(Console.ReadLine(), out height)) 
     
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obrazce Z znovu: ");
    }


    for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
            if (i == 0)
                    {
                        Console.Write("*");
                    }
           else if (i==height - 1)
            {
                Console.Write("*");
            }
                    else if (j == height - 1 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150)); //zpoždění
        }
        Console.WriteLine();
    }
     
     
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}
