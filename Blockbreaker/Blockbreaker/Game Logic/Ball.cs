using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Blockbreaker.Logic
{
    /// <summary>
    /// Represents a ball inside the level.
    /// </summary>
    class Ball
    {
        /// <summary>
        /// All balls have the same texture. But the texture is only black and white and needs to get colored before displaying.
        /// </summary>
        public static Texture2D Texture;

        /// <summary>
        /// Current position of the ball
        /// </summary>
        public Vector2 Position
        {
            get;
            set;
        }

        /// <summary>
        /// Acceleration of the ball. Every game tick, the acceleration Vector2 is added to the position of the ball.
        /// </summary>
        public Vector2 Acceleration
        {
            get;
            set;
        }

        /// <summary>
        /// Color of the ball.
        /// </summary>
        public Color Color
        {
            get;
            set;
        }
    }
}
