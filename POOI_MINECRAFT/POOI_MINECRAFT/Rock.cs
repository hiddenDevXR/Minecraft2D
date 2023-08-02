using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace POOI_MINECRAFT
{
    internal class Rock : Block
    {
        public Rock() { }

        public Rock(Vector2 position) : base(position)
        {
            resistance = 5;
        }
    }
}
