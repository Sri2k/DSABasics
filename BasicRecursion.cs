public class BasicRecursion{
    public void printNTimes(int n){
        if(n<1)
            return;
        Console.WriteLine(n);
        printNTimes(n-1);
        Console.WriteLine(n);
    }

    public void sumOfNNumbers(int n,int sum){
        if(n<1){
            Console.WriteLine(sum);
            return;
        }
        sumOfNNumbers(n-1,sum+n);
    }

    public int sumOfNNumbers(int n){
        if(n<1){
            return n;
        }
        return n + sumOfNNumbers(n-1);
    }


    public void factorial(int n,int absorber)
    {
        if (n < 2){
            Console.WriteLine(absorber);
            return;
        }
        factorial(n - 1, absorber*n);
    }
    public int factorial(int n)
    {
        if (n < 2)
            return 1;
        return factorial(n - 1)*n;
    }

    // 1 2 3 4 5 6 7
    public void reverseArray(int[] array, int start, int end)
    {
        if (array.Length / 2 <= start)
        {
            foreach (var item in array)
            {
                Console.Write(item);
            }
            return;
        }
        array[start] = array[start] + array[end];
        array[end] = array[start] - array[end];
        array[start] = array[start] - array[end];
        reverseArray(array, start + 1, end - 1);
    }
    // m a d a m
    // m a d k m
    public void isPalindrome(string input,int start,int end){
        if(start >= end){
            Console.WriteLine(true);
            return;
        }
        if(input[start] != input[end]){
            Console.WriteLine(false);
            return;
        }
        isPalindrome(input, start + 1, end - 1);
    }

    public int fibNumber(int n){
        if (n <= 1)
            return n; 
        return fibNumber(n - 1) + fibNumber(n - 2);
    }
}