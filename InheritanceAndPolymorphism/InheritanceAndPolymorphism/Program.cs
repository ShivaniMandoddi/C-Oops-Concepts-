using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Inheritance allows to define a class interms of other class which makes easier to create and maintain a application
             * This also provides an opportunity to reuse the code functionality.
             * Monobehaviour class in unity is the best example.
             *
             */
            Post post = new Post("First Post","Shivani",true);
            ImagePost image = new ImagePost("Unity", "Shivani", "image.jpg", true);
            VideoPost video = new VideoPost("PurpleTalk", "Seeta", "purpletalk.mp4", 14.30f, true);
            Console.WriteLine(post.ToString());
            Console.WriteLine(image.ToString());
            Console.WriteLine(video.ToString());
            
            Console.ReadLine();
        }
    }
}
