using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UmbralPhoenix.Domain.Entities
{
    public class Sprite
    {
		private Texture2D texture;
        private Vector2 position;
        private int sizeX;
        private int sizeY;

        public Texture2D Texture
		{
			get { return texture; }
			set { texture = value; }
		}

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public int SizeX
        {
            get { return sizeX; }
            set { sizeX = value; }
        }

        public int SizeY
        {
            get { return sizeY; }
            set { sizeY = value; }
        }

		public Sprite(Texture2D texture, Vector2 position, int scaleFactor) 
		{
			Texture = texture;
			Position = position;
			SizeX = scaleFactor * texture.Width;
			SizeY = scaleFactor * texture.Height;
		}
	}
}
