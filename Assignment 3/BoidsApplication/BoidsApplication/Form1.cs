using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoidsApplication
{
    /*
     *The boids algorithm takes a list of items and runs each item through a series of
     *processes to adjust their position relative to the other items in the list.
     *
     * Resources:
     * https://www.macs.hw.ac.uk/~dwcorne/Teaching/Boids%20Pseudocode.htm
     * https://en.wikipedia.org/wiki/Boids
     * https://cs.stanford.edu/people/eroberts/courses/soco/projects/2008-09/modeling-natural-systems/boids.html
     * https://fivedots.coe.psu.ac.th/~ad/jg/ch13/chap13.pdf
     * https://www.youtube.com/watch?v=QbUPfMXXQIY
     */

    public partial class Form1 : Form
    {
        Color BACKGROUND_COLOR = Color.LightSkyBlue;

        Random random;
        Flock flock;
        Graphics mainCanvas;
        Bitmap offScreenBitmap;
        Graphics offScreenGraphics;

        public Form1()
        {
            InitializeComponent();
            mainCanvas = CreateGraphics();
            offScreenBitmap = new Bitmap(Width, Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            random = new Random();
            flock = new Flock(offScreenGraphics, random, Width);
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            offScreenGraphics.FillRectangle(new SolidBrush(BACKGROUND_COLOR), 0, 0, Width, Height);
            flock.MoveBirds();
            mainCanvas.DrawImage(offScreenBitmap, 0, 0);
        }
    }
}
