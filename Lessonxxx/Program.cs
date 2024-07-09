using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Instagram

            Instagram instagram = new Instagram();

            instagram.Email = "musayevuqar@mail.ru";
            instagram.Password = "vuqar0105";
            instagram.İsActive = true;
            instagram.SetImage(instagram.Password);

            Console.WriteLine(instagram.GetImage());


            //  Facebook

            Facebook facebook = new Facebook("MyPost");


            facebook.Email = "musayevuqar@mail.ru";
            facebook.Password = "vuqar0105";
            facebook.İsActive = true;
            facebook.GetComment(facebook.Email);

            Console.WriteLine(facebook.Password);
        }

        public class SocialNetwork
        {
            public string Email;
            public string Password;
            public bool İsActive;
        }

        public class Instagram : SocialNetwork
        {
            private string _image;

            public string GetImage()
            {
                return _image;
            }
            public void SetImage(string image)
            {
                if (Password.Length > 7)
                {
                    _image = image;
                }
                else
                {
                    Console.WriteLine(default(string));
                }
            }
        }

        public class Facebook : SocialNetwork
        {
            private string Post;
            private string Comment;

            public Facebook(string post)
            {
                Post = post;
            }

            public string GetComment(String comment)
            {
                return comment;
            }



        }

    }
}

