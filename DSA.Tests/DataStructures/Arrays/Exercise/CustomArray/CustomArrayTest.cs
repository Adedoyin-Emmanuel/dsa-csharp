
using NUnit.Framework.Internal;

namespace DSA.Tests.DataStructures.Arrays.Exercise.CustomArray;

public class CustomArrayTest
{
    private DSA.DataStructures.Arrays.Exercise.CustomArray.CustomArray _array;
    [SetUp]
    public void SetUp()
    {
       _array = new DSA.DataStructures.Arrays.Exercise.CustomArray.CustomArray();
    }


    [Test]
    public void CountShouldReturnCorrectValueAfterAddingElements()
    {
        
        _array.Insert(1);
        _array.Insert(2);
        _array.Insert(3);

        Assert.That(_array.Count(), Is.EqualTo(3));
    }


    [Test]
    public void IndexOfShouldReturnCorrectValue()
    {
        _array.Insert(23);
        _array.Insert(24);
        _array.Insert(25);
        
        int validElement = 25;
        
        Assert.That(_array.IndexOf(validElement), Is.EqualTo(2));
    }


    [Test]
    public void CountShouldReturnArraySize()
    {
        _array.Insert(2);
        _array.Insert(4);
        _array.Insert(10);
        
        
        Assert.That(_array.Count(), Is.EqualTo(3));
    }

    [Test]
    public void RemoveAtShouldRemoveElement()
    {
        _array.Insert(5);
        _array.Insert(4);
        _array.Insert(10);
        
        _array.RemoveAt(1);
        
        /*
         * Array count should be 2 after removing element at index 1
         */
        Assert.That(_array.Count(), Is.EqualTo(2));
    }

    [Test]
    public void MaxShouldReturnHighestNumberInTheArray()
    {
        _array.Insert(4);
        _array.Insert(100);
        _array.Insert(45);
        _array.Insert(23);
        
        
        Assert.That(_array.Max(), Is.EqualTo(100));
    }


    [Test]
    public void IntersectShouldReturnCommonItemsInTheArray()
    {
        var inputArray = new int[5]{2014, 2015, 2025, 2028, 2030};
        
        _array.Insert(2025);
        _array.Insert(2026);
        _array.Insert(2027);
        _array.Insert(2028);
        _array.Insert(2029);
        _array.Insert(2030);


        var result = _array.Intersect(inputArray);
        
        Assert.Multiple(() =>
        {
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(result.IndexOf(2025), Is.EqualTo(0));
            Assert.That(result.IndexOf(2028), Is.EqualTo(1));
            Assert.That(result.IndexOf(2030), Is.EqualTo(2));
        });
    }
}