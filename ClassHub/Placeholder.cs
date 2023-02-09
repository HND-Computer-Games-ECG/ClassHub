using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHub
{
    class Placeholder
    {
        private Rectangle _rect;
        private string _label;

        public Placeholder(Rectangle frame, string label)
        {
            _rect = frame;
            _label = label;
        }

        public void DrawMe(GraphicsDevice gd, SpriteBatch sb, SpriteFont font, MouseState ms)
        {
            var tint = Color.Black;

            if (_rect.Contains(ms.Position))
                tint = Color.DarkGray;

            HelperFuncs.DrawRect(gd, sb, _rect, tint);
            sb.DrawString(font, _label, new Vector2(_rect.Right - 2, _rect.Bottom - 2) - font.MeasureString(_label), tint);
        }

    }
}
