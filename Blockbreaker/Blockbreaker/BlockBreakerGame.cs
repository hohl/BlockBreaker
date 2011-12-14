using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Blockbreaker.Logic;

namespace Blockbreaker
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class BlockBreakerGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameLevel gameLevel;

        public BlockBreakerGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load textures
            Block.Texture = Content.Load<Texture2D>("BlockTexture");
            Bat.Texture = Content.Load<Texture2D>("BatTexture");
            Ball.Texture = Content.Load<Texture2D>("BallTexture");

            gameLevel = new GameLevel(spriteBatch.GraphicsDevice.PresentationParameters.BackBufferWidth, spriteBatch.GraphicsDevice.PresentationParameters.BackBufferHeight); // ToDo: Read screen dimensions
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            MouseState mouseState = Mouse.GetState();
            Vector2 mousePos = new Vector2(mouseState.X,mouseState.Y);

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // check keys
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                gameLevel.Start();
            }

            // Update the game level and all it's contained objects.
            if (gameLevel != null)
            {
                gameLevel.UpdateInputDevice(mousePos);
                gameLevel.UpdateGameTime(gameTime);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();
            //this.DrawBlocks(spriteBatch, gameLevel.Blocks);
            this.DrawBat(spriteBatch, gameLevel.Bat);
            this.DrawBalls(spriteBatch, gameLevel.Balls);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Draws the blocks on the sprite batch
        /// </summary>
        /// <param name="spriteBatch">batch used to output</param>
        /// <param name="blocks">blocks to become drawed to batch</param>
        private void DrawBlocks(SpriteBatch spriteBatch, List<Block> blocks)
        {
            foreach (Block block in blocks) {
                spriteBatch.Draw(Block.Texture, block.Position, block.Color);
            }
        }

        /// <summary>
        /// Draws the platform to the sprite batch
        /// </summary>
        /// <param name="spriteBatch">batch used to output</param>
        /// <param name="blocks">blocks to output</param>
        private void DrawBat(SpriteBatch spriteBatch, Bat bat)
        {
            spriteBatch.Draw(Bat.Texture, bat.Position, bat.Color);
        }

        /// <summary>
        /// Draws the balls to the sprite batch.
        /// </summary>
        /// <param name="spriteBatch">batch used to output</param>
        /// <param name="balls">balls to output</param>
        private void DrawBalls(SpriteBatch spriteBatch, List<Ball> balls)
        {
            foreach (Ball ball in balls)
            {
                spriteBatch.Draw(Ball.Texture, ball.Position, ball.Color);
            }
        }

        /// <summary>
        /// Draws the item containers to the sprite batch.
        /// </summary>
        /// <param name="spriteBatch">batch used to output</param>
        /// <param name="containers">containers to output</param>
        private void DrawItemContainers(SpriteBatch spriteBatch, List<ItemContainer> containers)
        {
            foreach (ItemContainer container in containers)
            {
                spriteBatch.Draw(container.Item.GetTexture(), container.Position, Color.White);
            }
        }
    }
}
