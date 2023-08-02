using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace POOI_MINECRAFT
{
    internal class Block
    {
        public Texture2D texture;
        protected Vector2 position;
        public BoxCollider box;
        protected int resistance = 99;

        public Block() {}

        public Block(Vector2 position)
        {
            this.position = position;
            box = new BoxCollider(this.position, new Vector2(32, 32));
        }

        public Block(Vector2 position, Vector2 size)
        {
            this.position = position;
            box = new BoxCollider(this.position, size);
        }

        public void LoadContent(Block block)
        {
            texture = TextureManager.Instance.AssignTexture(block);
        }

        public Vector2 GetPosition()
        {
            return position;
        }


        public void TakeDamage(int damage)
        {
            resistance -= damage;
        }

        public int GetResistance() { return resistance; }
    }
}