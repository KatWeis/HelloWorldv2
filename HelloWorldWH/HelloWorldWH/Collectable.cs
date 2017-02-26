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
        private Random rgen;
        private List<Collectable> collects;
         
        //properties
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        //constructor
        public Collectable(Rectangle rec, Texture2D tex):base(rec, tex)
        {
            isActive = false;
            rgen = new Random();
        }

        public List<Collectable> Spawn(GraphicsDevice view)
        {
            List<Collectable> collects = new List<Collectable>(rgen.Next(2, 9));

            // create some local variables
            Collectable col;
            int windowW = view.Viewport.Width;
            int windowH = view.Viewport.Height;

            for (int i = 0; i < collects.Capacity; i++)
            {
                int x = rgen.Next(10, windowW - 80);
                int y = rgen.Next(10, windowH - 80);
                col = new Collectable(new Rectangle(x, y, 100, 100), texture);
                collects.Add(col);
            }
            return collects;
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
