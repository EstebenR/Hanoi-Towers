using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower tower1 = new Tower();
            Tower tower2 = new Tower();
            Tower tower3 = new Tower();

            PopulateTower(tower1, 3);
        }

        //Moves highest disc from 'fromTower' to 'toTower'
        static void MoveDisc(Tower fromTower, Tower toTower)
        {

        }

        //Fills tower from lowest to highest starting from maxSize
        static void PopulateTower(Tower tower, int maxSize)
        {
            for(int i = maxSize; i > 0; i--)
            {
                tower.AddDisc(i);
            }
        }
    }
}
