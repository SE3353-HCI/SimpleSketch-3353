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
        private Point currentLineStart;

        public Polygon (Point s, Point e)
        {
            lines = new List<Line>();
            view = (Form1)Form1.ActiveForm;
            penColor = view.p.Color;
            startPoints = (s);
            currentLineStart = s;
            endPoints = s;
        }

        public override void Draw(Point s, Point e)
        {
            view.getPanel2().Refresh();

            for (int i = lines.Count - 1; i >= 0; i--)
            {
                view.g.DrawLine(view.p, lines.ElementAt(i).startPoints, lines.ElementAt(i).endPoints);
            }
            view.g.DrawLine(view.p, currentLineStart, e);
        }

        public override void Redraw()
        {
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                view.g.DrawLine(view.p, lines.ElementAt(i).startPoints, lines.ElementAt(i).endPoints);
            }
        }

        private Point[] getBox()
        {
            Point[] box = new Point[2];
            box[0] = startPoints;
            box[1] = startPoints;
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                box[0].X = Math.Min(box[0].X, lines.ElementAt(i).startPoints.X);
                box[0].Y = Math.Min(box[0].Y, lines.ElementAt(i).startPoints.Y);
                box[0].X = Math.Min(box[0].X, lines.ElementAt(i).endPoints.X);
                box[0].Y = Math.Min(box[0].Y, lines.ElementAt(i).endPoints.Y);

                box[1].X = Math.Max(box[1].X, lines.ElementAt(i).startPoints.X);
                box[1].Y = Math.Max(box[1].Y, lines.ElementAt(i).startPoints.Y);
                box[1].X = Math.Max(box[1].X, lines.ElementAt(i).endPoints.X);
                box[1].Y = Math.Max(box[1].Y, lines.ElementAt(i).endPoints.Y);
            }
            return box;
        }

        public override bool isWithin(Point p)
        {
            Point[] box = getBox();
            if (p.X < box[0].X || p.Y < box[0].Y || p.X > box[1].X || p.Y > box[1].Y)
            {
                return false;
            }
            else
                return true;
        }

        public void addFinishedLine(Point e)
        {
            Line l = new Line(currentLineStart, e);
            lines.Add(l);
            currentLineStart = e;
        }

        public void finishPolygon()
        {
            Line l = new Line(currentLineStart, startPoints);
            lines.Add(l);
        }

        public void movePolygon(int xDiff, int yDiff)
        {
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                lines.ElementAt(i).startPoints.X -= xDiff;
                lines.ElementAt(i).startPoints.Y -= yDiff;

                lines.ElementAt(i).endPoints.X -= xDiff;
                lines.ElementAt(i).endPoints.Y -= yDiff;
            }
        }
    }
}
