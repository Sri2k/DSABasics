internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[]{1, 0 ,3, 0, 0, 4, 5 , 0 , 0};

        int[] arr1 = { 1, 1, 0, 1, 1, 1 };
        int[] arr2 = { 1, 0, 1, 1, 0, 1 };
        ArrayBasics arrayBasics = new ArrayBasics();
        var result = arrayBasics.maxConsecutiveOneV1(arr1);
        Console.WriteLine(result);




    }
    
}