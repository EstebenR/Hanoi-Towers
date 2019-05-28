using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    class Program
    {
        static int HEIGHT = 6;
        static Tower tower1, tower2, tower3;
        static void Main(string[] args)
        {
            tower1 = new Tower();
            tower2 = new Tower();
            tower3 = new Tower();

            PopulateTower(tower1, HEIGHT-1);
            PrintTowers();

			/*for(int i = 0; i < HEIGHT-1; i++)
            {
                if(i%2==0)
                SolveTower(tower1, tower2, tower3);
                else
                SolveTower(tower3, tower2, tower1);
            }*/
			SolveTower(HEIGHT - 1, tower1, tower3, tower2);
        }

        //Moves highest disc from 'fromTower' to 'toTower', true if able
        static bool MoveDisc(Tower fromTower, Tower toTower)
        {
            int aux = fromTower.GetSizeHighest();
            if (toTower.AddDisc(aux))
            {
                fromTower.RemoveHighest();
                PrintTowers();
                return true;
            }
            else return false;
        }

        //Fills tower from lowest to highest starting from maxSize
        static void PopulateTower(Tower tower, int maxSize)
        {
            for(int i = maxSize; i > 0; i--)
            {
                tower.AddDisc(i);
            }
        }

        static void PrintTowers()
        {
            Console.Clear();
            int[] towerSizes = new int[]{ tower1.NumDiscs(), tower2.NumDiscs(), tower3.NumDiscs() };
            for(int i = HEIGHT+1; i > 0; i--)
            {
                foreach (int towerHeight in towerSizes){
                    if (towerHeight >= i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                    }
                    else
                        Console.Write("||");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }

		static void SolveTower(int nDiscs, Tower fromTower, Tower toTower, Tower aux)
		{
			if(nDiscs > 0)
			{
				SolveTower(nDiscs - 1, fromTower, aux, toTower);
				MoveDisc(fromTower, toTower);
				System.Threading.Thread.Sleep(500);
				SolveTower(nDiscs - 1, aux, toTower, fromTower);
			}
		}
    }
}
