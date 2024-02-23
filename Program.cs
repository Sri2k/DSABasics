internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[]{8,8,9,11,12,13,13,14,11};
        ArrayBasics arrayBasics = new ArrayBasics();
        var result = arrayBasics.RemoveDuplicatesV2(array);
        Console.WriteLine(result);




        // Sorting sorting = new();
        // var sortedArray = sorting.InsertionSort(array);
        // Console.WriteLine(string.Join("",sortedArray));
    }
    
}