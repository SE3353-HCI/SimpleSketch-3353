using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSketch_3353
{
    public class Freehand : Shape
    {
        public List<Point> stroke;
        PaintEventArgs paintEvent;
        public Freehand()
         { 
             view = (Form1)Form1.ActiveForm;
             penColor = view.p.Color;
             stroke = new List<Point>();
             paintEvent = new PaintEventArgs(view.g, view.getPanel2().DisplayRectangle);
         }
         public override void Draw(Point s, Point e)
         {
            paintEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            stroke.Add(e);
            Point[] pArray = stroke.ToArray();
            paintEvent.Graphics.DrawLines(view.p, pArray);
            view.Refresh();
         }
         public override void Redraw()
         {
            paintEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            paintEvent.Graphics.DrawLines(view.p, stroke.ToArray());
         }
         public override bool isWithin(Point x)
         {
             return true;
         }
    }
}
