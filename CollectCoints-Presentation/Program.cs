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
                    ManageGame.Start(1);
                    Console.ReadKey();
                    break;
                case 2:
                    ManageGame.Start(2);
                    Console.ReadKey();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
            break;
    }
}while (true);
