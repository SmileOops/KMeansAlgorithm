using System.Drawing;

namespace KMeansAlgorithm.Classes
{
    internal class Dot
    {
        public Dot(Point location)
        {
            Location = location;
        }

        public Point Location { get; private set; }
        public int ClusterNumber { get; set; }
    }
}