using System;
using System.Reflection.Emit;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class SocialNetwork
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
    public class Instagram : SocialNetwork
    {
        private string _images;
        public string Get()
        {
            return _images;
        }
        public void Set(string image)
        {
            if (_images.Length > 7)
            {
                _images = image;
            }
            else
            {
                _images = null;
            }
        }
    }
    public class Facebook
    {
        public string Post { get; set; }
        public string Comment { get; set; }
    }
}

