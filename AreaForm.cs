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
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
        }
        public List<Point> points;
        public void setListBoxData()
        {
            sortPoints();
            for(int i=0; i<points.Count();i++)
                listBox_Points.Items.Add(points[i].X.ToString() + ":"+ points[i].Y.ToString());
        }
        private void sortPoints()
        {
            this.points = this.points.OrderBy(p => p.X).ToList();
        }
        private void button_CalculateArea_Click(object sender, EventArgs e)
        {
            sortPoints();
            Calculator calc = new Calculator(points);
            if (textBox_Precision.Text.Length != 0)
                calc.setPrecision(Convert.ToInt32(textBox_Precision.Text));
            double area = calc.calculateArea();
            label_Area.Text = area.ToString();
        }
        public class Calculator
        {
            private double precision = 1;
            private List<Point> points;

            public Calculator(List<Point> points)
            {
                this.points = points;
            }

            public void setPrecision(int precision)
            {
                double pr = 1;
                for (int i = 0; i < precision; i++)
                    pr = pr/10;
                this.precision = pr;
            }
            public double calculateArea()
            {
                double area = 0;
                for (int i = 0; i < points.Count()-1; i++)
                {
                    Line line = new Line(points[i], points[i + 1], precision);
                    for (int j = 0; j < line.mid_Y.Count(); j++) 
                    {
                        area += precision * line.mid_Y[j];
                    }
                }
                area = Math.Round(area, 3);
                return area;
            }
            
        }
        public class Line 
        {
            double precision;
            Point x1;
            Point x2;
            double a;
            double b;
            double distance;
            public List<double> mid_Y = new List<double>();
            public List<double> mid_X = new List<double>();
            public Line(Point x1, Point x2,double precision) 
            {
                Point p1 = new Point(Math.Abs(x1.X), Math.Abs(x1.Y));
                Point p2 = new Point(Math.Abs(x2.X), Math.Abs(x2.Y));
                this.x1 = p1;
                this.x2 = p2;
                this.precision = precision;
                setAofLine();
                setBofLine();
                setDistance();
                setMidPoints();
            }
            private void setAofLine()
            {
                if(x2.X - x1.X!=0)
                    a = (x2.Y - x1.Y) / (x2.X - x1.X);
                else
                    a = 0;
            }
            private void setBofLine()
            {
                b = x1.Y - (x1.X * a);
            }
            private double getYofPointOnLine(double x)
            {
                return (a * x) + b;
            }
            private void setDistance()
            {
                distance =  Math.Abs(x1.X - x2.X);
            }
            private void setMidPoints()
            {
                for (double i = 0; i < distance; i += precision)
                {
                    double x = x1.X + i;
                    mid_Y.Add(getYofPointOnLine(x));
                    mid_X.Add(x);
                }
            }
        }
    }
}
