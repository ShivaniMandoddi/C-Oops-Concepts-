using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class ImagePost: Post // Inherit from base class to Deriving class
    {
        public string ImageLink { get; set; }

        public ImagePost()
        {

        }
        public ImagePost(string title,string username,string image,bool isProtected)
        {
            // All properties are from Post Class except Imagelink property is from ImagePost class.
            this.Id = GenerateId();
            this.Title = title;
            this.UserName = username;
            this.ImageLink = image;
            this.IsProtected = isProtected;

        }
        public override string ToString()
        {
            return string.Format("{0} - Title : {1}, Name : {2} , Image link : {3}", Id, Title, UserName, ImageLink);
        }
    }
}
