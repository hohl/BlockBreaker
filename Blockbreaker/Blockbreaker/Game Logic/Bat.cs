using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blockbreaker.Logic
{
    /// <summary>
    /// Platform at the bottom of the screen which is controlled by the player.
    /// </summary>
    class Bat
    {
        /// <summary>
        /// All platforms have the same texture. But texture is only black and white and needs to get colored before displaying.
        /// </summary>
        public static Texture2D Texture;

        /// <summary>
        /// Position of the block.
        /// </summary>

        public Vector2 Position
        {
            get;
            set;
        }

        /// <summary>
        /// Color of the platform. Item effects could color the platform.
        /// </summary>
        public Color Color
        {
            get;
            set;
        }

        public Bat()
        {
            this.Color = Color.White;
        }
    }
}
