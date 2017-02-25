using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//use libraries
using System;

namespace HelloWorldWH
{
    //enums
    public enum GameState
    {
        MainMenu,
        Coding,
        Game
    }


    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //variables
        GameState gameState;//current mode of the game
        KeyboardState kbState; //used to get keyboard input
        KeyboardState preKB; //used to hold input of last keyboard presses

        Player pl; //player object that the user controls
        Texture2D plText; //texture for the player sprite

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            //initialize variables
            gameState = GameState.MainMenu;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

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
            //set the last keyboard state equal to preKeyboard
            preKB = kbState;
            //set keyboard state to be current state
            kbState = Keyboard.GetState();
            Console.WriteLine(gameState);
            

            //have switch statement to manage gamestate
            switch(gameState)
            {
                case GameState.MainMenu:
                    {
                        if(IsKeyPressed(Keys.Enter))
                        {
                            gameState = GameState.Game;
                        }
                        //closes game if escape key is pressed
                        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || IsKeyPressed(Keys.Escape))
                        {
                            Exit();
                        }
                    }
                    break;
                case GameState.Game:
                    {
                        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || IsKeyPressed(Keys.Escape))
                        {
                            gameState = GameState.MainMenu;
                        }
                        if (IsKeyPressed(Keys.E))
                        {
                            gameState = GameState.Coding;
                        }
                    }
                    break;
                case GameState.Coding:
                    {
                        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || IsKeyPressed(Keys.Escape))
                        {
                            gameState = GameState.Game;
                        }
                    }
                    break;
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        /// <summary>
        /// Determines if a key has been pressed once using IsKeyUp on the previous keyboard state and IsKeyDown 
        /// on the current keyboard state
        /// </summary>
        /// <param name="key">key that is being pressed</param>
        /// <returns>True/false on whether or not the key was pressed this frame</returns>
        private bool IsKeyPressed(Keys key)
        {
            if(preKB.IsKeyUp(key) && kbState.IsKeyDown(key))
            {
                return true;
            }
            return false;
        }
    }
}
