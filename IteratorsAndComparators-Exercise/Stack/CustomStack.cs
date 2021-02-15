using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private Note<T> top;

        public CustomStack()
        {
            this.top = null;
        }

        private class Note<T>
        {
            public Note(T element)
            {
                this.element = element;
                this.prev = null;
            }

            public T element { get; private set; }

            public Note<T> prev { get; set; }
        }

        public void Push(T element)
        {
            Note<T> newNote = new Note<T>(element);

            if (this.top == null)
            {
                this.top = newNote;
            }
            else
            {
                Note<T> currentTop = this.top;
                this.top = newNote;
                this.top.prev = currentTop;
            }
        }

        public T Pop()
        {
            if (this.top != null)
            {
                T returnValue = this.top.element;
                Note<T> current = this.top;
                this.top = this.top.prev;
                current = null;
                return returnValue;
            }

            throw new InvalidOperationException("No elements");
        }

        public IEnumerator<T> GetEnumerator()
        {
            Note<T> current = this.top;

            while (current != null)
            {
                yield return current.element;

                current = current.prev;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
