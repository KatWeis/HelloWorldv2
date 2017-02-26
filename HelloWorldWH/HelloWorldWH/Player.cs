﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HelloWorldWH
{
    class Player : Entity
    {
        //fields
        private const float GRAVITY = 9.8f;
        private float velocityY; // upward velocity of the player

        //booleans to do with jumping
        private bool isJumping;
        private bool canJump;

        //variable for Y before jumping
        private int startingY; // <-- might not need that (Catherine)

        //animation attributes -- Anna
        bool down = true; //tracks last key pressed to determine which directional rest animation to use

        Texture2D idleTexture;
        //variable to keep track of score
        private int score;

        //bool about whether or not score is enabled
        private bool scoreOn;

        //bool about whether or not the player can move
        private bool canMove;
        private bool canMoveR;//moving to the right
        private bool canMoveL;//moving to the left


        //properties
        public Texture2D Idle
        {
            get { return idleTexture; }
            set { idleTexture = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public bool ScoreOn
        {
            get { return scoreOn; }
            set { scoreOn = value; }
        }
        public bool CanMove
        {
            get { return canMove; }
            set { canMove = value; }
        }
        public bool CanMoveR
        {
            get { return canMoveR; }
            set { canMoveR = value; }
        }
        public bool CanMoveL
        {
            get { return canMoveL; }
            set { canMoveL = value; }
        }

        //constructor
        public Player(Rectangle rect, Texture2D tex) : base(rect, tex)
        {
            //initialize jumping bools
            isJumping = false;
            canJump = false;
            velocityY = 0;
            score = 0;
            scoreOn = false;
            //initialize the players ability to move to be false
            canMove = false;
            canMoveL = false;
            canMoveR = false;
        }


        private void Jump(GameTime gameTime, KeyboardState cKey, KeyboardState pKey)
        {

            float time = (float)gameTime.ElapsedGameTime.TotalSeconds; //maybe not needed 

            //If the Space Key is being pressed
            if (cKey.IsKeyDown(Keys.Space) && canJump == true) //short jump
            {

                isJumping = true; // the player is jumping
                velocityY = -8;  // the player moves up (Note: The origin (0,0) is in the UPPER LEFT corner of the screen, which is why our velocity is a negative number)
                canJump = false; // if a player is already jumping, should they be able to jump again?
            }

            // If the player is currently jumping
            if (isJumping) // when you put just a boolean in the if statement, it assumes it means “isJumping == true”

            {
                velocityY += GRAVITY * time;


                rec.Y += (int)velocityY;
            }

            
            velocityY += GRAVITY * time;
            rec.Y += (int)velocityY;

           
            if (rec.Y > 299)
            {
                isJumping = false;
                velocityY = 0;
                canJump = true;
            }
        } // end of method yEET

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

        public void PlayerUpdate(List<Collectible> stuff, KeyboardState kbState, KeyboardState preKB, GameTime gTime, GraphicsDevice gd)
        {
            //player movement
            if ((kbState.IsKeyDown(Keys.D) || kbState.IsKeyDown(Keys.Right)) && canMoveR == true)
            {
                rec.X += 5;
            }
            if((kbState.IsKeyDown(Keys.A) || kbState.IsKeyDown(Keys.Left)) && canMoveL == true)
            {
                rec.X -= 5;
            }
            //vertical screep wrap
            if(rec.X >= gd.Viewport.Width)
            {
                rec.X = -90;
            }
            if (rec.X <= -100)
            {
                rec.X = (int)gd.Viewport.Width;
            }
            //jump
            Jump(gTime, kbState, preKB);

            //collision
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
                    if(e is Collectible)
                    {
                        Collectible temp = (Collectible)e;
                        temp.CollisionResolution(this);
                    }
                    else
                    {
                        CollisionResolution(e, kbState);
                    }
                }
            }
            
        }

        //override drawAnimation method -- Anna
        public override void DrawAnimation(KeyboardState ck, SpriteBatch sb)
        {
            base.DrawAnimation(ck, sb);
            //calc source rectangle of the current frame
            source = new Rectangle(frameIndex * frameWidth, 0, frameWidth, frameHeight);
            //vector to draw to screen                    
            origin = new Vector2(0f, 0f);

            //resting animation
            if (((ck.IsKeyUp(Keys.D) && ck.IsKeyUp(Keys.Right)) && (ck.IsKeyUp(Keys.A) && ck.IsKeyUp(Keys.Left)))
                || ((ck.IsKeyDown(Keys.D) && ck.IsKeyDown(Keys.A)) || (ck.IsKeyDown(Keys.Right) && ck.IsKeyDown(Keys.Left))) || canMove == false
                || ((ck.IsKeyDown(Keys.A) || ck.IsKeyDown(Keys.Left)) && CanMoveL == false))
            {
                if (down == true)
                {
                    sb.Draw(idleTexture, rec, source, Color.White);
                }
                if (down == false)
                {
                    sb.Draw(idleTexture, rec, source, Color.White, 0.0f, origin, SpriteEffects.FlipHorizontally, 0.0f);
                }
            }
            //walk cycle right
            else if ((ck.IsKeyDown(Keys.D)||ck.IsKeyDown(Keys.Right)) && canMoveR == true)
            {
                sb.Draw(texture, rec, source, Color.White, 0.0f, origin, SpriteEffects.None, 0.0f);
                down = true;
            }
            //walk cycle left
            else if ((ck.IsKeyDown(Keys.A)||ck.IsKeyDown(Keys.Left)) && canMoveL == true)
            {
                sb.Draw(texture, rec, source, Color.White, 0.0f, origin, SpriteEffects.FlipHorizontally, 0.0f);
                down = false;
            }
           


        }
    }
}

