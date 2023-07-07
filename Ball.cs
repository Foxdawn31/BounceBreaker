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
    Rectangle Screen;
    public Ball(Texture2D pTexture, Rectangle pScreen) : base(pTexture)
    {
        Screen = pScreen;

    }
    public override void Update()
    {
       
        base.Update();
    }
}