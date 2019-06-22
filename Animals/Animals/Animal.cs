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
        public MoveBehaviour MoveBehaviour;
        public MakeSoundBehaviour MakeSoundBehaviour;

        public void Move()
        {
            MoveBehaviour.Move();
        }

        public void MakeSound()
        {
            MakeSoundBehaviour.MakeSound();
        }

        public void ChangeMoveBehaviour(MoveBehaviour moveBehaviour)
        {
            MoveBehaviour = moveBehaviour;
        }

        public void ChangeSoundBehaviour (MakeSoundBehaviour soundBehaviour)
        {
            MakeSoundBehaviour = soundBehaviour;
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
