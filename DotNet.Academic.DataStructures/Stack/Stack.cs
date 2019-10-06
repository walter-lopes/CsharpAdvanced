using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DotNet.Academic.DataStructures.Stack
{
    public class Stack<T>
    {
        public IList<T> Items { get; private set; }

        public Stack()
        {
            this.Items = new List<T>();
        }


        public void Push(T value)
        {
            Items.Add(value);
        }

        public T Pop()
        {
            var last = this.Size() - 1;
            var item = this.Items[last];
            Items.RemoveAt(last);

            return item;
        }

        public T Peek(T value)
        {
            var last = this.Size() - 1;
            return this.Items[last];
        }

        public bool IsEmpty()
        {
            return !this.Items.Any();
        }

        public void Clear()
        {
            this.Items = new List<T>();
        }

        public int Size()
        {
            return this.Items.Count();
        }
    }
}
