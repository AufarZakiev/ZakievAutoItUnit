using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakievAutoIt
{
    class Colour
    {
        public int x {get;private set;}
        public int y { get; private set; }
        public string name { get; private set; }
        public Colour(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
