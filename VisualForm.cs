using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator
{
    public partial class VisualForm : Form
    {
        public VisualForm()
        {
            InitializeComponent();
        }
        public List<Point> points = new List<Point>();
        public void rysujPunkty()
        {
            setFormSize();
            Drawer drawer = new Drawer(points, pictureBox.CreateGraphics());
            drawer.clearView();
            drawer.drawPoints();
        }
        public void polaczPunktyProsta()
        {
            setFormSize();
            Drawer drawer = new Drawer(points, pictureBox.CreateGraphics());
            drawer.clearView();
            drawer.connectPointsWithStraightLine();
        }
        public void polaczPunktyKrzywa()
        {
            setFormSize();
            Drawer drawer = new Drawer(points, pictureBox.CreateGraphics());
            drawer.clearView();
            drawer.connectPointsWithCurve();
        }
        public void rysujUklad()
        {
            setFormSize();
            new Drawer(points, pictureBox.CreateGraphics()).drawLayout();
        }
        private void setFormSize()
        {
            SizeHandler sizeHandler = new SizeHandler(points);
            Width = sizeHandler.setWidth() + 17;
            Height = sizeHandler.setHeight() + 40;
        }
        public class Drawer
        {
            List<Point> points;
            int width;
            int height;
            int xShift;
            int yShift;
            SizeHandler sizeHandler;
            Graphics graphics;
            public Drawer(List<Point> points,Graphics graphics)
            {
                this.points = points;
                sortPoints();
                sizeHandler = new SizeHandler(this.points);
                width = sizeHandler.setWidth();
                height = sizeHandler.setHeight();
                xShift = setWidthShift();
                yShift = setHeightShift();
                this.graphics = graphics;
            }
            private int setWidthShift()
            {
                int shift = sizeHandler.countMinX();
                if (shift < 1)
                    return Math.Abs(shift);
                return 1;
            }
            private int setHeightShift()
            {
                int shift = sizeHandler.countMinY();
                if (shift < 1)
                    return Math.Abs(shift);
                return 1;
            }
            private int countProperY(Point p)
            {
                return height-(yShift + p.Y);
            }
            private int countProperX(Point p)
            {
                return xShift + p.X;
            }
            private void sortPoints()
            {
                this.points =  this.points.OrderBy(p => p.X).ToList();
            }
            public void drawPoints()
            {
                for (int i = 0; i < points.Count(); i++)
                {
                    int x = countProperX(points[i]);
                    int y = countProperY(points[i]);
                    Point p = new Point(x, y);
                    graphics.FillRectangle(Brushes.White, p.X,p.Y,1,1);
                }
            }
            public void connectPointsWithStraightLine()
            {
                graphics.DrawLines(Pens.White, createPointF());
            }
            public void connectPointsWithCurve()
            {
                graphics.DrawCurve(Pens.White, createPointF());
            }
            private PointF[] createPointF()
            {
                PointF[] pointF = new PointF[points.Count()];
                for (int i = 0; i < points.Count(); i++)
                {
                    pointF[i] = new PointF(countProperX(points[i]), countProperY(points[i]));
                }
                return pointF;
            }
            public void clearView()
            {
                graphics.Clear(Color.Black);
            }
            public void drawLayout()
            {
                graphics.DrawLine(Pens.White, xShift, 0, xShift, height);
                graphics.DrawLine(Pens.White, 0, height-yShift, width, height-yShift);
            }

        }
        public class SizeHandler
        {
            List<Point> points;
            int minY;
            int maxY;
            int minX;
            int maxX;
            public SizeHandler(List<Point> points)
            {
                this.points = points;
                minX = countMinX();
                maxX = countMaxX();
                minY = countMinY();
                maxY = countMaxY();
            }
            public int countMinY()
            {
                int minY = points[0].Y;
                for (int i = 0; i < points.Count(); i++)
                    if (points[i].Y < minY)
                        minY = points[i].Y;
                return minY;
            }
            public int countMaxY()
            {
                int maxY = points[0].Y;
                for (int i = 0; i < points.Count(); i++)
                    if (points[i].Y > maxY)
                        maxY = points[i].Y;
                return maxY;
            }
            public int countMinX()
            {
                int minX = points[0].X;
                for (int i = 0; i < points.Count(); i++)
                    if (points[i].X < minX)
                        minX = points[i].X;
                return minX;
            }
            public int countMaxX()
            {
                int maxX = points[0].X;
                for (int i = 0; i < points.Count(); i++)
                    if (points[i].X > maxX)
                        maxX = points[i].X;
                return maxX;
            }
            public int setWidth()
            {
                return maxX - minY;
            }
            public int setHeight()
            {
                return maxY - minY;
            }
        }
    }
}
