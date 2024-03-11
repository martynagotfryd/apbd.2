// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

static double GetAverage(int[] arr)
{
    double resultt = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        resultt += i;
    }
    return resultt / arr.Length;
}

static int GetMax(int[] arr)
{
    return arr.Max();
    
}

int[] arr = { 1, 2, 3, 4 };
double average = GetAverage(arr);
int max = GetMax(arr);
Console.WriteLine(average);
Console.WriteLine(max);


