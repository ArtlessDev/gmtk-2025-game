using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using JairLib;
using MonoGame.Extended.Screens.Transitions;
using MonoGame.Extended.Screens;

namespace gmtk_loop_game
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;
        public ScreenManager screenManager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Globals.GlobalContent = Content; //content becomes global and becomes accessible for the ClassLibrary
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
            TitleScreenSwitch();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //Globals.LoadContent();
            
            //handle screen manager
            screenManager = new ScreenManager();
            Components.Add(screenManager);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //Globals.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        //SCREEN SWITCHERS
        public void SideOneScreenSwitch()
        {
            screenManager.LoadScreen(new SideOneScreen(this), new FadeTransition(GraphicsDevice, Color.Black));
        }
        public void TitleScreenSwitch()
        {
            screenManager.LoadScreen(new TitleScreen(this), new FadeTransition(GraphicsDevice, Color.Black));
        }
        public void SideTwoScreenSwitch()
        {
            screenManager.LoadScreen(new SideTwoScreen(this), new FadeTransition(GraphicsDevice, Color.Black));
        }
    }
}

