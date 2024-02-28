using System.Collections;

public class ArrayBasics
{

    // Quick Sort, Merge Sort,... etc these works with O(nlogn)
    public int LargestElementInArray(int[] array)
    {
        Array.Sort(array);
        return array[array.Length - 1];
    }

    // O(n) optimal solution
    public int LargestElementInArrayV1(int[] array)
    {
        int max = int.MinValue;
        int i = 0;
        while (i < array.Length)
        {
            if (array[i] > max)
                max = array[i];
            i++;
        }
        return max;
    }

    // O(nlogn)+O(N) if that sorting is working like quick sort, merge sort etc...
    public int SecondLargestElementInArray(int[] array)
    {
        Array.Sort(array);
        int i = array.Length - 1;
        while (i > 0)
        {
            if (array[i] != array[i - 1])
            {
                return array[i - 1];
            }
            i--;
        }
        return array[i];
    }

    // O(n)+O(n) = O(n)
    public int SecondLargestElementInArrayV1(int[] array)
    {
        int largest = LargestElementInArrayV1(array);
        int secondLargest = int.MinValue;
        int i = 0;
        while (i < array.Length)
        {
            if (array[i] > secondLargest && array[i] != largest)
                secondLargest = array[i];
            i++;
        }
        return secondLargest;
    }

    // O(n)
    public int SecondLargestElementInArrayV2(int[] array)
    {
        int i = 1;
        int largest = array[0];
        int secondLargest = int.MinValue;
        while (i < array.Length)
        {
            if (array[i] > largest)
            {
                secondLargest = largest;
                largest = array[i];
            }
            else if (array[i] < largest && array[i] > secondLargest)
            {
                secondLargest = array[i];
            }
            i++;
        }
        return secondLargest;
    }

