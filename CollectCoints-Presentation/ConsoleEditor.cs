using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectCoints_Presentation
{
    internal class ConsoleEditor
    {
        public static void ClearConsoleArea(int width, int height)
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
