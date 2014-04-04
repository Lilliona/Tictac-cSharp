using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tictic
{
    public class Computer: Player
    {

        public override void ImComputer()
        {
            Console.WriteLine("Oh no, I don't have Brain! D:");
        }
        public override int get_fieldtarget()
        {
            throw new NotImplementedException();
        }

        public void ask_Controller_for_fieldsets()
        {
            
        }
    }
}
