

using Microsoft.VisualBasic;

static void PrintNNames(int i, int n)
{
    if (i > n)
    {
        return;
    }
    Console.WriteLine("NS" + i);
    PrintNNames(i + 1, n);
}

static void SumOfFirstN_NaturalNumbers(int i, int sum)
{
    if (i <= 0)
    {
        Console.Write(sum);
        return;
    }
    sum = sum + i;
    SumOfFirstN_NaturalNumbers(i - 1, sum);
}

static int SumOfFirstN_NaturalNumbers_FunctionRecursion(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n + SumOfFirstN_NaturalNumbers_FunctionRecursion(n - 1);
}

static int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }

    return n * Factorial(n - 1);
}

static void Reverse(int start, int end, int[] arr)
{
    if (start < end)
    {
        int tmp = arr[start];
        arr[start] = arr[end];
        arr[end] = tmp;
        Reverse(start + 1, end - 1, arr);
    }
}

static bool Palindrome(string str, int i)
{
    if (i >= str.Length / 2)
    {
        return true;
    }

    if (str[i] != str[str.Length - i - 1])
    {
        return false;
    }

    return Palindrome(str, i + 1);
}

//static void Fibanocci(int n)
//{
//    int last = 1;
//    int secondLast = 0;

//    Console.Write($"{secondLast} {last} ");

//    for (int i = 2; i <= n; i++)
//    {
//        var curr = last + secondLast;
//        Console.Write(curr + " ");

//        secondLast = last;
//        last = curr;
//    }
//}

static int Fibanocci(int n)
{
    if (n <= 1)
    {
        return n;
    }

    return Fibanocci(n - 1) + Fibanocci(n - 2);
}

int[] arr = { 5, 4, 3, 2, 1 };

string s = "ABCDCOA";
var N = Fibanocci(4);
Console.Write(N);
