using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGeneration_Solution
{
    public enum ENeighbourType { north, east, south, west }
    public enum ECellType { begin, normal, end }
    
    //Class to hold an individual cell for a maze.
    public class Cell
    {
        const int DIRECTIONS = 4;
        const int SIZE_OFFSET = 3;

        public Cell[] Neighbours { get; set; } //Stores neighbouring cells    
        public bool Visited { get; set; } //Stores boolean value indicating whether the cell has been visited 
        public ECellType CellType { get; set; } //Value indicating if the cell is a start cell, and end cell or a normal cell
        public Point position { get; set; } //Stores position in matrix
        public bool[] walls; //Indicates whether a path is open between neighbouring cells

        public Cell()
        {
            Neighbours = new Cell[DIRECTIONS];
            walls = new bool[DIRECTIONS] { true, true, true, true };
            Visited = false;
            CellType = ECellType.normal; 
        }

        //Sets the cells neighbouring cells, or leaves null value if neighbour doesnt exist
        public void SetNeighbours(Cell[,] cells, int row, int column, int rows, int columns)
        {
            if (column - 1 >= 0)
                Neighbours[(int)ENeighbourType.west] = cells[row, column - 1];
            if (row + 1 < rows)
                Neighbours[(int)ENeighbourType.south] = cells[row + 1, column];
            if (column + 1 < columns)
                Neighbours[(int)ENeighbourType.east] = cells[row, column + 1];
            if (row - 1 >= 0)
                Neighbours[(int)ENeighbourType.north] = cells[row - 1, column];
        }

        //Returns a cells neighbours whose visited boolean is true
        public List<int> GetUnvisitedNeighbours()
        {
            List<int> unvisitedNeighbours = new List<int>();
            for (int neighbour = 0; neighbour < Neighbours.Count(); neighbour++)
                if (Neighbours[neighbour] != null)
                    if (!Neighbours[neighbour].Visited)
                        unvisitedNeighbours.Add(neighbour);
            return unvisitedNeighbours;
        }

        //Sets a wall boolean to false
        public void DestroyWall(int neighbour, Cell neighbouringCell)
        {
            walls[(int)neighbour] = false;
            neighbouringCell.walls[GetOppositeNeighbour(neighbour)] = false;
        }

        //Sets the neighbours opposite wall to false
        public int GetOppositeNeighbour(int neighbour)
        {
            int opposite = -1;
            if (neighbour.Equals((int)ENeighbourType.north))
                opposite = (int)ENeighbourType.south;
            if (neighbour.Equals((int)ENeighbourType.south))
                opposite = (int)ENeighbourType.north;
            if (neighbour.Equals((int)ENeighbourType.west))
                opposite = (int)ENeighbourType.east;
            if (neighbour.Equals((int)ENeighbourType.east))
                opposite = (int)ENeighbourType.west;
            return opposite;
        }

        //Draws the cell walls that are set to true, calculating the current cell position based on position in matrix
        public void DrawCell(Graphics canvas, int cellSize, Pen pen)
        {
            int row = position.Y;
            int column = position.X;
            Point topLeft = new Point(cellSize * row, cellSize * column);
            Point topRight = new Point(cellSize + cellSize * row, cellSize * column);
            Point bottomLeft = new Point(cellSize * row, cellSize * column + cellSize);
            Point bottomRight = new Point(cellSize + cellSize * row, cellSize * column + cellSize);

            if (walls[(int)ENeighbourType.north])
                if (!CellType.Equals(ECellType.begin))
                    canvas.DrawLine(pen, topLeft, topRight);
            if (walls[(int)ENeighbourType.west])
                canvas.DrawLine(pen, bottomLeft, topLeft);
            if (walls[(int)ENeighbourType.east])
                canvas.DrawLine(pen, bottomRight, topRight);
            if (walls[(int)ENeighbourType.south])
                if (!CellType.Equals(ECellType.end))
                    canvas.DrawLine(pen, bottomLeft, bottomRight);
        }

        //Fills a rectangle in cell position
        public void FillCell(Graphics canvas, int cellSize, Brush brush)
        {        
            int fillSize = cellSize - SIZE_OFFSET;
            int row = position.Y;
            int column = position.X;
            Point topLeft = new Point(((cellSize * row) + SIZE_OFFSET), ((cellSize * column) + SIZE_OFFSET));
            Rectangle rect = new Rectangle(topLeft, new Size(fillSize, fillSize));
            canvas.FillRectangle(brush, rect);
        }

        //Gets a list of neighbours thats corresponding wall is false and which are unvisited
        public List<int> GetUnvisitedUnblockedNeighbours()
        {
            List<int> unvisitedNeighbours = new List<int>();
            for (int neighbour = 0; neighbour < Neighbours.Count(); neighbour++)
                if (Neighbours[neighbour] != null)
                    if (!Neighbours[neighbour].Visited && walls[neighbour] == false)
                        unvisitedNeighbours.Add(neighbour);
            return unvisitedNeighbours;
        }

        //Resets a cells visited boolean to false
        public void ResetVisited()
        {
            Visited = false;
        }
    }
}
