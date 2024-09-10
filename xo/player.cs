using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xo
{//אפרת גפן
    internal abstract class player
    {
        public char shape { get; set; }
        public string name { get; set; }
        public abstract int[] choose();

    }
}
