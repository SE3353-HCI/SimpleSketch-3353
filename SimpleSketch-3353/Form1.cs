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
        public Graphics g;
        public int xCoord=0, yCoord = 0;
        public List<List<Point>> ListOfStrokes = new List<List<Point>>();
        List<Rectangle> RectangleList = new List<Rectangle>();
        List<Point> startEllPoints = new List<Point>();
        List<Point> endEllPoints = new List<Point>();
        List<Point> startLinePoints = new List<Point>();
        List<Point> endLinePoints = new List<Point>();
        List<Shape> shapeList= new List<Shape>();
        List<Color> lineColors = new List<Color>();

        Rectangle r, EllipseCoords2;
        public Pen p = new Pen(Color.Black, 1);
        bool isDrawing;
        bool isSelecting = false;
        bool isMoving = false;
        bool cursorMode = false;
        bool shapeMode = true;
        int currentShapePosition = 0;

        public Point start, end;
        public Shape currentShape;
        public String selectedShape="freeHand";


        public Form1()
        {
            InitializeComponent();
            g = panel2.CreateGraphics();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if(selectedShape.Equals("freeHand"))
            {
                foreach (List<Point> stroke in ListOfStrokes)
                    e.Graphics.DrawLines(p, stroke.ToArray());
            }*/


        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentShape.Draw(start, e.Location);
                repaint(); 
            }
            if (isSelecting && isMoving)
            {
                int xDiff = start.X - e.X;
                int yDiff = start.Y - e.Y;
                shapeList.ElementAt<Shape>(currentShapePosition).startPoints.X -= xDiff;
                shapeList.ElementAt<Shape>(currentShapePosition).startPoints.Y -= yDiff;
                shapeList.ElementAt<Shape>(currentShapePosition).endPoints.X -= xDiff;
                shapeList.ElementAt<Shape>(currentShapePosition).endPoints.Y -= yDiff;
                start = new Point(e.X, e.Y);
                currentShape = shapeList.ElementAt<Shape>(currentShapePosition);
                panel2.Refresh();
                repaint();
            }   
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (shapeMode)
            {
                isDrawing = true;
                start = new Point(e.X, e.Y);
                if(selectedShape.Equals("freeHand"))
                {
                    /*currentStroke = new List<Point>();
                    currentStroke.Add(e.Location);
                    ListOfStrokes.Add(currentStroke);*/
                    currentShape = new Freehand();
                    currentShape.penColor = p.Color;
                }

                if(selectedShape.Equals("Rectangle"))
                {
                    xCoord = e.X;
                    yCoord = e.Y;
                    currentShape = new MyRectangle(start, e.Location);
                    currentShape.penColor = p.Color;
                }

               if(selectedShape.Equals("Ellipse"))
                {
                    start = new Point(e.X, e.Y);
                    currentShape = new Ellipse(start, e.Location);
                    currentShape.penColor = p.Color;
                }

                if (selectedShape.Equals("Circle"))
                {
                   start = new Point(e.X, e.Y);
                   currentShape = new Circle(start, e.Location);
                   currentShape.penColor = p.Color;
               }

                if (selectedShape.Equals("Square"))
                {
                    xCoord = e.X;
                    yCoord = e.Y;
                    currentShape = new Square(start, e.Location);
                    currentShape.penColor = p.Color;
                }

                if(selectedShape.Equals("StraightLine"))
                {
                    start = new Point(e.X, e.Y);
                    currentShape = new Line(start, e.Location);
                    currentShape.penColor = p.Color;
                }

                if(selectedShape.Equals("Cursor"))
                {
                    xCoord = e.X;
                    yCoord = e.Y;
                }
            }
            if (cursorMode)
            {
                isSelecting = true;
                for (int i = shapeList.Count-1; i>=0; i--)
                {
                    if (shapeList.ElementAt<Shape>(i).isWithin(e.Location))
                    {
                        isMoving = true;
                        start = new Point(e.X, e.Y);
                        currentShapePosition = i;
                        break;
                    }
                }
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (shapeMode)
            {
                isDrawing = false;
                shapeList.Add(currentShape);
                repaint();
            }
            if (cursorMode)
            {
                isSelecting = false;
                isMoving = false;
                currentShapePosition = 1;
                repaint();
            }
        }

        private void freeHand_Click(object sender, EventArgs e)
        {
            selectedShape = "freeHand";
            cursorMode = false;
            shapeMode = true;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            selectedShape = "Rectangle";
            cursorMode = false;
            shapeMode = true;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            selectedShape = "Ellipse";
            cursorMode = false;
            shapeMode = true;
        }

        private void line_Click(object sender, EventArgs e)
        {
            selectedShape = "StraightLine";
            cursorMode = false;
            shapeMode = true;
        }

        private void CursorButton_Click(object sender, EventArgs e)
        {
            selectedShape = "Cursor";
            cursorMode = true;
            shapeMode = false;
        }

        private void square_Click(object sender, EventArgs e)
        {
            selectedShape = "Square";
            cursorMode = false;
            shapeMode = true;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            selectedShape = "Circle";
            cursorMode = false;
            shapeMode = true;
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
            for (int i = 0; i < shapeList.Count; i++)
            {
                g = panel2.CreateGraphics();
                //shapeList.ElementAt<Shape>(i).Draw(shapeList.ElementAt<Shape>(i).startPoints, shapeList.ElementAt<Shape>(i).endPoints);
                p.Color = shapeList.ElementAt<Shape>(i).penColor;
                shapeList.ElementAt<Shape>(i).Redraw();
            }
            p.Color = currentShape.penColor;

            /*for (int i = 0; i < RectangleList.Count; i++)
            {
                Rectangle rect = RectangleList.ElementAt<Rectangle>(i);
                g = panel2.CreateGraphics();
                g.DrawRectangle(p, rect);
            }*/

            /*for(int j=0; j<startEllPoints.Count; j++)
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

            foreach (List<Point> stroke in ListOfStrokes)
                e.Graphics.DrawLines(p, stroke.ToArray());*/
        }
        public Panel getPanel2() {
            return panel2;
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cursorMode && shapeList.Count>0 && e.Button == MouseButtons.Left)
            {
                for (int i = shapeList.Count - 1; i >= 0; i--)
                {
                    if (shapeList.ElementAt<Shape>(i).isWithin(e.Location))
                    {
                        isMoving = true;
                        start = new Point(e.X, e.Y);
                        currentShapePosition = i;
                        currentShape = shapeList.ElementAt<Shape>(currentShapePosition);
                        shapeList.RemoveAt(currentShapePosition);
                        break;
                    }
                } 
            }
            if (cursorMode && e.Button == MouseButtons.Right)
            {
                currentShape.endPoints = new Point(e.Location.X + Math.Abs(currentShape.startPoints.X - currentShape.endPoints.X), e.Location.Y + Math.Abs(currentShape.startPoints.Y - currentShape.endPoints.Y));
                currentShape.startPoints = e.Location;
                shapeList.Add(currentShape);
            }
        panel2.Refresh(); 
        repaint();
        }
        
    }
}
