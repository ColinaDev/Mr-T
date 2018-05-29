using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MrT.Droid
{
    internal abstract class GameObject
    {
        private Rectangle _hitbox;

        public int X
        {
            get => _hitbox.X;
            set => _hitbox.X = value;
        }

        public int Y
        {
            get => _hitbox.Y;
            set => _hitbox.Y = value;
        }

        public int Width
        {
            get => _hitbox.Width;
            set => _hitbox.Height = value;
        }

        public int Height
        {
            get => _hitbox.Height;
            set => _hitbox.Height = value;
        }

        public bool CheckCollision(GameObject go)
        {
            return _hitbox.Intersects(go._hitbox);
        }

        public bool CheckCollision(Rectangle rect)
        {
            return _hitbox.Intersects(rect);
        }

        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}