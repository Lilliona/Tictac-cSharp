using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tictic
{
    public class Human: Player
    {
        public override int get_fieldtarget(Field field,char opponent,char actual_player)
        {
            int ask_for_fieldtarget;

            Console.WriteLine("Please enter a value where you want to place your sign");

            while (!Int32.TryParse(Console.ReadLine(), out ask_for_fieldtarget) || ask_for_fieldtarget < 1 || ask_for_fieldtarget > 9)
            {
                if (ask_for_fieldtarget < 1 || ask_for_fieldtarget > 9)
                {
                    Console.WriteLine("Your Input is invalid. Please enter a value between 1 and 9:");
                }
                else 
                {
                    Console.WriteLine("Your Input is invalid. Please enter a number:");
                }
            }
            return ask_for_fieldtarget;
        }
    }
}
