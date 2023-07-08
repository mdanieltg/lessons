namespace Algorithms.Classlib.Sorting;

public static class MergeSort
{
    public static int[] Sort(int[] array)
    {
        // Base case
        if (array.Length == 1) return array;

        var mid = array.Length / 2;

        // Create arrays
        var leftArray = new int[mid];
        var rightArray = new int[array.Length - mid];

        // Fill arrays (effectively dividing main array by half)
        Array.Copy(array, leftArray, mid);
        Array.Copy(array, mid, rightArray, 0, rightArray.Length);

        // Call Sort on each side of the array, and merge them back together
        return Merge(Sort(leftArray), Sort(rightArray));
    }

    public static int[] Merge(int[] arrA, int[] arrB)
    {
        int index = 0, indexA = 0, indexB = 0;
        var array = new int[arrA.Length + arrB.Length];

        while (indexA < arrA.Length && indexB < arrB.Length)
        {
            if (arrA[indexA] < arrB[indexB])
                array[index++] = arrA[indexA++];

            else if (arrA[indexA] > arrB[indexB])
                array[index++] = arrB[indexB++];

            else
            {
                array[index++] = arrA[indexA++];
                array[index++] = arrB[indexB++];
            }
        }

        // Missing items from arrA
        if (indexA < arrA.Length)
            Array.Copy(arrA, indexA, array, index, arrA.Length - indexA);

        // Missing items from arrB
        if (indexB < arrB.Length)
            Array.Copy(arrB, indexB, array, index, arrB.Length - indexB);

        return array;
    }
}
