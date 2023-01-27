using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHub
{
    public static class HelperFuncs
    {
        /// <summary>
        /// Creates a texture that is a single white pixel
        /// </summary>
        /// <param name="gd">The current game's graphics device</param>
        /// <returns></returns>
        public static Texture2D GeneratePixel(GraphicsDevice gd)
        {
            Texture2D texture = new Texture2D(gd, 1, 1);
            Color[] data = { Color.White };
            texture.SetData(data);
            return texture;
        }

        public static void DrawRect(GraphicsDevice gd, SpriteBatch sb, Rectangle rect, Color tint)
        {
            var pixel = GeneratePixel(gd);

            // Pale body fill
            sb.Draw(pixel, rect, tint * 0.1f);

            // Borders (internal)
            sb.Draw(pixel, new Rectangle(rect.Left, rect.Top, rect.Width, 1), tint * 0.8f);
            sb.Draw(pixel, new Rectangle(rect.Left, rect.Top, 1, rect.Height), tint * 0.8f);
            sb.Draw(pixel, new Rectangle(rect.Left, rect.Bottom-1, rect.Width, 1), tint * 0.8f);
            sb.Draw(pixel, new Rectangle(rect.Right-1, rect.Top, 1, rect.Height), tint * 0.8f);
        }
    }
}
