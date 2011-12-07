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
        /// Platform which is controlled by the player.
        /// </summary>
        public Platform Platform
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
        /// Manages the movements and actions of the 
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of the game time</param>
        public void UpdateGameTime(GameTime gameTime)
        {
            // ToDo: Implement!
        }
    }
}
