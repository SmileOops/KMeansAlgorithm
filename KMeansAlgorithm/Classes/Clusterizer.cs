using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void OptimizeClusterisation(List<ClusterCore> cores, List<Dot> dots)
        {
            bool isAnyCoreChanged;
            do
            {
                isAnyCoreChanged = false;
                for (var i = 0; i < cores.Count; i++)
                {
                    var dotsFromThisCluster = dots.Where(d => d.ClusterNumber == i).ToList();
                    var probableNewMassCenter = GetNewMassCenter(dotsFromThisCluster);
                    if (probableNewMassCenter != cores[i].Location)
                    {
                        isAnyCoreChanged = true;
                        cores[i].Location = probableNewMassCenter;
                    }
                }
                Clusterize(cores, dots);
            } while (isAnyCoreChanged);
        }

        private Point GetNewMassCenter(List<Dot> dots)
        {
            int x = 0;
            int y = 0;

            foreach (var dot in dots)
            {
                x += dot.Location.X;
                y += dot.Location.Y;
            }

            return new Point(x/dots.Count, y / dots.Count);
        }
    }
}