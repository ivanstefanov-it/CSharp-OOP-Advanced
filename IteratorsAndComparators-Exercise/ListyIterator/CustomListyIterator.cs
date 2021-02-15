using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class CustomListyIterator<T>
    {
        private T[] array;
        private int index;

        public CustomListyIterator(T[] array)
        {
            this.array = array;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.index < this.array.Length - 1)
            {
                this.index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return this.index < this.array.Length - 1;
        }

        public void Print()
        {
            if (this.array.Length != 0)
            {
                Console.WriteLine(this.array[this.index]);
                return;
            }

            throw new InvalidOperationException("Invalid Operation!");
        }
    }
}
