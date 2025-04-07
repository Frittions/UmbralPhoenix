using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using UmbralPhoenix.Game.Entities;

namespace UmbralPhoenix.Game
{
    public class DesktopGame : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Player player;

        public DesktopGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            
            Texture2D texture = Content.Load<Texture2D>("celeste");
            Vector2 initialPosition = new(100, 100);
            int scaleFactor = 4;

            player = new Player(texture, initialPosition, scaleFactor);
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            _spriteBatch.Draw(player.Texture, 
                              new Rectangle((int)player.Position.X, (int)player.Position.Y, player.SizeX, player.SizeY), 
                              Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
