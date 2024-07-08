using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class SocialNetwork
        {
            public string Email;
            private string Password;
            public bool IsActive;
        }
        public class Instagram : SocialNetwork
        {
            private string Images;
            public string PropImages
            {
                get { return Images; }
                set
                {
                    if (Images.Length >= 7)
                    {
                        Images = value;
                    }
                    else
                    {
                        Images = null;
                    }
                }
            }
        }
        public class Facebook : SocialNetwork
        {
            public string Post;
            public string Comment;
            public string Propcommnet
            {
                get { return Comment; }
                set
                {
                    if (true)
                    {
                        Comment = value;
                    }
                    else
                    {
                        Console.WriteLine("Comment can only be set once");
                    }
                }
            }
            public Facebook(string post)
            {
                Post = post;
            }
        }
    }
}
