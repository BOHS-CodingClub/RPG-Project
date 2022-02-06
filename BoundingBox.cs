using Microsoft.Xna.Framework;

namespace RPG
{
	public class BoundingBox
	{
		public Vector2 Position { get; set; }
		public float Width { get; set; }
		public float Height { get; set; }
		public Rectangle Rectangle
        {
			get
            {
				return new Rectangle((int)Position.X, (int)Position.Y, (int)Width, (int)Height);
            }
        }

		public BoundingBox(Vector2 position, float width, float height)
        {
			Position = position;
			Width = width;
			Height = height;
        }
		public bool CollidesWith(BoundingBox boundingBox)
        {
			if (Position.X < boundingBox.Position.X + boundingBox.Width &&
				Position.X + Width > boundingBox.Position.X &&
				Position.Y < boundingBox.Position.Y + boundingBox.Height &&
				Position.Y + Height > boundingBox.Position.Y)
				return true;
			else
				return false;
        }
	}
}