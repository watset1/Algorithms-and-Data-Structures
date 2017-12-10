using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoidsApplication
{
    //Class to manage list of birds
    public class Flock
    {
        const int BIRD_AMOUNT = 20;
        public List<Bird> Birds = new List<Bird>();

        public Flock(Graphics canvas, Random random, int boundary)
        {
            for (int increment = 0; increment < BIRD_AMOUNT; increment++)
                Birds.Add(new Bird(canvas, random, boundary));
        }

        //Calls all birds move method
        public void MoveBirds()
        {
            foreach (Bird bird in Birds)
                bird.Move(Birds);
        }
    }
}
