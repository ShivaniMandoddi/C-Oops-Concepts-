using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Post
    {
        private static int currentPostId;
        // Properties 
        protected int Id { get; set; }
        protected string UserName { get; set; }
        protected string Title { get; set; }
        protected bool IsProtected { get; set; }

       
        public Post()
        {
            Id = 123;
            UserName = "Shivani";
            Title = "My Post";
            IsProtected = true;

        }
        public Post(string title, string userName, bool isProtected) // Instance Constructor that has three parameters
        {
            this.Id = GenerateId();
            this.Title = title;
            this.UserName = userName;
            this.IsProtected = isProtected;
        }
        protected int GenerateId()
        {
            return ++currentPostId;
        }
        protected void UpdatePost(string title,bool isProtected)
        {
            this.Title = title;
            this.IsProtected = isProtected;
        }
        public override string ToString()
        {
            return string.Format("{0} - Title : {1} , Name : {2}",Id,Title,UserName);
        }

    }
}
