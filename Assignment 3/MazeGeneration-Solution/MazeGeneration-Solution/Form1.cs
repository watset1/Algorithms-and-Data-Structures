using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGeneration_Solution
{
    public partial class Form1 : Form
    {
        const int rows = 30;
        const int columns = 30;
        const int cellSize = 20;

        Random random;
        Maze maze;
        Graphics mainCanvas;
        Bitmap offScreenBitmap;
        Graphics offScreenGraphics;
        Brush brush;

        public Form1()
        {
            InitializeComponent();
            mainCanvas = panel1.CreateGraphics();
            offScreenBitmap = new Bitmap(Width, Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            random = new Random();
            brush = new SolidBrush(Color.AntiqueWhite);     
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            offScreenGraphics.FillRectangle(brush, 0, 0, Width, Height);
            maze = MazeController.Generate(new Maze(rows, columns, cellSize), random);
            maze.DrawMaze(offScreenGraphics);           
            mainCanvas.DrawImage(offScreenBitmap, 0, 0);
            btnSolve.Enabled = true;                    
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            offScreenGraphics.FillRectangle(brush, 0, 0, Width, Height);
            maze.DrawMaze(offScreenGraphics);
            mainCanvas.DrawImage(offScreenBitmap, 0, 0);
            MazeController.Solve(mainCanvas, offScreenGraphics, offScreenBitmap, maze, random, cellSize);
        }       
    }
}
