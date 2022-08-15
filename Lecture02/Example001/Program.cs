int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int n = arr.Length;

int index = 0;
int find = 7;

while (index < n)
{
    if (arr[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
Console.WriteLine(n);