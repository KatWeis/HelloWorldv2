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
        //constructor
        public Player(Rectangle rec, Texture2D tex):base(rec, tex)
        {
        }
    }
}
