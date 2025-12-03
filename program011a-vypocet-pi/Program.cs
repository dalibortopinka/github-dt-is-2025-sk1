string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpočet pí *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Dalibor Topinka ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    Console.Write("Zadejte hodnotu (reálné číslo): ");
    double presnost; //datový typ double - reálná čísla

    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste reálné číslo. Zadejte hodnotu znovu: ");
    }

double i=1;
double piCtvrt = 1;
double znamenko = 1;

while ((1/i)>= presnost) {
    i = i+2;
    znamenko = -znamenko;
    piCtvrt = piCtvrt + znamenko * (1/i);
}
       
    double pi = 4 * piCtvrt;
    Console.WriteLine("Vypočítané pí: {0}", pi);
    

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}
