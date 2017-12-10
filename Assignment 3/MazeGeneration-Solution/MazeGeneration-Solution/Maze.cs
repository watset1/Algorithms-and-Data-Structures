using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGeneration_Solution
{
    //Class that generates a maze
    public class Maze
    {
        const int PEN_SIZE = 1;
        public int rows;
        public int columns;
        int cellSize;
        public Cell[,] cells { get; set; }

        public Maze(int rows, int columns, int cellSize)
        {
            this.rows = rows;
            this.columns = columns;
            this.cellSize = cellSize;
            cells = new Cell[rows, columns];
            CreateCells();
            SetNeighbours();
        }

        //Populates matrix with Cells
        public void CreateCells()
        {
            for (int row = 0; row < rows; row++)
                for (int column = 0; column < columns; column++)
                {
                    cells[row, column] = new Cell();
                    cells[row, column].position = new Point(row, column);
                }
        }
        
        //Sets each cells neighbouring cells
        public void SetNeighbours()
        {
            for (int row = 0; row < rows; row++)
                for (int column = 0; column < columns; column++)
                    cells[row, column].SetNeighbours(cells, row, column, rows, columns);
        }

        //Draws the maze to the canvas
        public void DrawMaze(Graphics canvas)
        {
            Pen pen;
            int penSize = PEN_SIZE;
            pen = new Pen(Color.Black, penSize);

            for (int currentCol = 0; currentCol < rows; currentCol++)
            {
                for (int currentRow = 0; currentRow < columns; currentRow++)
                {
                    Cell currentCell = cells[currentCol, currentRow];
                    currentCell.DrawCell(canvas, cellSize, pen);                   
                }
            }
        }

        //Resets all cells visited boolean to false
        public void ResetCellVisited()
        {
            foreach (Cell cell in cells)
                cell.ResetVisited();
        }
    }
}
