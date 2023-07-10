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

    public Rectangle BoundingBox { get; private set; }

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

    public Rectangle NextposX()
    {
        Rectangle nextPos = BoundingBox;
        nextPos.Offset(new Point((int)Speed.X,0));
        return nextPos;
    }

    public Rectangle NextposY()
    {
        Rectangle nextPos = BoundingBox;
        nextPos.Offset(new Point(0, (int)Speed.Y));
        return nextPos;
    }
    public void ReverseSpeedX()
    {
        Speed = new Vector2(-Speed.X, Speed.Y);
    }
    public void ReverseSpeedY()
    {
        Speed = new Vector2(Speed.X, -Speed.Y);
    }

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

        Position = new Vector2(Position.X + Speed.X, Position.Y + Speed.Y);

        BoundingBox = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
    }

    public virtual void Draw(SpriteBatch pBatch) 
        {
            pBatch.Draw(Texture, Position,Color.White);
        }

    }
