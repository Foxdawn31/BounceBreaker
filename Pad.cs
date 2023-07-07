using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Pad : Sprites
    {
    Ball Myball;
   // ScreenWidth =
        public Pad(Texture2D pTexture, Rectangle pScreen) : base(pTexture, pScreen) 
        {
      
        }

    public override void Update()
    {
        SetPosition(Mouse.GetState().X - (Width/2),Position.Y); 

        if (Position.X < 0)
        {
            SetPosition(0, Position.Y);
        }
        if (Position.X > Screen.Width-Width) 
        { 
           SetPosition(Screen.Width-Width, Position.Y);
        }
        
        base.Update();  
    }
}
