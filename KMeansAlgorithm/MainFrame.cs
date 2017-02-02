using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var coreColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                var coreLocation = new Point(rand.Next(0, 420), rand.Next(0, 420));
                cores.Add(new ClusterCore(coreLocation, coreColor));
            }

            var dots = new List<Point>();
            for (var i = 0; i < 100000; i++)
            {
                dots.Add(new Point(rand.Next(0, 420), rand.Next(0, 420)));
            }

            var bitmap = new Bitmap(420, 420);
            var graphics = Graphics.FromImage(bitmap);
            drawer.DrawField(graphics, dots, cores);
            picboxBeforeClusterization.Image = bitmap;
        }
    }
}
