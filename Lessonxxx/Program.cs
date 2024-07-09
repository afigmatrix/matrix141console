using System;

namespace Lessonxxx
{
    internal class Program
    {
        //Task 1
        #region
        static void Main(string[] args)
        {
            SocialNetwork socialNetwork = new SocialNetwork();
            socialNetwork.Email = "teymur.akhmadov@gmail.com";
            socialNetwork.Password = "password";
            socialNetwork.IsActivate = true;

            //Task Instagram

            Instagram instagram = new Instagram();
            instagram.Image = "Teymur";

            if (instagram.Image == null)
            {
                //Console.WriteLine("Dogru deyer elave edin !!!");
            }




            //Task Facebook

            Facebook facebook = new Facebook("Post");
            facebook.Comment = "Yes";


            if (facebook.Comment == "Yes")
            {
                Console.WriteLine("Set");
            }
        }

        public class SocialNetwork
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public bool IsActivate { get; set; }
        }

        public class Instagram
        {
            private string _image;
            public string Image
            {

                get
                {
                    return _image;
                }

                set
                {
                    if (value.Length > 7)
                    {
                        _image = value;
                    }
                    else
                    {
                        _image = null;
                    }

                }

            }

        }

        public class Facebook : SocialNetwork
        {
            public string Post { get; set; }
            public Facebook(string post)
            {
                Post = post;
            }

            private string _comment;
            public string Comment 
            {
                get 
                {
                    return _comment;
                
                }

                set
                {
                    if(string.IsNullOrEmpty(Comment)) 
                    {
                        _comment = value;
                    }
                    //_comment = value;
                }
            
            
            }


        }
        #endregion

        //Task 2

      

      


    }
}
