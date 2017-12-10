using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoidsApplication
{
    //Bird class that holds information to draw them as well as methods to move, draw and set their movements
    public class Bird
    {
        const int BIRD_SIZE = 10;
        const int SPEED_CONTROL = 4;
        const double BORDER = 100;
        const double SIGHT = 75;
        const double SPACE = 30;
        const double SPEED = 12;
        Color BIRD_COLOR = Color.White;

        private Graphics canvas;
        private SolidBrush birdBrush;
        public Point Position;      
        public double boundary;
        public double dX;
        public double dY;
        
        public Bird(Graphics canvas, Random random, int boundary)
        {
            this.canvas = canvas;
            Position = new Point(random.Next(boundary), random.Next(boundary));
            this.boundary = boundary;
            birdBrush = new SolidBrush(BIRD_COLOR);
        }

        //Sets birds new position
        public void Move(List<Bird> birds)
        {
            SetBirdMovement(birds);
            CheckBounds();
            CheckSpeed();
            Position.X += (int)dX;
            Position.Y += (int)dY;
            DrawBird();
        }

        //Draws the bird to canvas
        public void DrawBird()
        {
            canvas.FillEllipse(birdBrush, Position.X, Position.Y, BIRD_SIZE, BIRD_SIZE);
        }

        //Method that processes each birds speed, distance between other birds, and their percieved center of mass
        private void SetBirdMovement(List<Bird> birds)
        {
            foreach (Bird bird in birds)
            {
                double distance = Distance(Position, bird.Position);
                if (bird != this)
                {
                    BoidConstraints.AlignBoids(distance, SIGHT, this, bird);
                    BoidConstraints.MakeSpace(distance, SPACE, this, bird);
                    BoidConstraints.MatchVelocity(distance, SIGHT, this, bird);
                }
            }
        }

        //Calculates and returns the distance between two points
        private double Distance(Point p1, Point p2)
        {
            double dist = Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2);
            return (double)Math.Sqrt(dist);
        }

        //Ckecks if birds new position is inside the boundaries of the client. Adjusts position if they are heading outside the boundaries
        private void CheckBounds()
        {
            double bounds = boundary - BORDER;
            if (Position.X < BORDER) dX += BORDER - Position.X;
            if (Position.Y < BORDER) dY += BORDER - Position.Y;
            if (Position.X > bounds) dX += bounds - Position.X;
            if (Position.Y > bounds) dY += bounds - Position.Y;
        }

        //Adjusts birds speed based on their distance between the rest of the flock
        private void CheckSpeed()
        {
            double speed = SPEED / SPEED_CONTROL;
            double dist = Distance(new Point(0, 0), new Point((int)dX, (int)dY));
            if (dist > speed)
            {
                dX = dX * speed / dist;
                dY = dY * speed / dist;
            }
        }
    }
}
