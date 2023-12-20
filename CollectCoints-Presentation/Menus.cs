using CollectCoins_Library;

namespace CollectCoints_Presentation
{
    internal static class Menus
    {
        public static void MainMenu(int choice)
        {
            GameName();
            switch (choice)
            {
                case 1:
                    CurrentChoice("1 Player");
                    AnotherChoice("2 Players");
                    AnotherChoice("Exit");
                    break;
                case 2:
                    AnotherChoice("1 Player");
                    CurrentChoice("2 Players");
                    AnotherChoice("Exit");
                    break;
                case 3:
                    AnotherChoice("1 Player");
                    AnotherChoice("2 Players");
                    CurrentChoice("Exit"); 
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("==============================");
        }

        public static IEnumerable<Player> PlayerInfoMenu(int choice)
        {
            GameName();
            GameStart();
            Player player;
            switch (choice)
            {
                case 1:
                    player = GetPlayerData();
                    Console.WriteLine("Now: ");
                    Console.WriteLine(player);
                    yield return player;
                    break;

                case 2:
                    (int x,int y) = Console.GetCursorPosition();
                    for (int i = 1;i < 3; i++)
                    {
                        Console.SetCursorPosition(x, y);
                        ClearConsoleArea(40, 10);
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine($"Player {i}");
                        player = GetPlayerData();
                        Console.WriteLine("Now: ");
                        Console.WriteLine(player);
                        yield return player;
                    }
                    break;
                default:
                    yield break;
            }
        }


        private static void GameName()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("         Collect Coins        ");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }
        private static void CurrentChoice(string choice)
        {
            Console.WriteLine($">> {choice}");
        }
        private static void AnotherChoice(string choice)
        {
            Console.WriteLine($"   {choice}");
        }
        private static void GameStart()
        {
            Console.WriteLine("         *Game Started   \r\n" +
                "==============================");
        }

        private static Player GetPlayerData()
        {
            string name;
            int x, y;
            (x, y) = Console.GetCursorPosition();
            do
            {
                Console.SetCursorPosition(x, y);
                ClearConsoleArea(40, 3);
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Enter Player Name: ");
                name = Console.ReadLine();
            } while (name.Length < 3);
            (x,y) = Console.GetCursorPosition();
            Console.WriteLine("Enter Player symbol");
            Console.WriteLine("Note: Enter only one char.");
            string symbol = Console.ReadLine();
            while(symbol.Length > 1)
            {
                Console.WriteLine($"Do you agree that your symbol is {symbol[0]}?\n\t\t yes / no");
                string response = Console.ReadLine();
                if(response.Contains("Y") || response.Contains("y"))
                {
                    break;
                }
                Console.SetCursorPosition(x, y);
                ClearConsoleArea(40, 6);
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Enter Player symbol");
                Console.WriteLine("Note: Enter only one char.");
                symbol = Console.ReadLine();
            }
            return new Player(name, symbol[0]);
        }
        static void ClearConsoleArea(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(' ');
                }

                // Move the cursor to the next line
                Console.WriteLine();
            }
        }
    }
}

