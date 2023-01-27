using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace ClassHub
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private List<string> names;
        private SpriteFont placeholderText;

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

            placeholderText = Content.Load<SpriteFont>("Arial07");
        }

        protected override void Update(GameTime gameTime)
        {
            ms_curr = Mouse.GetState();

            base.Update(gameTime);
        }

        private void drawPlaceholder(int x, int y, int size, string label)
        {
            HelperFuncs.DrawRect(GraphicsDevice, _spriteBatch, new Rectangle(x, y, size, size), Color.Black);
            _spriteBatch.DrawString(placeholderText, label, new Vector2(x + size - 2, y + size - 2) - placeholderText.MeasureString(label), Color.Black);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // Placeholders for the unused spaces
            int x = 40, y = 24;
            int size = 92, spacing = 24;
            int rowLength = 6;
            int i = 0;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;

            drawPlaceholder(x + (i % rowLength) * (size + spacing), y + (i / rowLength) * (size + spacing), size, names[i]);
            i++;


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}