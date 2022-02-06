using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPG
{
	public class Player : Entity
	{
		public Vector2 location;
		public float speed;
		public Player(Vector2 initialPosition)
		{
			location = initialPosition;
			speed = 300f;
		}
		public void Update(double gameTime, InputManager inputManager)
        {
			Vector2 moveVector = new Vector2(0f, 0f);
			if (inputManager.KeyRight)
				moveVector += new Vector2(1f, 0f);
			if (inputManager.KeyLeft)
				moveVector -= new Vector2(1f, 0f);
			if (inputManager.KeyDown)
				moveVector += new Vector2(0f, 1f);
			if (inputManager.KeyUp)
				moveVector -= new Vector2(0f, 1f);
			if (moveVector.Length() > 0f) moveVector.Normalize();
			MovePlayer(gameTime, moveVector);
        }

		private void MovePlayer(double gameTime, Vector2 direction)
        {
			location += direction * speed * (float)gameTime; 
        }

	}
}