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
            int size;
            Disc above, below;

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


        public Tower()
        {

        }
    }
}
