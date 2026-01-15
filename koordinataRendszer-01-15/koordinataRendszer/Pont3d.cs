using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koordinataRendszer
{
    internal class Pont3d : Pont
    {
        public int z;
        public Pont3d(int x, int y, int z) : base(x,y){
            this.z = z;
        }
    }
}
