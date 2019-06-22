using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.MakeSound;
using Animals.Move;

namespace Animals.Animals
{
    public class Lion : Animal
    {

        public Lion()
        {
            Name = "Lion";
            MoveBehaviour = new Walks();
            MakeSoundBehaviour = new Roar();
        }
    }
}
