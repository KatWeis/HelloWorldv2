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
        //variables
        private bool isActive;//determines if the collectable has been collected or not

        //constructor
        public Collectable(Rectangle rec, Texture2D tex):base(rec, tex)
        {
            isActive = false;
        }

        public void CollisionResolution(Player pl)
        {
            if(isActive == true)
            {
                pl.Score += 10;
            }
        }
    }
}
