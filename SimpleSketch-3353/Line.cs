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
            startPoints = (s);
            endPoints = e;
            view = (Form1) Form1.ActiveForm;
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
    }
}
