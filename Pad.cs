using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Pad : Sprites
    {
        public Pad(Texture2D pTexture) : base(pTexture) 
        {
           // SetPosition()
        }

    public override void Update()
    {
        SetPosition(Mouse.GetState().X - (Width/2),Position.Y); 
        base.Update(); 
    }
}
