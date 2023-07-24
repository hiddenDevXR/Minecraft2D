using Microsoft.Xna.Framework.Graphics;
using System.IO;
using System.Collections.Generic;


namespace POOI_MINECRAFT
{
    internal class TextureManager
    {
        //Esta clase nos va a ayudar a cargar texturas.

        //Definimos el path / ruta del archivo donde se encuentran
        //definidas las texturas

        string[] textureNames;
        List<Texture> textureList;
        
        public TextureManager()
        {
            string filePath = "C:/Users/anton/source/repos/POOI_MINECRAFT/POOI_MINECRAFT/Textures.txt";
            textureNames = File.ReadAllLines(filePath);

        }

        public void LoadTextures()
        {
            for (int i = 0; i < textureNames.Length; i++)
            {
                Texture2D texture2D;
                texture2D = Game1.content.Load<Texture2D>(textureNames[i]);
                textureList.Add(texture2D);
            }
        }

        void AssignTexture()
        {

        }
    }
}
