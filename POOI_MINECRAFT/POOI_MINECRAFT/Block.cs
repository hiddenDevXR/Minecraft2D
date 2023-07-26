using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace POOI_MINECRAFT
{
    internal class Block
    {
        public Texture2D texture;
        private Vector2 position;

        public Block() {}

        public Block(Vector2 position)
        {
            this.position = position;
        }

        public void LoadContent(Block block)
        {
            texture = TextureManager.Instance.AssignTexture(block);
        }

        public Vector2 GetPosition()
        {
            return position;
        }
    }
}