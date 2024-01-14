// Задача 3
void ZeroIvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PtintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
int[] array = { 9, 1, 7, 8, 5 };
ZeroIvenElements(array);
PtintArray(array);
