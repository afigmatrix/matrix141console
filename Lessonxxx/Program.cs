using System;

namespace Lessonxxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Instagram ınstagram = new Instagram();



        }
        public class SocialNetwork
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public bool IsActive { get; set; }
        }
        public class Instagram : SocialNetwork
        {
            private string _Images;
            public string Images
            {
                get
                {
                    return _Images;
                }
                set
                {
                    if (value.Length > 7)
                    {
                        _Images = value;
                    }
                    else
                    {
                        _Images = null;
                    }

                }
            }
            #endregion



            #region
            public class Fcaebook : SocialNetwork
            {
                private string _post;
                private string _comment;
                private bool _commentSet;
                public string post
                {
                    get
                    {
                        return _post;

                    }


                    set
                    {
                        if (!_commentSet)
                        {
                            _comment = value;
                            _commentSet = true;
                        }
                    }
                }
                #endregion
            }
        }
    }
}
    
