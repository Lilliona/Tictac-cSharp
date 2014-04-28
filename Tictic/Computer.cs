using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* is_free() bi AIs */

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

        public override int get_fieldtarget(Field field,char opponent,char actual_player)
        {
            int ask_for_fieldtarget=0;
            
            if (choice_for_intelligence == 1)
            {
                ask_for_fieldtarget=low_level_AI(field,opponent,actual_player);
            }
            else if (choice_for_intelligence == 2)
            {
                ask_for_fieldtarget=normal_level_AI(field,opponent,actual_player);
            }
            else if (choice_for_intelligence == 3)
            {
                ask_for_fieldtarget = high_level_AI(field,opponent,actual_player);
            }
            else
            {
                Console.WriteLine("This value is no option!");
            }

            return ask_for_fieldtarget;
        }

        private int high_level_AI(Field field,char opponent,char actual_player) 
        {
            Random random = new Random();

            int help_for_random;
            int result_of_AI=0;

	        if (field.get_content(4) == opponent || field.get_content(4) == actual_player)
            {

		        /***********************************************************

		        Is the first step of the Player '5', set actual_player into a corner

		        ***********************************************************/

                if (field.get_content(4) == opponent && field.is_free(1) && field.is_free(2) && field.is_free(3) && field.is_free(4) && field.is_free(6) && field.is_free(7) && field.is_free(8) && field.is_free(9))
                {

                    help_for_random = random.Next(0, 4);

                    switch (help_for_random)
                    {

                        case 0:
                            result_of_AI = 1;
                            break;

                        case 1:
                            result_of_AI = 3;
                            break;

                        case 2:
                            result_of_AI = 7;
                            break;

                        case 3:
                            result_of_AI = 9;
                            break;

                        default:
                            Console.WriteLine("Some Mistake has happened");
                            break;
                    }
                }

                /********************************

                Looks if actual_player could directly win

                ********************************/

                else if (field.is_free(1) && ((field.get_content(1) == actual_player && field.get_content(2) == actual_player) || (field.get_content(4) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(6) == actual_player)))
                { result_of_AI = 1; }

                else if (field.is_free(3) && ((field.get_content(0) == actual_player && field.get_content(1) == actual_player) || (field.get_content(4) == actual_player && field.get_content(6) == actual_player) || (field.get_content(5) == actual_player && field.get_content(8) == actual_player)))
                { result_of_AI = 3; }

                else if (field.is_free(7) && ((field.get_content(0) == actual_player && field.get_content(3) == actual_player) || (field.get_content(2) == actual_player && field.get_content(4) == actual_player) || (field.get_content(7) == actual_player && field.get_content(8) == actual_player)))
                { result_of_AI = 7; }

                else if (field.is_free(9) && ((field.get_content(0) == actual_player && field.get_content(4) == actual_player) || (field.get_content(2) == actual_player && field.get_content(5) == actual_player) || (field.get_content(6) == actual_player && field.get_content(7) == actual_player)))
                { result_of_AI = 9; }

                else if (field.is_free(2) && ((field.get_content(0) == actual_player && field.get_content(2) == actual_player) || (field.get_content(4) == actual_player && field.get_content(7) == actual_player)))
                { result_of_AI = 2; }

                else if (field.is_free(4) && ((field.get_content(0) == actual_player && field.get_content(6) == actual_player) || (field.get_content(4) == actual_player && field.get_content(5) == actual_player)))
                { result_of_AI = 4; }

                else if (field.is_free(6) && ((field.get_content(2) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(4) == actual_player)))
                { result_of_AI = 6; }

                else if (field.is_free(8) && ((field.get_content(1) == actual_player && field.get_content(4) == actual_player) || (field.get_content(6) == actual_player && field.get_content(8) == actual_player)))
                { result_of_AI = 8; }

                else if (field.is_free(5) && ((field.get_content(1) == actual_player && field.get_content(7) == actual_player) || (field.get_content(0) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(5) == actual_player) || (field.get_content(2) == actual_player && field.get_content(6) == actual_player)))
                { result_of_AI = 5; }

                /********************************

                Looks if opponent could directly win

                ********************************/

                else if (field.is_free(1) && ((field.get_content(1) == opponent && field.get_content(2) == opponent) || (field.get_content(4) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(6) == opponent)))
                { result_of_AI = 1; }

                else if (field.is_free(3) && ((field.get_content(0) == opponent && field.get_content(1) == opponent) || (field.get_content(4) == opponent && field.get_content(6) == opponent) || (field.get_content(5) == opponent && field.get_content(8) == opponent)))
                { result_of_AI = 3; }

                else if (field.is_free(7) && ((field.get_content(0) == opponent && field.get_content(3) == opponent) || (field.get_content(2) == opponent && field.get_content(4) == opponent) || (field.get_content(7) == opponent && field.get_content(8) == opponent)))
                { result_of_AI = 7; }

                else if (field.is_free(9) && ((field.get_content(0) == opponent && field.get_content(4) == opponent) || (field.get_content(2) == opponent && field.get_content(5) == opponent) || (field.get_content(6) == opponent && field.get_content(7) == opponent)))
                { result_of_AI = 9; }

                else if (field.is_free(2) && ((field.get_content(0) == opponent && field.get_content(2) == opponent) || (field.get_content(4) == opponent && field.get_content(7) == opponent)))
                { result_of_AI = 2; }

                else if (field.is_free(4) && ((field.get_content(0) == opponent && field.get_content(6) == opponent) || (field.get_content(4) == opponent && field.get_content(5) == opponent)))
                { result_of_AI = 4; }

                else if (field.is_free(6) && ((field.get_content(2) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(4) == opponent)))
                { result_of_AI = 6; }

                else if (field.is_free(8) && ((field.get_content(1) == opponent && field.get_content(4) == opponent) || (field.get_content(6) == opponent && field.get_content(8) == opponent)))
                { result_of_AI = 8; }

                else if (field.is_free(5) && ((field.get_content(1) == opponent && field.get_content(7) == opponent) || (field.get_content(0) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(5) == opponent) || (field.get_content(2) == opponent && field.get_content(6) == opponent)))
                { result_of_AI = 5; }

                /************************

                Looks for tricks of opponent

                *************************/

                /***

                -1:-

                ***/

                else if (field.is_free(1) && field.is_free(2) && field.get_content(2) == actual_player && field.get_content(3) == actual_player && field.get_content(4) == opponent && field.get_content(5) == opponent && field.get_content(6) == opponent && field.is_free(8) && field.is_free(9))
                { result_of_AI = random.Next(0, 2) + 1; }

                else if (field.get_content(0) == opponent && field.is_free(2) && field.is_free(3) && field.get_content(3) == actual_player && field.get_content(4) == opponent && field.get_content(5) == opponent && field.is_free(7) && field.is_free(8) && field.get_content(8) == actual_player)
                { result_of_AI = random.Next(0, 2) + 7; }

                else if (field.is_free(1) && field.is_free(2) && field.get_content(2) == opponent && field.get_content(3) == opponent && field.get_content(4) == opponent && field.get_content(5) == actual_player && field.get_content(6) == actual_player && field.is_free(8) && field.is_free(9))
                { result_of_AI = random.Next(0, 2) + 8; }

                else if (field.get_content(0) == actual_player && field.is_free(2) && field.is_free(3) && field.get_content(3) == opponent && field.get_content(4) == opponent && field.get_content(5) == actual_player && field.is_free(7) && field.is_free(8) && field.get_content(8) == opponent)
                { result_of_AI = random.Next(0, 2) + 2; }

                else if (field.get_content(0) == actual_player && field.get_content(1) == opponent && field.is_free(3) && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.is_free(7) && field.get_content(7) == actual_player && field.get_content(8) == opponent)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 4;

                    else
                        result_of_AI = 7;
                }

                else if (field.is_free(1) && field.get_content(1) == opponent && field.get_content(2) == actual_player && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.get_content(6) == opponent && field.get_content(7) == actual_player && field.is_free(9))
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 6;

                    else
                        result_of_AI = 9;
                }

                else if (field.get_content(0) == opponent && field.get_content(1) == actual_player && field.is_free(3) && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.is_free(7) && field.get_content(7) == opponent && field.get_content(8) == actual_player)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 3;

                    else
                        result_of_AI = 6;
                }

                else if (field.is_free(1) && field.get_content(1) == actual_player && field.get_content(2) == opponent && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.get_content(6) == actual_player && field.get_content(7) == opponent && field.is_free(9))
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else
                        result_of_AI = 4;
                }

                /***

                -2:-

                ***/

                else if ((field.is_free(1) && field.is_free(2) && field.get_content(2) == actual_player && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.get_content(6) == opponent && field.is_free(8) && field.is_free(9)) || (field.is_free(1) && field.is_free(2) && field.get_content(2) == opponent && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.get_content(6) == actual_player && field.is_free(8) && field.is_free(9)))
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else
                        result_of_AI = 9;
                }

                else if ((field.get_content(0) == opponent && field.is_free(2) && field.is_free(3) && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.is_free(7) && field.is_free(8) && field.get_content(8) == actual_player) || (field.get_content(0) == actual_player && field.is_free(2) && field.is_free(3) && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.is_free(7) && field.is_free(8) && field.get_content(8) == opponent))
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 3;

                    else
                        result_of_AI = 7;
                }

                /***

                -3:-

                ***/

                else if ((field.get_content(0) == opponent && field.is_free(4) && field.is_free(7) && field.get_content(7) == opponent && field.is_free(9)) || (field.is_free(1) && field.get_content(3) == opponent && field.is_free(7) && field.is_free(8) && field.get_content(8) == opponent))
                { result_of_AI = 7; }

                else if ((field.get_content(0) == opponent && field.is_free(2) && field.is_free(3) && field.get_content(5) == opponent && field.is_free(9)) || (field.is_free(1) && field.get_content(1) == opponent && field.is_free(3) && field.is_free(6) && field.get_content(8) == opponent))
                { result_of_AI = 3; }

                else if ((field.is_free(1) && field.is_free(2) && field.get_content(2) == opponent && field.get_content(3) == opponent && field.is_free(7)) || (field.is_free(1) && field.get_content(1) == opponent && field.is_free(3) && field.is_free(4) && field.get_content(6) == opponent))
                { result_of_AI = 1; }

                else if ((field.get_content(2) == opponent && field.is_free(6) && field.is_free(7) && field.get_content(7) == opponent && field.is_free(9)) || (field.is_free(3) && field.get_content(5) == opponent && field.get_content(6) == opponent && field.is_free(8) && field.is_free(9)))
                { result_of_AI = 9; }

                /***

                -4:-

                ***/

                else if (field.is_free(1) && field.get_content(3) == opponent && field.is_free(7) && field.get_content(7) == opponent && field.is_free(9))
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)

                        result_of_AI = 1;

                    else if (help_for_random == 1)

                        result_of_AI = 7;

                    else result_of_AI = 9;
                }

                else if (field.is_free(1) && field.get_content(1) == opponent && field.is_free(3) && field.get_content(5) == opponent && field.is_free(9))
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else if (help_for_random == 1)
                        result_of_AI = 3;

                    else result_of_AI = 9;
                }

                else if (field.is_free(1) && field.get_content(1) == opponent && field.is_free(3) && field.get_content(3) == opponent && field.is_free(7))
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else if (help_for_random == 1)
                        result_of_AI = 3;

                    else
                        result_of_AI = 7;
                }

                else if (field.is_free(3) && field.get_content(5) == opponent && field.is_free(7) && field.get_content(7) == opponent && field.is_free(9))
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 3;

                    else if (help_for_random == 1)
                        result_of_AI = 7;

                    else
                        result_of_AI = 9;
                }

                /***

                -5:-

                ***/

                else if (field.get_content(0) == opponent && field.is_free(4) && field.is_free(7) && field.is_free(8) && field.get_content(8) == opponent)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 4;

                    else
                        result_of_AI = 8;
                }

                else if (field.get_content(0) == opponent && field.is_free(2) && field.is_free(3) && field.is_free(6) && field.get_content(8) == opponent)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 2;

                    else
                        result_of_AI = 6;
                }

                else if (field.is_free(1) && field.is_free(2) && field.get_content(2) == opponent && field.is_free(4) && field.get_content(6) == opponent)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 2;

                    else
                        result_of_AI = 4;
                }

                else if (field.get_content(2) == opponent && field.is_free(6) && field.get_content(6) == opponent && field.is_free(8) && field.is_free(9))
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 6;

                    else
                        result_of_AI = 8;
                }

                /*******************

                Looks for own tricks

                *******************/

                /***

                -1:-

                ***/

                else if ((field.get_content(0) == actual_player && field.is_free(4) && field.is_free(7) && field.get_content(7) == actual_player && field.is_free(9)) || (field.is_free(1) && field.get_content(3) == actual_player && field.is_free(7) && field.is_free(8) && field.get_content(8) == actual_player))
                { result_of_AI = 7; }

                else if ((field.get_content(0) == actual_player && field.is_free(2) && field.is_free(3) && field.get_content(5) == actual_player && field.is_free(9)) || (field.is_free(1) && field.get_content(1) == actual_player && field.is_free(3) && field.is_free(6) && field.get_content(8) == actual_player))
                { result_of_AI = 3; }

                else if ((field.is_free(1) && field.is_free(2) && field.get_content(2) == actual_player && field.get_content(3) == actual_player && field.is_free(7)) || (field.is_free(1) && field.get_content(1) == actual_player && field.is_free(3) && field.is_free(4) && field.get_content(6) == actual_player))
                { result_of_AI = 1; }

                else if ((field.get_content(2) == actual_player && field.is_free(6) && field.is_free(7) && field.get_content(7) == actual_player && field.is_free(9)) || (field.is_free(3) && field.get_content(5) == actual_player && field.get_content(6) == actual_player && field.is_free(8) && field.is_free(9)))
                { result_of_AI = 9; }

                /***

                -2:-

                ***/

                else if (field.is_free(1) && field.get_content(3) == actual_player && field.is_free(7) && field.get_content(7) == actual_player && field.is_free(9))
                { result_of_AI = 7; }

                else if (field.is_free(1) && field.get_content(1) == actual_player && field.is_free(3) && field.get_content(5) == actual_player && field.is_free(9))
                { result_of_AI = 3; }

                else if (field.is_free(1) && field.get_content(1) == actual_player && field.is_free(3) && field.get_content(3) == actual_player && field.is_free(7))
                { result_of_AI = 1; }

                else if (field.is_free(3) && field.get_content(5) == actual_player && field.is_free(7) && field.get_content(7) == actual_player && field.is_free(9))
                { result_of_AI = 9; }

                /***

                -3:-

                ***/

                else if (field.get_content(0) == actual_player && field.is_free(4) && field.is_free(7) && field.is_free(8) && field.get_content(8) == actual_player)
                { result_of_AI = 7; }

                else if (field.get_content(0) == actual_player && field.is_free(2) && field.is_free(3) && field.is_free(6) && field.get_content(8) == actual_player)
                { result_of_AI = 3; }

                else if (field.is_free(1) && field.is_free(2) && field.get_content(2) == actual_player && field.is_free(4) && field.get_content(6) == actual_player)
                { result_of_AI = 1; }

                else if (field.get_content(2) == actual_player && field.is_free(6) && field.get_content(6) == actual_player && field.is_free(8) && field.is_free(9))
                { result_of_AI = 9; }

                /****************

                sets random actual_player

                ****************/

                else
                {
                    do
                    {
                        help_for_random = random.Next(1, 10);

                    } while (!field.is_free(help_for_random));

                    result_of_AI = help_for_random;
                }

	        }
	        else
	        {
                result_of_AI = 5;
	        }

            if (result_of_AI == 0)
            {
                Console.WriteLine("Something went wrong. Ask Computer why.");
            }

            Console.WriteLine("The Player inserts: " + result_of_AI);
            return result_of_AI;
        }

        private int normal_level_AI(Field field,char opponent,char actual_player) 
        {
            Random random = new Random();

            int help_for_random;
            int result_of_AI=0;

	        if (field.get_content(4)==opponent|| field.get_content(4)==actual_player)
            {

		        /***********************************************************

		        Is the first step of the Player '5', set actual_player into a corner

		        ***********************************************************/

                if (field.get_content(4) == opponent && field.is_free(1) && field.is_free(2) && field.is_free(3) && field.is_free(4) && field.is_free(6) && field.is_free(7) && field.is_free(8) && field.is_free(9))
                {

                    help_for_random = random.Next(0, 4);

                    switch (help_for_random)
                    {

                        case 0:
                            result_of_AI = 1;
                            break;

                        case 1:
                            result_of_AI = 3;
                            break;

                        case 2:
                            result_of_AI = 7;
                            break;

                        case 3:
                            result_of_AI = 9;
                            break;

                        default:
                            Console.WriteLine("Some Mistake has happened");
                            break;
                    }
                }

                /********************************

                Looks if actual_player could directly win

                ********************************/

                else if (field.is_free(1) && ((field.get_content(1) == actual_player && field.get_content(2) == actual_player) || (field.get_content(4) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(6) == actual_player)))
                { result_of_AI = 1; }

                else if (field.is_free(3) && ((field.get_content(0) == actual_player && field.get_content(1) == actual_player) || (field.get_content(4) == actual_player && field.get_content(6) == actual_player) || (field.get_content(5) == actual_player && field.get_content(8) == actual_player)))
                { result_of_AI = 3; }

                else if (field.is_free(7) && ((field.get_content(0) == actual_player && field.get_content(3) == actual_player) || (field.get_content(2) == actual_player && field.get_content(4) == actual_player) || (field.get_content(7) == actual_player && field.get_content(8) == actual_player)))
                { result_of_AI = 7; }

                else if (field.is_free(9) && ((field.get_content(0) == actual_player && field.get_content(4) == actual_player) || (field.get_content(2) == actual_player && field.get_content(5) == actual_player) || (field.get_content(6) == actual_player && field.get_content(7) == actual_player)))
                { result_of_AI = 9; }

                else if (field.is_free(2) && ((field.get_content(0) == actual_player && field.get_content(2) == actual_player) || (field.get_content(4) == actual_player && field.get_content(7) == actual_player)))
                { result_of_AI = 2; }

                else if (field.is_free(4) && ((field.get_content(0) == actual_player && field.get_content(6) == actual_player) || (field.get_content(4) == actual_player && field.get_content(5) == actual_player)))
                { result_of_AI = 4; }

                else if (field.is_free(6) && ((field.get_content(2) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(4) == actual_player)))
                { result_of_AI = 6; }

                else if (field.is_free(8) && ((field.get_content(1) == actual_player && field.get_content(4) == actual_player) || (field.get_content(6) == actual_player && field.get_content(8) == actual_player)))
                { result_of_AI = 8; }

                else if (field.is_free(5) && ((field.get_content(1) == actual_player && field.get_content(7) == actual_player) || (field.get_content(0) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(5) == actual_player) || (field.get_content(2) == actual_player && field.get_content(6) == actual_player)))
                { result_of_AI = 5; }

                /********************************

                Looks if opponent could directly win

                *********************************/

                else if (field.is_free(1) && ((field.get_content(1) == opponent && field.get_content(2) == opponent) || (field.get_content(4) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(6) == opponent)))
                { result_of_AI = 1; }

                else if (field.is_free(3) && ((field.get_content(0) == opponent && field.get_content(1) == opponent) || (field.get_content(4) == opponent && field.get_content(6) == opponent) || (field.get_content(5) == opponent && field.get_content(8) == opponent)))
                { result_of_AI = 3; }

                else if (field.is_free(7) && ((field.get_content(0) == opponent && field.get_content(3) == opponent) || (field.get_content(2) == opponent && field.get_content(4) == opponent) || (field.get_content(7) == opponent && field.get_content(8) == opponent)))
                { result_of_AI = 7; }

                else if (field.is_free(9) && ((field.get_content(0) == opponent && field.get_content(4) == opponent) || (field.get_content(2) == opponent && field.get_content(5) == opponent) || (field.get_content(6) == opponent && field.get_content(7) == opponent)))
                { result_of_AI = 9; }

                else if (field.is_free(2) && ((field.get_content(0) == opponent && field.get_content(2) == opponent) || (field.get_content(4) == opponent && field.get_content(7) == opponent)))
                { result_of_AI = 2; }

                else if (field.is_free(4) && ((field.get_content(0) == opponent && field.get_content(6) == opponent) || (field.get_content(4) == opponent && field.get_content(5) == opponent)))
                { result_of_AI = 4; }

                else if (field.is_free(6) && ((field.get_content(2) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(4) == opponent)))
                { result_of_AI = 6; }

                else if (field.is_free(8) && ((field.get_content(1) == opponent && field.get_content(4) == opponent) || (field.get_content(6) == opponent && field.get_content(8) == opponent)))
                { result_of_AI = 8; }

                else if (field.is_free(5) && ((field.get_content(1) == opponent && field.get_content(7) == opponent) || (field.get_content(0) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(5) == opponent) || (field.get_content(2) == opponent && field.get_content(6) == opponent)))
                { result_of_AI = 5; }

                /************************

                Looks for tricks of opponent

                ************************/

                /***

                -1:-

                ***/

                else if (field.is_free(1) && field.is_free(2) && field.get_content(2) == actual_player && field.get_content(3) == actual_player && field.get_content(4) == opponent && field.get_content(5) == opponent && field.get_content(6) == opponent && field.is_free(8) && field.is_free(9))
                { result_of_AI = random.Next(0, 2) + 1; }

                else if (field.get_content(0) == opponent && field.is_free(2) && field.is_free(3) && field.get_content(3) == actual_player && field.get_content(4) == opponent && field.get_content(5) == opponent && field.is_free(7) && field.is_free(8) && field.get_content(8) == actual_player)
                { result_of_AI = random.Next(0, 2) + 7; }

                else if (field.is_free(1) && field.is_free(2) && field.get_content(2) == opponent && field.get_content(3) == opponent && field.get_content(4) == opponent && field.get_content(5) == actual_player && field.get_content(6) == actual_player && field.is_free(8) && field.is_free(9))
                { result_of_AI = random.Next(0, 2) + 8; }

                else if (field.get_content(0) == actual_player && field.is_free(2) && field.is_free(3) && field.get_content(3) == opponent && field.get_content(4) == opponent && field.get_content(5) == actual_player && field.is_free(7) && field.is_free(8) && field.get_content(8) == opponent)
                { result_of_AI = random.Next(0, 2) + 2; }

                else if (field.get_content(0) == actual_player && field.get_content(1) == opponent && field.is_free(3) && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.is_free(7) && field.get_content(7) == actual_player && field.get_content(8) == opponent)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 4;

                    else
                        result_of_AI = 7;
                }

                else if (field.is_free(1) && field.get_content(1) == opponent && field.get_content(2) == actual_player && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.get_content(6) == opponent && field.get_content(7) == actual_player && field.is_free(9))
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 6;

                    else
                        result_of_AI = 9;
                }

                else if (field.get_content(0) == opponent && field.get_content(1) == actual_player && field.is_free(3) && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.is_free(7) && field.get_content(7) == opponent && field.get_content(8) == actual_player)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 3;

                    else
                        result_of_AI = 6;
                }

                else if (field.is_free(1) && field.get_content(1) == actual_player && field.get_content(2) == opponent && field.is_free(4) && field.get_content(4) == opponent && field.is_free(6) && field.get_content(6) == actual_player && field.get_content(7) == opponent && field.is_free(9))
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else
                        result_of_AI = 4;
                }

                /***

                -2:-

                ***/

                else if (field.is_free(1) && field.get_content(3) == opponent && field.is_free(7) && field.get_content(7) == opponent && field.is_free(9))
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)

                        result_of_AI = 1;

                    else if (help_for_random == 1)

                        result_of_AI = 7;

                    else result_of_AI = 9;
                }

                else if (field.is_free(1) && field.get_content(1) == opponent && field.is_free(3) && field.get_content(5) == opponent && field.is_free(9))
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else if (help_for_random == 1)
                        result_of_AI = 3;

                    else result_of_AI = 9;
                }

                else if (field.is_free(1) && field.get_content(1) == opponent && field.is_free(3) && field.get_content(3) == opponent && field.is_free(7))
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else if (help_for_random == 1)
                        result_of_AI = 3;

                    else
                        result_of_AI = 7;
                }

                else if (field.is_free(3) && field.get_content(5) == opponent && field.is_free(7) && field.get_content(7) == opponent && field.is_free(9))
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 3;

                    else if (help_for_random == 1)
                        result_of_AI = 7;

                    else
                        result_of_AI = 9;
                }

                /****************

                sets random actual_player

                *****************/

                else
                {
                    do
                    {
                        help_for_random = random.Next(1, 10);

                    } while (!field.is_free(help_for_random));

                    result_of_AI = help_for_random;
                }

	        }
	        else
	        {
                result_of_AI = 5;
	        }

            if (result_of_AI == 0)
            {
                Console.WriteLine("Something wnt wrong. Ask Computer why.");
            }

            Console.WriteLine("The Player inserts: " + result_of_AI);
            return result_of_AI;
        }

        private int low_level_AI(Field field,char opponent,char actual_player)
        {
            Random random = new Random();
            int result_of_AI;
            int help_for_random;

            /********************************

            Looks if actual_player could directly win

            ********************************/

            if (field.is_free(1) && ((field.get_content(1) == actual_player && field.get_content(2) == actual_player) || (field.get_content(4) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(6) == actual_player)))
            { result_of_AI = 1; }

            else if (field.is_free(3) && ((field.get_content(0) == actual_player && field.get_content(1) == actual_player) || (field.get_content(4) == actual_player && field.get_content(6) == actual_player) || (field.get_content(5) == actual_player && field.get_content(8) == actual_player)))
            { result_of_AI = 3; }

            else if (field.is_free(7) && ((field.get_content(0) == actual_player && field.get_content(3) == actual_player) || (field.get_content(2) == actual_player && field.get_content(4) == actual_player) || (field.get_content(7) == actual_player && field.get_content(8) == actual_player)))
            { result_of_AI = 7; }

            else if (field.is_free(9) && ((field.get_content(0) == actual_player && field.get_content(4) == actual_player) || (field.get_content(2) == actual_player && field.get_content(5) == actual_player) || (field.get_content(6) == actual_player && field.get_content(7) == actual_player)))
            { result_of_AI = 9; }

            else if (field.is_free(2) && ((field.get_content(0) == actual_player && field.get_content(2) == actual_player) || (field.get_content(4) == actual_player && field.get_content(7) == actual_player)))
            { result_of_AI = 2; }

            else if (field.is_free(4) && ((field.get_content(0) == actual_player && field.get_content(6) == actual_player) || (field.get_content(4) == actual_player && field.get_content(5) == actual_player)))
            { result_of_AI = 4; }

            else if (field.is_free(6) && ((field.get_content(2) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(4) == actual_player)))
            { result_of_AI = 6; }

            else if (field.is_free(8) && ((field.get_content(1) == actual_player && field.get_content(4) == actual_player) || (field.get_content(6) == actual_player && field.get_content(8) == actual_player)))
            { result_of_AI = 8; }

            else if (field.is_free(5) && ((field.get_content(1) == actual_player && field.get_content(7) == actual_player) || (field.get_content(0) == actual_player && field.get_content(8) == actual_player) || (field.get_content(3) == actual_player && field.get_content(5) == actual_player) || (field.get_content(2) == actual_player && field.get_content(6) == actual_player)))
            { result_of_AI = 5; }

            /********************************

            Looks if opponent could directly win

            *********************************/

            else if (field.is_free(1) && ((field.get_content(1) == opponent && field.get_content(2) == opponent) || (field.get_content(4) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(6) == opponent)))
            { result_of_AI = 1; }

            else if (field.is_free(3) && ((field.get_content(0) == opponent && field.get_content(1) == opponent) || (field.get_content(4) == opponent && field.get_content(6) == opponent) || (field.get_content(5) == opponent && field.get_content(8) == opponent)))
            { result_of_AI = 3; }

            else if (field.is_free(7) && ((field.get_content(0) == opponent && field.get_content(3) == opponent) || (field.get_content(2) == opponent && field.get_content(4) == opponent) || (field.get_content(7) == opponent && field.get_content(8) == opponent)))
            { result_of_AI = 7; }

            else if (field.is_free(9) && ((field.get_content(0) == opponent && field.get_content(4) == opponent) || (field.get_content(2) == opponent && field.get_content(5) == opponent) || (field.get_content(6) == opponent && field.get_content(7) == opponent)))
            { result_of_AI = 9; }

            else if (field.is_free(2) && ((field.get_content(0) == opponent && field.get_content(2) == opponent) || (field.get_content(4) == opponent && field.get_content(7) == opponent)))
            { result_of_AI = 2; }

            else if (field.is_free(4) && ((field.get_content(0) == opponent && field.get_content(6) == opponent) || (field.get_content(4) == opponent && field.get_content(5) == opponent)))
            { result_of_AI = 4; }

            else if (field.is_free(6) && ((field.get_content(2) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(4) == opponent)))
            { result_of_AI = 6; }

            else if (field.is_free(8) && ((field.get_content(1) == opponent && field.get_content(4) == opponent) || (field.get_content(6) == opponent && field.get_content(8) == opponent)))
            { result_of_AI = 8; }

            else if (field.is_free(5) && ((field.get_content(1) == opponent && field.get_content(7) == opponent) || (field.get_content(0) == opponent && field.get_content(8) == opponent) || (field.get_content(3) == opponent && field.get_content(5) == opponent) || (field.get_content(2) == opponent && field.get_content(6) == opponent)))
            { result_of_AI = 5; }

            /****************

            sets random actual_player

            *****************/

            else
            {
                do
                {
                    help_for_random = random.Next(1, 10);

                } while (!field.is_free(help_for_random));

                result_of_AI = help_for_random;
            }
            Console.WriteLine("The Player tries: " + result_of_AI);
            return result_of_AI;
        }

    }
}