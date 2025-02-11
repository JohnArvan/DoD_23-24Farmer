﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DoD_23_24;
public class Main : Game
{
    private GraphicsDeviceManager _graphics;

    //World world;
    Farm farm;
    Canvas canvas;

    public Main()
    {
        this._graphics = new GraphicsDeviceManager(this);
        this._graphics.PreferredBackBufferWidth = Globals.WIDTH;
        this._graphics.PreferredBackBufferHeight = Globals.HEIGHT;
        this.Content.RootDirectory = "Content";
        this.IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        Globals.content = this.Content;
        Globals.spriteBatch = new SpriteBatch(this.GraphicsDevice);
        Globals.graphics = this.GraphicsDevice;
        Globals.window = this.Window;

        //world = new World();
        farm = new Farm();
        canvas = new Canvas();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        //world.Update(gameTime);
        farm.Update(gameTime);
        canvas.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        //Drawing the world
        //Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, transformMatrix: world.GetCamera().GetComponent<CameraComponent>().GetTranslation());
        Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, transformMatrix: farm.GetCamera().GetComponent<CameraComponent>().GetTranslation());

        //world.Draw();
        farm.Draw();

        Globals.spriteBatch.End();

        Globals.spriteBatch.Begin();
        canvas.Draw();
        Globals.spriteBatch.End();

        base.Draw(gameTime);
    }
}