
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
    
    
    // [Test]
    // public void 
}