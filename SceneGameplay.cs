using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace BounceBreaker
{
    class SceneGameplay : Scene
    {

        Pad SprPad;
        Brick SprBrick;
        Ball SprBall;
        bool Stickyball;
        const int Columnumbr = 17;
        const int Linumber = 8;
        private int [,] Level;
        private List<Brick> Lstbrick;

        public SceneGameplay(Game Pgame) : base(Pgame)
        {

            Rectangle Screen = game.Window.ClientBounds;


            Contexte.lives = 5;


            SprPad = new Pad(Pgame.Content.Load<Texture2D>("Pad"), Screen);
            SprPad.SetPosition((Screen.Width / 2) - (SprPad.Width / 2), Screen.Height - SprPad.Height);


            //SprBrick = new Brick(Pgame.Content.Load<Texture2D>("Intact_Normal_Brick"), Screen);
            //SprBrick.SetPosition(Screen.Width / 2, Screen.Height / 2);


            SprBall = new Ball(Pgame.Content.Load<Texture2D>("Ball"), Screen);
            SprBall.SetPosition(SprPad.Position.X + SprBall.Width / 2, SprPad.Position.Y - SprBall.Height);
            SprBall.Speed = new Vector2(4, -4);

            Stickyball = true;

            Level = new int[,]
            {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            };

            Lstbrick = new List<Brick>();

            Texture2D TexBrick = game.Content.Load<Texture2D>("Intact_Normal_Brick");


            for (int l = 0 ; l < Level.GetLength(0); l++)
            {
                for (int c = 0; c < Level.GetLength(1); c++)
                {
                    Brick Mybrick = new Brick(TexBrick, Screen);
                    Mybrick.SetPosition((c) * TexBrick.Width, (l) * TexBrick.Height);
                    Lstbrick.Add(Mybrick);
                }
            }
        }
        public override void Update()
        {



            if (Stickyball == true)
            {
                SprBall.SetPosition(SprPad.Position.X + SprPad.Width / 2 - SprBall.Width / 2, SprPad.Position.Y - SprPad.Height);

            }

            foreach (var Brick in Lstbrick)
            {
                Brick.Update();
                if (Brick.BoundingBox.Intersects(SprBall.BoundingBox))
                {
                    SprBall.Speed = new Vector2 (SprBall.Speed.X, -SprBall.Speed.Y);
                }
            }

            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                Stickyball =false;
            }

            if (SprPad.BoundingBox.Intersects(SprBall.BoundingBox))
            {
                SprBall.Speed = new Vector2(SprBall.Speed.X,- SprBall.Speed.Y);
            }

           // if (SprBall.BoundingBox.Intersects(SprBrick.BoundingBox))
            //{
           //     SprBall.Speed = new Vector2(SprBall.Speed.X, -SprBall.Speed.Y);
           // }
           
            SprPad.Update();
            SprBall.Update();
            //SprBrick.Update();
        }
        public override void Draw(SpriteBatch pBatch)
        {
        base.Draw(pBatch);
            foreach (var Brick in Lstbrick)
            {
                Brick.Draw(pBatch);
            }
            SprPad.Draw(pBatch);
            SprBall.Draw(pBatch);
                //SprBrick.Draw(pBatch);
        }
    }
}