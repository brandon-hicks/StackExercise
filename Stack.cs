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
                throw new InvalidOperationException();
            }
            value.Add(obj);  
        }

        public object Pop()
        {
            if(value.Count == 0)
            {
                throw new InvalidOperationException();
            }
            object result =  value[0];

            for (int i = 0; i <= value.Count; i++)
            {
                value[i] = (int)value[i + 1];
            }
            value.Remove(value.Count - 1);

            return result;
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