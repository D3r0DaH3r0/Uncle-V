using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncle_V
{
    internal class Sound : Character
    {
        public float Magnitude { get; set; }
        public override Rectangle collisionrect
        {
            get
            {
                return new Rectangle
                     (
                      (int)position.X + 8,      // Creates Hitbox Centre
                      (int)position.Y + 8,    
                      16,                    // Creates hitbox dimensions
                      16
                     );
            }
        }
        public Sound(Texture2D texture, Vector2 position, float speed, float magnitude) : base(texture, position, speed)
        {
            Magnitude = magnitude;
        }

    }
}
