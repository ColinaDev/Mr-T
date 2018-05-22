using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MrT.Droid
{
    class Player : GameObject
    {

        private Texture2D _texture;


        public Player(GraphicsDevice graphicsDevice, int x, int y)
        {
            X = x;
            Y = y;
            Width = 30;
            Height = 30;
            _texture = new Texture2D(graphicsDevice, Width, Height);
        }



        protected override void Update(GameTime gameTime)
        {
            
        }

        protected override void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}