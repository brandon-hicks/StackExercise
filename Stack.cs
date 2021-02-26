using System;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {
        private List<object> value = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot add a null value to this list.");
            }
            value.Add(obj);
            int elements = value.Count;
            if (elements > 1)
            {
                for (int i = elements - 1; i > 0; i--)
                {
                    value[i] = value[i - 1];
                }
                value[0] = obj;
            }
        }

        public object Pop()
        {
            if(value.Count == 0)
                throw new InvalidOperationException("There is nothing here yet");
            object ToReturn = value[0];
            
            int element = value.Count;
            for (int i = 0; i < element; i++)
            {
                value[i] = (int)value[i + 1];
            }
            value.Remove(element - 1);
            return (ToReturn);
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