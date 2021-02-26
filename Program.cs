using System;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            int max = 5;

            for(int i = 0; i <= max; i++)
            {
                stack.Push(i);
            }

            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            
        }
    }
}
