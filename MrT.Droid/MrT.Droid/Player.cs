using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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
<<<<<<< HEAD
            Width = 30;
            Height = 30;
            
         }

        public void LoadContent(ContentManager cm)
        {
            _texture = cm.Load<Texture2D>("walking1");
=======
            _position = new Vector2(X, Y);
            Width = 60;
            Height =60;

            _texture = content.Load<Texture2D>("standing");
            


>>>>>>> 255ad1fb2b8bf3fb7524d7f71641f55024e6da55
        }



        public override void Update(GameTime gameTime)
        {
<<<<<<< HEAD
            X += 1;
            Y += 1;
=======


            _position.X = X;
            _position.Y = Y;
>>>>>>> 255ad1fb2b8bf3fb7524d7f71641f55024e6da55
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
<<<<<<< HEAD
            spriteBatch.Draw(_texture, new Vector2(X, Y), Color.White);
=======
            spriteBatch.Draw(_texture, Hitbox, null, Color.White);
>>>>>>> 255ad1fb2b8bf3fb7524d7f71641f55024e6da55
        }
    }
}