    // O(n)
    public bool IsSorted(int[] array)
    {
        int i = 0;
        while (i < array.Length - 1)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
            i++;
        }
        return true;
    }

    // O(n) iterations , space => O(n)
    public int[] RemoveDuplicates(int[] array)
    {
        // HashSet<int> ints = new HashSet<int>();
        // for(int i=0;i<array.Length;i++){
        //     ints.Add(array[i]);
        // }
        // return ints.ToArray();
        return new HashSet<int>(array).ToArray();
    }

    // same as above but O(n^2) just for seaching (Contains Method) 
    public int[] RemoveDuplicatesV1(int[] array)
    {
        List<int> list = new();
        for (int i = 0; i < array.Length; i++)
        {
            if (!list.Contains(array[i]))
            {
                list.Add(array[i]);
            }
        }
        return list.ToArray();
    }

    // Worst way of doing
    public int[] RemoveDuplicatesV2(int[] array)
    {
        int length = 0;
        int[] result = new int[length];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (!IsExist(result, array[i]))
            {
                Array.Resize(ref result, length + 1);
                result[j] = array[i];
                length++;
                j++;
            }
        }
        return result;
    }

    private bool IsExist(int[] array, int target)
    {
        int i = 0;
        while (i < array.Length)
        {
            if (array[i] == target)
            {
                return true;
            }
            i++;
        }
        return false;
    }

    // 1 0 2 0 3 4 5
    public int[] PushZerosToBack(int[] array)
    {
        int i = 0;
        int j = array.Length - 1;
        while (i < j)
        {
            if (array[i] != 0)
            {
                i++;
                continue; // Move to the next element
            }
            if (array[j] == 0)
            {
                j--;
                continue; // Move to the previous element
            }
            Swap(array, i, j);
            i++;
            j--;
        }
        return array;
    }

    public int[] PushZerosToBackV1(int[] array)
    {
        int left = 0; // Pointer for non-zero elements
        int right = 0; // Pointer for iterating through the array

        // Move non-zero elements to the beginning of the array
        while (right < array.Length)
        {
            if (array[right] != 0)
            {
                array[left++] = array[right];
            }
            right++;
        }

        // Fill the remaining array with zeroes
        while (left < array.Length)
        {
            array[left++] = 0;
        }

        return array;
    }


    private void Swap(int[] array, int firstIndex, int secondIndex)
    {
        var temp = array[secondIndex];
        array[secondIndex] = array[firstIndex];
        array[firstIndex] = temp;
    }

    public int[] UnionOfArrays(int[] array1, int[] array2)
    {
        int i = 0;
        int j = 0;
        HashSet<int> nonDuplicates = new();
        while (i < array1.Length)
        {
            nonDuplicates.Add(array1[i]);
            i++;
        }

        while (j < array2.Length)
        {
            nonDuplicates.Add(array2[j]);
            j++;
        }
        return nonDuplicates.ToArray();
    }

    public int[] UnionOfArraysV1(int[] array1, int[] array2)
    {
        return new HashSet<int>(array1.Concat(array2)).ToArray();
    }

    public int[] UnionOfArraysV2(int[] array1, int[] array2)
    {
        int max = array1.Length > array2.Length ? array1.Length : array2.Length;
        int min = array1.Length < array2.Length ? array1.Length : array2.Length;
        HashSet<int> nonDuplicates = new();
        for (int i = 0; i < max; i++)
        {
            if (i < min)
            {
                nonDuplicates.Add(array1[i]);
            }
            nonDuplicates.Add(array2[i]);
        }
        return nonDuplicates.ToArray();
    }

    public int[] UnionOfArraysV3(int[] array1, int[] array2)
    {
        HashSet<int> set = new();
        int i = 0, j = 0;
        while (i < array1.Length && j < array2.Length)
        {
            set.Add(array1[i++]);
            set.Add(array2[j++]);
        }
        while (i < array1.Length)
        {
            set.Add(array1[i++]);
        }
        while (j < array2.Length)
        {
            set.Add(array2[j++]);
        }
        return set.ToArray();
    }

    public int MissingNumber(int[] array, int n)
    {
        int i = 0;
        int counter = 1;
        while (counter <= n)
        {
            if (counter != array[i])
            {
                return counter;
            }
            counter++;
            i++;
        }
        return -1;
    }

    public int MissingNumberV1(int[] array, int n)
    {
        int i = 0;
        while (i < n)
        {
            if (array[i] != i + 1)
            {
                return i + 1;
            }
            i++;
        }
        return -1;
    }

    public int MissingNumberV2(int[] array, int n)
    {
        int i = 0;
        int sum = 0;
        while (i < array.Length)
        {
            sum += array[i];
            i++;
        }
        return (n * (n + 1)) / 2 - sum;
    }

    public int MissingNumberV3(int[] array, int n)
    {
        int[] hash = new int[n + 1];
        int i = 1;
        while (i < array.Length)
        {
            if (array[i - 1] == i)
            {
                hash[i] += hash[i] + 1;
            }
            i++;
        }
        i = 1;
        while (i < hash.Length)
        {
            if (hash[i] == 0)
            {
                return i;
            }
            i++;
        }
        return -1;
    }


    public int MissingNumberV4(int[] array, int N)
    {
        int xor1 = 0, xor2 = 0;
        for (int i = 0; i < N - 1; i++)
        {
            xor2 = xor2 ^ array[i]; // XOR of array elements
            xor1 = xor1 ^ (i + 1); //XOR up to [1...N-1]
        }
        xor1 = xor1 ^ N; //XOR up to [1...N]

        return xor1 ^ xor2;
    }

    public int maxConsecutiveOne(int[] array){
        List<int> counters = new();
        int counter = 0;
        for(int i = 0 ; i <array.Length ; i++){
            if(array[i] == 1)
                counter++;
            else{
                counters.Add(counter);
                counter = 0;
            }
        }
        counters.Add(counter);
        return counters.Max();
    }

    // int[] arr1 = { 1, 1, 0, 1, 1, 1 };
    public int maxConsecutiveOneV1(int[] array)
    {
        int i = 0;
        int counter  = 0;
        int previousMaxCount = 0;
        while(i < array.Length){
            if(array[i] == 1)
                counter++;
            else{
                previousMaxCount = counter > previousMaxCount ? counter : previousMaxCount;
                counter = 0;
            }
            i++;
            previousMaxCount = counter > previousMaxCount ? counter : previousMaxCount;

        }
        return previousMaxCount;
    }





    }