internal class Program
{
    private static void Main(string[] args)
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("**********");
            Console.WriteLine("***Výpis řady čísel***");
            Console.WriteLine("*********");
            Console.WriteLine("***Dalibor Topinka***");
            Console.WriteLine("********");
            Console.WriteLine();


            //Vstup hodnoty do programu řešený správně
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;

            while (!int.TryParse(Console.ReadLine(), out first))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu.");

            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskni a");
            again = Console.Readline();

        }
    }
}