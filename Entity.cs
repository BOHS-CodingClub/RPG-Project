using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG
{
	public abstract class Entity
	{
        protected Texture2D _texture;
        protected Vector2 _position = Vector2.One;

        protected List<BoundingBox> _boundingBoxes = new List<BoundingBox>();
        public virtual int Width { get { return _texture.Width; } }
        public virtual int Height { get { return _texture.Height; } }
        public virtual Vector2 Position
        {
            get { return _position; }
            set
            {
                var deltaX = value.X - _position.X;
                var deltaY = value.Y - _position.Y;
                _position = value;

                foreach (var bb in _boundingBoxes)
                {
                    bb.Position = new Vector2(bb.Position.X + deltaX, bb.Position.Y + deltaY);
                }
            }
        }
        public List<BoundingBox> BoundingBoxes
        {
            get
            {
                return _boundingBoxes;
            }
        }
        public void AddBoundingBox(BoundingBox bb)
        {
            _boundingBoxes.Add(bb);
        }
    }
}
