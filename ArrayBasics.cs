using System.Collections;

public class ArrayBasics{

    // Quick Sort, Merge Sort,... etc these works with O(nlogn)
    public int LargestElementInArray(int[] array)
    {
        Array.Sort(array);
        return array[array.Length-1];
    }

    // O(n) optimal solution
    public int LargestElementInArrayV1(int[] array){
        int max = int.MinValue;
        int i = 0;
        while(i<array.Length){
            if(array[i]>max)
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
        while(i>0){
            if(array[i]!=array[i-1]){
                return array[i-1];
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
        int i = 0 ;
        while(i<array.Length){
            if(array[i]>secondLargest && array[i] != largest)
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
            if(array[i]>largest){
                secondLargest = largest;
                largest = array[i];
            }
            else if(array[i]<largest && array[i]>secondLargest){
                secondLargest = array[i];
            }
            i++;
        }
        return secondLargest;
    }

    // O(n)
    public bool IsSorted(int[] array){
        int i=0;
        while(i<array.Length-1){
            if(array[i]>array[i+1]){
                return false;
            }
            i++;
        }
        return true;
    }

    // O(n) iterations , space => O(n)
    public int[] RemoveDuplicates(int[] array){
        // HashSet<int> ints = new HashSet<int>();
        // for(int i=0;i<array.Length;i++){
        //     ints.Add(array[i]);
        // }
        // return ints.ToArray();
        return new HashSet<int>(array).ToArray();
    }

    // same as above but O(n^2) just for seaching (Contains Method) 
    public int[] RemoveDuplicatesV1(int[] array){
        List<int> list = new();
        for(int i=0;i<array.Length;i++){
            if(!list.Contains(array[i])){
                list.Add(array[i]);
            }
        }
        return list.ToArray();
    }

    // Worst way of doing
    public int[] RemoveDuplicatesV2(int[] array){
        int length =0;
        int[] result = new int[length];
        int j =0;
        for(int i=0;i<array.Length;i++){
            if(!IsExist(result,array[i])){
                Array.Resize(ref result, length+1);
                result[j] = array[i];
                length++;
                j++;
            }
        }
        return result;
    }

    private bool IsExist(int[] array,int target){
        int i =0 ;
        while(i < array.Length){
            if(array[i]==target){
                return true;
            }
            i++;
        }
        return false;   
    }








    }