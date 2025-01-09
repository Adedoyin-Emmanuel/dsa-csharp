using DSA.DSA.DataStructures.Arrays.Exercise.GenericArray;

namespace DSA.Tests.DataStructures.Arrays.Exercise.GenericArray;

public class GenericArrayTest
{
    private GenericArray<int> _numbers;
    
    [SetUp] 
    public void SetUp()
    {
        _numbers = new GenericArray<int>();
    }

    [Test]
    public void CountShouldReturnCorrectValueAfterInsertingElements()
    {
        _numbers.Insert(1);
        _numbers.Insert(2);
        _numbers.Insert(3);
        _numbers.Insert(4);
        
        
        Assert.That(_numbers.Count(), Is.EqualTo(4));
    }


    [Test]
    public void IndexOfShouldReturnCorrectIndex()
    {
        _numbers.Insert(5);
        _numbers.Insert(6);
        _numbers.Insert(10);
        
        Assert.That(_numbers.IndexOf(10), Is.EqualTo(2));
    }

    [Test]
    public void RemoveAtShouldRemoveArrayElement()
    {
        _numbers.Insert(20);
        _numbers.Insert(50);
        _numbers.Insert(60);
        
        _numbers.RemoveAt(1);
        
        /*
         * Numbers array should be 2 after removing an element
         */
        
        Assert.That(_numbers.Count(), Is.EqualTo(2));
    }
}