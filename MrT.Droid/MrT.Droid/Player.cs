using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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
            
         }

        public void LoadContent(ContentManager cm)
        {
            _texture = cm.Load<Texture2D>("walking1");
        }



        public override void Update(GameTime gameTime)
        {
            X += 1;
            Y += 1;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, new Vector2(X, Y), Color.White);
        }
    }
}