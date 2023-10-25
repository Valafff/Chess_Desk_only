using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Desk_only
{

	internal class Program
	{
		static void Main(string[] args)
		{
			int cell_size;
			int desk_size;
			char symbol_1 = '*';
			char symbol_2 = ' ';
			bool check_cell = false;
			bool check_row = false;

			Console.Write("Введите размер клетки: ");
			cell_size = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите размер доски: ");
			desk_size = Convert.ToInt32(Console.ReadLine());

			#region Доска (строки и флаги)
			string cellType_1Lenght = "";
			string cellType_2Lenght = "";
			int counter_rows = 0, counter_cols = 0;

			for (int i = 0; i < cell_size; i++)
			{
				cellType_1Lenght+=symbol_1;
				cellType_2Lenght+=symbol_2;
			}
			// строки
			for (int i = 0; i < cell_size * desk_size; i++)
			{
				if (counter_rows == cell_size && check_row == false)
				{
					check_row = true;
					counter_rows = 0;
				}
				else if (counter_rows == cell_size && check_row == true)
				{
					check_row = false;
					counter_rows = 0;
				}
				// колонки
				for (int j = 0; j < desk_size; j++)
				{
					if (counter_cols != 0  && check_cell == false)
					{
						check_cell = true;
						counter_cols = 0;
						if (j == 0 && desk_size%2!=0)
						{
							check_cell=false;
						}
					}
					else if (counter_cols != 0 && check_cell == true)
					{
						check_cell = false;
						counter_cols = 0;
						if (j == 0 && desk_size % 2 != 0)
						{
							check_cell = true;
						}
					}
					if (check_row == false)
					{
						if (check_cell)
						{

							Console.Write(cellType_1Lenght);

						}
						else
						{
							Console.Write(cellType_2Lenght);
						}
					}
					else
					{
						if (check_cell)
						{
							Console.Write(cellType_2Lenght);
						}
						else
						{
							Console.Write(cellType_1Lenght);
						}
					}
					counter_cols++;
				}
				Console.WriteLine();
				counter_rows++;
			}
			#endregion
		}
	}
}
