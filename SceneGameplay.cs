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

        Pad SprPad;
        Sprites SprBall;
       

        public SceneGameplay(Game Pgame) : base(Pgame)
        {

            Rectangle Screen = game.Window.ClientBounds;
            

            Contexte.lives = 5;

         
            SprPad = new Pad(Pgame.Content.Load<Texture2D>("Pad"));

            SprPad.SetPosition((Screen.Width/2) - (SprPad.Width/2) , Screen.Height - SprPad.Height);
            
            
            // SprPad.Speed = new Vector2(2, -2);
            SprBall = new Sprites(Pgame.Content.Load<Texture2D>("Ball"));
          //SprBall.Setposition 
        }
        public override void Update()
        {
           // if (Keyboard.GetState().IsKeyDown(Keys.Right))
            //{
            //    Pad_x = Pad_x + 3;
            //}
            //else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            // {
            //    Pad_x = Pad_x - 3;
            //}

            SprPad.Update();
        }
        public override void Draw(SpriteBatch pBatch)
        {
        base.Draw(pBatch);
                SprPad.Draw(pBatch);
                SprBall.Draw(pBatch);
        }
    }
}