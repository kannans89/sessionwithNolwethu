using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    internal class Rectangle
    {
        private int height;
        private int width;
    


        public int GetHeight()
        {
            return height;
        }

        public void SetHeight(int pheight)
        {
            if (pheight >= 1 && pheight <= 100)
            {
                height = pheight;
            }
            else {
                Console.WriteLine($"Not {pheight} a valid height");
            }


        }

        public int GetWidth() { 
          return width;
        }

        public void SetWidth(int pwidth)
        {
            if (pwidth >= 1 && pwidth <= 100)
            {
                width = pwidth;
            }
            else {
                Console.WriteLine($"Not {pwidth} a valid width");
            }
        }


        public int CalcuateArea()
        {
            return width * height;
        }
    }
}
