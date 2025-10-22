string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Vykreslování obrazců *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Dalibor Topinka ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně 
    Console.Write("Zadejte šířku obrazce (celé číslo): ");
    int width;

    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obrazce znovu: ");
    }


    Console.Write("Zadejte výšku obrazce (celé číslo): ");
    int height;

    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obrazce znovu: ");
    }


    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150)); //zpoždění
        }
        Console.WriteLine();
    }
     
     
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}
