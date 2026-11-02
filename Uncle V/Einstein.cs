using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncle_V
{
    internal class Einstein: Enemy
    {
    public Einstein(Texture2D texture, Vector2 position, float speed) : base(texture, position, speed)
        {
        }
        public override Rectangle collisionrect
        {
            get
            {
                return new Rectangle
                     (
                      (int)position.X +7,      // Creates Hitbox Centre at centre of sprite
                      (int)position.Y + 14,
                      14,
                      24                       // Creates Hitbox dimensions
                     );
            } 
        }
     public override void Decision(Vector2 sound, float magnitude)
        {
         // Decision making
         // Higher magnitude makes position estimation more accurate
        }
    }
}
