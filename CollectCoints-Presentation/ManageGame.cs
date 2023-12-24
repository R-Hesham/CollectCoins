using CollectCoins_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectCoints_Presentation
{
    internal static class ManageGame
    {
        static IGame currentGame;
        static Type gameType;
        public static void Start(int numberOfPlayers)
        {
            Console.Clear();
            StaticMenus.GameName();
            StaticMenus.GameStart();
            switch (numberOfPlayers)
            {
                case 1:
                    currentGame = new Game1Player();
                    gameType = typeof(Game1Player);
                    break;
                case 2:
                    currentGame = new Game2Player();
                    gameType = typeof(Game2Player);
                    break;
            }
            Console.ReadKey();
            currentGame.StartGame();
        }
    }
}
