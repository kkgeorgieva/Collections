using Collections;
using NUnit.Framework;
using System.Globalization;

namespace Collection.Tests
{
    public class CollectionTests
    {


        [Test]
        public void TestEmptyConstructor()
        {
            //Arrange
            var nums = new Collection<int>();
            //Act 

            //Assert
            Assert.AreEqual(0, nums.Count);
            Assert.AreEqual(16, nums.Capacity);
            Assert.That(nums.ToString(), Is.EqualTo("[]"));
        }

        [Test]
        public void TestConstrucotrSingleItem()
        {
            //Arrange
            var nums = new Collection<int>(5);
            //Act 

            //Assert
            Assert.That(nums.ToString, Is.EqualTo("[5]"));

        }

        [Test]
        public void TestCollectionAdd()
        {

            var nums = new Collection<int>(5);
            nums.Add(1);
            Assert.That(nums.Count, Is.EqualTo(2));

        }

        [Test]
        public void TestCollectionAddRange()
        {

            //Arrange
            var nums = new Collection<int>(5, 3, 4);
            int[] numsToAdd = new int[] { 1, 2, 3 };

            //Act
            nums.AddRange(numsToAdd);
            //Assert
            Assert.That(nums.Count, Is.EqualTo(6));


        }
        [Test]
        public void TestEnsureCapacity()
        {

            //Arrange
            var nums = new Collection<int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            //Act
            nums.Add(17);

            //Assert
            Assert.That(nums.Capacity, Is.EqualTo(32));
        }

        [Test]
        public void TestClear()
        {

            //Arrange
            var nums = new Collection<int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            //Act
            nums.Clear();

            //Assert
            Assert.That(nums.Count, Is.EqualTo(0));
        }

        [Test]
        [Timeout(5000)] // used so it doesnt take forever

        public void TestCollection1ThousandItems()
        {

            const int itemsCount = 1000; // 
            var nums = new Collection<int>();
            nums.AddRange(Enumerable.Range(1, itemsCount).ToArray()); // adding all numbers from 1 to 1000 to the collection
            Assert.That(nums.Count == itemsCount);
            Assert.That(nums.Capacity >= nums.Count);
            for (int i = itemsCount - 1; i >= 0; i--)
            {
                nums.RemoveAt(i);
            }
            Assert.That(nums.ToString() == "[]");
            Assert.That(nums.Capacity >= nums.Count);
        }


        [TestCase("Peter", 0, "Peter")]
        [TestCase("Peter, Maria , George", 0, "Peter")]
        [TestCase("Peter, Maria, George", 1, "Maria")]
        [TestCase("Peter, Maria, George", 2, "George")]

        //Defining the values from the testcase in the method braces
        public void TestCollectionGetByValidIndex(String data, int index, String expectedValue)
        {
            //Arrange
            var nums = new Collection<String>(data.Split(", "));

            //Act 
            var actual = nums[index];

            //Assert
            Assert.That(actual, Is.EqualTo(expectedValue));

        }

    }
}