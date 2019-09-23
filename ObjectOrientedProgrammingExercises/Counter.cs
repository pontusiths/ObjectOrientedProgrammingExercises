using System;

namespace ObjectOrientedProgrammingExercises
{
    //7 och 8
    public class Counter
    {
        private int counter;
        private static int numberOfCounters;
        public Counter()
        {
            counter = 0;
            numberOfCounters++;
        }

        public void Increase()
        {
            counter++;
        }

        public void Decrease()
        {
            counter--;
        }

        public void Print()
        {
            Console.WriteLine($"Counter is {counter}");
            Console.WriteLine($"Number of counters are {numberOfCounters}");
        }
    }
}