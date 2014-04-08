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
        List<Point> startEllPoints = new List<Point>();
        List<Point> endEllPoints = new List<Point>();
        List<Point> startLinePoints = new List<Point>();
        List<Point> endLinePoints = new List<Point>();
        List<Shape> shapeList= new List<Shape>();
        List<Color> lineColors = new List<Color>();
        
        List<Freehand> freehandList = new List<Freehand>();

        public Pen p = new Pen(Color.Black, 1);
        bool lineDrawn=false;
        bool isDrawing = false;
        bool isMoving = false;
        bool cursorMode = false;
        bool shapeMode = true;
        bool freeHandMode = false;
        int currentShapePosition = 0;
        public int polyEndX, polyEndY;

        public Point start, end;
        public Shape currentShape;
        public String selectedShape="freeHand";
        public PaintEventArgs paintEvent;


        public Form1()
        {
            InitializeComponent();
            g = panel2.CreateGraphics();
            p.Color = Color.Black;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentShape.Draw(start, e.Location);
                repaint(); 
            }

            if (isDrawing && selectedShape.Equals("freeHand"))
            {
                currentShape.Draw(start, e.Location);
                Freehand fHand = (Freehand)currentShape;
                g.DrawLines(p, fHand.getPointList());
                repaint();
            }

            if (isMoving)
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
                if (selectedShape.Equals("freeHand"))
                {
                    currentShape = new Freehand();
                    currentShape.penColor = p.Color;
                    freeHandMode = true;
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
                if (lineDrawn)
                {
                    Point Start = new Point(polyEndX, polyEndY);
                    currentShape.Draw(Start, e.Location);
                }
                if (selectedShape.Equals("Polygon") && lineDrawn == false)
                {
                    start = new Point(e.X, e.Y);
                    currentShape = new Polygon(start, e.Location);
                    currentShape.penColor = p.Color;
                    lineDrawn = true;
                }
            }
            
            else if (cursorMode)
            {
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
            isDrawing = false;

            if(lineDrawn)
            {
                Polygon p = (Polygon)currentShape;
                p.addFinishedLine(start, e.Location);
                polyEndX = e.Location.X;
                polyEndY = e.Location.Y;
                currentShape = p;
            }
            if (freeHandMode)
            {
                freehandList.Add((Freehand)currentShape);
                freeHandMode = false;
            }
            else if (shapeMode)
                shapeList.Add(currentShape);
            isMoving = false;
            currentShapePosition = 1;
            repaint();
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

        private void polygon_Click(object sender, EventArgs e)
        {
            selectedShape = "Polygon";
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
                p.Color = shapeList.ElementAt<Shape>(i).penColor;
                shapeList.ElementAt<Shape>(i).Redraw();
            }

            foreach (Freehand fhand in freehandList)
            {
                p.Color = fhand.penColor;
                g.DrawLines(p, fhand.getPointList());
            }
            
            p.Color = currentShape.penColor;
        }

        public void drawFreeHand(Freehand fhand)
        {
            
        }

        public Panel getPanel2() {
            return panel2;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (lineDrawn && e.Button==MouseButtons.Left)
            {
                Polygon p = (Polygon)currentShape;
                p.addFinishedLine(start, e.Location);
                currentShape = p;
            }
            if (lineDrawn && e.Button == MouseButtons.Right)
            {
                Polygon p = (Polygon)currentShape;
                p.addFinishedLine(start, e.Location);
                currentShape = p;
                lineDrawn = false;
            }
        }
        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cursorMode && shapeList.Count > 0 && e.Button == MouseButtons.Left)
            {
                for (int i = (shapeList.Count-1); i >= 0; i--)
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

        private void Clear_Click(object sender, EventArgs e)
        {
            for (int i = shapeList.Count-1; i >=0; i--)
            {
                shapeList.RemoveAt(i);
            }
            repaint();
            panel2.Refresh();
            /*for (int i = 0; i < shapeList.Count; i++)
            {
                g = panel2.CreateGraphics();
                p.Color = shapeList.ElementAt<Shape>(i).penColor;
                shapeList.ElementAt<Shape>(i).Redraw();
            }*/
        }
        
    }
}
