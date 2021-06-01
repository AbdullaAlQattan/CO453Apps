using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("    Abdulla's News Feed");

            string[] choices = new string[]
            {
                "Posts Message", "Post Image", "" +
                "Display All Posts", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: wantToQuit(); break;
                }

            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            throw new NotImplementedException();
        }

        private void PostImage()
        {
            throw new NotImplementedException();
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }
    }
}
