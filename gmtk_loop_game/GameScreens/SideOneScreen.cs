using gmtk_loop_game;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Screens;
using JairLib;

public class SideOneScreen : GameScreen
{
    private new Game1 Game => (Game1) base.Game;
    public SideOneScreen(Game1 game) : base(game) { }
    private PlayerOverworld playerOW;

    public override void LoadContent()
    {
        base.LoadContent();
        playerOW = new PlayerOverworld();
    }

    public override void Update(GameTime gameTime)
    {
        if (Globals.keyboardState.IsKeyDown(Keys.P))
        {
            Game.SideOneScreenSwitch();
        }
        
        playerOW.Update(gameTime);
        //throw new System.NotImplementedException();
    }


    public override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Blue);

        Game._spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        // TODO: Add your drawing code here
        
        Game._spriteBatch.Draw(playerOW.texture, playerOW.rectangle, playerOW.color);        

        Game._spriteBatch.End();

    }


}