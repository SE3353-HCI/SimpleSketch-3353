using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSketch_3353
{
    public class Circle : Ellipse
    {
        public Circle(Point s, Point e): base(s,e)
        { }

        public override void Draw (Point s, Point e)
        {
            //endPoints.RemoveAt(endPoints.Count-1);
            
            view.getPanel2().Refresh();
            int length = Math.Abs(s.X - e.X);
            Rectangle EllipseCoords = new Rectangle(s.X, s.Y, e.X - s.X, e.X - s.X);
            view.g.DrawEllipse(view.p, EllipseCoords);
            Point endPoints = new Point(e.X, e.Y);
            Rectangle EllipseCoords2 = new Rectangle(s.X, s.Y, endPoints.X - s.X, endPoints.X - s.X);
            view.g.DrawEllipse(view.p, EllipseCoords2);
        }
    }
}
