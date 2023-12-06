using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePropertiesApp.Model
{
    internal class Rectangle
    {
        private int height;
        private int width;


        public int Height
        {
            get
            {
                return height;
            }
            set
            {

                if (value >= 1 && value <= 100)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine($"Not {value} a valid height");
                }
            }
        }


        public int Widht
        {
            get
            {
                return width;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine($"Not {value} a valid width");
                }
            }

        }


        public int CalcuateArea()
        {
            return width * height;
        }
    }
}
