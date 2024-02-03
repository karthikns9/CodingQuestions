
static void CountFrequencyOfElementInArray(int[] arr)
{
    Dictionary<int, int> keyValuePairs = new();

    foreach (var pair in arr)
    {
        if (!keyValuePairs.TryAdd(pair, 1))
        {
            keyValuePairs[pair]++;
        }
    }
    
    foreach (var pair in keyValuePairs)
    {
        Console.WriteLine($"{pair.Key} ----> {pair.Value}");
    }
}

static void FindHighAndLowFrequencyElement(int[] arr)
{
    Dictionary<int, int> keyValuePairs = new();

    foreach (var pair in arr)
    {
        if (!keyValuePairs.TryAdd(pair, 1))
        {
            keyValuePairs[pair]++;
        }
    }
    int max = Int32.MinValue;
    int min = Int32.MaxValue;
    int maxKey = Int32.MinValue;
    int minKey = Int32.MaxValue;

    foreach (var pair in keyValuePairs)
    {
        if (pair.Value > max)
        {
            max = pair.Value;
            maxKey = pair.Key;
        }

        if (pair.Value < min)
        {
            min = pair.Value;
            minKey = pair.Key;
        }
    }
    Console.WriteLine($"Max Key is: {maxKey}, Min Key is: {minKey}");

}
int[] arr = { 2, 2, 3, 4, 4, 2 };

FindHighAndLowFrequencyElement(arr);
