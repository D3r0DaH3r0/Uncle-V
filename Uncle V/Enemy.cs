using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncle_V
{
    internal class Enemy : Character
    {
        public override Rectangle collisionrect
        {
            get
            {
                return new Rectangle
                     (
                      (int)position.X +16,  // Creates Hitbox Centre
                      (int)position.Y +16,
                      32,
                      32                   // Creates Hitbox dimensions
                     );
            }
        }

        public Enemy(Texture2D texture, Vector2 position, float speed) : base(texture, position, speed)
        {
        }
    public virtual void Decision(Vector2 sound, float magnitude)
        {
          // General enemy Decision making
        }
    }
}
