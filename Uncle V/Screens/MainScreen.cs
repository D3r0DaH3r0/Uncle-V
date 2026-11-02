using Gum.Converters;
using Gum.DataTypes;
using Gum.Managers;
using Gum.Wireframe;
using MonoGame.Extended.Screens;
using RenderingLibrary.Graphics;
using Microsoft.Xna.Framework;
using System.Linq;

namespace Uncle_V.Screens
{
    partial class MainScreen
    {
        partial void CustomInitialize()
        {
            Start_button.Click += (_, _) => ScreenManager.ReplaceScreen(new GamePlayScreen(Game));
        }
    }
}
