using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//use libraries
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

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

        Player player; //player object that the user controls
        Texture2D playerIdle; //texture for idle player
        Texture2D playerText; //texture for moving player sprite

        //background music
        Song music;

        //collectibles
        Collectible generalCollectibles;
        List<Collectible> collects;

        //fonts
        SpriteFont font;

        //textures for other objects
        Texture2D collectible;
        Texture2D menu;

        //windows form
        Form1 form = new Form1();

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
            generalCollectibles = new Collectible(new Rectangle(200, 150, 50, 50), collectible);
            collects = generalCollectibles.Spawn(GraphicsDevice);
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

            // create player
            playerIdle = Content.Load<Texture2D>("spritrestsheet");
            playerText = Content.Load<Texture2D>("spriterunsheet");
            player = new Player(new Rectangle(0, 0, 150, 200), playerText);
            player.Idle = playerIdle;

            //font for score
            font = Content.Load<SpriteFont>("Arial");

            //load in music
            music = Content.Load<Song>("credit_to_TopeconHeroes.ogg");
            MediaPlayer.Play(music);
            MediaPlayer.IsRepeating = true;

            //load in menu asset
            collectible = Content.Load<Texture2D>("eat_me");

            //load in collectible asset
            menu = Content.Load<Texture2D>("logo");
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
                        player.PlayerUpdate(collects, kbState, preKB, gameTime, GraphicsDevice);
                        
                        if(GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || IsKeyPressed(Keys.Escape))
                        {
                            gameState = GameState.MainMenu;
                        }
                        if (IsKeyPressed(Keys.E))
                        {
                            gameState = GameState.Coding;
                            form = new Form1();
                            form.Visible = true;
                        }
                    }
                    break;
                case GameState.Coding:
                    {
                        
                        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || IsKeyPressed(Keys.Escape))
                        {
                            form.Visible = false;
                            gameState = GameState.Game;
                            player.ScoreOn = true;
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

            spriteBatch.Begin();

            //PLAYER ANIMATION -- Anna
            player.Time += (float)gameTime.ElapsedGameTime.TotalSeconds;
            player.AnimateSetup(1, 502, 629, 6);
            player.DrawAnimation(kbState, spriteBatch);

            //draw text if the user has unlocked score
            if(player.ScoreOn)
            {
                spriteBatch.DrawString(font, "Score: " + player.Score, new Vector2(20, 20), Color.White);
            }

            //have switch statement to manage gamestate
            switch (gameState)
            {
                case GameState.MainMenu:
                    {
                        spriteBatch.Draw(menu, new Rectangle(-40, -15, 880, 520), Color.White);
                        spriteBatch.DrawString(font, "Press enter to start", new Vector2(280, 430), Color.White);
                    }
                    break;
                case GameState.Game:
                    {
                        foreach (Collectible col in collects)
                        {
                            spriteBatch.Draw(collectible, col.Rec, Color.White);
                        }
                    }
                    break;
                case GameState.Coding:
                    {
                        spriteBatch.Draw(menu, new Rectangle(-40, -15, 880, 520), Color.Black);
                    }
                    break;
            }

            spriteBatch.End();
              
            base.Draw(gameTime);
        }

        /// <summary>
        /// Determines if a key has been pressed once using IsKeyUp on the previous keyboard state and IsKeyDown 
        /// on the current keyboard state
        /// </summary>
        /// <param name="key">key that is being pressed</param>
        /// <returns>True/false on whether or not the key was pressed this frame</returns>
        public bool IsKeyPressed(Keys key)
        {
            if(preKB.IsKeyUp(key) && kbState.IsKeyDown(key))
            {
                return true;
            }
            return false;
        }
    }
}
