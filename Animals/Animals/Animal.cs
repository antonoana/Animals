using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public string Name;
        public string Aspect;
        public MoveBehaviour moveBehaviour;
        public MakeSoundBehaviour makeSoundBehaviour;

        public void Move()
        {
            moveBehaviour.Move();
        }

        public void MakeSound()
        {
            makeSoundBehaviour.MakeSound();
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");

            Console.WriteLine("How does it moves? ");
            Move();

            Console.WriteLine("How does it sound? ");
            MakeSound();

            Console.WriteLine();
        }
    }

}
