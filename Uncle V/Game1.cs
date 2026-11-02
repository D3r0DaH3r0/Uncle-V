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
    public class Game1 : Game
    {
        private readonly ScreenManager _screenManager; // declares Screenmanagaer as a field
        private GraphicsDeviceManager _graphics;
        
        //creates GumUI property
        Gum.GumService GumUI => Gum.GumService.Default;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
            
            // creates new screenManager instance
            _screenManager = new ScreenManager();
            // adds it as a game componenet to ensure its methods work
            Components.Add(_screenManager);
            IsMouseVisible = true;
            
        
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            GumUI.Initialize(this, "Gum ui/GumProject.gumj");
            
            
            
            base.Initialize();
            _screenManager.ShowScreen(new MainMenuScreen(this));
            

           
          
            
        }

        protected override void LoadContent()
        {
           

        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            GumUI.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            
            base.Draw(gameTime);
            GumUI.Draw();
        }
    }
}
