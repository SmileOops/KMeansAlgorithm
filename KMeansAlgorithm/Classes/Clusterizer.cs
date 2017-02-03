using System;
using System.Collections.Generic;
using System.Linq;

namespace KMeansAlgorithm.Classes
{
    internal class Clusterizer
    {
        public void Clusterize(List<ClusterCore> cores, List<Dot> dots)
        {
            foreach (var dot in dots)
            {
                var distanses = new List<double>();
                foreach (var core in cores)
                {
                    distanses.Add(
                        Math.Sqrt(Math.Pow(Math.Abs(dot.Location.X - core.Location.X), 2) +
                                  Math.Pow(Math.Abs(dot.Location.Y - core.Location.Y), 2)));
                }

                var min = distanses.Min(d => d);
                dot.ClusterNumber = distanses.IndexOf(min);
            }
        }
    }
}