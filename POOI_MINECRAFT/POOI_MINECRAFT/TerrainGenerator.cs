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
        int seed = 117;
        Random random;

        public List<Block> tiles;

        public TerrainGenerator()
        {
            GenerateLevel();
        }

        private void GenerateLevel()
        {
            random = new Random(seed);
            tiles = new List<Block>();
            Block block = new Block();

            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 5; y++)
                {            
                    if(y == 0)
                        block = new Dirt(new Vector2(x * 32, (y * 32) + 320));

                    else
                    {
                        int dice = random.Next(0, 100);

                        if (dice <= 80)
                            block = new Rock(new Vector2(x * 32, (y * 32) + 320));

                        else if (dice > 80)
                            block = new Diamond(new Vector2(x * 32, (y * 32) + 320));
                    }

                    tiles.Add(block);
                }
            }
        }

        public void LoadContent()
        {
            foreach (var tile in tiles)
                tile.LoadContent(tile);
        }
    }
}
