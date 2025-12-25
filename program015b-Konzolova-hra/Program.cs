        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine("***** Program 015b - Kostky s Grafickou Vizualizací ****");
            Console.WriteLine("********************************************************");
            Console.WriteLine("****************** Dalibor Topinka *********************");
            Console.WriteLine("********************************************************");
            Console.WriteLine();

            Random myRandNumb = new Random();

            Console.Write("Stiskněte ENTER pro hození kostkou.");
            Console.ReadLine();

            // ----------------------------------------------
            // Generování čísel
            // ----------------------------------------------
            int playerRoll = myRandNumb.Next(1, 7);
            int pcRoll = myRandNumb.Next(1, 7);

            Console.WriteLine();
            Console.WriteLine("***************************");
            Console.WriteLine("Průběh hry:");

            // --- HOD HRÁČE ---
            Console.Write("Hráč hází");
            Thread.Sleep(1000); Console.Write(".");
            Thread.Sleep(1000); Console.Write(".");
            Thread.Sleep(1000); Console.WriteLine(); 

            Console.WriteLine($"Hráč hodil: {playerRoll}");
           
            VykresliKostku(playerRoll);
            Console.WriteLine();

            // --- HOD POČÍTAČE ---
            Console.Write("Počítač hází");
            Thread.Sleep(1000); Console.Write(".");
            Thread.Sleep(1000); Console.Write(".");
            Thread.Sleep(1000); Console.WriteLine(); 

            Console.WriteLine($"Počítač hodil: {pcRoll}");
           
            VykresliKostku(pcRoll);

            Console.WriteLine("***************************");
            Console.WriteLine();

            // ----------------------------------------------
            // Vyhodnocení vítěze
            // ----------------------------------------------
            Console.WriteLine("======================");
            if (playerRoll > pcRoll)
            {
                Console.WriteLine("Výsledek: >>> VYHRÁL JSI! <<<");
            }
            else if (pcRoll > playerRoll)
            {
                Console.WriteLine("Výsledek: >>> PROHRÁL JSI. <<<");
            }
            else
            {
                Console.WriteLine("Výsledek: >>> REMÍZA. <<<");
            }
            Console.WriteLine("======================");

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
            again = Console.ReadLine();
        }

    // =================================================================
    // POMOCNÁ METODA PRO VYKRESLENÍ KOSTKY
    // =================================================================
    static void VykresliKostku(int cislo)
    {
        Console.WriteLine("+-------+"); 

        switch (cislo)
        {
            case 1:
                Console.WriteLine("|       |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|       |");
                break;
            case 2:
                Console.WriteLine("| o     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     o |");
                break;
            case 3:
                Console.WriteLine("| o     |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("|     o |");
                break;
            case 4:
                Console.WriteLine("| o   o |");
                Console.WriteLine("|       |");
                Console.WriteLine("| o   o |");
                break;
            case 5:
                Console.WriteLine("| o   o |");
                Console.WriteLine("|   o   |");
                Console.WriteLine("| o   o |");
                break;
            case 6:
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                Console.WriteLine("| o   o |");
                break;
        }

        Console.WriteLine("+-------+"); 
    }