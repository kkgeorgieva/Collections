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
            Assert.That(nums.ToString(), Is.EqualTo( "[]"));
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
        public void TestCollectionAdd() { 
         
            var nums = new Collection<int>(5);
            nums.Add(1);
            Assert.That(nums.Count,Is.EqualTo(2));
        
        }

        [Test]
        public void TestCollectionAddRange() {
        
            //Arrange
            var nums = new Collection<int>(5,3,4);
            int[] numsToAdd = new int[] {1,2,3};

            //Act
            nums.AddRange(numsToAdd);
            //Assert
            Assert.That(nums.Count, Is.EqualTo(6));
           

        }

    }


}