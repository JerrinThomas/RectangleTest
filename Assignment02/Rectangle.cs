using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Rectangle Class
 * Jerrin Thomas
 * 8770668
 * 
 */
namespace Assignment02
{
    public class Rectangle
    {
        private int length;
        private int width;


        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int GetLength()
        {
            // Check if the length is not less than 1.
            if (this.length <= 0)
            {
                throw new Exception("Not a valid length");
            }
            return this.length;
        }

        public int SetLength(int length)
        {
            // Check if the length is not less than 1.
            if (length <= 0)
            {
                throw new Exception("Not a valid length");
            }
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            // Check if the width is not less than 1.
            if (width <= 0)
            {
                throw new Exception("Not a valid width");
            }
            return this.width;
        }

        public int SetWidth(int width)
        {
            // Check if the width is not less than 1.
            if (width <= 0)
            {
                throw new Exception("Not a valid width");
            }
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            // Check if the length and width is not less than 1.
            if (length <= 0 || width <= 0)
            {
                throw new Exception("Not valid length or width.");
            }
            int perimeter = 2 * (length + width);
            return perimeter;
        }

        public int GetArea()
        {
            // Check if the length and width is not less than 1.
            if (length <= 0 || width <= 0)
            {
                throw new Exception("Not valid length or width.");
            }
            int area = length * width;
            return area;
        }

    }
}
