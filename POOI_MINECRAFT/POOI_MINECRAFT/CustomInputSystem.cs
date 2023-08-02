//Code taken from https://community.monogame.net/t/one-shot-key-press/11669
//Originla author: Luca_Carminati

using Microsoft.Xna.Framework.Input;

namespace POOI_MINECRAFT
{
    internal class CustomInputSystem
    {
        static MouseState currentMouseState;
        static MouseState previousMouseState;

        public static MouseState GetState()
        {
            previousMouseState = currentMouseState;
            currentMouseState = Mouse.GetState();
            return currentMouseState;
        }

        public static bool IsPressed()
        {
            if (currentMouseState.LeftButton == ButtonState.Pressed)
                return true;

            else return false;
        }

        public static bool HasBeenPressed()
        {
            if (currentMouseState.LeftButton == ButtonState.Pressed && previousMouseState.LeftButton != ButtonState.Pressed)
                return true;

            else 
                return false;
        }
    }
}
