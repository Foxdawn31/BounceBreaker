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
        Texture2D TexPad;
        int Pad_x;
        int Pad_y;

        Texture2D TexBall;
        int Ball_x;
        int Ball_y;

        public SceneGameplay(Game Pgame) : base(Pgame)
        {
            Pad_x = 10;
            Pad_y = 450;
            Ball_x = 40;
            Ball_y = 50;

            TexPad = Pgame.Content.Load<Texture2D>("Pad");
            TexBall = Pgame.Content.Load<Texture2D>("Ball");
        }
        public override void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Pad_x = Pad_x + 3;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left) && Pad_x >= 0)
            {
                Pad_x = Pad_x - 3;
            }
        }
        public override void Draw(SpriteBatch pBatch)
        {
            pBatch.Draw(TexPad, new Vector2(Pad_x, Pad_y), Color.White);
            pBatch.Draw(TexBall, new Vector2(Ball_x, Ball_y), Color.White);

            base.Draw(pBatch);
        }
    }
}