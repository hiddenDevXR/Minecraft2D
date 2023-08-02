using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace POOI_MINECRAFT
{
    internal class Diamond : Block
    {
        public Diamond() { }

        public Diamond(Vector2 position) : base(position)
        {
            resistance = 9;
        }
    }
}
