public class Maths
{
    public void Reverse(int number)
    {
        int reverse = 0;
        while (number > 0)
        {
            reverse = (reverse * 10) + (number % 10);
            number = number / 10;
        }
        Console.WriteLine(reverse);
    }

    public bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    public int GCDOrHCF(int num1, int num2)
    {
        if(num1>num2){
            num1=num1+num2;
            num2=num1-num2;
            num1=num1-num2;
        }
        for (int i = Math.Min(num1 - num2, num2); i >= 1; i--)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                return i;
            }
        }
        return default;
    }
    
}