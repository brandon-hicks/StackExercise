using System;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {
        private readonly List<object> value = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot add a null value to this list.");
            }
            value.Add(obj);
        }

        public object Pop()
        {
            if(value.Count == 0)
                throw new InvalidOperationException("There is nothing here yet");

            var lastObj = value.Count - 1;

            var result = value[lastObj];
            
            value.RemoveAt(lastObj);
            return (result);
        }

        public void Clear()
        {
            for (int i = 0; i <= value.Count; i++)
            {
                value.RemoveAt(i);
            }
        }
    }
}