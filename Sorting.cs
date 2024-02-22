public class Sorting{
    public int[] SelectionSort(int[] array){
        for(int i=0;i<array.Length-1;i++){
            Swap(array,i,MinIndex(array,i));
        }
        return array;
    }

    public int[] InsertionSort(int[] array){
        for(int i=0;i<array.Length;i++){
            for(int j= i + 1; j>0;j--){
                if(array[j]<array[j-1]){
                    Swap(array,j,j-1);
                }
            }
        }
        return array;
    }
    public int[] BubbleSort(int[] array){
        for(int i=0;i<array.Length;i++){
            for(int j=0;j<array.Length-i;j++){
                if(array[i]>array[j]){
                    Swap(array, i, j);
                }
            }
        }
        return array;
    }

    private int MinIndex(int[] array,int firstIndex){
        int minIndex = firstIndex;
        for(int i= firstIndex+1; i<array.Length;i++){
            if(array[i]<array[minIndex]){
                minIndex = i;
            }
        }
        return minIndex;
    }
    private void Swap(int[] array,int firstIndex,int secondIndex){
        var temp = array[secondIndex];
        array[secondIndex] = array[firstIndex];
        array[firstIndex] = temp;
    }
}