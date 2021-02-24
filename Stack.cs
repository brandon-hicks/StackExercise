using System;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {
        private static List<object> value = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
               throw new InvalidOperationException();
            }
            else
                value.Add(obj);
        }

        public object Pop()
        {
            
            for (int i = value.Count - 1; i >= 0; i--)
            {
                if(value[i] == null)
                {
                    throw new InvalidOperationException();
                }
                return value[i];
            }
        }
    }
}