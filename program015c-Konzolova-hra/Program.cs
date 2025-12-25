        List<string> history = new List<string>(); // Seznam pro ukládání výsledků
        int gameCounter = 0;                       // Počítadlo her
        
        int playerWins = 0;
        int pcWins = 0;
        int draws = 0;

        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Program 015c - Hra Kostky (Full) ****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************ Dalibor Topinka **************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Random myRandNumb = new Random();
            gameCounter++; 

            Console.Write($"HRA ČÍSLO {gameCounter}. Stiskněte ENTER pro hození kostkou...");
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

            string resultText = ""; 

            Console.WriteLine("======================");
            if (playerRoll > pcRoll)
            {
                Console.WriteLine("Výsledek: >>> VYHRÁL JSI! <<<");
                resultText = $"Hra {gameCounter}: Výhra ({playerRoll} vs {pcRoll})";
                playerWins++; 
            }
            else if (pcRoll > playerRoll)
            {
                Console.WriteLine("Výsledek: >>> PROHRÁL JSI. <<<");
                resultText = $"Hra {gameCounter}: Prohra ({playerRoll} vs {pcRoll})";
                pcWins++; 
            }
            else
            {
                Console.WriteLine("Výsledek: >>> REMÍZA. <<<");
                resultText = $"Hra {gameCounter}: Remíza ({playerRoll} vs {pcRoll})";
                draws++; 
            }
            Console.WriteLine("======================");

            history.Add(resultText);

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Celková historie her:");
            
            foreach (string record in history)
            {
                Console.WriteLine(record);
            }
            Console.WriteLine("-----------------------------");
            
            Console.WriteLine("STATISTIKA:");
            Console.WriteLine($"Počet výher: {playerWins}");
            Console.WriteLine($"Počet proher: {pcWins}");
            Console.WriteLine($"Počet remíz:  {draws}");
            Console.WriteLine("-----------------------------");

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