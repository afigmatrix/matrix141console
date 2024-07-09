using System;
using System.Drawing;
using System.Xml.Linq;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialNetwork network = new SocialNetwork();
            network.Email = "bashirov@yahoo.com";
            network.IsActive = true;
            network.Password = "password";


            Instagram instagram = new Instagram();
            instagram.Images = "emin0505";
            Console.WriteLine(instagram.Images);

            Facebook test = new Facebook("Post");
            test.Comment = "sagol";
            Console.WriteLine(test.Comment);
           



        }
    }
    // İnstagram adında class olacaq və İnstagram bir SoialNetworkdür.
    //İnstagramın özünə xas olan İmages (string) sında bir proerty olacaq
    //İmages properysinə dəyər set edərkən mütləq dəyərin uzunluğu 7-dən böyük olmalıdır.
    //Əks halda isə null dəyər set edin.(Encapsulation yazın)
    public class SocialNetwork
    {
        string email;
        string password;
        bool isActive;

        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

    }
    public class Instagram : SocialNetwork
    {
        private string _images;
        public string Images
        {
            get
            {
                return _images;
            }

            set
            {
                if (value.Length > 7)
                {
                    _images = value;
                }
                else
                {
                    _images = null;
                }
            }
        }
    }
    //Facebook adında bir class olacaq və Facebook-da bir SocialNetworkdür.
    //Faceookda isə Post və Comment(string 2-sidə) adında 2 propery olacaq.
    //Yeni facebook yaradilan zaman mütləq Post verilmədilir.Commentə isə sonradan dəyər set olna bilər.
    //Lakin Comment- ə dəyər set olunnubsa 2 ci dəfə gəlib həmmin commenti dəyişmək mümkün olmamalıdır.
    public class Facebook : SocialNetwork
    {
        private string _post;
        private string _comment;


        public string Post
        {
            get { return _post; }
            set { _post = value; }
        }

        public string Comment { get { return _comment; } set { _comment = "Xosh geldin"; } }

        public Facebook(string post)
        {
            this._post = post;
        }


    


        
    }
    }

