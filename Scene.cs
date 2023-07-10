using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

    public abstract class Scene
    {

    public Rectangle SizeScreen { get; private set; }
  

    protected Game game;

    public Scene(Game Pgame)
    {
       game = Pgame;
       SizeScreen = game.Window.ClientBounds;
    }

    public virtual void Update()
    {
       
    }

       public virtual void Draw(SpriteBatch pBatch)
       {
        
        }
    }
