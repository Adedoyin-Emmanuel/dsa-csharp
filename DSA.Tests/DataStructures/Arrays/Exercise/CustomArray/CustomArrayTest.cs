
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
}