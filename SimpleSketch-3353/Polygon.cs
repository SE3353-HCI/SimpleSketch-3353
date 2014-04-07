using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSketch_3353
{
    public class Polygon : Shape
    {
        public List<Line> lines;

        public Polygon (Point s, Point e)
        {
            lines = new List<Line>();
            view = (Form1)Form1.ActiveForm;
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

        public override bool isWithin(Point p)
        {
            return false;
        }

        public void addFinishedLine(Point s, Point e)
        {
            Line l = new Line(s, endPoints);
            lines.Add(l);
        }

        public override bool isWithin(Point x)
        {
            return false;
        }
    }
}
