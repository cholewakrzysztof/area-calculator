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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VisualForm okno = new VisualForm();
        AreaForm kalkulator = new AreaForm();
        List<Point> points = new List<Point>();
        private void button_addPoint_Click(object sender, EventArgs e)
        {
            Point p = createPoint();
            if (!listContainPoint(p))
                points.Add(p);
            okno.points = this.points;
            kalkulator.points = this.points;
        }
        public Point createPoint()
        {
            int x;
            if (textBox1.Text.Length == 0)
                x = 0;
            else
                x = Convert.ToInt32(textBox1.Text);

            int y;
            if (textBox2.Text.Length == 0)
                y = 0;
            else
                y = Convert.ToInt32(textBox2.Text);

            return new Point(x, y);
        }
        public bool listContainPoint(Point p)
        {
            for (int i = 0; i < points.Count(); i++)
                if (points[i].X == p.X)
                    if (points[i].Y == p.Y)
                        return true;
            return false;
        }
        private void button_connectPoints_Click(object sender, EventArgs e)
        {
            okno.polaczPunktyProsta();
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            okno.points.Clear();
            okno.Close();
            okno = new VisualForm();
        }
        private void button_drawSample_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(-100, -100);
            Point p2 = new Point(0, 0);
            Point p3 = new Point(100, 100);
            Point p4 = new Point(70, -50);
            if(!listContainPoint(p1))
                points.Add(p1);
            if (!listContainPoint(p2))
                points.Add(p2);
            if (!listContainPoint(p3))
                points.Add(p3);
            if (!listContainPoint(p4))
                points.Add(p4);
            okno.points = points;
            okno.rysujPunkty();
            okno.Show();
        }
        private void button_connectPointsCurve_Click(object sender, EventArgs e)
        {
            okno.polaczPunktyKrzywa();
        }
        private void button_drawLayout_Click(object sender, EventArgs e)
        {
            okno.rysujUklad();
        }
        private void button_areaForm_Click(object sender, EventArgs e)
        {
            kalkulator = new AreaForm();
            kalkulator.points = this.points;
            kalkulator.setListBoxData();
            kalkulator.ShowDialog();
        }
        private void button_drawPoints_Click(object sender, EventArgs e)
        {
            okno.rysujPunkty();
            okno.Show();
        }
        private void button_drawSinus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i+=5)
            {
                int y = Convert.ToInt32(Math.Abs(Math.Sin(i)+1)*10);
                Point p = new Point(i, y);
                points.Add(p);
            }
            kalkulator.points = points;
            okno.points = points;
            okno.rysujPunkty();
            okno.Show();
        }
    }
}
