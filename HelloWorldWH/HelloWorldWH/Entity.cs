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
    class Entity
    {
        // Attributes
        protected Rectangle rec;
        protected Texture2D texture;

        //properties
        public Rectangle Rec
        {
            get { return rec; }
        }
        public Texture2D Texture
        {
            get { return texture; }
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

    }
}
