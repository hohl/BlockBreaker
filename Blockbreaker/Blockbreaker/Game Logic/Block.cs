﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Blockbreaker.Logic;
using Microsoft.Xna.Framework.Graphics;

namespace Blockbreaker.Logic
{
    /// <summary>
    /// Replaces a fixed block inside the level.
    /// </summary>
    class Block
    {
        /// <summary>
        /// All blocks have the same texture. But the texture is black and white and needs to get colored for every differend block.
        /// </summary>
        public static Texture2D Texture;

        /// <summary>
        /// Position of the block
        /// </summary>
        public Vector2 Position
        {
            get;
            set;
        }

        /// <summary>
        /// Color of the block.
        /// </summary>
        public Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Item contained in the block. Could be null too!
        /// </summary>
        public Item Item
        {
            get;
            set;
        }
    }
}
