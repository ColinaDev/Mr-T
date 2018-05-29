using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MrT.Droid
{
    class Player : GameObject
    {

        private Texture2D _texture;
        private Vector2 _position;


        public Player(GraphicsDevice graphicsDevice, ContentManager content, int x, int y)
        {
            X = x;
            Y = y;
            _position = new Vector2(X, Y);
            Width = 60;
            Height =60;

            _texture = content.Load<Texture2D>("standing");
            


        }



        public override void Update(GameTime gameTime)
        {


            _position.X = X;
            _position.Y = Y;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Hitbox, null, Color.White);
        }
    }
}