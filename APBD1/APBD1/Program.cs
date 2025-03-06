static double Average(int[] arr)
{
    int suma = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        suma += arr[i];
    }

    return suma / arr.Length;
}
int[] arr = {10, 2, 3, 4, 5, 9, 7, 8};
Console.WriteLine(Average(arr));

static int Max(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}
Console.WriteLine(Max(arr));