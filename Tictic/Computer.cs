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

        public override int get_fieldtarget(Field field,char mark1,char mark2)
        {
            int ask_for_fieldtarget=0;
            
            if (choice_for_intelligence == 1)
            {
                ask_for_fieldtarget=low_level_AI(field,mark1,mark2);
            }
            else if (choice_for_intelligence == 2)
            {
                ask_for_fieldtarget=normal_level_AI(field,mark1,mark2);
            }
            else if (choice_for_intelligence == 3)
            {
                ask_for_fieldtarget = high_level_AI(field,mark1,mark2);
            }
            else
            {
                Console.WriteLine("This value is no option!");
            }

            return ask_for_fieldtarget;
        }

        private int high_level_AI(Field field,char mark1,char mark2) 
        {
            /*mark1=opponent*/
            /*mark2=actual player*/

            Random random;
            random = new Random();

            int help_for_random;
            int result_of_AI=0;

	        if (field.get_fieldcontent(4)==mark1|| field.get_fieldcontent(4)==mark2)
            {

		        /***********************************************************

		        Is the first step of the Player '5', set mark2 into a corner

		        ***********************************************************/

                if (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9')
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

                Looks if mark2 could directly win

                ********************************/

                else if (field.get_fieldcontent(0) == '1' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(6) == mark2)))
                { result_of_AI = 1; }

                else if (field.get_fieldcontent(2) == '3' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(6) == mark2) || (field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(8) == mark2)))
                { result_of_AI = 3; }

                else if (field.get_fieldcontent(6) == '7' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(3) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == mark2)))
                { result_of_AI = 7; }

                else if (field.get_fieldcontent(8) == '9' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(5) == mark2) || (field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == mark2)))
                { result_of_AI = 9; }

                else if (field.get_fieldcontent(1) == '2' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(2) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(7) == mark2)))
                { result_of_AI = 2; }

                else if (field.get_fieldcontent(3) == '4' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(6) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(5) == mark2)))
                { result_of_AI = 4; }

                else if (field.get_fieldcontent(5) == '6' && ((field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(4) == mark2)))
                { result_of_AI = 6; }

                else if (field.get_fieldcontent(7) == '8' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(8) == mark2)))
                { result_of_AI = 8; }

                else if (field.get_fieldcontent(4) == '5' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(7) == mark2) || (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(5) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(6) == mark2)))
                { result_of_AI = 5; }

                /********************************

                Looks if mark1 could directly win

                ********************************/

                else if (field.get_fieldcontent(0) == '1' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == mark1)))
                { result_of_AI = 1; }

                else if (field.get_fieldcontent(2) == '3' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(6) == mark1) || (field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(8) == mark1)))
                { result_of_AI = 3; }

                else if (field.get_fieldcontent(6) == '7' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(3) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == mark1)))
                { result_of_AI = 7; }

                else if (field.get_fieldcontent(8) == '9' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(5) == mark1) || (field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == mark1)))
                { result_of_AI = 9; }

                else if (field.get_fieldcontent(1) == '2' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(2) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(7) == mark1)))
                { result_of_AI = 2; }

                else if (field.get_fieldcontent(3) == '4' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(6) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark1)))
                { result_of_AI = 4; }

                else if (field.get_fieldcontent(5) == '6' && ((field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(4) == mark1)))
                { result_of_AI = 6; }

                else if (field.get_fieldcontent(7) == '8' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(8) == mark1)))
                { result_of_AI = 8; }

                else if (field.get_fieldcontent(4) == '5' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(7) == mark1) || (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(5) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(6) == mark1)))
                { result_of_AI = 5; }

                /************************

                Looks for tricks of mark1

                *************************/

                /***

                -1:-

                ***/

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9')
                { result_of_AI = random.Next(0, 2) + 1; }

                else if (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark2)
                { result_of_AI = random.Next(0, 2) + 7; }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9')
                { result_of_AI = random.Next(0, 2) + 8; }

                else if (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark1)
                { result_of_AI = random.Next(0, 2) + 2; }

                else if (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == mark1)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 4;

                    else
                        result_of_AI = 7;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == '9')
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 6;

                    else
                        result_of_AI = 9;
                }

                else if (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == mark2)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 3;

                    else
                        result_of_AI = 6;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == '9')
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

                else if ((field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9') || (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9'))
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else
                        result_of_AI = 9;
                }

                else if ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark1))
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

                else if ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == '9') || (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark1))
                { result_of_AI = 7; }

                else if ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(8) == '9') || (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(8) == mark1))
                { result_of_AI = 3; }

                else if ((field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == '7') || (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(6) == mark1))
                { result_of_AI = 1; }

                else if ((field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == '9') || (field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9'))
                { result_of_AI = 9; }

                /***

                -4:-

                ***/

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == '9')
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)

                        result_of_AI = 1;

                    else if (help_for_random == 1)

                        result_of_AI = 7;

                    else result_of_AI = 9;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(8) == '9')
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else if (help_for_random == 1)
                        result_of_AI = 3;

                    else result_of_AI = 9;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == '7')
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else if (help_for_random == 1)
                        result_of_AI = 3;

                    else
                        result_of_AI = 7;
                }

                else if (field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == '9')
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

                else if (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark1)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 4;

                    else
                        result_of_AI = 8;
                }

                else if (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(8) == mark1)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 2;

                    else
                        result_of_AI = 6;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(6) == mark1)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 2;

                    else
                        result_of_AI = 4;
                }

                else if (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9')
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

                else if ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == '9') || (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark2))
                { result_of_AI = 7; }

                else if ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(8) == '9') || (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(8) == mark2))
                { result_of_AI = 3; }

                else if ((field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(6) == '7') || (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(6) == mark2))
                { result_of_AI = 1; }

                else if ((field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == '9') || (field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9'))
                { result_of_AI = 9; }

                /***

                -2:-

                ***/

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == '9')
                { result_of_AI = 7; }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(8) == '9')
                { result_of_AI = 3; }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(6) == '7')
                { result_of_AI = 1; }

                else if (field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == '9')
                { result_of_AI = 9; }

                /***

                -3:-

                ***/

                else if (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark2)
                { result_of_AI = 7; }

                else if (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(8) == mark2)
                { result_of_AI = 3; }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(6) == mark2)
                { result_of_AI = 1; }

                else if (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9')
                { result_of_AI = 9; }

                /****************

                sets random mark2

                ****************/

                else
                {
                    do
                    {
                        help_for_random = random.Next(1, 10);

                    } while (field.get_fieldcontent(help_for_random - 1) == mark1 || field.get_fieldcontent(help_for_random - 1) == mark2);

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

        private int normal_level_AI(Field field,char mark1,char mark2) 
        {
            /*mark1=opponent*/
            /*mark2=actual player*/

            Random random;
            random = new Random();

            int help_for_random;
            int result_of_AI=0;

	        if (field.get_fieldcontent(4)==mark1|| field.get_fieldcontent(4)==mark2)
            {

		        /***********************************************************

		        Is the first step of the Player '5', set mark2 into a corner

		        ***********************************************************/

                if (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9')
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

                Looks if mark2 could directly win

                ********************************/

                else if (field.get_fieldcontent(0) == '1' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(6) == mark2)))
                { result_of_AI = 1; }

                else if (field.get_fieldcontent(2) == '3' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(6) == mark2) || (field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(8) == mark2)))
                { result_of_AI = 3; }

                else if (field.get_fieldcontent(6) == '7' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(3) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == mark2)))
                { result_of_AI = 7; }

                else if (field.get_fieldcontent(8) == '9' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(5) == mark2) || (field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == mark2)))
                { result_of_AI = 9; }

                else if (field.get_fieldcontent(1) == '2' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(2) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(7) == mark2)))
                { result_of_AI = 2; }

                else if (field.get_fieldcontent(3) == '4' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(6) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(5) == mark2)))
                { result_of_AI = 4; }

                else if (field.get_fieldcontent(5) == '6' && ((field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(4) == mark2)))
                { result_of_AI = 6; }

                else if (field.get_fieldcontent(7) == '8' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(8) == mark2)))
                { result_of_AI = 8; }

                else if (field.get_fieldcontent(4) == '5' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(7) == mark2) || (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(5) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(6) == mark2)))
                { result_of_AI = 5; }

                /********************************

                Looks if mark1 could directly win

                *********************************/

                else if (field.get_fieldcontent(0) == '1' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == mark1)))
                { result_of_AI = 1; }

                else if (field.get_fieldcontent(2) == '3' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(6) == mark1) || (field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(8) == mark1)))
                { result_of_AI = 3; }

                else if (field.get_fieldcontent(6) == '7' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(3) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == mark1)))
                { result_of_AI = 7; }

                else if (field.get_fieldcontent(8) == '9' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(5) == mark1) || (field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == mark1)))
                { result_of_AI = 9; }

                else if (field.get_fieldcontent(1) == '2' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(2) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(7) == mark1)))
                { result_of_AI = 2; }

                else if (field.get_fieldcontent(3) == '4' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(6) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark1)))
                { result_of_AI = 4; }

                else if (field.get_fieldcontent(5) == '6' && ((field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(4) == mark1)))
                { result_of_AI = 6; }

                else if (field.get_fieldcontent(7) == '8' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(8) == mark1)))
                { result_of_AI = 8; }

                else if (field.get_fieldcontent(4) == '5' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(7) == mark1) || (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(5) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(6) == mark1)))
                { result_of_AI = 5; }

                /************************

                Looks for tricks of mark1

                ************************/

                /***

                -1:-

                ***/

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9')
                { result_of_AI = random.Next(0, 2) + 1; }

                else if (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark2)
                { result_of_AI = random.Next(0, 2) + 7; }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == '9')
                { result_of_AI = random.Next(0, 2) + 8; }

                else if (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == '2' && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == '8' && field.get_fieldcontent(8) == mark1)
                { result_of_AI = random.Next(0, 2) + 2; }

                else if (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == mark1)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 4;

                    else
                        result_of_AI = 7;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == '9')
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 6;

                    else
                        result_of_AI = 9;
                }

                else if (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == mark2)
                {

                    help_for_random = random.Next(0, 2);

                    if (help_for_random == 0)
                        result_of_AI = 3;

                    else
                        result_of_AI = 6;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(3) == '4' && field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == '6' && field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == '9')
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

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == '9')
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)

                        result_of_AI = 1;

                    else if (help_for_random == 1)

                        result_of_AI = 7;

                    else result_of_AI = 9;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(8) == '9')
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else if (help_for_random == 1)
                        result_of_AI = 3;

                    else result_of_AI = 9;
                }

                else if (field.get_fieldcontent(0) == '1' && field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == '3' && field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == '7')
                {

                    help_for_random = random.Next(0, 3);

                    if (help_for_random == 0)
                        result_of_AI = 1;

                    else if (help_for_random == 1)
                        result_of_AI = 3;

                    else
                        result_of_AI = 7;
                }

                else if (field.get_fieldcontent(2) == '3' && field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(6) == '7' && field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == '9')
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

                sets random mark2

                *****************/

                else
                {
                    do
                    {
                        help_for_random = random.Next(1, 10);

                    } while (field.get_fieldcontent(help_for_random - 1) == mark1 || field.get_fieldcontent(help_for_random - 1) == mark2);

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

        private int low_level_AI(Field field,char mark1,char mark2)
        {
            Random random;
            random = new Random();
            int result_of_AI;
            int help_for_random;

            /********************************

            Looks if mark2 could directly win

            ********************************/

            if (field.get_fieldcontent(0) == '1' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(2) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(6) == mark2)))
            { result_of_AI = 1; }

            else if (field.get_fieldcontent(2) == '3' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(1) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(6) == mark2) || (field.get_fieldcontent(5) == mark2 && field.get_fieldcontent(8) == mark2)))
            { result_of_AI = 3; }

            else if (field.get_fieldcontent(6) == '7' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(3) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(7) == mark2 && field.get_fieldcontent(8) == mark2)))
            { result_of_AI = 7; }

            else if (field.get_fieldcontent(8) == '9' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(5) == mark2) || (field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(7) == mark2)))
            { result_of_AI = 9; }

            else if (field.get_fieldcontent(1) == '2' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(2) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(7) == mark2)))
            { result_of_AI = 2; }

            else if (field.get_fieldcontent(3) == '4' && ((field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(6) == mark2) || (field.get_fieldcontent(4) == mark2 && field.get_fieldcontent(5) == mark2)))
            { result_of_AI = 4; }

            else if (field.get_fieldcontent(5) == '6' && ((field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(4) == mark2)))
            { result_of_AI = 6; }

            else if (field.get_fieldcontent(7) == '8' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(4) == mark2) || (field.get_fieldcontent(6) == mark2 && field.get_fieldcontent(8) == mark2)))
            { result_of_AI = 8; }

            else if (field.get_fieldcontent(4) == '5' && ((field.get_fieldcontent(1) == mark2 && field.get_fieldcontent(7) == mark2) || (field.get_fieldcontent(0) == mark2 && field.get_fieldcontent(8) == mark2) || (field.get_fieldcontent(3) == mark2 && field.get_fieldcontent(5) == mark2) || (field.get_fieldcontent(2) == mark2 && field.get_fieldcontent(6) == mark2)))
            { result_of_AI = 5; }

            /********************************

            Looks if mark1 could directly win

            *********************************/

            else if (field.get_fieldcontent(0) == '1' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(2) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(6) == mark1)))
            { result_of_AI = 1; }

            else if (field.get_fieldcontent(2) == '3' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(1) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(6) == mark1) || (field.get_fieldcontent(5) == mark1 && field.get_fieldcontent(8) == mark1)))
            { result_of_AI = 3; }

            else if (field.get_fieldcontent(6) == '7' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(3) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(7) == mark1 && field.get_fieldcontent(8) == mark1)))
            { result_of_AI = 7; }

            else if (field.get_fieldcontent(8) == '9' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(5) == mark1) || (field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(7) == mark1)))
            { result_of_AI = 9; }

            else if (field.get_fieldcontent(1) == '2' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(2) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(7) == mark1)))
            { result_of_AI = 2; }

            else if (field.get_fieldcontent(3) == '4' && ((field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(6) == mark1) || (field.get_fieldcontent(4) == mark1 && field.get_fieldcontent(5) == mark1)))
            { result_of_AI = 4; }

            else if (field.get_fieldcontent(5) == '6' && ((field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(4) == mark1)))
            { result_of_AI = 6; }

            else if (field.get_fieldcontent(7) == '8' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(4) == mark1) || (field.get_fieldcontent(6) == mark1 && field.get_fieldcontent(8) == mark1)))
            { result_of_AI = 8; }

            else if (field.get_fieldcontent(4) == '5' && ((field.get_fieldcontent(1) == mark1 && field.get_fieldcontent(7) == mark1) || (field.get_fieldcontent(0) == mark1 && field.get_fieldcontent(8) == mark1) || (field.get_fieldcontent(3) == mark1 && field.get_fieldcontent(5) == mark1) || (field.get_fieldcontent(2) == mark1 && field.get_fieldcontent(6) == mark1)))
            { result_of_AI = 5; }

            /****************

            sets random mark2

            *****************/

            else
            {
                do
                {
                    help_for_random = random.Next(1, 10);

                } while (field.get_fieldcontent(help_for_random - 1) == mark1 || field.get_fieldcontent(help_for_random - 1) == mark2);

                result_of_AI = help_for_random;
            }
            Console.WriteLine("The Player tries: " + result_of_AI);
            return result_of_AI;
        }

    }
}