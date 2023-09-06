using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPatternLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            OrcsAI orcsAI = new OrcsAI();
            MonstersAI monstersAI = new MonstersAI();

            orcsAI.TakeTurn();
            Console.WriteLine();
            monstersAI.TakeTurn();

            Console.Read();
        }
    }

    //abstract class
    abstract class GameAI
    {
        public void TakeTurn()
        {
            CollectResources();
            BuildStructures();
            BuildUnits();
            Attack();
            SendScouts();
            SendWarriors();
        }
        public virtual void CollectResources()
        {
            Console.WriteLine("You are collecting resources");
        }
        public abstract void BuildStructures();
        public abstract void BuildUnits();
        public virtual void Attack()
        {
            Console.WriteLine("You are attacking player");
        }
        public abstract void SendScouts();
        public abstract void SendWarriors();
        
    }

    //concrete class
    class OrcsAI : GameAI
    {
        public override void BuildStructures()
        {
            Console.WriteLine("Orcs are building orcs camps");
        }

        public override void BuildUnits()
        {
            Console.WriteLine("Orcs are building orc's soldiers");
        }

        public override void SendScouts()
        {
            Console.WriteLine("Orcs send goblin scouts");
        }

        public override void SendWarriors()
        {
            Console.WriteLine("Orcs send orc's warriors");
        }
    }
    
    //concrete class
    class MonstersAI : GameAI
    {
        public override void CollectResources ()
        {
            Console.WriteLine("Monsters collecting corpses as resources");
        }

        public override void BuildStructures()
        {
            Console.WriteLine("Monsters are building meat camps");
        }

        public override void BuildUnits()
        {
            Console.WriteLine("Monsters are building creatures of doom");
        }

        public override void SendScouts()
        {
            Console.WriteLine("Monsters send hounds of death");
        }

        public override void SendWarriors()
        {
            Console.WriteLine("Monsters send big meat ogre");
        }

    }
}
