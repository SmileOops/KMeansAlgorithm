using System.Drawing;

namespace KMeansAlgorithm.Classes
{
    internal class ClusterCore
    {
        public ClusterCore(Point location)
        {
            Location = location;
        }

        public Point Location { get; set; }
    }
}