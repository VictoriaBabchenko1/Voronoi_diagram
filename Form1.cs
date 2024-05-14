using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voronoi_diagram
{
    public partial class Form1 : Form
    {
        private int width = 500;
        private int height = 400;

        private Random random = new Random();

        private readonly List<Point> _points = new List<Point>();
        private readonly Dictionary<Point, Color> _cellColors = new Dictionary<Point, Color>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the number of points to use
            
        }

        private void DrawVoronoiDiagram()
        {
            var bmp = new Bitmap(width, height);

            for (var x = 0; x < bmp.Width; x++)
            {
                for (var y = 0; y < bmp.Height; y++)
                {
                    var closestPoint = FindClosestPoint(new Point(x, y));

                    if (closestPoint != null)
                    {
                        bmp.SetPixel(x, y, _cellColors[closestPoint.Value]);
                    }
                }
            }

            if (ShowPointsCB.Checked)
            {
                DrawPoints(bmp);
            }

            pictureBox1.Image = bmp;
        }

        private void DrawVoronoiDiagramMultiThread()
        {
            var bmp = new Bitmap(width, height);

            int numThreads;
            if (AmountOfThreadsTB.Text == String.Empty)
            {
                numThreads = Environment.ProcessorCount;
            }
            else 
            {
                numThreads = Int32.Parse(AmountOfThreadsTB.Text);
            }
            int regionWidth = bmp.Width / numThreads;
            List<Rectangle> regions = new List<Rectangle>();
            for (int i = 0; i < numThreads; i++)
            {
                regions.Add(new Rectangle(i * regionWidth, 0, regionWidth, bmp.Height));
            }

            var tasks = new List<Task>();
            foreach (var region in regions)
            {
                tasks.Add(Task.Run(() =>
                {
                    for (var x = region.X; x < region.X + region.Width; x++)
                    {
                        for (var y = region.Y; y < region.Y + region.Height; y++)
                        {
                            var closestPoint = FindClosestPoint(new Point(x, y));

                            if (closestPoint != null)
                            {
                                lock (_cellColors)
                                {
                                    bmp.SetPixel(x, y, _cellColors[closestPoint.Value]);
                                }
                            }
                        }
                    }
                }));
            }

            Task.WaitAll(tasks.ToArray());

            if (ShowPointsCB.Checked)
            {
                DrawPoints(bmp);
            }

            pictureBox1.Image = bmp;
        }

        private void DrawPoints(Bitmap bmp)
        {
            using (var g = Graphics.FromImage(bmp))
            {
                var pointSize = 3;
                foreach (var point in _points)
                {
                    var brush = new SolidBrush(Color.Black);
                    g.FillEllipse(brush, point.X - pointSize / 2, point.Y - pointSize / 2, pointSize, pointSize);
                }
            }

            pictureBox1.Image = bmp;
        }

        private Point? FindClosestPoint(Point p)
        {
            var minDistance = double.MaxValue;
            Point? closestPoint = null;

            foreach (var point in _points)
            {
                var distance = Math.Sqrt(Math.Pow(p.X - point.X, 2) + Math.Pow(p.Y - point.Y, 2));
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestPoint = point;
                }
            }

            return closestPoint;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _points.Add(new Point(e.X, e.Y));
            _cellColors.Add(new Point(e.X, e.Y), Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            DrawVoronoiDiagram();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            _points.Clear();
            _cellColors.Clear();
            int numPoints = Int32.Parse(AmountOfPointsTB.Text);

            var rand = new Random();
            for (var i = 0; i < numPoints; i++)
            {
                var point = new Point(rand.Next(width), rand.Next(height));
                _points.Add(point);

                var color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                _cellColors[point] = color;
            }

            if (singleRadio.Checked)
            {
                DrawVoronoiDiagram();
            }
            else if (multiRadio.Checked)
            {
                DrawVoronoiDiagramMultiThread();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void singleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
