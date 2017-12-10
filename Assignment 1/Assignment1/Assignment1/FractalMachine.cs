using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public enum EDirection { up, left, down, right }

    public class FractalMachine
    {
        Graphics canvas;
        Pen pen;
        Brush brush;

        public FractalMachine(Graphics canvas) 
        {
            this.canvas = canvas;      
        }

        public void Triangle(int depth, Point x, Point y, Point z)
        {            
            brush = new SolidBrush(Color.Red); 
            if (depth == 0)
            {
                Point[] triPoints = { x, y, z };
                canvas.FillPolygon(brush, triPoints);
            }
            else
            {
                //Calculate new points
                Point leftMid = new Point((x.X + z.X) / 2, (x.Y + z.Y) / 2);
                Point rightMid = new Point((x.X + y.X) / 2, (x.Y + y.Y) / 2);
                Point bottomMid = new Point(((y.X + z.X) / 2), (y.Y + z.Y) / 2);
                //Recurse for next three triangles
                Triangle(depth - 1, x, rightMid, leftMid);
                Triangle(depth - 1, leftMid, bottomMid, z);
                Triangle(depth - 1, rightMid, y, bottomMid);
            }
        }

        public void Snowflake(int depth, Point start, Point end)
        {
            pen = new Pen(Color.Black);
            Point lineLength, firstThird, trianglePoint, lastThird;

            if (depth == 0)
                canvas.DrawLine(pen, start, end);
            else
            {
                //Get length of the previous line
                lineLength = new Point(end.X - start.X, end.Y - start.Y);
                //Get the coordinates for the end of the first segment
                firstThird = new Point(start.X + lineLength.X / 3, start.Y + lineLength.Y / 3);
                //Get tip of new triangle location
                trianglePoint = GetTipCoordinates(start, end);
                //Get the coordinates for the start of the third segment
                lastThird = new Point(start.X + 2 * lineLength.X / 3, start.Y + 2 * lineLength.Y / 3);
                //Recurse for each new line
                Snowflake(depth - 1, start, firstThird);
                Snowflake(depth - 1, firstThird, trianglePoint);
                Snowflake(depth - 1, trianglePoint, lastThird);
                Snowflake(depth - 1, lastThird, end);
            }
        }

        //Calculation to get new triangle tip point to draw to and from
        public Point GetTipCoordinates(Point start, Point end)
        {
            int x = (int)(0.5 * (start.X + end.X) + Math.Sqrt(3) * (start.Y - end.Y) / 6.25); //Played around with number to divide to straighten lines
            int y = (int)(0.5 * (start.Y + end.Y) + Math.Sqrt(3) * (end.X - start.X) / 6.25);
            return new Point(x, y);
        }

        public void Tree(int depth, int maxDepth, Point start, int length, int angle, int newAngle, int penWidth)
        {
            Color penColor;
            if (depth < maxDepth - 4) //Changes color of branches based on current depth
                penColor = Color.ForestGreen;
            else
                penColor = Color.Brown;
            pen = new Pen(penColor, penWidth);
            Point endPoint = GetBranchEndPoint(start, angle, length);
            double newPenWidth = penWidth * 0.8; //Reduces branch size
            double newLength = length * 0.7; //Reduces branch length           
            canvas.DrawLine(pen, start, endPoint);           

            if (depth > 0)//Base case
            {
                //Recursion for two new branches
                Tree(depth - 1, maxDepth, endPoint, (int)newLength, angle + newAngle, newAngle, (int)newPenWidth);
                Tree(depth - 1, maxDepth, endPoint, (int)newLength, angle - newAngle, newAngle, (int)newPenWidth);
            }
        }

        //Calculates end point of each new branch
        public Point GetBranchEndPoint(Point start, int angle, int length)
        {
            double x, y, radianAngle;
            radianAngle = angle * 0.01745;
            x = Math.Cos(radianAngle) * length + start.X;
            y = Math.Sin(radianAngle) * length + start.Y;
            return new Point((int)x, (int)y);
        }

        public void Dragon(int depth, Point start, Point direction, EDirection currentDirection)
        {
            pen = new Pen(Color.Red);
            if (depth == 0) //Base case
                canvas.DrawLine(pen, start.X, start.Y, start.X + direction.X, start.Y + direction.Y);
            else
            {
                //Calculates the coordinants where the next two lines should meet at a right angle
                double x = direction.X / 2;
                double y = direction.Y / 2;
                double newDirectionX = -y + x;
                double newDirectionY = x + y;

                if(currentDirection == EDirection.right)
                {
                    Dragon(depth - 1, start, new Point((int)newDirectionX, (int)newDirectionY), EDirection.right);
                    //Creates new start point where the previous line finished
                    double newStartX = start.X + newDirectionX;
                    double newStartY = start.Y + newDirectionY;
                    Point newStart = new Point((int)newStartX, (int)newStartY);
                    Dragon(depth - 1, newStart, new Point((int)newDirectionY, (int)-newDirectionX), EDirection.left);
                }
                if(currentDirection == EDirection.left)
                {
                    Dragon(depth - 1, start, new Point((int)newDirectionY, (int)-newDirectionX), EDirection.right);
                    //Creates new start point where the previous line finished
                    double newStartX = start.X + newDirectionY;
                    double newStartY = start.Y - newDirectionX;
                    Point newStart = new Point((int)newStartX, (int)newStartY);
                    Dragon(depth - 1, newStart, new Point((int)newDirectionX, (int)newDirectionY), EDirection.left);
                }
            }
        }

        public void Circle(int depth, Point start, int dimensions)
        {
            brush = new SolidBrush(Color.Purple);
            pen = new Pen(Color.Gold,1);
            //Creates border and background fill
            canvas.FillEllipse(brush, start.X, start.Y, dimensions, dimensions);
            canvas.DrawEllipse(pen, start.X, start.Y, dimensions, dimensions);
            brush = new SolidBrush(Color.Gold);
            if (depth == 0)
                canvas.FillEllipse(brush, start.X, start.Y, dimensions, dimensions);
            else
            {
                double newDimensions = (dimensions / 3); //Gets new big circle size
                double smallDimensions = newDimensions / 2; //Gets new small circle size
                //Gets the new start points for each circle
                Point middle = new Point((int)(start.X + newDimensions), (int)(start.Y + newDimensions));
                Point top = new Point((int)(start.X + newDimensions), start.Y);
                Point right = new Point((int)(start.X + newDimensions * 2), (int)(start.Y + newDimensions));
                Point left = new Point(start.X, (int)(start.Y + newDimensions));
                Point bottom = new Point((int)(start.X + newDimensions), (int)(start.Y + newDimensions * 2));
                Point topLeft = new Point((int)(start.X + smallDimensions), (int)(start.Y + smallDimensions));
                Point topRight = new Point((int)(start.X + smallDimensions * 4), (int)(start.Y + smallDimensions));
                Point bottomLeft = new Point((int)(start.X + smallDimensions), (int)(start.Y + smallDimensions * 4));
                Point bottomRight = new Point((int)(start.X + smallDimensions * 4), (int)(start.Y + smallDimensions * 4));
                //Recurses through 8 circles, 4 big - 2 small
                Circle(depth - 1, middle, (int)newDimensions);
                Circle(depth - 1, top, (int)newDimensions);
                Circle(depth - 1, right, (int)newDimensions);
                Circle(depth - 1, left, (int)newDimensions);
                Circle(depth - 1, bottom, (int)newDimensions);
                Circle(depth - 1, topLeft, (int)smallDimensions);
                Circle(depth - 1, topRight, (int)smallDimensions);
                Circle(depth - 1, bottomRight, (int)smallDimensions);
                Circle(depth - 1, bottomLeft, (int)smallDimensions);
            }
        }
    }
}
