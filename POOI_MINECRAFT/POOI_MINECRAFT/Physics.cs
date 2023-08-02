using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_MINECRAFT
{
    internal class Physics
    {
        public Physics() { }

        public bool OnCollision(BoxCollider a, BoxCollider b)
        {
            if (a.Max().X < b.Min().X || a.Min().X > b.Max().X) return false;
            if (a.Max().Y < b.Min().Y || a.Min().Y > b.Max().Y) return false;
            
            return true;
        }
    }
}
