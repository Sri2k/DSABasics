internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[]{14,9,12,6,8,14,14,13};
        ArrayBasics arrayBasics = new ArrayBasics();
        var result = arrayBasics.SecondLargestElementInArrayV2(array);
        Console.WriteLine(result);




        // Sorting sorting = new();
        // var sortedArray = sorting.InsertionSort(array);
        // Console.WriteLine(string.Join("",sortedArray));
    }
    
}