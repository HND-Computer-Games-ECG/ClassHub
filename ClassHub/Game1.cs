using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace ClassHub
{
    public class Game1 : Game
    {
        enum GameMode
        {
            Hub,
            DetailsPage
        }

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SpriteFont placeholderFont;

        private List<Placeholder> placeHolders;
        private List<string> names;

        private List<ClickyButton> clickyButtons;

        private MouseState ms_curr;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            names = new List<string>
            {
                "Nigel",
                "Kristopher",
                "Jonathan",
                "Duncan",
                "Harry",
                "Declan",
                "Kamil",
                "Jakub",
                "Shannon",
                "Deuie",
                "Noah",
                "Ross",
                "Alvin",
                "Lewis", // hey mum look at me, im on github - you're soooo cool.
                "Gastao",
                "MateuszS", // :D
                "Juan",
                "MateuszW",
                "Peter"
            };

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            placeholderFont = Content.Load<SpriteFont>("Arial07");

            int x = 40, y = 24;
            int size = 92, spacing = 24;
            int rowLength = 6;
            int i = 0;
            clickyButtons = new List<ClickyButton>();
            placeHolders = new List<Placeholder>();

            clickyButtons.Add(new ClickyButton(Content.Load<Texture2D>("Avatar92"), x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing)));
            i++;

            clickyButtons.Add(new ClickyButton(Content.Load<Texture2D>("ship"), x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing)));
            i++;

            clickyButtons.Add(new ClickyButton(Content.Load<Texture2D>("f1"), x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing)));
            i++;

            clickyButtons.Add(new ClickyButton(Content.Load<Texture2D>("Kenzie"), x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing)));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            clickyButtons.Add(new ClickyButton(Content.Load<Texture2D>("LewSco"), x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing)));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            clickyButtons.Add(new ClickyButton(Content.Load<Texture2D>("alien"), x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing)));
            i++;

            placeHolders.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            clickyButtons.Add(new ClickyButton(Content.Load<Texture2D>("duck"), x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing)));
            i++;

        }

        protected override void Update(GameTime gameTime)
        {
            ms_curr = Mouse.GetState();

            base.Update(gameTime);
        }

        private void drawPlaceholder(Rectangle rect, string label)
        {
            // HelperFuncs.DrawRect(GraphicsDevice, _spriteBatch, new Rectangle(x, y, size, size), Color.Black);
            HelperFuncs.DrawRect(GraphicsDevice, _spriteBatch, rect, Color.Black);
            _spriteBatch.DrawString(placeholderFont, label, new Vector2(rect.Right - 2, rect.Bottom - 2) - placeholderFont.MeasureString(label), Color.Black);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            _spriteBatch.Begin();

            for (int i = 0; i < placeHolders.Count; i++)
            {
                placeHolders[i].DrawMe(GraphicsDevice, _spriteBatch, placeholderFont, ms_curr);
            }

            for (int i = 0; i < clickyButtons.Count; i++)
            {
                clickyButtons[i].DrawMe(_spriteBatch, ms_curr);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}