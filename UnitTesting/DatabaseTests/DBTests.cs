namespace DatabaseTests
{
    using DatabaseExample;
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Reflection;

    [TestFixture]
    public class DBTests
    {
        private const int arrSize = 16;
        private const int initialArrIndex = -1;

        [Test]
        public void EmptyConstructorShouldInitializeData()
        {
            Database database = new Database();

            Type type = typeof(Database);

            int[] field = (int[])type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "data")
                .GetValue(database);

            int lenght = field.Length;

            Assert.That(lenght, Is.EqualTo(arrSize));
        }

        [Test]
        public void EmptyConstructorShouldInitializeIndexToMinusOne()
        {
            Database database = new Database();

            Type type = typeof(Database);

            int indexValue = (int)type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(database);
            
            Assert.That(indexValue, Is.EqualTo(initialArrIndex));
        }

        [Test]
        public void CtorShouldThrowInvalidOperationExceptionWithLargerArray()
        {
            int[] arr = new int[arrSize + 1];
            Assert.Throws<InvalidOperationException>(() => new Database(arr));
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void CtorShouldSetIndexCorrectly(int[] values)
        {
            Database database = new Database(values);

            int expectedIndex = values.Length - 1;
            Type type = typeof(Database);

            int index = (int)type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(database);

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
        public void AddShouldIncreaceIndexCorrectly(int[] values)
        {
            Database database = new Database(values);

            Type type = typeof(Database);

            database.Add(16);

            int index = (int)type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(database);

            int expectedIndex = values.Length;

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void AddWhenDatabaseIsFullShouldThrowInvalidOperationException()
        {
            int[] arr = new int[16];

            Database database = new Database(arr);
            
            Assert.Throws<InvalidOperationException>(() => database.Add(1));
        }

        [Test]
        public void RemoveShouldDecreaceIndex()
        {
            int[] arr = new int[10];

            Database database = new Database(arr);

            Type type = typeof(Database);

            database.Remove();

            int index = (int)type
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "index")
                .GetValue(database);

            int expectedIndex = arr.Length - 2;

            Assert.That(index, Is.EqualTo(expectedIndex));
        }

        [Test]
        public void RemoveFromEmptyDatabaseShouldThrowInvalidOperationException()
        {
            Database database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
    }
}
