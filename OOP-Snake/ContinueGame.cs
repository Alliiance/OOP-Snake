using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class ContinueGame
    {
        private int winWidth;
        private int winHeight;

        public ContinueGame(int winWidth, int winHeight)
        {
            this.winWidth = winWidth;
            this.winHeight = winHeight;
        }

        public bool GoOnGame()
        {
            Console.SetCursorPosition(winWidth / 2 - 10, winHeight / 2);
            Console.WriteLine("Do you want to continue ? Press yes");

            Console.SetCursorPosition(winWidth / 2 - 10, winHeight / 2 + 2);
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
                return true;
            else
                return false;
          
        }
    }
}
