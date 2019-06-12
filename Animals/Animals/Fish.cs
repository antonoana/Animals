using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.MakeSound;
using Animals.Move;

namespace Animals.Animals
{
    public class Fish : Animal
    {
        public Fish()
        {
            Name = Fish;
            moveBehaviour = new Swim();
            makeSoundBehaviour = new Silence();
        }
    }
}
