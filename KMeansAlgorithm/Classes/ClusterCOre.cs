using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMeansAlgorithm.Classes
{
    internal class ClusterCore
    {
        public Point Location { get; private set; }
        public Color Color { get; private set; }

        public ClusterCore(Point location, Color color)
        {
            Location = location;
            Color = color;
        }


    }
}
