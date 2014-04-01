using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSketch_3353
{
    public class Line : Shape
    {
        public Line(Point s, Point e)
        {
            view = (Form1) Form1.ActiveForm;
            penColor = view.p.Color;
            startPoints = (s);
            endPoints = e;
        }
        public override void Draw(Point s, Point e)
        {
            view.getPanel2().Refresh();
            view.g.DrawLine(view.p, s, e);
            endPoints = new Point(e.X, e.Y);
            //lineColors.Add(p.Color);
            view.g.DrawLine(view.p, s, endPoints);
        }
        public override void Redraw()
        {
            view.g.DrawLine(view.p, startPoints, endPoints);
        }

        public override bool isWithin(Point x)
        {
            //List<Point> inLine = new List<Point>();
            Point currentPoint = new Point();
            double slope = (Double)(startPoints.Y - endPoints.Y)/(startPoints.X-endPoints.X);
            //inLine.Add(startPoints);
            currentPoint = startPoints; 
            for (int xx = startPoints.X, y = startPoints.Y; y <= endPoints.Y; y++)
            {
                //currentPoint = new Point(xx, y);
                //if (x.X == currentPoint.X && x.Y == currentPoint.Y)
                //    return true;
                //   
                //xx += (int)slope;
            }
            return false;
        }
    }
}
