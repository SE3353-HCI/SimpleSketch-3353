using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSketch_3353
{
    public class Ellipse : Shape
    {
        public Ellipse(Point s, Point e)
        {
            startPoints = (s);
            endPoints = e;
            view = (Form1) Form1.ActiveForm;
        }
        public override void Draw(Point s, Point e)
        {
            view.getPanel2().Refresh();
            Rectangle EllipseCoords = new Rectangle(s.X, s.Y, e.X-s.X, e.Y-s.Y);
            view.g.DrawEllipse(view.p, EllipseCoords);
            endPoints = new Point(e.X, e.Y);
            Rectangle EllipseCoords2 = new Rectangle(s.X, s.Y, endPoints.X - s.X, endPoints.Y - s.Y);
            view.g.DrawEllipse(view.p, EllipseCoords2);
        }
        public override void Redraw()
        {
            Rectangle EllipseCoords3 = new Rectangle(startPoints.X, startPoints.Y, endPoints.X - startPoints.X, endPoints.Y - startPoints.Y);
            view.g.DrawEllipse(view.p, EllipseCoords3);
        }
    }
}
