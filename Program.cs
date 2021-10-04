using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Animal
    {
        public int NombreDeJambes { get; set; }
        public string Name { get; set; }

        public Animal(string name, int nombreDeJambes)
        {
            this.NombreDeJambes = nombreDeJambes;
            this.Name = name;
        }

        public virtual void Move()
        {
            
        }

        public virtual void Eat()
        {

        }

    }

    public class Humain : Animal
    {
        public Humain(string name) : base("humain", 2)
        { 
        }

        public override void Eat()
        {
            Console.WriteLine("L'"+Name+" mange avec des couverts");
        }

        public override void Move()
        {
            Console.WriteLine("L'" + Name + " se deplace en marchant sur "+NombreDeJambes+" jambes");
        }
    }

    public class Singe : Animal
    {
        public Singe(string name) : base("singe", 4)
        {
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Move()
        {
            Console.WriteLine("Le " + Name + " se deplace en marchant à " + NombreDeJambes + " pattes");
        }
    }

    public class Elephant : Animal
    {
        public Elephant() : base("éléphant", 2)
        {
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Move()
        {
            Console.WriteLine("L'" + Name + " se deplace en marchant à " + NombreDeJambes + " pattes");
        }
    }

    public class Tortue : Animal
    {
        public Tortue(string name) : base("Tortue", 4)
        {
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Move()
        {
            Console.WriteLine("La " + Name + " se deplace en marchant à " + NombreDeJambes + " pattes ou en nageant");
        }
    }

    public class Lezard : Animal
    {
        public Lezard(string name) : base(name, 2)
        {
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Move()
        {
            Console.WriteLine("La " + Name + " se deplace en marchant à " + NombreDeJambes + " pattes ou en nageant");
        }
    }
}
