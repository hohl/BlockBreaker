using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Blockbreaker.Logic
{
    /// <summary>
    /// Interface for all items.
    /// </summary>
    interface Item
    {
        /// <summary>
        /// Returns the texture of the item.
        /// </summary>
        /// <returns>Texture2D of the item</returns>
        Texture2D GetTexture();

        /// <summary>
        /// Called when a user picked up the item with the platform.
        /// </summary>
        /// <param name="platform">Platform which picked up the item</param>
        void PickedUp(Platform platform);

        /// <summary>
        /// Called every game tick. If the the method returns false, the item is used up, and Use(Platform) is not called anymore.
        /// </summary>
        /// <param name="platform">Platform which holds the item</param>
        /// <returns>false will remove the item from the platform (when item is used up)</returns>
        bool Use(Platform platform);
    }
}
