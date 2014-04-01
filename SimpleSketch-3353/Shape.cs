using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSketch_3353
{
    public abstract class Shape
    {
        public Point startPoints = new Point();
        public Point endPoints = new Point();
        public Form1 view;
        abstract public void Draw(Point x, Point y);
        abstract public void Redraw();
    }
}
