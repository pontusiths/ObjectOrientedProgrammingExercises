using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedProgrammingExercises
{
    //9 Oroa er inte om att man måste ha använt IEnumerable. Funktionaliten är det som räknas.
    public class Semaphore
    {
        private static Semaphore[] instances;

        private static int incrementedIndex = -1;
        private int index;
        private Semaphore()
        {
            index = ++incrementedIndex;
        }

        public static Semaphore Request()
        {
            if (instances == null)
            {
                instances = Enumerable.Repeat(new Semaphore(), 5).Cast<Semaphore>().ToArray();
            }
            return RequestEnumerable().ToList().FirstOrDefault();
        }

        private static IEnumerable<Semaphore> RequestEnumerable()
        {
            int foundIndex = -1;
            for (int i = 0; i < instances.Length; i++)
            {
                if (foundIndex >= 0 || instances[i] == null)
                    continue;

                foundIndex = i;
                yield return instances[i];
            }
            if (foundIndex >= 0)
            {
                instances[foundIndex] = null;
            }
        }

        public void Release()
        {
            instances[index] = this;
        }
    }
}