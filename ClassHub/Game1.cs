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

        private List<Placeholder> widgetGrid;
        private List<string> names;

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
                "Lewis",
                "Gastao",
                "MateuszS",
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
            widgetGrid = new List<Placeholder>();

            widgetGrid.Add(new ClickyButton(Content.Load<Texture2D>("Avatars\\Avatar92"), x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
            i++;

            widgetGrid.Add(new Placeholder(new Rectangle(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, size), names[i]));
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

            for (int i = 0; i < widgetGrid.Count; i++)
            {
                widgetGrid[i].DrawMe(GraphicsDevice, _spriteBatch, placeholderFont, ms_curr);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}