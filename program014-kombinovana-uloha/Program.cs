string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Kombinovaná úloha *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("************ Dalibor Topinka **************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }


    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }


    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("***************************");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2};", n, lowerBound, upperBound);
    Console.WriteLine("***************************");

    int[] myRandNumbs = new int[n];

    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("***************************");
    Console.WriteLine("Pseudonáhodná čísla: ");
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.WriteLine("{0}; ", myRandNumbs[i]);
    }
// ----------------------------------------------
//Hledání maxima a minima a všechny jejich pozice
// ----------------------------------------------
int max = myRandNumbs[0];
int min = myRandNumbs[0];
for (int i =1; i < n; i++)
    {
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
        }
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
        }
    }
Console.WriteLine();
Console.WriteLine("======================");
Console.Write("Maximum je {0}; jeho pozice: ", max);
for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] == max)
        {
            Console.WriteLine("{0}; ", i);
        }
    }

Console.Write("Minimum je {0}; jeho pozice: ", min);
for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] == min)
        {
            Console.Write("{0}; ", i);
        }
    }

// ----------------------------------------------
//Seřazení pole - Shaker sort neumím - použiji aspoň bubble sort
// ----------------------------------------------

for (int i = 0; i < n -1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int temp = myRandNumbs[j+1];
                myRandNumbs[j+1] = myRandNumbs[j];
                myRandNumbs[j] = temp;
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine("Seřazená čísla pomocí Bubble sortu: ");
    Console.WriteLine();
for (int i = 0; i < n; i++)
    {
        Console.WriteLine("{0} ", myRandNumbs[i]);
    }

// -----------------------------------------
// Druhé, třetí, čtvrté největší číslo - řeší správně duplicity
// -----------------------------------------
    int uniqueCount = 0;
    int lastValue = int.MinValue;
    int second = 0, third = 0, fourth = 0;
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] != lastValue)
        {
            uniqueCount++;
            lastValue = myRandNumbs[i];

            if (uniqueCount ==2)
                second = myRandNumbs[i];
            if (uniqueCount ==3)
                third = myRandNumbs[i];
            if (uniqueCount ==4)
                fourth = myRandNumbs[i];
        }
    }


    Console.WriteLine();
    Console.WriteLine("=================================");
    Console.WriteLine("Druhé největší číslo: {0}", second);
    Console.WriteLine("Třetí největší číslo: {0}", third);
    Console.WriteLine("Čtvrté největší číslo: {0}", fourth);


// -------------------------------------------
// Medián
// -------------------------------------------
    int median;
    if (n%2 == 1)
        median = myRandNumbs[n/2];
    else 
        median = (myRandNumbs[n/2 -1] + myRandNumbs[n/2]) / 2;

    Console.WriteLine();
    Console.WriteLine("=======================");
    Console.WriteLine("Medián je: {0}", median);





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}
