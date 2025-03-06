static double Average(int[] arr)
{
    int suma = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        suma += arr[i];
    }

    return suma / arr.Length;
}
int[] arr = {1, 2, 3, 4, 5, 6, 7, 8};
Console.WriteLine(Average(arr));