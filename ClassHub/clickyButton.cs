using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ClassHub
{
    class ClickyButton : Placeholder
    {
        Texture2D _txr;

        public ClickyButton(Texture2D img, int xPos, int yPos, string label = "") : base (new Rectangle(xPos, yPos, img.Width, img.Height), label)
        {
            _txr = img;
        }

        public override void DrawMe(GraphicsDevice gd, SpriteBatch sb, SpriteFont font, MouseState ms)
        {
            var textTint = Color.Black;
            var highlightTint = Color.LightGray;

            if (_rect.Contains(ms.Position))
            {
                textTint = Color.DarkGray;
                highlightTint = Color.White;
            }

            sb.Draw(_txr, _rect, highlightTint);
            sb.DrawString(font, _label, new Vector2(_rect.Right - 2, _rect.Bottom - 2) - font.MeasureString(_label), textTint);
        }
    }
}
