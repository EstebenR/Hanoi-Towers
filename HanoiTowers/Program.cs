using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    class Program
    {
        static int HEIGHT = 5;
        static void Main(string[] args)
        {
            Tower tower1 = new Tower();
            Tower tower2 = new Tower();
            Tower tower3 = new Tower();

            PopulateTower(tower1, HEIGHT-1);
            PrintTowers(tower1, tower2, tower3);
        }

        //Moves highest disc from 'fromTower' to 'toTower'
        static void MoveDisc(Tower fromTower, Tower toTower)
        {
            int aux = fromTower.GetSizeHighest();
            if (toTower.AddDisc(aux))
                fromTower.RemoveHighest();
        }

        //Fills tower from lowest to highest starting from maxSize
        static void PopulateTower(Tower tower, int maxSize)
        {
            for(int i = maxSize; i > 0; i--)
            {
                tower.AddDisc(i);
            }
        }

        static void SolveTower(Tower fromTower, Tower toTower, Tower auxiliar)
        {
            //Numero de elementos impar hay que mover highest a toTower, par a auxiliar
        }

        static void PrintTowers(Tower tower1, Tower tower2, Tower tower3)
        {
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
    }
}
