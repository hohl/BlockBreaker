using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Blockbreaker.Logic
{
    /// <summary>
    /// Represents a level of the game.
    /// </summary>
    class GameLevel
    {
        /// <summary>
        /// Screen dimensions
        /// </summary>
        protected float width, height;

        /// <summary>
        /// Distance between Border and Bat
        /// </summary>
        private const int BatDistanceToBorder = 5;

        /// Space between 2 blocks
        /// </summary>
        private const float BlockSpace = 1;

        /// <summary>
        /// True if the game has started
        /// </summary>
        private bool isStarted;

        /// <summary>
        /// Platform which is controlled by the player.
        /// </summary>
        public Bat Bat
        {
            get;
            set;
        }

        /// <summary>
        /// Blocks contained by the level. To destroy a block remove it from the list.
        /// </summary>
        public List<Block> Blocks
        {
            get;
            set;
        }

        /// <summary>
        /// All balls which are available in the world currently.
        /// </summary>
        public List<Ball> Balls
        {
            get;
            set;
        }

        /// <summary>
        /// Item containers inside the map.
        /// </summary>
        public List<ItemContainer> Items
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new level for the passed dimensions.
        /// </summary>
        /// <param name="width">Widht of the frame</param>
        /// <param name="height">Height of the frame</param>
        public GameLevel(float width, float height)
        {
            this.Bat = new Bat();
            this.width = width;
            this.height = height;
            this.Bat.Position = new Vector2(width / 2, height - Bat.Texture.Height - 20);

            // Create balls
            this.Balls = new List<Ball>();
            this.Balls.Add(new Ball(new Vector2(-Ball.Texture.Width,-Ball.Texture.Height)));

            // Create Blocks:
            this.Blocks = new List<Block>();
            Random rand = new Random();
            float blockOffset = (width - ((float)Math.Truncate(width / (Block.Texture.Width + BlockSpace)) * Block.Texture.Width)) / 2;
            for (float x = blockOffset; x + Block.Texture.Width < width; x += Block.Texture.Width + BlockSpace)
            {
                for (float y = blockOffset; y + Block.Texture.Height < height / 2; y += Block.Texture.Height + BlockSpace)
                {
                    this.Blocks.Add(new Block(new Vector2(x, y), new Color((float)rand.NextDouble(), (float)rand.NextDouble(), (float)rand.NextDouble())));
                }
            }
        }

        public void Start()
        {
            isStarted = true;
        }

        /// <summary>
        /// Manages the movements and actions of the 
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of the game time</param>
        public void UpdateGameTime(GameTime gameTime)
        {
            if (isStarted)
            {
                foreach (Ball ball in this.Balls)
                {
                    for (int times = 0; times < gameTime.ElapsedGameTime.Milliseconds; times++)
                    {
                        ball.Position += ball.Acceleration;
                    }
                }
            }
            else
            {
                foreach(Ball ball in this.Balls)
                {
                    ball.Position = new Vector2(Bat.Position.X + Bat.Texture.Width / 2 - Ball.Texture.Width / 2, Bat.Position.Y - Ball.Texture.Height);
                }
            }
        }

        /// <summary>
        /// Manages the position of the bat
        /// </summary>
        /// <param name="mousePosition">Position of mouse</param>
        public void UpdateInputDevice(Vector2 mousePosition)
        {
            float x;

            if (mousePosition.X < Bat.Texture.Width / 2 + BatDistanceToBorder)
            {
                x = BatDistanceToBorder;
            }
            else if (mousePosition.X > this.width - Bat.Texture.Width / 2 - BatDistanceToBorder)
            {
                x = this.width - Bat.Texture.Width - BatDistanceToBorder;
            }
            else
            {
                x = mousePosition.X - Bat.Texture.Width / 2;
            }

            this.Bat.Position = new Vector2(x, this.Bat.Position.Y);
        }
    }
}
