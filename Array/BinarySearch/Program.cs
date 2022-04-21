static int BinarySearch(int[] arr, int target)
{
    bool isOk(int mid)
    {
        return arr[mid] < target;
    }
    int ok = -1;
    int ng = arr.Length;
    while (Math.Abs(ok - ng) > 1)
    {
        int mid = (ok + ng) / 2;
        if (isOk(mid))
        {
            ok = mid;
        }
        else
        {
            ng = mid;
        }
    }
    return ok;
}

int[] arr = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine(BinarySearch(arr, 4));