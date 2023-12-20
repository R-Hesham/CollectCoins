using CollectCoins_Library;
using CollectCoints_Presentation;

Configuration.display();

int mainChoice = 1;
do
{
    Console.Clear();
    Menus.MainMenu(mainChoice);
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    switch (keyInfo.Key)
    {
        case ConsoleKey.UpArrow:
            mainChoice--;
            if (mainChoice == 0) mainChoice = 3;
            break;
        case ConsoleKey.DownArrow:
            mainChoice++;
            if(mainChoice == 4) mainChoice = 1;
            break;
        case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
        case ConsoleKey.Enter:
            Console.Clear();
            switch (mainChoice)
            {
                case 1:
                    foreach(var player in Menus.PlayerInfoMenu(1))
                    {
                        //Console.WriteLine(player);
                    }
                    Console.ReadKey();
                    
                    break;
                case 2:
                    foreach (var player in Menus.PlayerInfoMenu(2))
                    {
                        //Console.WriteLine(player);
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine(mainChoice);

                    Environment.Exit(0);
                    break;
            }
            break;
    }
}while (true);
