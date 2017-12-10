using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoidsApplication
{
    //Constraints used to process birds movement
    public static class BoidConstraints
    {
        //Aligns two birds to each other
        public static void AlignBoids(double distance, double sight, Bird currentBird, Bird otherBird)
        { 
            if (distance < sight)
            {
                currentBird.dX += otherBird.dX * 0.5;
                currentBird.dY += otherBird.dY * 0.5;
            }
        }

        //Matches a birds velovity with the rest of the flock
        public static void MatchVelocity(double distance, double sight, Bird currentBird, Bird otherBird)
        {
            if (distance < sight)
            {
                currentBird.dX += (otherBird.Position.X - currentBird.Position.X) * 0.05;
                currentBird.dY += (otherBird.Position.Y - currentBird.Position.Y) * 0.05;
            }
        }

        //Creates space between each bird
        public static void MakeSpace(double distance, double space, Bird currentBird, Bird otherBird)
        {
            if (distance < space)
            {
                currentBird.dX += currentBird.Position.X - otherBird.Position.X;
                currentBird.dY += currentBird.Position.Y - otherBird.Position.Y;
            }
        }
    }
}
