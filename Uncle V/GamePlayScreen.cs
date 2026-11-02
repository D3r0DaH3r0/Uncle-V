using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Input;
using System;
using System.Diagnostics;
using MonoGame.Extended.Tilemaps;
using MonoGame.Extended.Tilemaps.Rendering;
using MonoGame.Extended;
using MonoGame.Extended.ViewportAdapters;
using System.Collections.Generic;
using Gum.Forms;
using Gum.Forms.Controls;
using MonoGameGum;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
using Uncle_V.Screens;
using GumDataTypes;

namespace Uncle_V
{
    internal class GamePlayScreen : GameScreen
    {
        public GamePlayScreen(Game game) : base(game) { }
        private SpriteBatch _spriteBatch;
        private Tilemap _tilemap;
        private TilemapSpriteBatchRenderer _renderer;
        private OrthographicCamera _camera;
        List<Rectangle> wallcollisions = new List<Rectangle>(); // Creates a list to store the wall collisions
        Player me;       // Creates player object for player
        Einstein einstein; // Creates einstein object for other uncle V
        Enemy noise;   // Creates new enemy object for other entities
        Enemy tattle;
        public override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here

            // loads map and stores it
            _tilemap = Content.Load<Tilemap>("comp sci map");
            // creates a new sprite batch renderer object and stores it
            _renderer = new TilemapSpriteBatchRenderer();
            // renders my map
            _renderer.LoadTilemap(_tilemap);

            // gets the wall layer from the map
            TilemapTileLayer walllayer = _tilemap.Layers["Obstacles"] as TilemapTileLayer;
            foreach (TilemapTileEntry entry in walllayer.GetTiles())
            {
                if (entry.Tile.GlobalId == 13 || entry.Tile.GlobalId == 8)

                {
                    Rectangle rectcollision = new Rectangle(((int)entry.X) * 32, ((int)entry.Y) * 32, 32, 32);

                    wallcollisions.Add(rectcollision);
                }
            }

            // Loads each character's sprite might change to add book sprites
            Texture2D meTexture = Content.Load<Texture2D>("Player");
            Texture2D einsteinTexture = Content.Load<Texture2D>("Uncle V");
            Texture2D noiseTexture = Content.Load<Texture2D>("Noisemaker");
            Texture2D tattleTexture = Content.Load<Texture2D>("Tattletale");

            // creates player object and its attributes
            me = new Player(meTexture, new Vector2(401, 593), 75f, 100, 50);

            // creates Einstein object and its attributes
            einstein = new Einstein(einsteinTexture, new Vector2(2, 593), 86.25f);

            // creates enemy objects and their attributes 
            noise = new Enemy(noiseTexture, new Vector2(2, 298), 63.75f);
            tattle = new Enemy(tattleTexture, new Vector2(768, 219), 78.75f);
            
           
        }
        public override void Initialize()
        {
            BoxingViewportAdapter viewportAdapter = new BoxingViewportAdapter(Game.Window, GraphicsDevice, 400, 400);

            _camera = new OrthographicCamera(viewportAdapter);
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            // Updates the renderer
            _renderer.Update(gameTime);



            // updates keyboard tracking
            KeyboardExtended.Update();



            // TODO: Add your update logic here
            me.Update(gameTime, wallcollisions);  // Updates Player logic

            
        }

        public override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.Black); // wipes the map clean and sets the background color to blue

            _camera.LookAt(me.position); // makes the camera follow the player

            Matrix cameraMatrix = _camera.GetViewMatrix(); // gets the camera matrix to draw the map and characters in the correct position
                                                           // TODO: Add your drawing code here


            _camera.Zoom = 3f; // sets the zoom level of the camera
            _renderer.Draw(_spriteBatch, _camera); // Draws the map onto the screen

            _spriteBatch.Begin(transformMatrix: cameraMatrix);
            // Draws each characters sprite onto the screen in a line
            _spriteBatch.Draw(me.texture, me.position, Color.White);
            _spriteBatch.Draw(einstein.texture, einstein.position, Color.White);
            _spriteBatch.Draw(noise.texture, noise.position, Color.White);
            _spriteBatch.Draw(tattle.texture, tattle.position, Color.White);

            _spriteBatch.End();

            
        }
    }
}
