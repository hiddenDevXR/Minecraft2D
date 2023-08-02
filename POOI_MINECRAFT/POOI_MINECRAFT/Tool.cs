using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace POOI_MINECRAFT
{
    struct ToolData
    {
        public int damageAmount;
    }

    internal class Tool : Block
    {
        public ToolData data;

        enum ToolType { None, Shovel, Pickaxe, DiamondPickaxe };
        ToolType type;

        public Tool() { }

        public Tool(Vector2 position) : base(position, new Vector2(8,8))
        {
            type = ToolType.Shovel;
            data.damageAmount = (int)type;
        }

        public void Update(Vector2 mousePosition)
        {
            position = mousePosition;
            box.Update(position);
        }

        public void ChangeTool(int index)
        {
            type = (ToolType)index;
            data.damageAmount = (int)type;
        }
    }
}
