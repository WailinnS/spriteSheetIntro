using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace SpriteSheetIntro
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D spriteSheet;
        List<Frame> idleframes;
        int index = 0;
        float currentTime = 0;
        int x = 0;
       
        TimeSpan updateTime = TimeSpan.FromMilliseconds(100);
        TimeSpan elapsedTime = TimeSpan.Zero;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            idleframes = new List<Frame>();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {

            spriteSheet = Content.Load<Texture2D>("GreenKnight\\GreenKnightSpriteSheet");

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            idleframes.Add(new Frame(Vector2.Zero, new Rectangle(0, 567, 52, 63)));
            idleframes.Add(new Frame(Vector2.Zero, new Rectangle(79, 567, 52, 63)));
            idleframes.Add(new Frame(Vector2.Zero, new Rectangle(158, 567, 52, 63)));
            idleframes.Add(new Frame(Vector2.Zero, new Rectangle(237, 567, 52, 63)));
            idleframes.Add(new Frame(Vector2.Zero, new Rectangle(316, 567, 52, 63)));
            idleframes.Add(new Frame(Vector2.Zero, new Rectangle(395, 567, 52, 63)));

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            //currentTime += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            //if (currentTime > 1000)
            //{
            //    index++;

            //}
            //if(index > 5)
            //{
            //    index = 0;
            //}
            x++;
            elapsedTime += gameTime.ElapsedGameTime;
            if(elapsedTime > updateTime)
            {
                elapsedTime = TimeSpan.Zero;
                index++;
                if(index > idleframes.Count-1)
                {
                    index = 0;
                }
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            
            spriteBatch.Draw(spriteSheet, new Vector2(x,417), idleframes[index].SourceRectangle, Color.White,0.0f,idleframes[index].Origin, Vector2.One,SpriteEffects.None, 0.0f);

            spriteBatch.End();
          
            base.Draw(gameTime);
        }
    }
}
