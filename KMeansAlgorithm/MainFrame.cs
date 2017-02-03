using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KMeansAlgorithm.Classes;

namespace KMeansAlgorithm
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var drawer = new Drawer();
            var rand = new Random();

            var cores = new List<ClusterCore>();
            for (var i = 0; i < 20; i++)
            {
                var coreLocation = new Point(rand.Next(0, 420), rand.Next(0, 420));
                cores.Add(new ClusterCore(coreLocation));
            }

            var dots = new List<Dot>();
            for (var i = 20; i < 100000; i++)
            {
                dots.Add(new Dot(new Point(rand.Next(0, 420), rand.Next(0, 420))));
            }

            var clusterizer = new Clusterizer();
            clusterizer.Clusterize(cores, dots);

            var bitmap = new Bitmap(420, 420);
            var graphics = Graphics.FromImage(bitmap);
            drawer.DrawField(graphics, dots, cores);
            picboxBeforeClusterization.Image = bitmap;

            clusterizer.OptimizeClusterisation(cores, dots);
            var bitmap1 = new Bitmap(420, 420);
            var graphics1 = Graphics.FromImage(bitmap1);
            drawer.DrawField(graphics1, dots, cores);
            picBoxAfterClusterization.Image = bitmap1;
        }

        private void btnClusterize_Click(object sender, EventArgs e)
        {
            
        }
    }
}