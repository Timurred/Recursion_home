

int[] arr = new int[5];
for (int i = 0; i < arr.Length; i++)
{
    Random rnd = new Random();
    arr[i] = rnd.Next(10);
}
void PrintArr(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
static void PrintReversArr(int[] arr, int index)
{
    if (index < 0)
        return;
    Console.Write(arr[index] + " ");
    PrintReversArr(arr, index - 1);
}
PrintArr(arr);
PrintReversArr(arr, 4);

