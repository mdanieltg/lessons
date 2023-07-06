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

        // Fill arrays (effectively dividing array by half)
        Array.Copy(array, leftArray, mid);
        Array.Copy(array, mid, rightArray, 0, rightArray.Length);

        // Recursively call MergeSort
        var newLeftArray = Sort(leftArray);
        var newRightArray = Sort(rightArray);

        // Merge and sort arrays
        return Merge(newLeftArray, newRightArray);
    }

    public static int[] Merge(int[] arrA, int[] arrB)
    {
        int index = 0, indexA = 0, indexB = 0;
        var array = new int[arrA.Length + arrB.Length];

        while (indexA < arrA.Length && indexB < arrB.Length)
        {
            var itemA = arrA[indexA];
            var itemB = arrB[indexB];

            if (itemA == itemB)
            {
                array[index++] = itemA;
                array[index++] = itemB;
                indexA++;
                indexB++;
            }
            else if (itemA < itemB)
            {
                array[index++] = itemA;
                indexA++;
            }
            else
            {
                array[index++] = itemB;
                indexB++;
            }
        }

        if (indexA < arrA.Length)
        {
            Array.Copy(arrA, indexA, array, index, arrA.Length - indexA);
        }

        else if (indexB < arrB.Length)
        {
            Array.Copy(arrB, indexB, array, index, arrB.Length - indexB);
        }

        return array;
    }
}
