using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BounceBreaker
{
    public class GameBouncebreaker : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Scenemenu MaSceneMenu;
        SceneGameplay MaSceneGameplay;
        SceneGameover MaSceneGameover;
        Scene CurrentGameState;


        public GameBouncebreaker()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            MaSceneMenu = new Scenemenu(this);
            MaSceneGameplay = new SceneGameplay(this);
            MaSceneGameover = new SceneGameover(this);


            CurrentGameState = MaSceneMenu;
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                CurrentGameState = MaSceneGameplay;
            }

            // else if (Keyboard.GetState().IsKeyDown(Keys.NumPad8))
            // {
            //    CurrentGameState = MaSceneGameover;
            // }
                CurrentGameState.Update();


            
            
                // TODO: Add your update logic here

                base.Update(gameTime);
       
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MidnightBlue);

            
            // TODO: Add your drawing code here

            _spriteBatch.Begin();

           CurrentGameState.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}