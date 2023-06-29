using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace BounceBreaker
{
    class Scenemenu : Scene
    {
        SpriteFont FontMenu;
        public Scenemenu (Game Pgame) : base (Pgame)
        {
            FontMenu = Pgame.Content.Load<SpriteFont>("PixFont");
        }
        public override void Update()
        {

        }
        public override void Draw(SpriteBatch pBatch)
        {
            base.Draw(pBatch);

            pBatch.DrawString(FontMenu, "Bouncebreaker Menu", new Vector2(1, 1), Color.FloralWhite);
        }
    }
}
