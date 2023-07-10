using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ball : Sprites
{
   
    public Ball(Texture2D pTexture,Rectangle pScreen) : base(pTexture, pScreen)
    {
  

    }
    public override void Update()
    {
            if (Position.X > Screen.Width - Width)
        {
            SetPosition(0, Position.Y);
        }

            if (Position.X < 0)
        {
            SetPosition(Position.X,0);
        }
            if (Position.Y < 0) 
        { 
            SetPosition(Position.X,0);
            Speed =new Vector2(Speed.X,-Speed.Y);
        }
          //  if (Position.Y > 0)
        //{
            
       // }
        
        
        base.Update();
    }
}