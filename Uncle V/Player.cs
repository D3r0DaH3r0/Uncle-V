using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Uncle_V
{
    internal class Player : Character 
    {
       public int Health { get; set; }
       
       public int Stamina { get; set; }
        public override Rectangle collisionrect
        {
            get
            {
                return new Rectangle
                     (
                      (int)position.X +11 ,     // Creates Hitbox Centre at centre of player
                      (int)position.Y +8 ,     //And follows player
                      8,                        // Creates Hitbox dimensions
                      24
                     );
            }
        }
        public Player(Texture2D texture, Vector2 position, float speed, int stamina, int health): base(texture, position, speed)
        {
             Stamina = stamina;
             Health = health;
        }


        public void Update(GameTime gameTime, List<Rectangle> wallcollisions)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            KeyboardStateExtended keyboardstate = KeyboardExtended.GetState();
            float currentspeed = speed;  // stores speed attribute
            if(keyboardstate.IsControlDown()) 
            {
                 currentspeed = speed * 1.5f; // changes speed when ctrl is pressed
                                              // without changing original attribute
            
            }
            else if(keyboardstate.IsShiftDown())
            {                               
                currentspeed = speed * 0.5f;    // changes speed when shift is pressed
                                                // without changing original attribute
            }

        
                float changeY = 0;

                if (keyboardstate.IsKeyDown(Keys.W)) //Moves up whilst W is pressed
                {
                    changeY -= currentspeed * deltaTime;
                }
                else if (keyboardstate.IsKeyDown(Keys.S)) //Moves down whilst S is pressed
                {
                    changeY += currentspeed * deltaTime;
                }
                position.Y += changeY; // stores change in poisition to Y position of player

                foreach (Rectangle wallcollision in wallcollisions)
                {
                    if (collisionrect.Intersects(wallcollision) || (position.Y + changeY) <-12 || (position.Y + changeY) > 610)
                    {
                        position.Y -= changeY; // moves player back to previous position if colliding with wall
                    }
                }
            

     
            
                float changeX = 0;

                if (keyboardstate.IsKeyDown(Keys.D)) //Moves right whilst D is pressed
                {
                    changeX += currentspeed * deltaTime;
                }
                else if (keyboardstate.IsKeyDown(Keys.A)) //Moves left whilst A is pressed
                {
                    changeX -= currentspeed * deltaTime;
                }
                position.X += changeX; // stores change in poisition to Y position of player

                foreach (Rectangle wallcollision in wallcollisions)
                {
                    if (collisionrect.Intersects(wallcollision) || (position.X + changeX) < -14 || (position.X + changeX) > 784)
                    {
                        position.X -= changeX; // moves player back to previous position if colliding with wall
                    }
                }
            


        }
    
    }
}
