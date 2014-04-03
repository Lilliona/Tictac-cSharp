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
			Console.WriteLine("Yay we started a turn! :D");
		}

		public void start()
		{
			field = new Field();
			choose_Player();
			turn();
			show_field();
		}

		public void show_field()
		{
			Console.WriteLine();
			for (int iterationnumber=0; iterationnumber<9; iterationnumber+=3)
			{
				Console.WriteLine(" " + field.get_fieldcontent(iterationnumber) + " | " + field.get_fieldcontent(iterationnumber + 1) + " | " + field.get_fieldcontent(iterationnumber + 2));
				if (iterationnumber < 6)
				{
					Console.WriteLine("-----------");
				}
			}
			Console.WriteLine();
		}
        public  give_information_about_field()
        {
            field.get_fieldcontent();
        }
	}
}
