using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tictic
{
    public class Controller
    {
        Player player1;
        Player player2;

        public void start()
        {
            turn();
        }

        private void turn()
        {
            Console.WriteLine("Yay we started a turn! :D");
        }
    }
}
