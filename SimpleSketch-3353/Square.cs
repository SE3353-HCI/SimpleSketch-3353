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
            Rectangle r = new Rectangle(Math.Min(e.X, view.xCoord), Math.Min(e.X, view.xCoord), Math.Abs(e.X - view.xCoord), Math.Abs(e.X - view.xCoord));
            view.g = view.getPanel2().CreateGraphics();
            view.g.DrawRectangle(view.p, r);
            endPoints = e;
        }
        public override void Redraw()
        {
            //Rectangle r = new Rectangle(Math.Min(e.X, view.xCoord), Math.Min(e.X, view.xCoord), Math.Abs(e.X - view.xCoord), Math.Abs(e.X - view.xCoord));
            //view.g = view.getPanel2().CreateGraphics();
            //view.g.DrawRectangle(view.p, r);
        }
    }
}
