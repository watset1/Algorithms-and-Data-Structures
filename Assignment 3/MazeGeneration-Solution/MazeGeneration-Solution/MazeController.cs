using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MazeGeneration_Solution
{
    //Static class to generate and solve a maze
    public static class MazeController
    {
        //Generates a Maze
        public static Maze Generate(Maze closedMaze, Random random)
        {
            CellStack stack = new CellStack();
            Cell currentCell = closedMaze.cells[0, 0];
            currentCell.Visited = true;
            stack.Push(currentCell);
            currentCell.CellType = ECellType.begin;

            while(!stack.IsEmpty())
            {
                List<int> unvisitedNeighbours = currentCell.GetUnvisitedNeighbours();
                int totalUnvisitedNeighbours = unvisitedNeighbours.Count();

                if (totalUnvisitedNeighbours == 0)
                {
                    currentCell = stack.Pop();
                    currentCell.Visited = true;
                }
                else
                {
                    int chosenNeighbour = random.Next(totalUnvisitedNeighbours);
                    int neighbourIndex = unvisitedNeighbours[chosenNeighbour];
                    Cell newCell = currentCell.Neighbours[neighbourIndex];
                    stack.Push(newCell);
                    currentCell.DestroyWall(neighbourIndex, newCell);
                    currentCell = newCell;
                    currentCell.Visited = true;
                }              
            }
            int endRowIndex = closedMaze.rows -1;
            int endColumnIndex = closedMaze.columns - 1;
            closedMaze.cells[endRowIndex, endColumnIndex].CellType = ECellType.end;

            return closedMaze;
        }

        //Backtracking algorithm that solves maze, drawing progress to the screen
        public static void Solve(Graphics mainCanvas, Graphics canvas, Bitmap offScreenBitmap, Maze maze, Random random, int cellSize)
        {
            const int SLEEP_TIME = 50;

            Brush correctBrush = new SolidBrush(Color.Coral);
            Brush incorrectBrush = new SolidBrush(Color.LightGray);
            maze.ResetCellVisited();
            CellStack stack = new CellStack();
            Cell currentCell = maze.cells[0, 0];
            currentCell.Visited = true;
            stack.Push(currentCell);

            while (currentCell.CellType != ECellType.end)
            {
                List<int> unvisitedNeighbours = currentCell.GetUnvisitedUnblockedNeighbours();
                int totalUnvisitedNeighbours = unvisitedNeighbours.Count();

                if (totalUnvisitedNeighbours == 0)
                {
                    Thread.Sleep(SLEEP_TIME);
                    currentCell.Visited = true;
                    currentCell.FillCell(canvas, cellSize, incorrectBrush);
                    mainCanvas.DrawImage(offScreenBitmap, 0, 0);
                    stack.Pop();
                    currentCell = stack.Peek();
                }
                else
                {
                    Thread.Sleep(SLEEP_TIME);
                    currentCell.FillCell(canvas, cellSize, correctBrush);
                    mainCanvas.DrawImage(offScreenBitmap, 0, 0);
                    int chosenNeighbour = random.Next(totalUnvisitedNeighbours);
                    int neighbourIndex = unvisitedNeighbours[chosenNeighbour];
                    Cell newCell = currentCell.Neighbours[neighbourIndex];
                    stack.Push(newCell);
                    currentCell = newCell;
                    currentCell.Visited = true;
                }

            }
            currentCell.FillCell(canvas, cellSize, correctBrush);
            mainCanvas.DrawImage(offScreenBitmap, 0, 0);
        }
    }
}
