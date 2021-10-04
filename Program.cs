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
            List<Animal> animaux = new List<Animal>{ new Humain(), new Elephant(), new Singe(), new Serpent(), new Tortue(), new Lezard()  };

            foreach (Animal animal in animaux)
            {
                animal.Eat();
                animal.Move();
                animal.ModeDeGestation();
            }
                

            Console.ReadKey();
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

        public virtual void ModeDeGestation()
        {

        }

        public virtual void Move()
        {
            Console.WriteLine("L'animal de l'espèce ");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Les "+Name+"s mangent par la bouche.");
        }

    }

    public abstract class Mammifere : Animal
    {

        public Mammifere(string name, int nombreDeJambes) : base(name, nombreDeJambes)
        {
        }

        public override void ModeDeGestation()
        {
            Console.WriteLine("Les Mammifères sont des vivipares");
        }

        public override void Move()
        {
            base.Move();
        }

        public virtual void Eat()
        {
            base.Eat();
        }

    }

    public class Humain : Mammifere
    {
        public Humain() : base("Homme", 2)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("L'" + Name + " mange avec des couverts");
        }

        public override void Move()
        {
            Console.WriteLine("L'" + Name + " se deplace en marchant sur " + NombreDeJambes + " jambes");
        }
    }

    public class Singe : Mammifere
    {
        public Singe() : base("singe", 4)
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
        public Elephant() : base("éléphant", 4)
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


    public class Reptile : Animal
    {
        public Reptile(string name, int nombreDeJambes) : base(name, nombreDeJambes)
        {
        }


        public override void ModeDeGestation()
        {
            Console.WriteLine("L'animal "+ Name+ " est un ovipare !!");
        }

        public override void Move()
        {
            Console.WriteLine("La " + Name + " se deplace en marchant à " + NombreDeJambes + " pattes ou en nageant");
        }
    }

    public class Tortue : Reptile
    {
        public Tortue() : base("Tortue", 4)
        {
        }

        public override void Eat()
        {
            base.Eat();
        }
    }

    public class Lezard : Reptile
    {
        public Lezard() : base("Lézard", 4)
        {
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Move()
        {
            Console.WriteLine("Le " + Name + " se deplace en marchant à " + NombreDeJambes + " pattes ou en nageant");
        }
    }

    public class Serpent : Reptile
    {
        public Serpent() : base("serpent", 0)
        {
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Move()
        {
            Console.WriteLine("Le " + Name + " se deplace en serpentant qui comme son nom l'indique, à la même racine que le mot serpent");
        }
    }
}
