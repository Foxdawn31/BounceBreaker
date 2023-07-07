using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Sprites
    {
       protected Rectangle Screen;
         public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }

        public int Height 
        {
             get
          {
            return Texture.Height;
          }
         }

        public int Width
        {
            get
            {
            return Texture.Width;
            } 
        } 
    private Texture2D Texture;



        public Sprites(Texture2D pTexture,Rectangle pScreen) 
        { 
        Texture = pTexture;
        Screen = pScreen;
        }

    public void SetPosition(Vector2 pPosition)
    {
        Position = pPosition;
    }

    public void SetPosition(float pX, float pY)
    {
        Position = new Vector2(pX, pY);
    }

    
    public virtual void Update()
    {

        Position = new Vector2 (Position.X + Speed.X,Position.Y + Speed.Y);
    }

    public virtual void Draw(SpriteBatch pBatch) 
        {
            pBatch.Draw(Texture, Position,Color.White);
        }

    }
