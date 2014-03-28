using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tictic
{
    public class Human: Player
    {
        public override int get_fieldtarget()
        {
            int ask_for_fieldtarget;

            Console.WriteLine("Please enter a value where you want to place your sign");
            ask_for_fieldtarget=Convert.ToInt32(Console.ReadLine());
          
            return ask_for_fieldtarget;
        }
    }
}
