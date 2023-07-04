using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Sprites
    {
    public Vector2 Position { get; set; }
    public Vector2 Speed { get; set; }
    private Texture2D Texture;
        public Sprites(Texture2D pTexture) 
        { 
        Texture = pTexture;
        }

    public void SetPosition(Vector2 pPosition)
    {
        Position = pPosition;
    }

        public void Draw(SpriteBatch pBatch) 
        {
            pBatch.Draw(Texture, Position,Color.White);
        }

    }
