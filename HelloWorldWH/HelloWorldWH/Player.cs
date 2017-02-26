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
    class Player : Entity
    {
        //animation attributes -- Anna
        bool down = true; //tracks last key pressed to determine which directional rest animation to use
        Texture2D idleTexture;
        public Texture2D Idle
        {
            get { return idleTexture; }
            set { idleTexture = value; }
        }

        //constructor
        public Player(Rectangle rect, Texture2D tex) : base(rect, tex)
        {
        }

        //override drawAnimation method -- Anna
        public override void DrawAnimation(KeyboardState ck, SpriteBatch sb)
        {
            base.DrawAnimation(ck, sb);
            //calc source rectangle of the current frame
            source = new Rectangle(frameIndex * frameWidth, 0, frameWidth, frameHeight);
            //vector to draw to screen                    
            origin = new Vector2(0f, 0f);
            //walk cycle right
            if (ck.IsKeyDown(Keys.D))
            {
                sb.Draw(texture, rec, source, Color.White, 0.0f, origin, SpriteEffects.None, 0.0f);
                down = true;
            }
            //walk cycle left
            if (ck.IsKeyDown(Keys.A))
            {
                sb.Draw(texture, rec, source, Color.White, 0.0f, origin, SpriteEffects.FlipHorizontally, 0.0f);
                down = false;
            }
            //resting animation
            if (ck.IsKeyUp(Keys.D) && (ck.IsKeyUp(Keys.A)))
            {
                if (down == true)
                {
                    //sb.Draw(idleTexture, rec, source, Color.White);
                    sb.Draw(texture, rec, source, Color.White, 0.0f, origin, SpriteEffects.None, 0.0f);
                }
                if (down == false)
                {
                    //sb.Draw(idleTexture, rec, source, Color.White, 0.0f, origin, SpriteEffects.FlipHorizontally, 0.0f);
                    sb.Draw(texture, rec, source, Color.White, 0.0f, origin, SpriteEffects.None, 0.0f);
                }
            }


        }
    }
}

