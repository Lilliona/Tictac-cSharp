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
            this.choice_for_intelligence = 3;
        }
        public Computer(int choice_for_intelligence)
        {
            this.choice_for_intelligence = choice_for_intelligence;
        }

        public override int get_fieldtarget(Field field)
        {
            int ask_for_fieldtarget=0;
            
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
                ask_for_fieldtarget = high_level_AI();
            }
            else
            {
                Console.WriteLine("This value is no option!");
            }

            return ask_for_fieldtarget;
        }

        private int high_level_AI() 
        {
            Random random;
            random = new Random();
            int help_for_random;
            help_for_random = random.Next(1,10);
            int result_of_AI = help_for_random;//help for random wird später übernommen von opponents_set, s. TicTac2

            return result_of_AI;
        }

        private int normal_level_AI()
        {
            Random random;
            random = new Random();
            int help_for_random;
            help_for_random = random.Next(1, 10);
            int result_of_AI = help_for_random;

            return result_of_AI;
        }

        private int low_level_AI()
        {
            Random random;
            random = new Random();
            int help_for_random;
            help_for_random = random.Next(1, 10);
            int result_of_AI = help_for_random;

            return result_of_AI;
        }
    }
}
