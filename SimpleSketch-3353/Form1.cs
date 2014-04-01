using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SimpleSketch_3353
{
    public partial class Form1 : Form
    {
        private Graphics g;
        int xCoord=0, yCoord = 0;
        List<List<Point>> ListOfStrokes = new List<List<Point>>();
        List<Point> currentStroke;
        
        List<Rectangle> RectangleList = new List<Rectangle>();

        List<Point> startEllPoints = new List<Point>();
        List<Point> endEllPoints = new List<Point>();

        List<Point> startLinePoints = new List<Point>();
        List<Point> endLinePoints = new List<Point>();

        List<Color> lineColors = new List<Color>();

        Rectangle r, EllipseCoords2;
        Pen p = new Pen(Color.Black, 1);
        bool isDrawing;

        public Point start, end;
        public String Shape="freeHand";

        public Form1()
        {
            InitializeComponent();
            g = panel2.CreateGraphics();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if(Shape.Equals("freeHand"))
            {
                foreach (List<Point> stroke in ListOfStrokes)
                    e.Graphics.DrawLines(p, stroke.ToArray());
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && Shape.Equals("freeHand"))
            {
                currentStroke.Add(e.Location);
                Refresh();
            }

            if (isDrawing && Shape.Equals("Rectangle"))
            {
                panel2.Refresh();
                int width = e.X - xCoord, height = e.Y - yCoord;
                r = new Rectangle(Math.Min(e.X, xCoord),Math.Min(e.Y, yCoord),Math.Abs(e.X - xCoord),Math.Abs(e.Y - yCoord));
                g = panel2.CreateGraphics();
                g.DrawRectangle(p, r);
            }

            if (isDrawing && Shape.Equals("Ellipse"))
            {
                panel2.Refresh();
                Rectangle EllipseCoords = new Rectangle(start.X, start.Y, end.X-start.X, end.Y-start.Y);
                g.DrawEllipse(p, EllipseCoords);
                end = new Point(e.X, e.Y);

                EllipseCoords2 = new Rectangle(start.X, start.Y, end.X - start.X, end.Y - start.Y);
                g.DrawEllipse(p, EllipseCoords2);
            }

            if (isDrawing && Shape.Equals("StraightLine"))
            {
                panel2.Refresh();
                g.DrawLine(p, start,end);
                end = new Point(e.X, e.Y);
                lineColors.Add(p.Color);
                g.DrawLine(p, start, end);
            }

            if(isDrawing && Shape.Equals("Cursor"))
            {
                
            }
            repaint();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            if(Shape.Equals("freeHand"))
            {
                currentStroke = new List<Point>();
                currentStroke.Add(e.Location);
                ListOfStrokes.Add(currentStroke);
            }

            if(Shape.Equals("Rectangle"))
            {
                xCoord = e.X;
                yCoord = e.Y;
            }

            if(Shape.Equals("Ellipse"))
            {
                start = new Point(e.X, e.Y);
            }

            if(Shape.Equals("StraightLine"))
            {
                start = new Point(e.X, e.Y);
            }

            if(Shape.Equals("Cursor"))
            {
                xCoord = e.X;
                yCoord = e.Y;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            RectangleList.Add(r);

            if(Shape.Equals("Ellipse"))
            {
                startEllPoints.Add(start);
                endEllPoints.Add(end);
            }

            if (Shape.Equals("StraightLine"))
            {
                startLinePoints.Add(start);
                endLinePoints.Add(end);
            }
        }

        private void freeHand_Click(object sender, EventArgs e)
        {
            Shape = "freeHand";
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            Shape = "Rectangle";
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            Shape = "Ellipse";
        }

        private void line_Click(object sender, EventArgs e)
        {
            Shape = "StraightLine";
        }

        private void CursorButton_Click(object sender, EventArgs e)
        {
            Shape = "Cursor";
        }

        private void RedColor_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void GreenColor_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void BlueColor_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void PurpleColor_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void BlackColor_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void YellowColor_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void repaint()
        {
            for (int i = 0; i < RectangleList.Count; i++)
            {
                Rectangle rect = RectangleList.ElementAt<Rectangle>(i);
                g = panel2.CreateGraphics();
                g.DrawRectangle(p, rect);
            }

            for(int j=0; j<startEllPoints.Count; j++)
            {
                Point s = new Point(startEllPoints.ElementAt<Point>(j).X, startEllPoints.ElementAt<Point>(j).Y);
                Point e = new Point(endEllPoints.ElementAt<Point>(j).X, endEllPoints.ElementAt<Point>(j).Y);
                EllipseCoords2 = new Rectangle(s.X,s.Y, e.X - s.X, e.Y - s.Y);
                g.DrawEllipse(p, EllipseCoords2);
            }

            for (int k = 0; k < startLinePoints.Count; k++)
            {
                Point s = new Point(startLinePoints.ElementAt<Point>(k).X, startLinePoints.ElementAt<Point>(k).Y);
                Point e = new Point(endLinePoints.ElementAt<Point>(k).X, endLinePoints.ElementAt<Point>(k).Y);
                p.Color = lineColors.ElementAt<Color>(k);
                g.DrawLine(p, s, e);
            }

            /*foreach (List<Point> stroke in ListOfStrokes)
                e.Graphics.DrawLines(p, stroke.ToArray());*/
        }
    }
}
