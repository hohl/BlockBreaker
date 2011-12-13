using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Blockbreaker.Logic
{
    /// <summary>
    /// Item container is a used to display an item inside the world. Items itself does not have a coordinate.
    /// </summary>
    class ItemContainer
    {
        /// <summary>
        /// Position of the container.
        /// </summary>
        public Vector2 Position
        {
            get;
            set;
        }

        /// <summary>
        /// Item of the container.
        /// </summary>
        public Item Item
        {
            get;
            set;
        }
    }
}
