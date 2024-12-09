using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int target = 7;

        Console.WriteLine("Array: " + string.Join(", ", array));
        Console.WriteLine("Target: " + target);

        int linearResult = LinearSearch(array, target);
        Console.WriteLine($"Linear Search: Index of {target} is {linearResult}");

        int binaryResult = BinarySearch(array, target);
        Console.WriteLine($"Binary Search: Index of {target} is {binaryResult}");

        int interpolationResult = InterpolationSearch(array, target);
        Console.WriteLine($"Interpolation Search: Index of {target} is {interpolationResult}");
    }

    static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1; // Not found
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1; // Not found
    }

    static int InterpolationSearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high && target >= array[low] && target <= array[high])
        {
            if (low == high)
            {
                if (array[low] == target) return low;
                return -1;
            }

            int pos = low + ((target - array[low]) * (high - low) / (array[high] - array[low]));

            if (array[pos] == target)
            {
                return pos;
            }

            if (array[pos] < target)
            {
                low = pos + 1;
            }
            else
            {
                high = pos - 1;
            }
        }
        return -1; // Not found
    }
}
