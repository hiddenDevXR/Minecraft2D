using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace POOI_MINECRAFT
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        float w = 0;
        float h = 0;

        TerrainGenerator terrain;

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

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            TextureManager.Instance.LoadTextures();

            terrain.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            foreach (Block block in terrain.tiles)
                _spriteBatch.Draw(block.texture, block.GetPosition(), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}