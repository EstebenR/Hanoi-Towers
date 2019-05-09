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

        public void AddDisc(int size)
        {
            if(lowest == null)
            {
                lowest = new Disc(size);
                highest = lowest;
            }
            else
            {
                highest.above = new Disc(size, highest);
                highest = highest.above;
            }
            nDiscs++;
        }

        public void RemoveHighest()
        {
            if(highest != null)
            {
                highest = highest.below;
            }
        }
    }
}
