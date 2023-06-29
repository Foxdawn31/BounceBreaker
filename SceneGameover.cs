using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace BounceBreaker
{
    class SceneGameover : Scene
    {
        SpriteFont FontGameover;
        public SceneGameover(Game Pgame) : base(Pgame)
        {
            FontGameover = Pgame.Content.Load<SpriteFont>("PixFont");
        }
        
        public override void Update()
        {

        }
        public override void Draw(SpriteBatch pBatch)
        {
             base.Draw(pBatch);
            
            
        pBatch.DrawString(FontGameover, "Game over", new Vector2(1, 1), Color.FloralWhite);

           
        }
    }
}
