using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class VideoPost:Post
    {
        public string VideoLink { get; set; }
        public float VideoLength { get; set; }
        public VideoPost(string title, string username,string videolink,float videolength,bool isProtected)
        {
            this.Id = GenerateId();
            this.Title = title;
            this.UserName = username;
            this.VideoLink = videolink;
            this.VideoLength = videolength;
        }
        public override string ToString()
        {
            return string.Format("{0} - Title : {1} , Name : {2} , Video link: {3} , Video length : {4} minutes", Id, Title, UserName, VideoLink,VideoLength);
        }
    }
}
