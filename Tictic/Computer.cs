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
            int ask_for_fieldtarget;
            Console.WriteLine("I am the ultimate Computer! Take this:");
            ask_for_fieldtarget=Convert.ToInt32(Console.ReadLine());
            return ask_for_fieldtarget;

        }

        public void ask_Controller_for_fieldsets()
        {
            
        }
    }
}
