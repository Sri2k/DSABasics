public class BasicHashing{
    public int NumberOfRepeats(int number,int[] array){
        int count = 0;
        for(int i = 0 ;i<array.Length;i++){
            if(number == array[i]){
                count++;
            }
        }
        return count;
    }

    public int NumberOfRepeatsV1(int number,int[] array){
        int[] hashedArray = new int[array.Length];
        for(int i=0;i<array.Length;i++){
            if(number == array[i])
            {
                hashedArray[number] += 1;
            }
        }
        return hashedArray[number];
    }
    public int NumberOfChars(string input,char character){
        input = input.ToLower();
        int[] hash = new int[26] ;
        for(int i=0;i<input.Length;i++){
             if(character == input[i])
             // anyway 97/'a'
             //   hash[character-97]+=1;
                hash[character-'a']+=1;

        }
        return hash[character - 'a'];
    }
    // d a m m m m z y z
    public int NumberOfCharsV1(string input, char character)
    {
        Dictionary<char,int> keyValuePairs = new();
        for(int i =0;i<input.Length;i++)
        {
            if(keyValuePairs.ContainsKey(input[i]))
                keyValuePairs[input[i]] += 1;
            else
                keyValuePairs[input[i]]=1;
        }
        return keyValuePairs[character];
    }

    public void Max_Min_Chars(string input)
    {
        Dictionary<char, int> keyValuePairs = new();
        for (int i = 0; i < input.Length; i++)
        {
            if (keyValuePairs.ContainsKey(input[i]))
                keyValuePairs[input[i]] += 1;
            else
                keyValuePairs[input[i]] = 1;
        }
        int max = 1; int min = 1;
        for(int i = 0; i < keyValuePairs.Count;i++){
            if(keyValuePairs[input[i]] > max){
                max = keyValuePairs[input[i]];
            }
            if(keyValuePairs[input[i]] < min){
                min = keyValuePairs[input[i]];
            }
        }
        Console.WriteLine($"Maximum repeated count {max}");
        Console.WriteLine($"Minimum repeated count {min}");
    }


}

