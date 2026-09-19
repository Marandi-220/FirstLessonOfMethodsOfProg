using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.abstractFactory
{
    internal class Hero
    {
        public string Name { get; }
        IHit hit;
        IMove move;

        public Hero(IHit hit, IMove move, string name)
        {
            this.hit = hit;
            this.move = move;
            Name = name;
        }

        public void Hit()
        {
            hit.Hit();
            Console.WriteLine("I am " + this.Name);
        }

        public void Move()
        {
            move.Move();
        }
    }
}
