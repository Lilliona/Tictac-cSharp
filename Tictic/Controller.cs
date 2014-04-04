using System;

namespace Tictic
{
    public class Controller
    {
        private Player player1;
        private Player player2;
        private Field field;

        private void choose_Player()
        {
            int input_for_Player1;
            int input_for_Player2;

            do
            {
                Console.WriteLine("From what type is Player 1?");
                Console.WriteLine(" [1] Human");
                Console.WriteLine(" [2] Computer");
                input_for_Player1 = Convert.ToInt32(Console.ReadLine());
            } while (input_for_Player1 < 1 && input_for_Player1 > 2);

            do
            {
                Console.WriteLine("From what type is Player 2?");
                Console.WriteLine(" [1] Human");
                Console.WriteLine(" [2] Computer");
                input_for_Player2 = Convert.ToInt32(Console.ReadLine());
            } while (input_for_Player2 < 1 && input_for_Player2 > 2);

            if (input_for_Player1 == 1)
            {
                player1 = new Human();
            }
            else if (input_for_Player1 == 2)
            {
                player1 = new Computer();
            }
            else
            {
                Console.WriteLine("This value is not representing anything");
            }

            if (input_for_Player2 == 1)
            {
                player2 = new Human();
            }
            else if (input_for_Player2 == 2)
            {
                player2 = new Computer();
            }
            else
            {
                Console.WriteLine("This value is not representing anything");
            }

            //player1.ImComputer ();
            //player2.ImComputer ();

        }

        private void turn()
        {
            char mark;//bekommt den Wert X oder O je nach Spieler
            int who_inserts = 1;//Wechsel zwischen Spielern durch %2
            int fieldtarget_of_player = 0;//überbringt das gewählte Feld vom aktuellen Spieler
            int i = -1; //sagt durch bestimmen von Gewinner/Draw ob das Spiel weiter geht

            do
            {
                show_field();
                
                who_inserts = who_inserts % 2;

                if (who_inserts == 1)
                {
                    fieldtarget_of_player = player1.get_fieldtarget(field);
                    mark = 'X';
                }
                else
                {
                    fieldtarget_of_player = player2.get_fieldtarget();
                    mark = 'O';
                }

                /*******************************

                Sets the mark at a free position

                *******************************/

                if (fieldtarget_of_player == 1 && field.get_fieldcontent(0) == '1')
                {
                    field.set_fieldcontent(0, mark);
                }
                else if (fieldtarget_of_player == 2 && field.get_fieldcontent(1) == '2')
                {
                    field.set_fieldcontent(1, mark);
                }
                else if (fieldtarget_of_player == 3 && field.get_fieldcontent(2) == '3')
                {
                    field.set_fieldcontent(2, mark);
                }
                else if (fieldtarget_of_player == 4 && field.get_fieldcontent(3) == '4')
                {
                    field.set_fieldcontent(3, mark);
                }
                else if (fieldtarget_of_player == 5 && field.get_fieldcontent(4) == '5')
                {
                    field.set_fieldcontent(4, mark);
                }
                else if (fieldtarget_of_player == 6 && field.get_fieldcontent(5) == '6')
                {
                    field.set_fieldcontent(5, mark);
                }
                else if (fieldtarget_of_player == 7 && field.get_fieldcontent(6) == '7')
                {
                    field.set_fieldcontent(6, mark);
                }
                else if (fieldtarget_of_player == 8 && field.get_fieldcontent(7) == '8')
                {
                    field.set_fieldcontent(7, mark);
                }
                else if (fieldtarget_of_player == 9 && field.get_fieldcontent(8) == '9')
                {
                    field.set_fieldcontent(8, mark);
                }
                else
                {
                    Console.WriteLine("Invalid move!");
                    continue;
                }

                who_inserts++;
                i=check_if_won();

            } while (i == -1);

            if (i == 1)
            {
                if (who_inserts == 2)
                {
                    Console.WriteLine("Player 1 won!");
                }
                else
                {
                    Console.WriteLine("Player 2 won!");
                }
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }

        public void start()
        {
            field = new Field();
            choose_Player();
            turn();
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
