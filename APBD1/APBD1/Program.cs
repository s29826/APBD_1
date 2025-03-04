static double Avg(int[] arr)
{
    int suma = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        suma += arr[i];
    }
    return (float) suma / arr.Length;
}
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(Avg(arr));