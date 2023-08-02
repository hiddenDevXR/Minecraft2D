using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;

namespace POOI_MINECRAFT
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        float w = 0;
        float h = 0;

        TerrainGenerator terrain;
        Tool pickaxe;

        Physics physics;

        MouseState mouseState;

        public static ContentManager content;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);

            content = Content;
            content.RootDirectory = "Content";

            w = _graphics.PreferredBackBufferWidth;
            h = _graphics.PreferredBackBufferHeight;
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            terrain = new TerrainGenerator();
            pickaxe = new Tool(Vector2.Zero); 
            physics = new Physics();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            TextureManager.Instance.LoadTextures();
            terrain.LoadContent();

            pickaxe.LoadContent(pickaxe);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            mouseState = Mouse.GetState();


            if(Keyboard.GetState().IsKeyDown(Keys.NumPad1))
                pickaxe.ChangeTool(1);

            if (Keyboard.GetState().IsKeyDown(Keys.NumPad3))
                pickaxe.ChangeTool(3);


            pickaxe.Update(new Vector2(mouseState.X, mouseState.Y));

            //Detectamos si se está haciendo click.

            CustomInputSystem.GetState();

            if (CustomInputSystem.HasBeenPressed())
            {
                foreach (Block tile in terrain.tiles)
                {
                    if (physics.OnCollision(pickaxe.box, tile.box))
                    {
                        Console.WriteLine("HIT!");
                        tile.TakeDamage(pickaxe.data.damageAmount);
                        break;
                    }
                }
            }


            for(int i = 0; i < terrain.tiles.Count; i++)
            {
                if (terrain.tiles[i].GetResistance() <= 0)
                    terrain.tiles.RemoveAt(i);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            foreach (Block block in terrain.tiles)
                _spriteBatch.Draw(block.texture, block.GetPosition(), Color.White);

            _spriteBatch.Draw(pickaxe.texture, pickaxe.GetPosition(), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}