using Algorithms.Classlib.Sorting;

namespace Algorithms.Tests.Sorting;

public class MergeSortTests
{
    [TestCase(new[] { 53, 41, 54, 27, 68, 94, 41, 76, 22, 90, 97, 64, 53, 20, 67, 100, 72, 98, 91, 605, 57, 69, 6, 14, 63, 19, 3, 38, 45, 215, 83, 47, 56, 42 }, new[] { 3, 6, 14, 19, 20, 22, 27, 38, 41, 41, 42, 45, 47, 53, 53, 54, 56, 57, 63, 64, 67, 68, 69, 72, 76, 83, 90, 91, 94, 97, 98, 100, 215, 605 })]
    [TestCase(new[] { 41, 1, 94, 32, 12, 81, 81, 35, 100, 13, 2, 64, 66, 71, 6 }, new[] { 1, 2, 6, 12, 13, 32, 35, 41, 64, 66, 71, 81, 81, 94, 100 })]
    [TestCase(new[] { 14, -58, 96, 98, -78, -26, -19, 77, 63, 24 }, new[] { -78, -58, -26, -19, 14, 24, 63, 77, 96, 98 })]
    public void Sort_SortsAlphabetically(int[] arrayToSort, int[] sortedArray)
    {
        // Act
        var result = MergeSort.Sort(arrayToSort);

        // Assert
        CollectionAssert.AreEqual(sortedArray, result);
    }
}
