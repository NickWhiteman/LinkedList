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
        [TestCase(new int[] { 1, 2, 3, 4, 6, 8 }, 4, new int[] { 1, 2, 3, 4, 6, 8, 4 })]
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

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 0, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 3, new int[] { 3, 1, 2, 3 })]
        [TestCase(new int[] { }, 4, new int[] { 4 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 0, 1 })]
        public void AddByStart(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddByStart(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveByEnd(int[] array, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveByEnd();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveByStart(int[] array, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveByStart();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 6, 1, 5, 0 }, 2, new int[] { 2, 6, 5, 0 })]
        [TestCase(new int[] { 1, 43, 35, 99, 23 }, 4, new int[] { 1, 43, 35, 99 })]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, 1, new int[] { 23, -84, 34, 54 })]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, 3, new int[] { -23, -12, -45, 0 })]
        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { 1, 2, 3 }, 0, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, 0, new int[] { })]
        public void RemoveByIndex(int[] array, int index, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1 }, 1)]
        public void GetLength(int[] array, int expLength)
        {
            int expected = expLength;
            LinkedList actual = new LinkedList(array);

            int result = actual.GetLength();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void Reverse(int[] array, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1, 5, new int[] { 1, 5, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 4, new int[] { 4, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3 }, 2, 8, new int[] { 1, 2, 8 })]
        [TestCase(new int[] { 1, 2, 3 }, 1, 10, new int[] { 1, 10, 3 })]
        [TestCase(new int[] { 1 }, 0, 2, new int[] { 2 })]
        public void ChangeIndex(int[] array, int index, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.ChangeIndex(index, value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, 99)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, 54)]
        [TestCase(new int[] { -23, -45, -12, -1, 0 }, 0)]
        public void GetMaxItem(int[] array, int expMax)
        {
            int expected = expMax;
            LinkedList actual = new LinkedList(array);

            int result = actual.GetMaxItem();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, 1)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, -84)]
        [TestCase(new int[] { -23, -45, -12, -1, 0 }, -45)]
        public void GetMinItem(int[] array, int expMin)
        {
            int expected = expMin;
            LinkedList actual = new LinkedList(array);

            int result = actual.GetMinItem();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, 2)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, 4)]
        [TestCase(new int[] { -23, -45, -12, -1, 0 }, 4)]
        public void GetIndexMaxItem(int[] array, int expMax)
        {
            int expected = expMax;
            LinkedList actual = new LinkedList(array);

            int result = actual.GetIndexMaxItem();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, 0)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, 2)]
        [TestCase(new int[] { -23, -45, -12, -1, 0 }, 1)]
        public void GetIndexMinItem(int[] array, int expMin)
        {
            int expected = expMin;
            LinkedList actual = new LinkedList(array);

            int result = actual.GetIndexMinItem();

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 2, 3, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 2, 6, 1, 5, 0 }, new int[] { 0, 1, 2, 5, 6 })]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, new int[] { 1, 23, 35, 43, 99 })]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, new int[] { -84, -12, 23, 34, 54 })]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, new int[] { -45, -23, -12, -1, 0 })]
        public void SortLayout(int[] array, int[] expArr)
        {
            LinkedList expected = new LinkedList(expArr);
            LinkedList actual = new LinkedList(array);

            actual.SortLayout();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 3, 1 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 2, 6, 1, 5, 0 }, new int[] { 6, 5, 2, 1, 0 })]
        [TestCase(new int[] { 1, 43, 99, 35, 23 }, new int[] { 99, 43, 35, 23, 1 })]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, new int[] { 54, 34, 23, -12, -84 })]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, new int[] { 0, -1, -12, -23, -45 })]
        public void SortDecrease(int[] array, int[] expArr)
        {
            LinkedList expected = new LinkedList(expArr);
            LinkedList actual = new LinkedList(array);

            actual.SortDecrease();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 1, 3 })]
        [TestCase(new int[] { 2, 6, 1, 5, 0 }, 5, new int[] { 2, 6, 1, 0 })]
        [TestCase(new int[] { 1, 43, 35, 99, 23 }, 99, new int[] { 1, 43, 35, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, -12, new int[] { 23, -84, 34, 54 })]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, 0, new int[] { -23, -12, -45, -1 })]
        public void RemoveItemFirstValue(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveItemFirstValue(value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 2, 1)]
        [TestCase(new int[] { 2, 6, 1, 5, 0 }, 5, 3)]
        [TestCase(new int[] { 1, 43, 35, 99, 23 }, 99, 3)]
        [TestCase(new int[] { 23, -12, -84, 34, 54 }, -12, 1)]
        [TestCase(new int[] { -23, -12, -45, -1, 0 }, 0, 4)]
        public void GetIndexByValue(int[] array, int value, int expArr)
        {
            int expected = expArr;
            LinkedList actual = new LinkedList(array);

            int result = actual.GetIndexByValue(value);

            Assert.AreEqual(expected, result);
        }



        [TestCase(new int[] { 1, 2, 2 }, 2, new int[] { 1 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 6, new int[] { 2, 1, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 99, new int[] { 1, 35, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, -12, new int[] { 23, -84, 34 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 0, new int[] { -12, -45, -1 })]
        public void RemoveItemByValueAll(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveItemByValueAll(value);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 1, 2, 3 }, 2, 3)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 4, 0)]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 3, 99)]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, 3, 34)]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 0, 0)]
        public void AccessByIndex(int[] array, int index, int exp)
        {
            int expected = exp;
            LinkedList actual = new LinkedList(array);

            int result = actual.AccessByIndex(index);

            Assert.AreEqual(expected, result);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, -2, 1 }, new int[] { 1, 2, 3, 3, -2, 1 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, new int[] { 5, 2, 1, 0 }, new int[] { 2, 6, 1, 6, 0, 5, 2, 1, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, new int[] { 43, 22, 12 }, new int[] { 1, 99, 35, 99, 23, 43, 22, 12 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, new int[] { 32, 1, 2, 3 }, new int[] { 23, -12, -84, 34, -12, 32, 1, 2, 3 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, new int[] { 3, -4, 21 }, new int[] { 0, -12, -45, -1, 0, 3, -4, 21 })]
        public void AddArrayInEnd(int[] array, int[] AddArr, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddArrayInEnd(AddArr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, -2, 1 }, new int[] { 3, -2, 1, 1, 2, 3 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, new int[] { 5, 2, 1, 0 }, new int[] { 5, 2, 1, 0, 2, 6, 1, 6, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, new int[] { 43, 22, 12 }, new int[] { 43, 22, 12, 1, 99, 35, 99, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, new int[] { 32, 1, 2, 3 }, new int[] { 32, 1, 2, 3, 23, -12, -84, 34, -12 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, new int[] { 3, -4, 21 }, new int[] { 3, -4, 21, 0, -12, -45, -1, 0 })]
        public void AddArrayInFirst(int[] array, int[] AddArr, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddArrayInFirst(AddArr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, -2, 1 }, 1, new int[] { 1, 3, -2, 1, 2, 3 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, new int[] { 5, 2, 1, 0 }, 3, new int[] { 2, 6, 1, 5, 2, 1, 0, 6, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, new int[] { 43, 22, 12 }, 4, new int[] { 1, 99, 35, 99, 43, 22, 12, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, new int[] { 32, 1, 2, 3 }, 1, new int[] { 23, 32, 1, 2, 3, -12, -84, 34, -12 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, new int[] { 3, -4, 21 }, 4, new int[] { 0, -12, -45, -1, 3, -4, 21, 0 })]
        public void AddArrayByIndex(int[] array, int[] AddArr, int index, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.AddArrayByIndex(AddArr, index);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 3, new int[] { 2, 6 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 2, new int[] { 1, 99, 35 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, 5, new int[] { })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 4, new int[] { 0 })]
        public void RemoveByEndItems(int[] array, int quantity, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveByEndItems(quantity);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1, new int[] { 2, 3 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 3, new int[] { 6, 0 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 2, new int[] { 35, 99, 23 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, 5, new int[] { })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 4, new int[] { 0 })]
        public void RemoveByFirstItems(int[] array, int quantity, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveByFirstItems(quantity);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1, 1, new int[] { 1, 3 })]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, 3, 2, new int[] { 2, 6, 1 })]
        [TestCase(new int[] { 1, 99, 35, 99, 23 }, 2, 3, new int[] { 1, 99 })]
        [TestCase(new int[] { 23, -12, -84, 34, -12 }, 4, 1, new int[] { 23, -12, -84, 34 })]
        [TestCase(new int[] { 0, -12, -45, -1, 0 }, 0, 5, new int[] { })]
        public void RemovByIndexItems(int[] array, int index, int quantity, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);

            actual.RemovByIndexItems(index, quantity);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 1, 2, 3 }, 5, 1)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, -1, 2)]
        public void AddByIndex(int[] array, int index, int value)
        {
            try
            {
                LinkedList actual = new LinkedList(array);
                actual.AddByIndex(index, value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


        [TestCase(new int[] { 1, 2, 3 }, 5, 1)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, -1, 2)]
        public void AddByIndexNegative(int[] array, int index, int value)
        {
            try
            {
                LinkedList actual = new LinkedList(array);
                actual.AddByIndex(index, value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }



        [TestCase(new int[] { 1, 2, 3 }, 5)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, -1)]
        public void RemoveByIndexNegative(int[] array, int index)
        {
            try
            {
                LinkedList actual = new LinkedList(array);
                actual.RemoveByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }



        [TestCase(new int[] { 1, 2, 3 }, 5, 2)]
        [TestCase(new int[] { 2, 6, 1, 6, 0 }, -1, 8)]
        public void ChangeIndexNegative(int[] array, int index, int value)
        {
            try
            {
                LinkedList actual = new LinkedList(array);
                actual.ChangeIndex(index, value);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[0] { })]
        public void AddArrayInEndNegative(int[] array, int[] arr)
        {
            try
            {
                LinkedList actual = new LinkedList(array);
                actual.AddArrayInEnd(arr);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[0] { })]
        public void AddArrayInFirstNegative(int[] array, int[] arr)
        {
            try
            {
                LinkedList actual = new LinkedList(array);
                actual.AddArrayInFirst(arr);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }




        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }, -1)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }, 4)]
        public void AddArrayByIndexNegative(int[] array, int[] arr, int index)
        {
            try
            {
                LinkedList actual = new LinkedList(array);
                actual.AddArrayByIndex(arr, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }



    }
}