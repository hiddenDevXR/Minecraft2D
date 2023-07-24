using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace POOI_MINECRAFT
{
    internal class TerrainGenerator
    {
        int seed = 0;
        Random random;

        public List<Block> tiles;

        public TerrainGenerator()
        {
            random = new Random(seed);
            tiles = new List<Block>();

            for(int x = 0; x < 20; x++)
            {
                for(int y = 0; y < 5; y++)
                {
                    Block block = new Dirt(new Vector2(x * 32, y * 32));
                    tiles.Add(block);
                }
            }
        }
    }
}
