using Microsoft.Xna.Framework.Graphics;
using System.IO;
using System.Collections.Generic;


namespace POOI_MINECRAFT
{
    internal class TextureManager
    {
        //Para poder acceder a la clase textureManager donde nosotros querramos, sin necesidad de 
        //tener que crear instancias de objecto, es decir: TextureManager textureMgr = new TextureManager();
        //Usaremos el PDD (DP Design Pattern) singleton.

        //Patrón singleton.
        //Crear un instance static y después su getter.
        private readonly static TextureManager instance = new TextureManager();
        public static TextureManager Instance
        {
            get { return instance; }
        }

        string[] textureNames;
        List<Texture2D> textureList;
        
        public TextureManager()
        {
            textureList = new List<Texture2D>();
            string filePath = "../../../Textures.txt";
            textureNames = File.ReadAllLines(filePath);
        }

        public void LoadTextures()
        {
            for (int i = 0; i < textureNames.Length; i++)
            {
                Texture2D texture2D;

                try
                {
                    texture2D = Game1.content.Load<Texture2D>("Textures/" + textureNames[i]);
                }

                catch
                {
                    texture2D = Game1.content.Load<Texture2D>("Textures/" + "T_Placeholder");
                }
  
                textureList.Add(texture2D);
            }
        }

        public Texture2D AssignTexture(Block block)
        {
            if (block.GetType() == typeof(Dirt))
                return textureList[1];

            if (block.GetType() == typeof(Rock))
                return textureList[2];

            if (block.GetType() == typeof(Diamond))
                return textureList[3];

            else return null;
        }
    }
}
