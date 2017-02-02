using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMeansAlgorithm.Classes
{
    internal class Drawer
    {
        private const int _dotHeight = 2;
        private const int _dotWidth = 2;
        private List<Color> _clusterColors;

        public Drawer()
        {
            _clusterColors = new List<Color>()
            {
                Color.Aqua,
                Color.Blue,
                Color.Salmon,
                Color.BlueViolet,
                Color.Brown,
                Color.Chartreuse,
                Color.DarkOrange,
                Color.DeepPink,
                Color.Gold,
                Color.Red,
                Color.DimGray,
                Color.Green,
                Color.Peru,
                Color.MediumSeaGreen,
                Color.Lime,
                Color.Sienna,
                Color.RoyalBlue,
                Color.Olive,
                Color.Maroon,
                Color.Indigo,
            };
        }

        public void DrawField(Graphics graphics, List<Point> dots, List<ClusterCore> cores)
        {
            var currentColor = Color.Black;
            var pen = new Pen(currentColor) {Brush = new SolidBrush(currentColor)};
            foreach (var dot in dots)
            {
                var distanses = new List<double>();
                foreach (var core in cores)
                {
                    distanses.Add(
                        Math.Sqrt(Math.Pow(Math.Abs(dot.X - core.Location.X), 2) +
                                  Math.Pow(Math.Abs(dot.Y - core.Location.Y), 2)));
                }

                var min = distanses.Min(d => d);
                var index = distanses.IndexOf(min);

                pen.Color = cores[index].Color;

                graphics.DrawEllipse(pen, dot.X, dot.Y, _dotWidth, _dotHeight);
                graphics.FillEllipse(pen.Brush, dot.X, dot.Y, _dotWidth, _dotHeight);
            }
        }
    }
}
