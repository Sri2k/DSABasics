internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[]{1,5,4,3,2};
        Sorting sorting = new();
        var sortedArray = sorting.BubbleSort(array);
        Console.WriteLine(string.Join("",sortedArray));
    }
    
}