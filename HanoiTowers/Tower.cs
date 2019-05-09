using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowers
{
    public class Tower
    {
        class Disc
        {
            public int size;
            public Disc above, below;

            public Disc(int discSize)
            {
                size = discSize;
                above = null; below = null;
            }

            public Disc(int discSize, Disc discBelow)
            {
                size = discSize;
                above = discBelow;
            }
        }

        Disc lowest, highest;
        int nDiscs;

        public Tower()
        {
            lowest = highest = null;
            nDiscs = 0;
        }

        //Adds disc of 'size' on top of the tower, true if it could be added
        public bool AddDisc(int size)
        {
            if(lowest == null)
            {
                lowest = new Disc(size);
                highest = lowest;
                nDiscs++;
                return true;
            }
            else if(size < highest.size)
            {
                highest.above = new Disc(size, highest);
                highest = highest.above;
                nDiscs++;
                return true;
            }
            return false;
        }

        //Removes the highest disc of the tower
        public void RemoveHighest()
        {
            if(highest != null)
            {
                highest = highest.below;
                nDiscs--;
            }
        }

        //Returns size of the highest disc in tower
        public int GetSizeHighest()
        {
            return highest.size;
        }
    }
}
