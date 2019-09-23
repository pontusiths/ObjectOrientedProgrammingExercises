using System;

namespace ObjectOrientedProgrammingExercises
{
    //1
    public class Animal
    {
        
        public bool HasTail { get; private set; }
        public int NumberOfLegs { get; private set; }
        public string Name { get; private set; }

        //3
        public Animal(string name, bool hasTail, int numberOfLegs)
        {
            Name = name;
            HasTail = hasTail;
            NumberOfLegs = numberOfLegs;
            
        }
        
        //2
        public void PrintInfo()
        {
            Console.WriteLine
            (
                "Animal information." +
                $"Name: {Name}" +
                $"Legs: {NumberOfLegs}" + 
                $"Has tail: {HasTail}"
            );
        }
    }
}