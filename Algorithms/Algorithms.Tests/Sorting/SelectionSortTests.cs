using Algorithms.Classlib.Sorting;

namespace Algorithms.Tests.Sorting;

public class SelectionSortTests
{
    [Test]
    public void Sort_SortsUniqueElements()
    {
        // Prepare
        var array = new[] { 9, 2, 8, 7, 1 };

        // Act
        SelectionSort.Sort(array);

        // Assert
        Assert.That(array[0], Is.EqualTo(1));
        Assert.That(array[1], Is.EqualTo(2));
        Assert.That(array[2], Is.EqualTo(7));
        Assert.That(array[3], Is.EqualTo(8));
        Assert.That(array[4], Is.EqualTo(9));
    }

    [Test]
    public void Sort_SortsRepeatedElements()
    {
        // Prepare
        var array = new[] { 1, 9, 5, 9, 10, 4, 2, 5, 9, 10 };

        // Act
        SelectionSort.Sort(array);

        // Assert
        Assert.That(array[0], Is.EqualTo(1));
        Assert.That(array[1], Is.EqualTo(2));
        Assert.That(array[2], Is.EqualTo(4));
        Assert.That(array[3], Is.EqualTo(5));
        Assert.That(array[4], Is.EqualTo(5));
        Assert.That(array[5], Is.EqualTo(9));
        Assert.That(array[6], Is.EqualTo(9));
        Assert.That(array[7], Is.EqualTo(9));
        Assert.That(array[8], Is.EqualTo(10));
        Assert.That(array[9], Is.EqualTo(10));
    }
}
