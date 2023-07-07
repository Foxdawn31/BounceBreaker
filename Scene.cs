using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

    public class Scene
    {
        protected Game game;

    public Scene(Game Pgame)
    {
       game = Pgame;
    }

    public virtual void Update()
    {
       
    }

       public virtual void Draw(SpriteBatch pBatch)
       {
        
        }
    }
