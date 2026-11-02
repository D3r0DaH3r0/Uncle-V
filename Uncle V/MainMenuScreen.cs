using Gum.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;
using MonoGame.Extended.ViewportAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gum.Forms.Controls;
using MonoGameGum;
using Uncle_V.Screens;

namespace Uncle_V
{
    internal class MainMenuScreen : GameScreen
    {
        private MainScreen _gumMainScreen;
        public MainMenuScreen(Game game) : base(game) { }

        
        
        public override void LoadContent()
        {
            base.LoadContent();
            _gumMainScreen = new MainScreen();
            _gumMainScreen.AddToRoot(); // adds to root screen

            _gumMainScreen.Start_button.Click += Start_button_Click;  // registers start button click
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            _gumMainScreen.RemoveFromRoot(); // removes from root

            ScreenManager.ReplaceScreen( new GamePlayScreen(Game));
        }

        public override void Update(GameTime gameTime)
        {
        
            
        
        }

        public override void Draw(GameTime gameTime)
        {
            //makes background colour
            GraphicsDevice.Clear(Color.DarkKhaki);
           
        
        }
    }

    
}
