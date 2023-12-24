using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectCoints_Presentation
{
    internal static class StaticMenus
    {
        public static void GameName()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("         Collect Coins        ");
            Console.WriteLine("==============================");
        }
        public static void GameStart()
        {
            Console.WriteLine("         *Game Started*       ");
            Console.WriteLine("==============================");
        }
        public static void GameInitializing()
        {
            Console.WriteLine("         *Prepare Game*       ");
            Console.WriteLine("==============================");
        }
    }
}
