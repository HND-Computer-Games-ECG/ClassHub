using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHub
{
    class BasicInfoPage
    {
        Texture2D _txr;
        string _title;
        ClickyButton _backButton;

        public BasicInfoPage(Texture2D avatarTxr, Texture2D backTxr, string title)
        {
            _txr = avatarTxr;
            _title = title;

            _backButton = new ClickyButton(backTxr, 600, 400);
        }

        public virtual void DrawMe(SpriteBatch sb, SpriteFont font)
        {
            sb.Draw(_txr, new Vector2(64), Color.Black);
            sb.DrawString(font, _title, new Vector2(64, 96), Color.Black);
            _backButton.DrawMe()
        }
    }
}
