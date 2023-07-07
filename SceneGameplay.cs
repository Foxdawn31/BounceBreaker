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
        Ball SprBall;
        bool Stickyball;


        public SceneGameplay(Game Pgame) : base(Pgame)
        {

            Rectangle Screen = game.Window.ClientBounds;
            

            Contexte.lives = 5;

         
            SprPad = new Pad(Pgame.Content.Load<Texture2D>("Pad"),Screen);
            SprPad.SetPosition((Screen.Width/2) - (SprPad.Width/2) , Screen.Height - SprPad.Height);                      
            
            SprBall = new Ball(Pgame.Content.Load<Texture2D>("Ball"),Screen);
            SprBall.SetPosition(SprPad.Position.X + SprBall.Width / 2, SprPad.Position.Y - SprBall.Height);
            SprBall.Speed = new Vector2 (4, -4);

            Stickyball = true;
        }
        public override void Update()
        {
            
           

            if (Stickyball == true) 
            {
                SprBall.SetPosition(SprPad.Position.X + SprPad.Width / 2 - SprBall.Width/2, SprPad.Position.Y - SprPad.Height);
                
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                Stickyball =false;
            }
            if (SprPad.BoundingBox.Intersects(SprBall.BoundingBox))
            {
                SprBall.Speed = new Vector2(SprBall.Speed.X,- SprBall.Speed.Y);
            }

           
            SprPad.Update();
            SprBall.Update();
        }
        public override void Draw(SpriteBatch pBatch)
        {
        base.Draw(pBatch);
                SprPad.Draw(pBatch);
                SprBall.Draw(pBatch);
        }
    }
}