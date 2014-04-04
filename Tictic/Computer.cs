using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tictic
{
    public class Computer: Player
    {

        private int choice_for_intelligence;
        public Computer()
        {
            choice_for_intelligence = 3;
        }

        public Computer(int choice_for_intelligence)
        {
            this.choice_for_intelligence = choice_for_intelligence;
        }

        public override int get_fieldtarget(char[] field)
        {
            int ask_for_fieldtarget;
            
            if (choice_for_intelligence == 1)
            {
                ask_for_fieldtarget=low_level_AI();
            }
            else if (choice_for_intelligence == 2)
            {
                ask_for_fieldtarget=normal_level_AI();
            }
            else if (choice_for_intelligence == 3)
            {
                ask_for_fieldtarget=high_level_AI();
            }

            return ask_for_fieldtarget;
        }

        private int high_level_AI() 
        {
            int result_of_AI=3;


            return result_of_AI;
        }

        private int normal_level_AI()
        {
            int result_of_AI=2;


            return result_of_AI;
        }

        private int low_level_AI()
        {
            int result_of_AI=1;


            return result_of_AI;
        }
    }
}
