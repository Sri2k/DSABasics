internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[]{14,9,15,12,6,8,13};
        Sorting sorting = new();
        var sortedArray = sorting.InsertionSort(array);
        Console.WriteLine(string.Join("",sortedArray));
    }
    
}