using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HelloWorldWH
{
    class Player: Entity
    {
        //variables
        private const float GRAVITY = 9.8f;
        //booleans to do with jumping
        private bool isJumping;
        private bool canJump;
        //variable for Y before jumping
        private int startingY; 

        //constructor
        public Player(Rectangle rec, Texture2D tex):base(rec, tex)
        {
            //initialize jumping bools
            isJumping = false;
            canJump = false;
        }

        /// <summary>
        /// Resolves collision for platforms
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="kbState"></param>
        protected override void CollisionResolution(Entity obj, KeyboardState kbState)
        {
            //determines if the player is running into a wall
            if (rec.Bottom > obj.Rec.Top + GRAVITY && isJumping == false)
            {
                if (rec.Right > obj.Rec.Left && kbState.IsKeyDown(Keys.D))
                {
                    rec.X = obj.Rec.Left - rec.Width;
                    //position.X -= movement.PlayerSpeed;
                }
                else if (rec.Left < obj.Rec.Right && kbState.IsKeyDown(Keys.A))
                {
                    rec.X = obj.Rec.Right;
                    //position.X += movement.PlayerSpeed;
                }
            }
            //sets player on top of terrain if fell
            if (rec.Bottom <= obj.Rec.Top + GRAVITY && rec.Bottom > obj.Rec.Top)
            {
                rec.Y -= rec.Bottom - obj.Rec.Top;
                startingY = rec.Y;
                canJump = true;
            }
            if (startingY > obj.Rec.Bottom && isJumping == true) // starts below the object & jumps
            {
                if (rec.Top < obj.Rec.Bottom && isJumping == true && rec.Top > obj.Rec.Top)
                {
                    rec.Y += obj.Rec.Bottom - rec.Top;
                }
            }
            else if (startingY - rec.Height < obj.Rec.Bottom && isJumping == true) // jumps and hits an object from the side
            {
                if (rec.Right > obj.Rec.Left && kbState.IsKeyDown(Keys.D))
                {
                    rec.X = obj.Rec.Left - rec.Width;
                    //position.X -= movement.PlayerSpeed;
                }
                else if (rec.Left < obj.Rec.Right && kbState.IsKeyDown(Keys.A))
                {
                    rec.X = obj.Rec.Right;
                    //position.X += movement.PlayerSpeed;
                }
            }
        }

        public void PlayerUpdate(List<Entity> stuff, KeyboardState kbState)
        {
            foreach(Entity e in stuff)
            {
                //standing on top of the platform
                if (!(rec.Left > e.Rec.Right) && !(rec.Right < e.Rec.Left))
                {
                    if (rec.Bottom == e.Rec.Top)
                    {
                        isJumping = false;
                        startingY = rec.Y;
                        canJump = true;
                    }
                }
                //colliding with platforms
                if (CollisionDetection(e) == true)
                {
                    if(e is Collectable)
                    {
                        //call some method to react to colliding with the collectable
                    }
                    else
                    {
                        CollisionResolution(e, kbState);
                    }
                }
            }
            
        }
    }
}
