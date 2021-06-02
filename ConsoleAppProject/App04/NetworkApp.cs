using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        public bool LikePosts { get; private set; }

        /// <summary>
        /// 
        /// </summary>
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
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    //case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }

            } while (!wantToQuit);
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }

        //private void LikePosts()
        //{
            //throw new NotImplementedException();
        //}

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ",
                                                    1, Post.GetNumberOfPosts());
            news.RemovePost1(id);
        }

        private void DisplayAll()
        {
            news.Display(); 
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");

            string author = InputName();

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter yout image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image:");
            post.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
