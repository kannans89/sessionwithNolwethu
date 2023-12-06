using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangelAbstractionApp.Model
{
    internal class Rectangle
    {
        public int height;
        public int width;
        public string color;


        public int CalcuateArea() {
            return width * height;
        }
    }
}
