using System;

namespace ObjectOrientedProgrammingExercises
{
    internal class PancakeRecipe
    {
        
        private double requiredDecilitresOfFlour = 2.5;
        private double requiredDecilitresOfmilk = 6;
        private int requirednumberOfEggs = 3;
        private double requiredTablespoonsOfSalt = 0.5;
        private double requiredGramsOfButter = 50;

        private double availableDecilitresOfFlour = 5;
        private double availableDecilitresOfmilk = 12;
        private int availablenumberOfEggs = 6;
        private double availableTablespoonsOfSalt = 1;
        private double availableGramsOfButter = 150;

        //12
        public void MakeAllThePancakes()
        {
            if (CanMakePancakes() == false)
                return;
                            
            MakePancakes();
            MakeAllThePancakes();
        }

        public bool CanMakePancakes()
        {
            return availableDecilitresOfFlour >= requiredDecilitresOfFlour &&
                availableDecilitresOfmilk >= requiredDecilitresOfmilk &&
                availablenumberOfEggs >= requirednumberOfEggs &&
                availableTablespoonsOfSalt >= requiredTablespoonsOfSalt &&
                availableGramsOfButter >= requiredGramsOfButter;
        }

        public void MakePancakes()
        {
            if (CanMakePancakes() == false)
            {
                Console.WriteLine("You dont have enough ingredients");
                return;
            }

            availableDecilitresOfFlour -= requiredDecilitresOfFlour;
            availableDecilitresOfmilk -= requiredDecilitresOfmilk;
            availablenumberOfEggs -= requirednumberOfEggs;
            availableTablespoonsOfSalt -= requiredTablespoonsOfSalt;
            availableGramsOfButter -= requiredGramsOfButter;
            Console.WriteLine("Making pancakes");
        }
    }
}