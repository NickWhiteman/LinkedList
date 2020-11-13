using NUnit.Framework;
using LinkedList;

namespace LinkedList.Test
{
    public class Tests
    {
        [TestCase(new int[] { 1, 2, 3 }, 1, 4, new int[] { 1, 4, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { }, 0, 4, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 0, 4, new int[] { 4, 1 })]
        public void AddByIndexTest(int[] array, int index, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 1, 2, 3, 0 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3, 3 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 1, 0 })]
        public void AddByEnd(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddByEnd(value);

            Assert.AreEqual(expected, actual);
        }
    }
}