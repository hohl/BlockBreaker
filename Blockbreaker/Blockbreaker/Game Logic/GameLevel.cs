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

        public GameLevel(float width, float height)
        {
            this.Bat = new Bat();
            this.Bat.Position = new Vector2(width / 2, height - Bat.Texture.Height - 20);
        }

        /// <summary>
        /// Manages the movements and actions of the 
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of the game time</param>
        public void UpdateGameTime(GameTime gameTime)
        {
            // ToDo: Implement!
        }

        /// <summary>
        /// Manages the position of the bat
        /// </summary>
        /// <param name="mousePosition">Position of mouse</param>
        public void UpdateInputDevice(Vector2 mousePosition)
        {
            this.Bat.Position = new Vector2(mousePosition.X - Bat.Texture.Width / 2, this.Bat.Position.Y);
        }
    }
}
