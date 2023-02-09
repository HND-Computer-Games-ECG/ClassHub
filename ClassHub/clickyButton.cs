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
    class ClickyButton
    {
        Texture2D _txr;
        Rectangle _frame;

        public ClickyButton(Texture2D img, int xPos, int yPos)
        {
            _txr = img;
            _frame = new Rectangle(xPos, yPos, img.Width, img.Height);
        }

        public void DrawMe(SpriteBatch sb, MouseState ms)
        {
            if (_frame.Contains(ms.Position))
                sb.Draw(_txr, _frame, Color.White);
            else
                sb.Draw(_txr, _frame, Color.LightGray);
        }
    }
}
