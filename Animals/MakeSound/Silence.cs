using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.MakeSound
{
    public class Silence : MakeSoundBehaviour
    {
        public void MakeSound()
        {
            Console.Write("It makes no sound. It's silent.");
        }
    }
}
}
