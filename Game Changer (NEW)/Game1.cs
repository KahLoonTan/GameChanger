﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Sprites;
using Nez.Tiled;


namespace Game_Changer__NEW_
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Core
    {
        
        SpriteBatch spriteBatch;
        private Scene myScene;
       

        public Game1()
        {
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

            base.Initialize();
            myScene = Scene.createWithDefaultRenderer(Color.CornflowerBlue);
            myScene.setDesignResolution(960, 512, Scene.SceneResolutionPolicy.ExactFit);
            
            //Loading tilemap
            var tiledEntity = myScene.createEntity("tiled-map");
            var tiledmap = content.Load<TiledMap>("tilemap");
            var tiledMapComponent = tiledEntity.addComponent(new TiledMapComponent(tiledmap));

            //Loading Tile Functionality, like creating coordinates    
            var tileSelect = new SelectTile(tiledmap);
            var selectmap = tiledEntity.addComponent(tileSelect);
            tiledMapComponent.setLayersToRender("maplayer");
            tiledMapComponent.renderLayer = 1;

            var russiaEntity = myScene.createEntity("russiaFact", new Vector2(590,180)); 
            var russiaInMap = content.Load<Texture2D>("russia");
            var russiaComponent = russiaEntity.addComponent(new Sprite(russiaInMap));

            var usaEntity = myScene.createEntity("usaFact", new Vector2(175, 115));
            var usaInMap = content.Load<Texture2D>("usa");
            var usaComponent = usaEntity.addComponent(new Sprite(usaInMap));

            Core.scene = myScene;
        }        /// <summary>
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
        //protected override void Update(GameTime gameTime)
        //{
        //    if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        //        Exit();

        //    // TODO: Add your update logic here

        //    base.Update(gameTime);
        //}

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
