static Boolean LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
        {
            return true;
        }
    }
    return false;
}

int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(LinearSearch(arr, 5));
Console.WriteLine(Array.Find(arr, ele => ele == 3));
Array.FindAll(arr, ele => ele >= 5);