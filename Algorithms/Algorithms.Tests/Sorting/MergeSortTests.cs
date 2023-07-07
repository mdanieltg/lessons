using Algorithms.Classlib.Sorting;

namespace Algorithms.Tests.Sorting;

public class MergeSortTests
{
    [TestCase(new[] { 14, -58, 96, 98, -78, -26, -19, 77, 63, 24 }, new[] { -78, -58, -26, -19, 14, 24, 63, 77, 96, 98 })]
    [TestCase(new[] { -5, 15, 12, 11, -3, 6, 7, 10, -4, -6, 0 }, new[] { -6, -5, -4, -3, 0, 6, 7, 10, 11, 12, 15 })]
    [TestCase(new[] { 14, -3, 13, 1, 6, -13, -9, -14, -8, 2, 4, -6, -5, 11, -15, 5, -4, 10, 3, -12, 8, 12, -11, 9, -10, 0, -1, 15, 7 }, new[] { -15, -14, -13, -12, -11, -10, -9, -8, -6, -5, -4, -3, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })]
    public void Sort_SortsArrayWithUniqueElements(int[] arrayToSort, int[] sortedArray)
    {
        // Act
        var result = MergeSort.Sort(arrayToSort);

        // Assert
        CollectionAssert.AreEqual(sortedArray, result);
    }

    [TestCase(new[] { 2, -84, -53, 7, -70, -2, 83 }, new[] { -84, -70, -53, -2, 2, 7, 83 })]
    [TestCase(new[] { 41, 1, 94, 32, 12, 81, 81, 35, 100, 13, 2, 64, 66, 71, 6 }, new[] { 1, 2, 6, 12, 13, 32, 35, 41, 64, 66, 71, 81, 81, 94, 100 })]
    [TestCase(new[] { 53, 41, 54, 27, 68, 94, 41, 76, 22, 90, 97, 64, 53, 20, 67, 100, 72, 98, 91, 605, 57, 69, 6, 14, 63, 19, 3, 38, 45, 215, 83 }, new[] { 3, 6, 14, 19, 20, 22, 27, 38, 41, 41, 45, 53, 53, 54, 57, 63, 64, 67, 68, 69, 72, 76, 83, 90, 91, 94, 97, 98, 100, 215, 605 })]
    public void Sort_SortsArrayWithRepeatedElements(int[] arrayToSort, int[] sortedArray)
    {
        // Act
        var result = MergeSort.Sort(arrayToSort);

        // Assert
        CollectionAssert.AreEqual(sortedArray, result);
    }

    [TestCase(new[] { 6 }, new[] { -2, 9 }, new[] { -2, 6, 9 })]
    [TestCase(new[] { 4, 7, 8 }, new[] { 13, 14 }, new[] { 4, 7, 8, 13, 14 })]
    [TestCase(new[] { 2, 3 }, new[] { 5, 7, 11 }, new[] { 2, 3, 5, 7, 11 })]
    [TestCase(new[] { -15, 15 }, new[] { -10, -8, 14 }, new[] { -15, -10, -8, 14, 15 })]
    [TestCase(new[] { -15, 0, 15 }, new[] { -2, 3, 5 }, new[] { -15, -2, 0, 3, 5, 15 })]
    public void Merge_MergesArraysWithUniqueElements(int[] leftArray, int[] rightArray, int[] mergedArray)
    {
        // Act
        var result = MergeSort.Merge(leftArray, rightArray);

        // Assert
        CollectionAssert.AreEqual(mergedArray, result);
    }

    [TestCase(new[] { -11, -10, -9 }, new[] { -11, -4 }, new[] { -11, -11, -10, -9, -4 })]
    [TestCase(new[] { -13, -13, -8 }, new[] { -12, -8, -6 }, new[] { -13, -13, -12, -8, -8, -6 })]
    [TestCase(new[] { 2, 2 }, new[] { -14, 3, 3 }, new[] { -14, 2, 2, 3, 3 })]
    public void Merge_MergesArraysWithRepeatedElements(int[] leftArray, int[] rightArray, int[] mergedArray)
    {
        // Act
        var result = MergeSort.Merge(leftArray, rightArray);

        // Assert
        CollectionAssert.AreEqual(mergedArray, result);
    }
}
