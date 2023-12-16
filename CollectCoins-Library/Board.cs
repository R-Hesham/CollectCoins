using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectCoins_Library
{
    public class Board
    {
        public string Draw()
        {
            string board = "#==1==2==3==4==5==6==7==8==9=*\n";
            for(int i = 1; i < 10; i++)
            {
                board += $"{i}=";
                for(int j = 1; j < 10; j++)
                {
                    board += "   ";
                }
                board += "*\n";
            }
            return board;
        }
    }
}
