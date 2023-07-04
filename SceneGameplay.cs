using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BounceBreaker
{
    class SceneGameplay : Scene
    {
       
        Sprites SprPad;
        Sprites SprBall;
       

        public SceneGameplay(Game Pgame) : base(Pgame)
        {
            
          

            Contexte.lives = 5;

         
            SprPad = new Sprites(Pgame.Content.Load<Texture2D>("Pad"));
            SprPad.SetPosition (new Vector2 (10, 450));
            SprBall = new Sprites(Pgame.Content.Load<Texture2D>("Ball"));
          //SprBall.Setposition 
        }
        public override void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
            //    Pad_x = Pad_x + 3;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
             {
            //    Pad_x = Pad_x - 3;
             }

        }
        public override void Draw(SpriteBatch pBatch)
        {
        base.Draw(pBatch);
                SprPad.Draw(pBatch);
                SprBall.Draw(pBatch);
        }
    }
}