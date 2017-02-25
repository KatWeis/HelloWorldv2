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
        Rectangle rec;
        Texture2D texture;

        // constructor
        public Entity(Rectangle rectangle, Texture2D tex)
        {
            rec = rectangle;
            texture = tex;
        }

    }
}
