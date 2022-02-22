using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductonToOops
{
    class BoxClass
    {
        private int length; //Length of a box
        private int height; //Height of a box
        private int width; //Width of a box
        private int volume;//Volume of a box


        public int Length { get { return length; } set { length = value; } }
        public int Height { get => height; set => height = value; }
       // public int Height { get { return height; } set { height = value; } }
        public int Width { get { return width; } set { width = value; } }

        public int Volume { get { return (volume); } set { volume =length*height*width ; } }


        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }
        public BoxClass()
        {
            volume = length * height * width;
        }
        public BoxClass(int length,int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
           volume = length * height * width;
        }
        public void Display()
        {
            Console.WriteLine("Length {0}, Height {1}, Width {2} and Volume of a Box {3} ",length,height,width,volume);
        }
    }
}
