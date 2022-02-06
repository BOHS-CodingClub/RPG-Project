using System;
using Microsoft.Xna.Framework.Input;

namespace RPG
{
	public class InputManager
	{
		public bool KeyRight { get; private set; }
		public bool KeyLeft { get; private set; }
		public bool KeyUp { get; private set; }
		public bool KeyDown { get; private set; }

		public void Update()
        {
			ResetKeys();
			var input = Keyboard.GetState();
			if (input.IsKeyDown(Keys.Up) || input.IsKeyDown(Keys.W))
				KeyUp = true;
			if (input.IsKeyDown(Keys.Right) || input.IsKeyDown(Keys.D))
				KeyRight = true;
			if (input.IsKeyDown(Keys.Down) || input.IsKeyDown(Keys.S))
				KeyDown = true;
			if (input.IsKeyDown(Keys.Left) || input.IsKeyDown(Keys.A))
				KeyLeft = true;
		}

		private void ResetKeys()
        {
			KeyRight = false;
			KeyLeft = false;
			KeyUp = false;
			KeyDown = false;
        }
	}
}
