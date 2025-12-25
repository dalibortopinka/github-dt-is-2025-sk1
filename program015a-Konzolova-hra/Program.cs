        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** Program 015a - Kostky *********");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************ Dalibor Topinka **************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Random myRandNumb = new Random();

            // ----------------------------------------------
            // Čekání na vstup uživatele
            // ----------------------------------------------
            Console.Write("Stiskněte ENTER pro hození kostkou.");
            Console.ReadLine(); 

            // ----------------------------------------------
            // Generování náhodných čísel
            // ----------------------------------------------
            int playerRoll = myRandNumb.Next(1, 7);
            int pcRoll = myRandNumb.Next(1, 7);

            Console.WriteLine();
            Console.WriteLine("***************************");
            Console.WriteLine("Výsledky hodu:");
            
            Console.Write("Hráč hodil: {0}", playerRoll);
            Console.WriteLine();
            
            Console.Write(" ... ");
            Thread.Sleep(3000); 
            Console.Write("počítač hází");
            Thread.Sleep(3000); 
            Console.WriteLine(" ...");
            
            Console.WriteLine("Počítač hodil: {0}", pcRoll);
            Console.WriteLine("***************************");
            Console.WriteLine();

            // ----------------------------------------------
            // Vyhodnocení vítěze
            // ----------------------------------------------
            Console.WriteLine("======================");
            if (playerRoll > pcRoll)
            {
                Console.WriteLine("Výsledek: VYHRÁL JSI!");
            }
            else if (pcRoll > playerRoll)
            {
                Console.WriteLine("Výsledek: PROHRÁL JSI.");
            }
            else
            {
                Console.WriteLine("Výsledek: REMÍZA.");
            }
            Console.WriteLine("======================");

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
            again = Console.ReadLine();
        }