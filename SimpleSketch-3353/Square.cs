using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSketch_3353
{
    public class Square : MyRectangle
    {
        public Square (Point s, Point e):base(s,e)
        {}
        public override void Draw(Point s, Point e)
        {
            //endPoints.RemoveAt(endPoints.Count-1);
            
            view.getPanel2().Refresh();
            int width = e.X - view.xCoord, height = e.Y - view.yCoord;
            Rectangle r = new Rectangle(Math.Min(e.X, view.xCoord), Math.Min(e.Y, view.yCoord), Math.Abs(e.X - view.xCoord), Math.Abs(e.X - view.xCoord));
            startPoints = new Point(view.xCoord, view.yCoord);
            view.g = view.getPanel2().CreateGraphics();
            view.g.DrawRectangle(view.p, r);
            endPoints = e;
        }
        public override void Redraw()
        {
            Rectangle r = new Rectangle(Math.Min(endPoints.X, startPoints.X), Math.Min(endPoints.Y, startPoints.Y), Math.Abs(endPoints.X - startPoints.X), Math.Abs(endPoints.X - startPoints.X));
            view.g = view.getPanel2().CreateGraphics();
            view.g.DrawRectangle(view.p, r);
        }
        public override bool isWithin(Point x)
        {
            if ((Math.Min(startPoints.X,endPoints.X) < x.X) && ((Math.Max(startPoints.X,endPoints.X) > x.X) && ((Math.Min(startPoints.Y,endPoints.Y) < x.Y)) && ((Math.Max(startPoints.Y,endPoints.Y) > x.Y))))
                return true;
            else
                return false;
        }
    }
}
