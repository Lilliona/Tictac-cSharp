﻿using System;

namespace Tictic
{
    public class Controller
    {
        private Player player1;
        private Player player2;
        private Field field;

        private int win_counter_player1;
        private int win_counter_player2;
        private int win_counter_draw;

        private void choose_Player()
        {
            int input_for_Player1;
            int input_for_Player2;

            Console.WriteLine("From what type is Player 1?");
            Console.WriteLine(" [1] Human");
            Console.WriteLine(" [2] Computer");

            while (!Int32.TryParse(Console.ReadLine(), out input_for_Player1) || input_for_Player1 < 1 || input_for_Player1 > 2)
            {
                if (input_for_Player1 < 1 || input_for_Player1 > 2)
                {
                    Console.WriteLine("Your Input is invalid. Please enter a value between 1 and 2:");
                }
                else 
                {
                    Console.WriteLine("Your Input is invalid. Please enter a number:");
                }
            }

                Console.WriteLine("From what type is Player 2?");
                Console.WriteLine(" [1] Human");
                Console.WriteLine(" [2] Computer");
                Console.WriteLine();

                while (!Int32.TryParse(Console.ReadLine(), out input_for_Player2) || input_for_Player2 < 1 || input_for_Player2 > 2)
                {
                    if (input_for_Player2 < 1 || input_for_Player2 > 2)
                    {
                        Console.WriteLine("Your Input is invalid. Please enter a value between 1 and 2:");
                    }
                    else
                    {
                        Console.WriteLine("Your Input is invalid. Please enter a number:");
                    }
                }

            if (input_for_Player1 == 1)
            {
                player1 = new Human();
            }
            else if (input_for_Player1 == 2)
            {
                int choose_difficulty;
                Console.WriteLine(" What difficulty do you wish?");
                Console.WriteLine("  [1] Easy");
                Console.WriteLine("  [2] Normal");
                Console.WriteLine("  [3] Hard");

                while (!Int32.TryParse(Console.ReadLine(), out choose_difficulty) || choose_difficulty < 1 || choose_difficulty > 3)
                {
                    if (choose_difficulty < 1 || choose_difficulty > 3)
                    {
                        Console.WriteLine("Your Input is invalid. Please enter a value between 1 and 3:");
                    }
                    else
                    {
                        Console.WriteLine("Your Input is invalid. Please enter a number:");
                    }
                }

                Console.WriteLine();
                player1 = new Computer(choose_difficulty);
            }

            if (input_for_Player2 == 1)
            {
                player2 = new Human();
            }
            else if (input_for_Player2 == 2)
            {
                int choose_difficulty;
                Console.WriteLine(" What difficulty do you wish?");
                Console.WriteLine("  [1] Easy");
                Console.WriteLine("  [2] Normal");
                Console.WriteLine("  [3] Hard");

                while (!Int32.TryParse(Console.ReadLine(), out choose_difficulty) || choose_difficulty < 1 || choose_difficulty > 3)
                {
                    if (choose_difficulty < 1 || choose_difficulty > 3)
                    {
                        Console.WriteLine("Your Input is invalid. Please enter a value between 1 and 3:");
                    }
                    else
                    {
                        Console.WriteLine("Your Input is invalid. Please enter a number:");
                    }
                }
                Console.WriteLine();
                player2 = new Computer(choose_difficulty);
            }
        }

        private void turn()
        {
            char mark1,mark2;//bekommt den Wert X oder O je nach Spieler
            int who_inserts = 1;//Wechsel zwischen Spielern durch %2
            int fieldtarget_of_player = 0;//überbringt das gewählte Feld vom aktuellen Spieler
            int i = -1; //sagt durch bestimmen von Gewinner/Draw ob das Spiel weiter geht

            do
            {
                show_field();
                
                who_inserts = who_inserts % 2;

                if (who_inserts == 1)
                {
                    Console.WriteLine("Player 1: ");
                    mark1 = 'X';
                    mark2 = 'O';
                    fieldtarget_of_player = player1.get_fieldtarget(field,mark2,mark1);


                }
                else
                {
                    Console.WriteLine("Player 2: ");
                    mark1 = 'O';
                    mark2 = 'X';
                    fieldtarget_of_player = player2.get_fieldtarget(field,mark2,mark1);


                }

                /*******************************

                Sets the mark at a free position

                *******************************/

                if (fieldtarget_of_player == 1 && field.get_fieldcontent(0) == '1')
                {
                    field.set_fieldcontent(0, mark1);
                }
                else if (fieldtarget_of_player == 2 && field.get_fieldcontent(1) == '2')
                {
                    field.set_fieldcontent(1, mark1);
                }
                else if (fieldtarget_of_player == 3 && field.get_fieldcontent(2) == '3')
                {
                    field.set_fieldcontent(2, mark1);
                }
                else if (fieldtarget_of_player == 4 && field.get_fieldcontent(3) == '4')
                {
                    field.set_fieldcontent(3, mark1);
                }
                else if (fieldtarget_of_player == 5 && field.get_fieldcontent(4) == '5')
                {
                    field.set_fieldcontent(4, mark1);
                }
                else if (fieldtarget_of_player == 6 && field.get_fieldcontent(5) == '6')
                {
                    field.set_fieldcontent(5, mark1);
                }
                else if (fieldtarget_of_player == 7 && field.get_fieldcontent(6) == '7')
                {
                    field.set_fieldcontent(6, mark1);
                }
                else if (fieldtarget_of_player == 8 && field.get_fieldcontent(7) == '8')
                {
                    field.set_fieldcontent(7, mark1);
                }
                else if (fieldtarget_of_player == 9 && field.get_fieldcontent(8) == '9')
                {
                    field.set_fieldcontent(8, mark1);
                }
                else
                {
                    Console.WriteLine("Invalid move!");
                    continue;
                }

                who_inserts++;
                i=check_if_won();

            } while (i == -1);

            show_field();

            if (i == 1)
            {
                if (who_inserts == 2)
                {
                    Console.WriteLine("Player 1 won!");
                    win_counter_player1 = win_counter_player1 + 1;
                }
                else
                {
                    Console.WriteLine("Player 2 won!");
                    win_counter_player2 = win_counter_player2 + 1;
                }
            }
            else
            {
                Console.WriteLine("Draw!");
                win_counter_draw = win_counter_draw + 1;
            }
        }

