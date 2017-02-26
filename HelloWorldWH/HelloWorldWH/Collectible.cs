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
    class Collectible: Entity
    {
        //variables
        private bool isActive;//determines if the collectable has been collected or not
        private Random rgen;
        private Color curCol;
         
        //properties
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        public Color CurCol
        {
            get { return curCol; }
            set { curCol = value; }
        }

        //constructor
        public Collectible(Rectangle rec, Texture2D tex):base(rec, tex)
        {
            isActive = false;
            curCol = Color.Transparent;
            rgen = new Random();
        }

        public List<Collectible> Spawn(GraphicsDevice view)
        {
            List<Collectible> collects = new List<Collectible>(rgen.Next(3, 9));

            // create some local variables
            Collectible col;
            int windowW = view.Viewport.Width;
            int windowH = view.Viewport.Height;

            for (int i = 0; i < collects.Capacity; i++)
            {
                int x = rgen.Next(10, windowW - 80);
                int y = rgen.Next(10, windowH - 80);
                col = new Collectible(new Rectangle(x, y, 50, 50), texture);
                collects.Add(col);
            }
            return collects;
        }

        public void CollisionResolution(Player pl)
        {
            if(isActive == true)
             {
                //mark inactive
                isActive = false;
                //increment score
                pl.Score += 10;
                //make collectibles disappear
                curCol = Color.Transparent;
            }
        }
    }
}
