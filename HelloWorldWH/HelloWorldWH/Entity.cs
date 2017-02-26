using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//monogame using statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//monogame extended
using MonoGame.Extended.Collisions;

namespace HelloWorldWH
{
    class Entity
    {
        // Attributes
        protected Rectangle rec;
        protected Texture2D texture;

        //Animation attributes  - Anna     
        //duration of time to show each frame
        float frameTime = 0.1f;
        //index of current frame shown
        protected int frameIndex;
        //total number of frames in spritesheet;
        protected int totalFrames;
        //size of the animation frame
        protected int frameHeight;
        protected int frameWidth;
        //passed in attributes
        protected Rectangle source;
        protected Vector2 origin;
        protected float time;

        //properties
        public Rectangle Rec
        {
            get { return rec; }
        }
        public Texture2D Texture
        {
            get { return texture; }
        }
        //animation properties
        public float Time
        {
            get { return time; }
            set { time = value; }
        }

        // constructor
        public Entity(Rectangle rectangle, Texture2D tex)
        {
            rec = rectangle;
            texture = tex;
        }

        public bool CollisionDetection(Entity obj)
        {
            if(rec.Intersects(obj.Rec))
            {
                return true;
            }
            return false;
        }


        protected virtual void CollisionResolution(Entity obj, KeyboardState kbState)
        {
            
        }

        //setup animation method
        public void AnimateSetup(int fIndex, int fWidth, int fHeight, int maxFrames) //animation method --Anna
        {
            //set animation attributes 
            //frameIndex = fIndex;
            frameWidth = fWidth;
            frameHeight = fHeight;
            totalFrames = maxFrames;
            //calc source rectangle of the current frame
            source = new Rectangle(frameIndex * frameWidth, 0, frameWidth, frameHeight);
            //vector to draw to screen                    
            origin = new Vector2(0f, 0f);
        }

        //draw animaiton method --overrided in player  -- Anna
        public virtual void DrawAnimation(KeyboardState Kstate, SpriteBatch sb)
        {
            //process elapsed game time 
            while (Time > frameTime)
            {
                //increment next frame in walkRight spritesheet
                frameIndex++;
                //reset elapsed time
                Time = 0f;
                //check if frameIndex has exceeded number of frames in spriteSheet
                if (frameIndex >= totalFrames)
                {
                    //reset to 1
                    frameIndex = 1;
                }
            }

        }
    }
}
