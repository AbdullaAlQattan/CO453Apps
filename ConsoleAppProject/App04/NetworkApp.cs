using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

//        public bool LikePosts { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("    Abdulla's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Remove Post",
                "Display All Posts", "Display by Author",
                "Display by Date", "Add Comment", 
                "Like Posts", "Quit"
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
                    case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }

            } while (!wantToQuit);
        }


        private void PostMessage()
        {
            string author = InputString("Please enter your name > ");
            string message = InputString("Please enter your messager > ");

            MessagePost messagePost = new MessagePost(author,message);
            news.AddMessagePost(messagePost);
        }

        private void LikePosts()
        {
            throw new NotImplementedException();
        }

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

            string author = InputString("Please enter your name > ");
            string filename = InputString(" Please enter your image filename > ");
            string caption = InputString(" Please enter yout image caption > ");

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image:");
            post.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string InputString(string prompt)
        {
            Console.Write(prompt);
            string text = Console.ReadLine();

            return text;
        }
    }
}
