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
        TextureManager textureManager;

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

            //Definición del objeto
            terrain = new TerrainGenerator();
            textureManager = new TextureManager();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //Declaración: En este momento, ya empieza a exisitr la textura en momoria.
            //La computadora ya hace un espacio para que este objeto viva.

            foreach (Block block in terrain.tiles)
                block.texture = content.Load<Texture2D>("Textures/T_Dirt");

            // TODO: use this.Content to load your game content here
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