        public void start()
        {
            win_counter_player1 = 0;
            win_counter_player2 = 0;
            int continueoptions = 0;
            field = new Field();
            choose_Player();
            turn();
            do
            {
                Console.WriteLine("How do you wish to continue?");
                Console.WriteLine("[1] Next Round with same options");
                Console.WriteLine("[2] Next Round with new options");
                Console.WriteLine("[3] Exit");
                continueoptions = Convert.ToInt32(Console.ReadLine());

                field = new Field();

                switch (continueoptions)
                {
                    case 2:
                        choose_Player();
                        turn();
                        break;
                    case 1:
                        turn();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("This is no option! Please try again:");
                        break;
                }

                Console.WriteLine("Spielstand");
                Console.WriteLine("----------");
                Console.WriteLine("Player 1: " + win_counter_player1);
                Console.WriteLine("Player 2: " + win_counter_player2);
                Console.WriteLine("Draw: " + win_counter_draw);
            } while (continueoptions != 3);
            

            show_field();
        }

        private void show_field()
        {
            Console.WriteLine();
            for (int iterationnumber = 0; iterationnumber < 9; iterationnumber += 3)
            {
                Console.WriteLine(" " + field.get_fieldcontent(iterationnumber) + " | " + field.get_fieldcontent(iterationnumber + 1) + " | " + field.get_fieldcontent(iterationnumber + 2));
                if (iterationnumber < 6)
                {
                    Console.WriteLine("-----------");
                }
            }
            Console.WriteLine();
        }
        public void give_information_about_field()
        {
            field.get_fieldcontent(1);
        }

        private int check_if_won()
        {
	        if ((field.get_fieldcontent(0) == field.get_fieldcontent(1) && field.get_fieldcontent(1) == field.get_fieldcontent(2)) 

		        || (field.get_fieldcontent(3) == field.get_fieldcontent(4) && field.get_fieldcontent(4) == field.get_fieldcontent(5)) 

		        || (field.get_fieldcontent(6) == field.get_fieldcontent(7) && field.get_fieldcontent(7) == field.get_fieldcontent(8))

		        || (field.get_fieldcontent(0) == field.get_fieldcontent(3) && field.get_fieldcontent(3) == field.get_fieldcontent(6))

		        || (field.get_fieldcontent(1) == field.get_fieldcontent(4) && field.get_fieldcontent(4) == field.get_fieldcontent(7))

		        || (field.get_fieldcontent(2) == field.get_fieldcontent(5) && field.get_fieldcontent(5) == field.get_fieldcontent(8))

		        || (field.get_fieldcontent(0) == field.get_fieldcontent(4) && field.get_fieldcontent(4) == field.get_fieldcontent(8))

		        || (field.get_fieldcontent(2) == field.get_fieldcontent(4) && field.get_fieldcontent(4) == field.get_fieldcontent(6)))
	        {
		        return 1;
	        }
	        else if ((field.get_fieldcontent(0) != '1') && (field.get_fieldcontent(1) != '2') && (field.get_fieldcontent(2) != '3') 

		        && (field.get_fieldcontent(3) != '4') && (field.get_fieldcontent(4) != '5') && (field.get_fieldcontent(5) != '6') 

                && (field.get_fieldcontent(6) != '7') && (field.get_fieldcontent(7) != '8') && (field.get_fieldcontent(8) != '9'))
	        {
                return 0;
            }
	        else
	        {	
		        return -1;
	        }
        }

    }
}
