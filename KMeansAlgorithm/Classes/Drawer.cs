using System.Collections.Generic;
using System.Drawing;

namespace KMeansAlgorithm.Classes
{
    internal class Drawer
    {
        private const int DotHeight = 2;
        private const int DotWidth = 2;
        private const int CoreHeight = 8;
        private const int CoreWidth = 8;


        public Drawer()
        {
            ClusterColors = new List<Color>
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
                Color.Indigo
            };
        }

        public List<Color> ClusterColors { get; }

        public void DrawField(Graphics graphics, List<Dot> dots, List<ClusterCore> cores)
        {
            var pen = new Pen(Color.Black) {Brush = new SolidBrush(Color.Black)};

            foreach (var dot in dots)
            {
                pen.Color = ClusterColors[dot.ClusterNumber];

                graphics.DrawEllipse(pen, dot.Location.X, dot.Location.Y, DotWidth, DotHeight);
                graphics.FillEllipse(pen.Brush, dot.Location.X, dot.Location.Y, DotWidth, DotHeight);
            }

            pen.Color = Color.Black;

            foreach (var core in cores)
            {
                graphics.DrawEllipse(pen, core.Location.X, core.Location.Y, CoreWidth, CoreHeight);
                graphics.FillEllipse(pen.Brush, core.Location.X, core.Location.Y, CoreWidth, CoreHeight);
            }
        }
    }
}