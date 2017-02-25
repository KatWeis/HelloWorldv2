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
    class Collectable: Entity
    {
        //constructor
        public Collectable(Rectangle rec, Texture2D tex):base(rec, tex)
        {
        }
    }
}
