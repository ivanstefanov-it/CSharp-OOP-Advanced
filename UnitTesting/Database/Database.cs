namespace DatabaseExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Database
    {
        private const int Capacity = 16;
        private int[] data;
        private int index;

        public Database()
        {
            this.data = new int[Capacity];
            this.index = -1;
        }

        public Database(int[] data)
            :this()
        {
            if (data.Length > 16)
            {
                throw new InvalidOperationException("Database capacity should be 16 or less!");
            }

            for (int i = 0; i < data.Length; i++)
            {
                this.data[i] = data[i];
            }
            this.index = data.Length - 1;
        }

        public void Add(int number)
        {
            if (this.index < Capacity - 1)
            {
                this.data[++this.index] = number;
                return;
            }

            throw new InvalidOperationException("Database is full!");
        }

        public void Remove()
        {
            if (this.index == -1)
            {
                throw new InvalidOperationException("Database is empty!");
            }
            
            this.index--;
        }

        public int[] Fetch()
        {
            return this.data.Take(this.index + 1).ToArray();
        }
    }
}
