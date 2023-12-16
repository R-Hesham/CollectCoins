using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectCoins_Library
{
    public static class Menus
    {
        public static string GameName()
        {
            return  "==============================\r\n" +
                    "         Collect Coins        \r\n" +
                    "==============================";
        }
        public static string MainMenu(int choice)
        {
            string menu = GameName() + "\r\n\r\n\t";
            if (choice == 1) menu += ">>"; else menu += "  ";
            menu += " 1Player\r\n\t";
            if (choice == 2) menu += ">>"; else menu += "  ";
            menu += " 2Player\r\n\t";
            if (choice == 3) menu += ">>"; else menu += "  ";
            menu += " Exit\r\n\r\n";
            menu += "==============================\r\n";
            return menu;
        }
    
        public static string GameStart()
        {
            return "         *Game Started   \r\n==============================";
        }
    }
}

