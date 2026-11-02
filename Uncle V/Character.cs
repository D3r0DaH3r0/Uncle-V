using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uncle_V 
{
    internal class Character
    {
        public Texture2D texture; // Sprite texture
        public Vector2 position;  // Sprite position
        public float speed;  // character speed
        public virtual Rectangle collisionrect
        {
            get
            {
                return new Rectangle
                     (
                      (int)position.X , // Creates Hitbox Centre
                      (int)position.Y , //And follows player
                      32,               // Creates Hitbox Dimensions
                      32
                     );
            }
        }

        public Character(Texture2D texture, Vector2 position, float speed)
        {
            this.texture = texture;
            this.position = position;
            this.speed = speed;
        }

       
    }

}
