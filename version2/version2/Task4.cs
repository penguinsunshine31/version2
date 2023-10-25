using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version2
{
    public class Task4
    {

        abstract class Bird
        {
            public abstract string MakeSound();
        }

        class Sparrow : Bird
        {
            public override string MakeSound()
            {
                return "Chirp";
            }
        }

        class Pigeon : Bird
        {
            public override string MakeSound()
            {
                return "Coo";
            }
        }



        public void task4()
        {
            Bird sparrow = new Sparrow();
            Bird pigeon = new Pigeon();

            Console.WriteLine("Sparrow makes the sound: " + sparrow.MakeSound());
            Console.WriteLine("Pigeon makes the sound: " + pigeon.MakeSound());




        }













    }
}
