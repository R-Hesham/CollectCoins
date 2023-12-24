using CollectCoins_Library;

namespace CollectCoints_Presentation
{
    internal static class Menus
    {
        public static void MainMenu(int choice)
        {
            StaticMenus.GameName();
            Console.WriteLine();
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

        public static IEnumerable<Player> PlayerInfoMenu(int numberOfPlayers)
        {
            StaticMenus.GameName();
            StaticMenus.GameInitializing();
            Player player;
            if (numberOfPlayers < 1) yield break;
            (int x, int y) = Console.GetCursorPosition();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.SetCursorPosition(x, y);
                ConsoleEditor.ClearConsoleArea(40, 11);
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"Player {i}");
                player = GetPlayerData();
                Console.WriteLine("Now: ");
                Console.WriteLine(player);
                yield return player;
            }
        }


        
        private static void CurrentChoice(string choice)
        {
            Console.WriteLine($">> {choice}");
        }
        private static void AnotherChoice(string choice)
        {
            Console.WriteLine($"   {choice}");
        }
        

        private static Player GetPlayerData()
        {
            string name;
            int x, y;
            (x, y) = Console.GetCursorPosition();
            do
            {
                Console.SetCursorPosition(x, y);
                ConsoleEditor.ClearConsoleArea(40, 3);
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Enter Player Name: ");
                name = Console.ReadLine();
            } while (name.Length < 3);
            (x, y) = Console.GetCursorPosition();
            Console.WriteLine("Enter Player symbol");
            Console.WriteLine("Note: Enter only one char.");
            string symbol = Console.ReadLine();
            while (symbol.Length > 1)
            {
                Console.WriteLine($"Do you agree that your symbol is {symbol[0]}?\n\t\t yes / no");
                string response = Console.ReadLine();
                if (response.Contains("Y") || response.Contains("y"))
                {
                    break;
                }
                Console.SetCursorPosition(x, y);
                ConsoleEditor.ClearConsoleArea(40, 6);
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Enter Player symbol");
                Console.WriteLine("Note: Enter only one char.");
                symbol = Console.ReadLine();
            }
            return new Player(name, symbol[0]);
        }
        
    }
}

