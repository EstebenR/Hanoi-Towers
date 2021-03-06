﻿using System;
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
                below = discBelow;
            }
        }

        Disc lowest, highest;
        int nDiscs;

        public Tower()
        {
            lowest = highest = null;
            nDiscs = 0;
        }

        //Returns number of discs in tower
        public int NumDiscs() { return nDiscs; }

        //Adds disc of 'size' on top of the tower, true if it could be added
        public bool AddDisc(int size)
        {
            if(highest == null)
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
            if (highest != null)
                return highest.size;
            else
                return 1000;
        }

        public int GetSizeLower()
        {
            return lowest.size;
        }

        public bool CheckMove(int size)
        {
            if (highest == null || size < highest.size)
                return true;
            else
                return false;
        }
    }
}
