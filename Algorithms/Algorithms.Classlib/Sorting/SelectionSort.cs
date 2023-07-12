namespace Algorithms.Classlib.Sorting;

public static class SelectionSort
{
    public static void Sort(int[] array)
    {
        for (int indexA = 0; indexA <= array.Length - 2; indexA++)
        {
            int MinIndex = indexA;

            for (int indexB = indexA + 1; indexB < array.Length; indexB++)
                if (array[MinIndex] > array[indexB])
                    MinIndex = indexB;

            if (array[indexA] > array[MinIndex])
                (array[MinIndex], array[indexA]) = (array[indexA], array[MinIndex]);
        }
    }
}