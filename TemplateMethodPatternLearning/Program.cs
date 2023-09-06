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
            WarriorTraining warriorTraining = new WarriorTraining();
            MageTraining mageTraining = new MageTraining();

            warriorTraining.Learn();
            Console.WriteLine();
            mageTraining.Learn();

            Console.Read();
        }
    }

    //abstract class
    abstract class Training
    {
        public void Learn()
        {
            Enter();
            Train();
            FinalFight();
            BecomeAMaster();
        }
        public abstract void Enter();
        public abstract void Train();
        public virtual void FinalFight()
        {
            Console.WriteLine("Fighting with the master");
        }
        public abstract void BecomeAMaster();
    }

    //concrete class
    class WarriorTraining : Training
    {
        public override void Enter()
        {
            Console.WriteLine("You enter the training field as a young soldier");
        }

        public override void Train()
        {
            Console.WriteLine("The great warrior teaching you how to use sword");
            Console.WriteLine("You are teaching how to patrol city");
        }

        public override void BecomeAMaster()
        {
            Console.WriteLine("You become a great swordmaster");
        }
    }
    
    //concrete class
    class MageTraining : Training
    {
        public override void Enter()
        {
            Console.WriteLine("You enter the mage colleague");
        }

        public override void Train()
        {
            Console.WriteLine("You choose the way of magic you will learn");
            Console.WriteLine("You are training with wizard and learning magic spells");
        }

        public override void FinalFight()
        {
            Console.WriteLine("The duel with the other magicians of various schools");
        }

        public override void BecomeAMaster()
        {
            Console.WriteLine("You become a wizard");
        }
    }
}
