using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DotNet.Academic.DataStructures.Stack
{
    public class Stack
    {
        public IList<string> Items { get; private set; }

        public Stack()
        {
            this.Items = new List<string>();
        }


        public void Push(string value)
        {
            Items.Add(value);
        }

        public void Pop()
        {
            var last = this.Size() - 1;
            Items.RemoveAt(last);
        }

        public string Peek(string value)
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
            this.Items = new List<string>();
        }

        public int Size()
        {
            return this.Items.Count();
        }
    }
}
