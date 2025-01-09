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
}