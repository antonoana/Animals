using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.MakeSound;
using Animals.Move;

namespace Animals.Animals
{
    public class Bird:Animal
    {
        public Bird()
        {
            Name = "Bird";
            moveBehaviour = new Fly();
            makeSoundBehaviour = new Chirp();
        }
    }
}
